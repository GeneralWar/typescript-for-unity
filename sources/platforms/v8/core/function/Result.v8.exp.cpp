#include "core/function/Function.h"
#include "delegates.h"
#include "core/function/Parameters.h"
#include "../Object.v8.h"
#include "../../utils.h"
#include "core/JSTypes.h"
#include <mutex>
#include "core/function/Result.exp.h"
#include "../Environment.v8.h"

static std::map<int, Persistent<Value>> sResultValues;

static std::mutex sMutex;

static int create_result_value(Isolate* isolate, const Local<Value>& value)
{
	int index = -1;
	sMutex.lock();
	for (auto it = sResultValues.begin(); sResultValues.end() != it; ++it)
	{
		if (it->first > index)
		{
			index = it->first;
		}
	}
	sResultValues[++index].Reset(isolate, value);
	sMutex.unlock();
	return index;
}

Local<Value> get_result_value(Isolate* isolate, int index)
{
	auto result = sResultValues.find(index);
	return sResultValues.end() == result ? Local<Value>() : sResultValues[index].Get(isolate);
}

int RegisterResultValue(Isolate* isolate, const Local<Value>& value)
{
	return create_result_value(isolate, value);
}

void ReleaseResultValue(int index)
{
	sMutex.lock();
	auto result = sResultValues.find(index);
	if (sResultValues.end() == result) return;
	result->second.Reset();
	sResultValues.erase(result);
	if (!sResultValues.size())
	{
		//sResultValues.swap(std::map<int, Persistent<Value>>());
		sResultValues.clear();
	}
	sMutex.unlock();
}


void General_Typescript_Result_Release(void* environment, int index)
{
	ReleaseResultValue(index);
}

int General_Typescript_Result_GetJsType(void* environment, int index)
{
	//HandleScope handleScope(isolate);
	//Local<Value> instance = get_result_value(isolate, index);
	return (int)TYPE_UNKNOWN;
}

double General_Typescript_Result_ToNumber(void* environment, int index)
{
	Isolate* isolate = GetIsolate(environment);
	if (!isolate) return 0;

	HandleScope handleScope(isolate);
	Local<Value> instance = get_result_value(isolate, index);
	return ValueToDouble(instance);
}

char* General_Typescript_Result_ToString(void* environment, int index)
{
	Isolate* isolate = GetIsolate(environment);
	if (!isolate) return ReturnStringToCSharp("");

	HandleScope handleScope(isolate);
	Local<Value> instance = get_result_value(isolate, index);
	return ReturnStringToCSharp(isolate, instance);
}

bool General_Typescript_Result_ToBoolean(void* environment, int index)
{
	Isolate* isolate = GetIsolate(environment);
	if (!isolate) return 0;

	HandleScope handleScope(isolate);
	Local<Value> instance = get_result_value(isolate, index);
	return instance.IsEmpty() ? false : instance->IsTrue();
}