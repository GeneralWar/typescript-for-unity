#include "utils.h"
#include "core/Environment.h"
#include "core/object/Object.h"
#include "defines.h"
#include "extra/log/Log.h"	
#include <algorithm>

Local<Object> CreateGlobalObject(Isolate* isolate, const char* name)
{
	auto context = isolate->GetCurrentContext();
	auto global = context->Global();
	auto local = Object::New(isolate);
	global->Set(String::NewFromUtf8(isolate, name), local);
	return local;
}

char* ReturnStringToCSharp(const char* value)
{
	DEBUG_LOG("Return string to csharp : %s\n", value);
	const char* origin = value ? value : "";
	size_t length = strlen(origin) + 1;
	char* buffer = new char[length];
	memset(buffer, 0, length);
	strcpy(buffer, origin);
	return buffer;
}

char* ReturnStringToCSharp(const std::string& value)
{
	return ReturnStringToCSharp(value.c_str());
}

char* ReturnStringToCSharp(Isolate* isolate, const Local<Value> value)
{
	String::Utf8Value utf(isolate, value);
	return ReturnStringToCSharp(*utf);
}

void ArrayRemove(Isolate* isolate, Local<Array> array, const char* value)
{
	assert(0);
	//Local<String> local = String::NewFromUtf8(isolate, value);
	//Local<Context> context = isolate->GetCurrentContext();
	//const int length = (int)array->Length();
	//for (int i = length; i >= 0; --i)
	//{
	//	Maybe<bool> result = array->Get(i)->Equals(context, local);
	//	if (result.ToChecked())
	//	{
	//		array->Delete(context, i);
	//	}
	//}
}

int ArrayGetLength(Isolate* isolate, Local<Value> value)
{
	if (!value->IsArray())
	{
		return -1;
	}
	return value.As<Array>()->Length();
}

std::string GetCustomType(Isolate* isolate, const Local<Object> object)
{
	if (!isolate) return "";

	if (object->IsConstructor())
	{
		std::string name = *String::Utf8Value(isolate, object->Get(String::NewFromUtf8(isolate, NAME)));
		std::string fullname = *String::Utf8Value(isolate, object->Get(String::NewFromUtf8(isolate, FULLNAME)));
		return *String::Utf8Value(isolate, object->Get(String::NewFromUtf8(isolate, FULLNAME)));
	}
	else if (object->IsObject())
	{
		return *String::Utf8Value(isolate, object->Get(String::NewFromUtf8(isolate, UNITY_INSTANCE_TYPE)));
	}
	return *String::Utf8Value(isolate, object->TypeOf(isolate));
}

std::string GetObjectType(Isolate* isolate, const Local<Object> value)
{
	if (!isolate || value.IsEmpty()) return "";

	Local<Value> property = value->Get(String::NewFromUtf8(isolate, UNITY_INSTANCE_TYPE));
	if (JsObject::IsValid(value->GetIsolate(), value))
	{
		return GetCustomType(isolate, value);
	}
	else
	{
		return *String::Utf8Value(isolate, property);
	}
}

std::vector<std::string> GetObjectPropertyNames(const Local<Object> target)
{
	std::vector<std::string> names;
	if (!target.IsEmpty() && !target->IsNullOrUndefined())
	{
		Isolate* isolate = target->GetIsolate();
		Local<Context> context = isolate->GetCurrentContext();
		MaybeLocal<Array> maybeArray = target->GetOwnPropertyNames(context);
		if (!maybeArray.IsEmpty())
		{
			Local<Array> array = maybeArray.ToLocalChecked();
			names.resize(array->Length());
			for (int i = array->Length() - 1; i >= 0; --i)
			{
				names[i] = *String::Utf8Value(isolate, array->Get(i));
			}
		}
		maybeArray = target->GetPropertyNames(context);
		if (!maybeArray.IsEmpty())
		{
			size_t count = names.size();
			Local<Array> array = maybeArray.ToLocalChecked();
			names.resize(count + array->Length());
			for (int i = array->Length() - 1; i >= 0; --i)
			{
				names[count + i] = *String::Utf8Value(isolate, array->Get(i));
			}
		}
	}
	std::sort(names.begin(), names.end());
	names.erase(std::unique(names.begin(), names.end()), names.end());
	return names;
}