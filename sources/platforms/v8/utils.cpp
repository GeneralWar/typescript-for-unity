#include "utils.h"
#include "core/Environment.v8.h"
#include "core/Reference.v8.h"

#define CUSTOM_BEHAVIOUR_PREFIX "General.Typescript.Custom.Behaviour"

Isolate* GetIsolate(Base* base)
{
	if (base)
	{
		EnvironmentV8* runtime = reinterpret_cast<EnvironmentV8*>(base->GetEnvironment());
		if (runtime)
		{
			return runtime->GetIsolate();
		}
	}
	return nullptr;
}

Isolate* GetIsolate(void* environment)
{
	EnvironmentV8* runtime = reinterpret_cast<EnvironmentV8*>(environment);
	if (!runtime) return nullptr;
	return runtime->GetIsolate();
}

Local<Template> GetTemplate(Base* base)
{
	if (base)
	{
		ReferenceWindows* reference = reinterpret_cast<ReferenceWindows*>(base->GetReference());
		if (reference)
		{
			return reference->GetTemplate();
		}
	}
	return Local<Template>();
}

Local<Template> GetParentTemplate(Base* base)
{
	if (base)
	{
		Base* parent = base->GetParent();
		if (parent)
		{
			return GetTemplate(parent);
		}
		else
		{
			EnvironmentV8* runtime = reinterpret_cast<EnvironmentV8*>(base->GetEnvironment());
			return runtime->GetGloalTemplate();
		}
	}
	return Local<Template>();
}

Local<Object> CreateGlobalObject(Isolate* isolate, const char* name)
{
	auto context = isolate->GetCurrentContext();
	auto global = context->Global();
	auto local = Object::New(isolate);
	global->Set(String::NewFromUtf8(isolate, name), local);
	return local;
}

unsigned long long ValueToUInt64(const Local<Value>& value)
{
	if (value.IsEmpty() || value->IsNullOrUndefined()) return 0;
	return value->IsNumber() || value->IsBigInt() ? value.As<BigInt>()->Uint64Value() : 0;
}

bool ValueToBoolean(Local<Value>& value)
{
	if (value.IsEmpty() || value->IsNullOrUndefined()) return false;
	return value->IsTrue() ? true : false;
}

double ValueToDouble(Local<Value>& value)
{
	if (value.IsEmpty() || value->IsNullOrUndefined()) return 0;
	if (value->IsNumber())
	{
		return value.As<Number>()->Value();
	}
	return (double)(value->IsBigInt() ? value.As<BigInt>()->Int64Value() : 0);
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

char* ReturnStringToCSharp(Isolate* isolate, const Local<Value>& value)
{
	String::Utf8Value utf(isolate, value);
	return ReturnStringToCSharp(*utf);
}

void ArrayRemove(Isolate* isolate, Local<Array>& array, const char* value)
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

int ArrayGetLength(Isolate* isolate, Local<Value>& value)
{
	if (!value->IsArray())
	{
		return -1;
	}
	return value.As<Array>()->Length();
}

std::string GetCustomType(const Local<Object>& object)
{
	Isolate* isolate = object->GetIsolate();
	if (object->IsConstructor())
	{
		Local<Context> context = isolate->GetCurrentContext();
		Local<Object> prototype = object->Get(String::NewFromUtf8(isolate, "prototype")).As<Object>();
		if (!prototype.IsEmpty())
		{
			Local<String> constructorString = String::NewFromUtf8(isolate, "constructor");
			String::Utf8Value content(isolate, prototype->Get(constructorString));
			if (content.length())
			{
				MaybeLocal<Value> maybe = prototype->GetOwnPropertyDescriptor(context, constructorString.As<Name>());
				if (!maybe.IsEmpty())
				{
					Local<Object> descriptor = maybe.ToLocalChecked().As<Object>();
					Local<Object> value = descriptor->Get(String::NewFromUtf8(isolate, "value")).As<Object>();
					Local<Value> localName = value->Get(String::NewFromUtf8(isolate, "name"));
					if (!localName->IsNullOrUndefined())
					{
						String::Utf8Value name(isolate, localName);
						char buffer[128];
						sprintf(buffer, "%s.%s", CUSTOM_BEHAVIOUR_PREFIX, *name);
						return buffer;
					}
				}
			}
		}
	}
	else if (object->IsObject())
	{
		return *String::Utf8Value(isolate, object->Get(String::NewFromUtf8(isolate, UNITY_INSTANCE_TYPE)));
	}
	return *String::Utf8Value(isolate, object->TypeOf(isolate));
}

std::string GetObjectType(const Local<Object>& value)
{
	if (value.IsEmpty()) return "";

	Isolate* isolate = value->GetIsolate();
	Local<Value> isType = value->Get(String::NewFromUtf8(isolate, UNITY_INSTANCE_BINDED_TYPE));
	if (!isType->BooleanValue(isolate))
	{
		Local<Value> property = value->Get(String::NewFromUtf8(isolate, UNITY_INSTANCE_TYPE));
		return property->IsUndefined() || property->IsNull() ? "" : *String::Utf8Value(isolate, property);
	}
	else
	{
		String::Utf8Value type(isolate, isType);
		if (strcmp("General.Behaviour", *type))
		{
			return *type;
		}
		return GetCustomType(value);
	}
}

//std::vector<std::string> GetObjectPropertyNames(const Local<Object>& target)
//{
//	std::vector<std::string> names;
//	Isolate* isolate = target->GetIsolate();
//	Local<Context> context = isolate->GetCurrentContext();
//	Local<Object> prototype = target->Get(String::NewFromUtf8(isolate, "prototype")).As<Object>();
//	if (!prototype.IsEmpty())
//	{
//		MaybeLocal<Array> maybeArray = prototype->GetOwnPropertyNames(context);
//		if (!maybeArray.IsEmpty())
//		{
//			Local<Array> array = maybeArray.ToLocalChecked();
//			names.resize(array->Length());
//			for (int i = array->Length() - 1; i >= 0; --i)
//			{
//				names[i] = *String::Utf8Value(isolate, array->Get(i));
//			}
//		}
//	}
//	return names;
//}

std::vector<std::string> GetObjectPropertyNames(const Local<Object>& target)
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
	}
	return names;
}

