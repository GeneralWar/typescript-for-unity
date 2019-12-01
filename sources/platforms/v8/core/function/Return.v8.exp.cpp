#include "core/function/Function.h"
#include "core/function/Parameters.h"
#include "delegates.h"
#include "../Object.v8.h"
#include "../../utils.h"
#include "core/JSTypes.h"
#include "core/function/Return.exp.h"
#include "../Environment.v8.h"
#include "extra/log/Log.h"

extern void onInstanceFunctionCall(const FunctionCallbackInfo<Value>& info);
extern void onInstancePropertyGetterCall(const FunctionCallbackInfo<Value>& info);
extern void onInstancePropertySetterCall(const FunctionCallbackInfo<Value>& info);

static std::map<int, Persistent<Value>> sReturnValues;

static int create_return_value(Isolate* isolate, const Local<Value>& value)
{
	int index = -1;
	if (sReturnValues.size())
	{
		for (auto it = sReturnValues.begin(); sReturnValues.end() != it; ++it)
		{
			if (it->first > index)
			{
				index = it->first;
			}
		}
	}
	sReturnValues[++index].Reset(isolate, value);
	return index;
}

Local<Value> GetReturnValue(Isolate* isolate, int index)
{
	auto result = sReturnValues.find(index);
	return sReturnValues.end() == result ? Local<Value>() : sReturnValues[index].Get(isolate);
}

void ReleaseReturnValue(int index)
{
	auto result = sReturnValues.find(index);
	if (sReturnValues.end() == result) return;
	result->second.Reset();
	sReturnValues.erase(result);
}


int General_Typescript_Return_CreateString(void* environment, const char* value)
{
	Isolate* isolate = GetIsolate(environment);
	if (!isolate) return -1;

	return create_return_value(isolate, String::NewFromUtf8(isolate, value));
}

int General_Typescript_Return_CreateNumber(void* environment, double value)
{
	Isolate* isolate = GetIsolate(environment);
	if (!isolate) return -1;

	return create_return_value(isolate, Number::New(isolate, value));
}

int General_Typescript_Return_CreateBoolean(void* environment, bool value)
{
	Isolate* isolate = GetIsolate(environment);
	if (!isolate) return -1;

	return create_return_value(isolate, Boolean::New(isolate, value));
}

int General_Typescript_Return_CreateWithHandle(void* environment, const char* type, void* handle)
{
	Isolate* isolate = GetIsolate(environment);
	if (!isolate) return -1;

	return create_return_value(isolate, CreateObject(isolate, type, handle));
}

int General_Typescript_Return_CreateWithField(void* environment, const char* type, void* handle, int size)
{
	Isolate* isolate = GetIsolate(environment);
	if (!isolate) return -1;

	return create_return_value(isolate, CreateObject(isolate, type, handle, size));
}

void General_Typescript_Return_MakePersistent(void* environment, int index)
{
	Isolate* isolate = GetIsolate(environment);
	if (!isolate) return;

	Local<Object> instance = GetReturnValue(isolate, index).As<Object>();
	if (!instance.IsEmpty())
	{
		MakePersistent(isolate, instance);
	}
}

void General_Typescript_Return_BindInstanceFunction(void* environment, int index, const char* name)
{
	Isolate* isolate = GetIsolate(environment);
	if (!isolate) return;

	Local<Object> instance = GetReturnValue(isolate, index).As<Object>();
	if (!instance.IsEmpty())
	{
		Local<String> property = String::NewFromUtf8(isolate, name);
		Local<Object> data = Object::New(isolate);
		data->Set(String::NewFromUtf8(isolate, PROPERTY_KEY), property);
		//data->Set(String::NewFromUtf8(isolate, OBJECT_KEY), instance);
		MaybeLocal<Function> functionTemplate = Function::New(isolate->GetCurrentContext(), onInstanceFunctionCall, data);
		if (functionTemplate.IsEmpty())
		{
			LogWarning("Bind instance function [%s.%s] failed!", GetObjectType(instance).c_str(), name);
		}
		else
		{
			instance->Set(property, functionTemplate.ToLocalChecked());
		}
	}
}

void General_Typescript_Return_BindInstanceProperty(void* environment, int index, const char* name, bool hasGetter, bool hasSetter)
{
	Isolate* isolate = GetIsolate(environment);
	if (!isolate) return;

	Local<Context> context = isolate->GetCurrentContext();
	if (context.IsEmpty()) return;

	Local<Object> instance = GetReturnValue(isolate, index).As<Object>();
	if (!instance.IsEmpty())
	{
		Local<String> property = String::NewFromUtf8(isolate, name);
		Local<Object> data = Object::New(isolate);
		data->Set(String::NewFromUtf8(isolate, PROPERTY_KEY), property);
		//data->Set(String::NewFromUtf8(isolate, OBJECT_KEY), instance);
		instance->SetAccessorProperty(property, hasGetter ? Function::New(context, onInstancePropertyGetterCall, data).ToLocalChecked() : Local<Function>(),
			hasSetter ? Function::New(context, onInstancePropertySetterCall, data).ToLocalChecked() : Local<Function>());
	}
}