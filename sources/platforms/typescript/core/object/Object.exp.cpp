#include "Object.exp.h"
#include "Object.h"
#include "Utils.h"
#include "core/Environment.h"
#include "core/JSTypes.h"
#include "core/class/Class.h"

#undef GetObject

void* General_Typescript_Object_CreateBoolean(void* environment, bool value)
{
    Environment* runtime = reinterpret_cast<Environment*>(environment);
	if (!runtime) return nullptr;
#if USE_ENGINE_V8
	Isolate* isolate = runtime->GetIsolate();
	if (!isolate) return nullptr;
	HandleScope handleScope(isolate);
#endif
	return JsObject::CreateBoolean(runtime->GET_JS_CONTEXT_FUNCTION(), value);
}

void* General_Typescript_Object_CreateString(void* environment, const char* value)
{
    Environment* runtime = reinterpret_cast<Environment*>(environment);
	if (!runtime) return nullptr;
#if USE_ENGINE_V8
	Isolate* isolate = runtime->GetIsolate();
	if (!isolate) return nullptr;
	HandleScope handleScope(isolate);
#endif
	return JsObject::CreateString(runtime->GET_JS_CONTEXT_FUNCTION(), std::string(SAFE_STRING(value)));
}

void* General_Typescript_Object_CreateInt32(void* environment, int value)
{
    Environment* runtime = reinterpret_cast<Environment*>(environment);
	if (!runtime) return nullptr;
#if USE_ENGINE_V8
	Isolate* isolate = runtime->GetIsolate();
	if (!isolate) return nullptr;
	HandleScope handleScope(isolate);
#endif
	return JsObject::CreateInt32(runtime->GET_JS_CONTEXT_FUNCTION(), value);
}

void* General_Typescript_Object_CreateUint32(void* environment, unsigned int value)
{
    Environment* runtime = reinterpret_cast<Environment*>(environment);
	if (!runtime) return nullptr;
#if USE_ENGINE_V8
	Isolate* isolate = runtime->GetIsolate();
	if (!isolate) return nullptr;
	HandleScope handleScope(isolate);
#endif
	return JsObject::CreateUint32(runtime->GET_JS_CONTEXT_FUNCTION(), value);
}

void* General_Typescript_Object_CreateInt64(void* environment, long long value)
{
    Environment* runtime = reinterpret_cast<Environment*>(environment);
	if (!runtime) return nullptr;
#if USE_ENGINE_V8
	Isolate* isolate = runtime->GetIsolate();
	if (!isolate) return nullptr;
	HandleScope handleScope(isolate);
#endif
	return JsObject::CreateInt64(runtime->GET_JS_CONTEXT_FUNCTION(), value);
}

void* General_Typescript_Object_CreateUint64(void* environment, unsigned long long value)
{
    Environment* runtime = reinterpret_cast<Environment*>(environment);
	if (!runtime) return nullptr;
#if USE_ENGINE_V8
	Isolate* isolate = runtime->GetIsolate();
	if (!isolate) return nullptr;
	HandleScope handleScope(isolate);
#endif
	return JsObject::CreateUint64(runtime->GET_JS_CONTEXT_FUNCTION(), value);
}

void* General_Typescript_Object_CreateFloat(void* environment, float value)
{
    Environment* runtime = reinterpret_cast<Environment*>(environment);
	if (!runtime) return nullptr;
#if USE_ENGINE_V8
	Isolate* isolate = runtime->GetIsolate();
	if (!isolate) return nullptr;
	HandleScope handleScope(isolate);
#endif
	return JsObject::CreateSingle(runtime->GET_JS_CONTEXT_FUNCTION(), value);
}

void* General_Typescript_Object_CreateDouble(void* environment, double value)
{
    Environment* runtime = reinterpret_cast<Environment*>(environment);
	if (!runtime) return nullptr;
#if USE_ENGINE_V8
	Isolate* isolate = runtime->GetIsolate();
	if (!isolate) return nullptr;
	HandleScope handleScope(isolate);
#endif
	return JsObject::CreateDouble(runtime->GET_JS_CONTEXT_FUNCTION(), value);
}

void General_Typescript_SetGarbageCollectionCallback(GarbageCollectionCallback callback)
{
	JsObject::SetGarbageCollectionCallback(callback);
}

void General_Typescript_Object_MakePersistent(void* environment, JsObject* instance)
{
#if USE_ENGINE_V8
    Environment* runtime = reinterpret_cast<Environment*>(environment);
	if (!runtime) return;
	Isolate* isolate = runtime->GetIsolate();
	if (!isolate) return;
	HandleScope handleScope(isolate);
#endif
    SAFE_CALL(instance, ->MakePersistent());
}

void General_Typescript_Object_MakeWeak(void* environment, JsObject* instance)
{
    Environment* runtime = reinterpret_cast<Environment*>(environment);
	if (!runtime) return;
#if USE_ENGINE_V8
	Isolate* isolate = runtime->GetIsolate();
	if (!isolate) return;
	HandleScope handleScope(isolate);
#endif
    SAFE_CALL(instance, ->MakeWeak());
}

int General_Typescript_Object_GetJsType(void* environment, JsObject* instance)
{
#if DEBUG
	assert(0);
#endif
	return (int)TYPE_UNKNOWN;
}

char* General_Typescript_Object_GetTypeName(void *environment, void* caller)
{
    Environment* runtime = reinterpret_cast<Environment*>(environment);
    if (!runtime) return ReturnStringToCSharp("");
#if USE_ENGINE_V8
    Isolate* isolate = runtime->GetIsolate();
    if (!isolate) return ReturnStringToCSharp("");
    HandleScope handleScope(isolate);
#endif
    
    JsObject* object = JsObject::Find(caller);
    if (!object) return ReturnStringToCSharp("");

    JS_CONTEXT_TYPE context = runtime->GET_JS_CONTEXT_FUNCTION();
    if (!context) return ReturnStringToCSharp("");
    
    const std::string type = GetObjectType(context, object->GetObject());
    DEBUG_LOG("Get object type for %llu : %s\n", (unsigned long long)caller, type.c_str());
    return ReturnStringToCSharp(type);
}

void *General_Typescript_Object_GetField(void *environment, void *pointer, void* caller)
{
    Environment *runtime = reinterpret_cast<Environment *>(environment);
    if (!runtime) return nullptr;
#if USE_ENGINE_V8
    Isolate* isolate = runtime->GetIsolate();
    if (!isolate) return nullptr;
    HandleScope handleScope(isolate);
#endif
        
    JsObject* object = JsObject::Find(caller);
    return object ? object->GetInstanceField() : nullptr;
}

bool General_Typescript_Object_ToBoolean(void* environment, JsObject* instance)
{
    Environment* runtime = reinterpret_cast<Environment*>(environment);
	if (!runtime) return false;
#if USE_ENGINE_V8
	Isolate* isolate = runtime->GetIsolate();
	if (!isolate) return false;
	HandleScope handleScope(isolate);
#endif
	return instance ? instance->ToBoolean() : false;
}

char* General_Typescript_Object_ToString(void* environment, JsObject* instance)
{
    Environment* runtime = reinterpret_cast<Environment*>(environment);
	if (!runtime) return ReturnStringToCSharp("");
#if USE_ENGINE_V8
	Isolate* isolate = runtime->GetIsolate();
	if (!isolate) return ReturnStringToCSharp("");
	HandleScope handleScope(isolate);
#endif
	return ReturnStringToCSharp(instance ? instance->ToString() : "");
}

int General_Typescript_Object_ToInt32(void* environment, JsObject* instance)
{
    Environment* runtime = reinterpret_cast<Environment*>(environment);
	if (!runtime) return 0;
#if USE_ENGINE_V8
	Isolate* isolate = runtime->GetIsolate();
	if (!isolate) return 0;
	HandleScope handleScope(isolate);
#endif
	return instance ? instance->ToInt32() : 0;
}

unsigned int General_Typescript_Object_ToUint32(void* environment, JsObject* instance)
{
    Environment* runtime = reinterpret_cast<Environment*>(environment);
	if (!runtime) return 0;
#if USE_ENGINE_V8
	Isolate* isolate = runtime->GetIsolate();
	if (!isolate) return 0;
	HandleScope handleScope(isolate);
#endif
	return instance ? instance->ToUint32() : 0;
}

long long General_Typescript_Object_ToInt64(void* environment, JsObject* instance)
{
    Environment* runtime = reinterpret_cast<Environment*>(environment);
	if (!runtime) return 0;
#if USE_ENGINE_V8
	Isolate* isolate = runtime->GetIsolate();
	if (!isolate) return 0;
	HandleScope handleScope(isolate);
#endif
	return instance ? instance->ToInt64() : 0;
}

unsigned long long General_Typescript_Object_ToUint64(void* environment, JsObject* instance)
{
    Environment* runtime = reinterpret_cast<Environment*>(environment);
	if (!runtime) return 0;
#if USE_ENGINE_V8
	Isolate* isolate = runtime->GetIsolate();
	if (!isolate) return 0;
	HandleScope handleScope(isolate);
#endif
	return instance ? instance->ToUint64() : 0;
}

float General_Typescript_Object_ToFloat(void* environment, JsObject* instance)
{
    Environment* runtime = reinterpret_cast<Environment*>(environment);
	if (!runtime) return 0;
#if USE_ENGINE_V8
	Isolate* isolate = runtime->GetIsolate();
	if (!isolate) return 0;
	HandleScope handleScope(isolate);
#endif
	return instance ? instance->ToSingle() : 0;
}

double General_Typescript_Object_ToDouble(void* environment, JsObject* instance)
{
    Environment* runtime = reinterpret_cast<Environment*>(environment);
	if (!runtime) return 0;
#if USE_ENGINE_V8
	Isolate* isolate = runtime->GetIsolate();
	if (!isolate) return 0;
	HandleScope handleScope(isolate);
#endif
	return instance ? instance->ToDouble() : 0;
}

void* create_with_handle_size(void* environment, const std::string& type, const size_t& size = 0)
{
    Environment* runtime = reinterpret_cast<Environment*>(environment);
	if (!runtime) return nullptr;
#if USE_ENGINE_V8
	Isolate* isolate = runtime->GetIsolate();
	if (!isolate) return nullptr;
	HandleScope handleScope(isolate);
#endif
	return TypescriptClass::CreateInstance(runtime->GET_JS_CONTEXT_FUNCTION(), type, size);
}

void* General_Typescript_Object_CreateInstanceHandle(void* environment, const char* type)
{
    DEBUG_LOG("Try to create instance : %s\n", type);
	return create_with_handle_size(environment, GetSafeType(type));
}

void* General_Typescript_Object_CreateWithField(void* environment, const char* type, int size)
{
    DEBUG_LOG("Try to create field : %s, size : %d\n", type, size);
	return create_with_handle_size(environment, GetSafeType(type), (size_t)size);
}

void* General_Typescript_Object_CreateArrayWithLength(void* environment, int length)
{
    Environment* runtime = reinterpret_cast<Environment*>(environment);
	if (!runtime) return nullptr;
#if USE_ENGINE_V8
	Isolate* isolate = runtime->GetIsolate();
	if (!isolate) return nullptr;
	HandleScope handleScope(isolate);
#endif
	return JsObject::CreateArray(runtime->GET_JS_CONTEXT_FUNCTION(), length);
}

void* General_Typescript_Object_CreateArrayWithElements(void* environment, JsObject** elements, int length)
{
    Environment* runtime = reinterpret_cast<Environment*>(environment);
	if (!runtime) return nullptr;
#if USE_ENGINE_V8
	Isolate* isolate = runtime->GetIsolate();
	if (!isolate) return nullptr;
	HandleScope handleScope(isolate);
#endif
	return JsObject::CreateArray(runtime->GET_JS_CONTEXT_FUNCTION(), elements, length);
}

bool General_Typescript_Object_HasProperty(void* environment, JsObject* instance, const char* name)
{
	Environment* runtime = reinterpret_cast<Environment*>(environment);
	if (!runtime) return nullptr;
#if USE_ENGINE_V8
	Isolate* isolate = runtime->GetIsolate();
	if (!isolate) return nullptr;
	HandleScope handleScope(isolate);
#endif
	return instance ? instance->Has(SAFE_STRING(name)) : false;
}

bool General_Typescript_Object_HasFunction(void* environment, JsObject* instance, const char* name)
{
	Environment* runtime = reinterpret_cast<Environment*>(environment);
	if (!runtime) return false;
#if USE_ENGINE_V8
	Isolate* isolate = runtime->GetIsolate();
	if (!isolate) return false;
	HandleScope handleScope(isolate);
#endif
	return instance ? instance->Has(SAFE_STRING(name)) : false;
}

void* General_Typescript_Object_CallFunction(void* environment, JsObject* instance, const char* name, JsObject* arguments)
{
    Environment* runtime = reinterpret_cast<Environment*>(environment);
	if (!runtime) return nullptr;
#if USE_ENGINE_V8
	Isolate* isolate = runtime->GetIsolate();
	if (!isolate) return nullptr;
	HandleScope handleScope(isolate);
#endif
    return instance ? instance->CallFunction(SAFE_STRING(name), arguments, true) : nullptr;
}

void General_Typescript_Object_CallFunctionWithoutResult(void* environment, JsObject* instance, const char* name, JsObject* arguments)
{
    Environment* runtime = reinterpret_cast<Environment*>(environment);
	if (!runtime) return;
#if USE_ENGINE_V8
	Isolate* isolate = runtime->GetIsolate();
	if (!isolate) return;
	HandleScope handleScope(isolate);
#endif
    instance->CallFunction(SAFE_STRING(name), arguments, false);
}

void* General_Typescript_Object_CallAsFunction(void* environment, JsObject* instance, JsObject* arguments)
{
    Environment* runtime = reinterpret_cast<Environment*>(environment);
	if (!runtime) return nullptr;
#if USE_ENGINE_V8
	Isolate* isolate = runtime->GetIsolate();
	if (!isolate) return nullptr;
	HandleScope handleScope(isolate);
#endif
	return instance ? instance->CallAsFunction(arguments, true) : nullptr;
}
