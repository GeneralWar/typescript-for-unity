#include "core/function/Function.h"
#include "delegates.h"
#include "core/function/Parameters.h"
#include "../Object.win.h"
#include "../../utils.h"
#include "core/function/Caller.exp.h"
#include "../Environment.win.h"

static std::map<int, Persistent<Value>> sCallers;

static int create_caller(Isolate* isolate, const Local<Value>& value)
{
	int index = -1;
	if (sCallers.size())
	{
		for (auto it = sCallers.begin(); sCallers.end() != it; ++it)
		{
			if (it->first > index)
			{
				index = it->first;
			}
		}
	}
	sCallers[++index].Reset(isolate, value);
	return index;
}

int RegisterCaller(Isolate* isolate, const Local<Value>& caller)
{
	return create_caller(isolate, caller);
}

static Local<Value> get_caller(Isolate* isolate, int index)
{
	auto result = sCallers.find(index);
	return sCallers.end() == result ? Local<Value>() : sCallers[index].Get(isolate);
}

void ReleaseCaller(int index)
{
	auto result = sCallers.find(index);
	if (sCallers.end() == result) return;
	result->second.Reset();
	sCallers.erase(result);
}


char* General_Typescript_Caller_GetTypeName(void* environment, int index)
{
	Isolate* isolate = GetIsolate(environment);
	if (!isolate) return ReturnStringToCSharp("");

	Local<Value> value = get_caller(isolate, index);
	if (value.IsEmpty() || !value->IsObject()) return ReturnStringToCSharp("");

	Local<Object> local = value.As<Object>();
	Local<Value> isType = local->Get(String::NewFromUtf8(isolate, UNITY_INSTANCE_IS_TYPE));
	//String::Utf8Value content(isolate, isType);
	if (isType->IsNullOrUndefined())
	{
		Local<Value> property = local->Get(String::NewFromUtf8(isolate, UNITY_INSTANCE_TYPE));
		return ReturnStringToCSharp(property->IsUndefined() || property->IsNull() ? "" : *String::Utf8Value(isolate, property));
	}
	else
	{
		String::Utf8Value type(isolate, isType);
		if (strcmp("General.Behaviour", *type))
		{
			return ReturnStringToCSharp(*type);
		}
		return ReturnStringToCSharp(GetCustomType(local).c_str());
	}
}

void* General_Typescript_Caller_GetHandle(void* environment, int index)
{
	Isolate* isolate = GetIsolate(environment);
	if (!isolate) return nullptr;

	Local<Value> value = get_caller(isolate, index);
	return value.IsEmpty() ? nullptr : GetObjectHandle(isolate, value);
}

void* General_Typescript_Caller_GetField(void* environment, void* pointer, int index)
{
	Isolate* isolate = GetIsolate(environment);
	if (!isolate) return nullptr;

	Local<Value> value = get_caller(isolate, index);
	return value.IsEmpty() ? nullptr : GetObjectField(isolate, value);
}
