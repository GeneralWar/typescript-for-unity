#include "core/function/Function.h"
#include "delegates.h"
#include "core/function/Parameters.h"
#include "../Object.v8.h"
#include "../../utils.h"
#include "core/function/Caller.exp.h"
#include "../Environment.v8.h"

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

	const std::string type = GetObjectType(value.As<Object>());
	DEBUG_LOG("Get caller type for %d : %s", index, type.c_str());
	return ReturnStringToCSharp(type);
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
