#include "Object.win.h"
#include <map>
#include "../utils.h"
#include "delegates.h"
#include "core/function/Constructor.h"
#include "extra/log/Log.h"
#include "defines.h"

Persistent<String> TYPE_KEY;
Persistent<String> FIELD_KEY;
Persistent<String> HANDLE_KEY;
Persistent<String> FIELD_SIZE_KEY;

Persistent<String> sZeroString;

std::map<unsigned long long, Persistent<Object>> sPersistentInstances;

void object_initialize(Isolate* isolate)
{
	TYPE_KEY.Reset(isolate, String::NewFromUtf8(isolate, UNITY_INSTANCE_TYPE));
	FIELD_KEY.Reset(isolate, String::NewFromUtf8(isolate, UNITY_INSTANCE_FIELD));
	HANDLE_KEY.Reset(isolate, String::NewFromUtf8(isolate, UNITY_INSTANCE_HANDLE));
	FIELD_SIZE_KEY.Reset(isolate, String::NewFromUtf8(isolate, UNITY_INSTANCE_FIELD_SIZE));
}

void object_finalize(Isolate* isolate)
{
	TYPE_KEY.Reset();
	FIELD_KEY.Reset();
	HANDLE_KEY.Reset();
	FIELD_SIZE_KEY.Reset();
	for (auto it = sPersistentInstances.begin(); sPersistentInstances.end() != it; ++it)
	{
		it->second.Reset();
	}
	sPersistentInstances.clear();
}

void* GetLocalObjectHandle(Isolate* isolate, const Local<Value>& value)
{
	return reinterpret_cast<unsigned long long*>(*value);
}

template <typename T> Local<T> getLocalInstance(Isolate* isolate, void* handle)
{
	if (isolate && handle)
	{
		auto result = sPersistentInstances.find((unsigned long long)handle);
		//return sInstances.end() == result ? Undefined(isolate).As<T>() : result->second.Get(isolate).As<T>();
		if (sPersistentInstances.end() != result)
		{
			return result->second.Get(isolate).As<T>();
		}

	//	Value* value = reinterpret_cast<Value*>(handle);

	//	if (value->IsString())
	//	{
	//		return value->ToString(isolate).As<T>();
	//	}
	//	if (value->IsBoolean())
	//	{
	//		return value->ToBoolean(isolate).As<T>();
	//	}
	//	if (value->IsNumber())
	//	{
	//		return value->ToNumber(isolate).As<T>();
	//	}
	//	if (value->IsObject())
	//	{
	//		return value->ToObject(isolate).As<T>();
	//	}
	//	if (value->IsUndefined())
	//	{
	//		return Undefined(isolate).As<T>();
	//	}
	//	if (value->IsNull())
	//	{
	//		return Null(isolate).As<T>();
	//	}
	}
	return Undefined(isolate).As<T>();
}

Local<Value> GetValueInstance(Isolate* isolate, void* handle)
{
	return handle ? getLocalInstance<Value>(isolate, handle) : Local<Value>();
}

Local<Object> GetObjectInstance(Isolate* isolate, void* handle)
{
	return handle ? getLocalInstance<Object>(isolate, handle) : Local<Object>();
}

Local<String> GetStringInstance(Isolate* isolate, void* handle)
{
	return handle ? getLocalInstance<String>(isolate, handle) : Local<String>();
}

Local<Object> CreateObject(Isolate* isolate, const char* type, void* handle)
{
	//auto result = sInstances.find(handle);
	//if (sInstances.end() == result)
	//{
		Local<Object> instance = InstantiateObject(isolate, type);
		if (instance.IsEmpty())
		{
			instance = Object::New(isolate);
		}
		instance->Set(TYPE_KEY.Get(isolate), String::NewFromUtf8(isolate, type));
		instance->Set(HANDLE_KEY.Get(isolate), BigInt::NewFromUnsigned(isolate, (unsigned long long)handle));
		return instance;
	//}
	//return result->second.Get(isolate);
}

Local<Object> CreateObject(Isolate* isolate, const char*type, void* handle, int size)
{
	Local<Object> value = Object::New(isolate);
	value->Set(TYPE_KEY.Get(isolate), String::NewFromUtf8(isolate, type));
	value->Set(FIELD_KEY.Get(isolate), BigInt::NewFromUnsigned(isolate, (unsigned long long)handle));
	value->Set(FIELD_SIZE_KEY.Get(isolate), ArrayBuffer::New(isolate, handle, size, ArrayBufferCreationMode::kInternalized));
	return value;
}

void* GetObjectHandle(Isolate* isolate, const Local<Value>& local)
{
	return local->IsObject() ? GetObjectHandle(isolate, local.As<Object>()) : nullptr;
}

void* GetObjectHandle(Isolate* isolate, const Local<Object>& local)
{
	Local<Value> value = local->Get(HANDLE_KEY.Get(isolate));
	return (void*)ValueToUInt64(value);
}

void* GetObjectField(Isolate* isolate, const Local<Value>& local)
{
	return local->IsObject() ? GetObjectField(isolate, local.As<Object>()) : nullptr;
}

void* GetObjectField(Isolate* isolate, const Local<Object>& local)
{
	Local<Value> value = local->Get(FIELD_KEY.Get(isolate));
	return (void*)ValueToUInt64(value);
}

void MakePersistent(Isolate* isolate, const Local<Object>& local)
{
	Local<Value> localHandle = local->Get(HANDLE_KEY.Get(isolate));
	if (localHandle->IsNullOrUndefined())
	{
		LogWarning("Try to make an instance as persistent but it's handle is null or undefined.");
		return;
	}
	unsigned long long handle = ValueToUInt64(localHandle);
	sPersistentInstances[handle].Reset(isolate, local);
}

Local<Object> GetPersistent(Isolate* isolate, void* handle)
{
	auto result = sPersistentInstances.find((unsigned long long)handle);
	return sPersistentInstances.end() == result ? Local<Object>() : result->second.Get(isolate);
}

void ReleaseHandle(unsigned long long& handle)
{
	auto result = sPersistentInstances.find(handle);
	if (sPersistentInstances.end() != result)
	{
		result->second.Reset();
		sPersistentInstances.erase(result);
	}
}

void ReleaseHandles(unsigned long long* handles, const int& size)
{
	for (int i = size - 1; i >= 0; --i)
	{
		ReleaseHandle(handles[i]);
	}
}