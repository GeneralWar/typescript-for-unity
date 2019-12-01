#include "Object.v8.h"
#include "delegates.h"
#include "../utils.h"
#include "core/function/Argument.h"
#include "core/function/Function.h"
#include "core/Object.exp.h"
#include "Environment.v8.h"

static Local<Value> call_function(Isolate* isolate, void* handle, const char* name, unsigned char* arguments)
{
	HandleScope handleScope(isolate);
	Local<Object> object = GetPersistent(isolate, handle);
	if (object.IsEmpty() || object->IsNullOrUndefined()) return Local<Value>();

	Local<Value> property = object->Get(String::NewFromUtf8(isolate, name));
	if (!property.IsEmpty() && property->IsFunction())
	{
		std::vector<Local<Value>> parameters;
		if (arguments)
		{
			int count = *(int*)arguments;
			unsigned char* start = arguments + 4;
			for (int i = 0; i < count; ++i)
			{
				parameters.push_back(Argument::Deserialize(isolate, start));
			}
		}

		Local<Function> function = property.As<Function>();
		MaybeLocal<Value> result = function->Call(isolate->GetCurrentContext(), object, (int)parameters.size(), parameters.data());
		return result.IsEmpty() ? Local<Value>() : result.ToLocalChecked();
	}
	return Local<Value>();
}


bool General_Typescript_Object_HasProperty(void* environment, void* handle, const char* name)
{
	Isolate* isolate = GetIsolate(environment);
	if (!isolate) return false;

	HandleScope handleScope(isolate);
	Local<Object> object = GetPersistent(isolate, handle);
	if (object.IsEmpty() || object->IsNullOrUndefined()) return false;

	Local<Value> property = object->Get(String::NewFromUtf8(isolate, name));
	return !property.IsEmpty() && !property->IsNullOrUndefined();
}

bool General_Typescript_Object_HasFunction(void* environment, void* handle, const char* name)
{
	Isolate* isolate = GetIsolate(environment);
	if (!isolate) return false;

	HandleScope handleScope(isolate);
	Local<Object> object = GetPersistent(isolate, handle);
	if (object.IsEmpty() || object->IsNullOrUndefined()) return false;

	Local<Value> property = object->Get(String::NewFromUtf8(isolate, name));
	return !property.IsEmpty() && property->IsFunction();
}

int General_Typescript_Object_CallFunction(void* environment, void* handle, const char* name, unsigned char* arguments)
{
	Isolate* isolate = GetIsolate(environment);
	if (!isolate) return -1;

	Local<Value> result = call_function(isolate, handle, name, arguments);
	return result.IsEmpty() ? -1 : RegisterResultValue(isolate, result);
}

void General_Typescript_Object_CallFunctionWithoutResult(void* environment, void* handle, const char* name, unsigned char* arguments)
{
	Isolate* isolate = GetIsolate(environment);
	if (!isolate) return;

	call_function(isolate, handle, name, arguments);
}