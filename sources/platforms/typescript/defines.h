#ifndef defines_h
#define defines_h

#if !defined(DEBUG) && defined(_DEBUG)
#define DEBUG 1
#endif

#ifndef EXTERN_BEGIN
#define EXTERN_BEGIN extern "C" {
#endif

#ifndef EXTERN_END
#define EXTERN_END }
#endif

#ifndef DLL_EXPORT
#if defined(_WIN32)
#define DLL_EXPORT __declspec(dllexport)
#elif defined(__APPLE__) || defined(__ANDROID__)
#define DLL_EXPORT
#endif
#endif

#if defined(_WIN32) && !defined(WINDOWS)

#define WINDOWS 1

#ifdef GetObject
#undef GetObject
#endif

#endif

#if !defined(USE_ENGINE_V8) && (defined(_WIN32) || defined(__ANDROID__))
#define USE_ENGINE_V8 1
#endif

#if !defined(USE_ENGINE_JSC) && defined(__APPLE__)
#define USE_ENGINE_JSC 1
#endif

#ifndef JS_CONTEXT_TYPE
#if USE_ENGINE_V8
#define  JS_CONTEXT_TYPE Isolate*
#elif USE_ENGINE_JSC
#define  JS_CONTEXT_TYPE JSContextRef
#endif
#endif

#ifndef JS_VALUE_TYPE
#if USE_ENGINE_V8
#define  JS_VALUE_TYPE Local<Value>
#elif USE_ENGINE_JSC
#define  JS_VALUE_TYPE JSValueRef
#endif
#endif

#ifndef JS_OBJECT_TYPE
#if USE_ENGINE_V8
#define  JS_OBJECT_TYPE Local<Object>
#elif USE_ENGINE_JSC
#define  JS_OBJECT_TYPE JSObjectRef
#endif
#endif

#ifndef JS_STRING_TYPE
#if USE_ENGINE_V8
#define  JS_STRING_TYPE Local<String>
#elif USE_ENGINE_JSC
#define  JS_STRING_TYPE JSStringRef
#endif
#endif

#ifndef JS_DEFAULT_VALUE
#if USE_ENGINE_V8
#define  JS_DEFAULT_VALUE Local<Value>()
#elif USE_ENGINE_JSC
#define  JS_DEFAULT_VALUE nullptr
#endif
#endif

#ifndef JS_DEFAULT_OBJECT
#if USE_ENGINE_V8
#define  JS_DEFAULT_OBJECT Local<Object>()
#elif USE_ENGINE_JSC
#define  JS_DEFAULT_OBJECT nullptr
#endif
#endif

#ifndef JS_PERSISTENT_OBJECT_TYPE
#if USE_ENGINE_V8
#define  JS_PERSISTENT_OBJECT_TYPE Persistent<Object>
#elif USE_ENGINE_JSC
#define  JS_PERSISTENT_OBJECT_TYPE JSObjectRef
#endif
#endif

#ifndef JS_PARAMETERS
#if USE_ENGINE_V8
#define  JS_PARAMETERS const FunctionCallbackInfo<Value>& info
#elif USE_ENGINE_JSC
#define  JS_PARAMETERS const JSValueRef arguments[], const int& argumentCount
#endif
#endif

#ifndef DEFINE_JS_CONSTRUCTOR_CALLBACK
#if USE_ENGINE_V8
#define  DEFINE_JS_CONSTRUCTOR_CALLBACK(__FUNCTION_NAME__) void __FUNCTION_NAME__(const FunctionCallbackInfo<Value>& info)
#elif USE_ENGINE_JSC
#define  DEFINE_JS_CONSTRUCTOR_CALLBACK(__FUNCTION_NAME__) JSValueRef __FUNCTION_NAME__(JSContextRef context, JSObjectRef constructor, size_t argumentCount, const JSValueRef arguments[], JSValueRef* exception)
#endif
#endif

#ifndef DEFINE_JS_FUNCTION_CALLBACK
#if USE_ENGINE_V8
#define  DEFINE_JS_FUNCTION_CALLBACK(__FUNCTION_NAME__) void __FUNCTION_NAME__(const FunctionCallbackInfo<Value>& info)
#elif USE_ENGINE_JSC
#define  DEFINE_JS_FUNCTION_CALLBACK(__FUNCTION_NAME__) JSValueRef __FUNCTION_NAME__(JSContextRef ctx, JSObjectRef function, JSObjectRef thisObject, size_t argumentCount, const JSValueRef arguments[], JSValueRef* exception)
#endif
#endif

#ifndef DEFINE_JS_PROPERTY_GETTER_CALLBACK
#if USE_ENGINE_V8
#define  DEFINE_JS_PROPERTY_GETTER_CALLBACK(__FUNCTION_NAME__) void __FUNCTION_NAME__(const FunctionCallbackInfo<Value>& info)
#elif USE_ENGINE_JSC
#define  DEFINE_JS_PROPERTY_GETTER_CALLBACK(__FUNCTION_NAME__) JSValueRef __FUNCTION_NAME__(JSContextRef context, JSObjectRef object, JSStringRef propertyName, JSValueRef* exception)
#endif
#endif

#ifndef DEFINE_JS_PROPERTY_SETTER_CALLBACK
#if USE_ENGINE_V8
#define  DEFINE_JS_PROPERTY_SETTER_CALLBACK(__FUNCTION_NAME__) void __FUNCTION_NAME__(const FunctionCallbackInfo<Value>& info)
#elif USE_ENGINE_JSC
#define  DEFINE_JS_PROPERTY_SETTER_CALLBACK(__FUNCTION_NAME__) bool __FUNCTION_NAME__(JSContextRef context, JSObjectRef object, JSStringRef propertyName, JSValueRef value, JSValueRef* exception)
#endif
#endif

#ifndef JS_PARAMETER_TYPE
#if USE_ENGINE_V8
#define JS_PARAMETER_TYPE FunctionCallbackInfo<Value>
#elif USE_ENGINE_JSC
#define JS_PARAMETER_TYPE JSValueRef*
#endif
#endif

#ifndef JS_FUNCTION_CALLBACK_TYPE
#if USE_ENGINE_V8
#define JS_FUNCTION_CALLBACK_TYPE FunctionCallback
#elif USE_ENGINE_JSC
#define JS_FUNCTION_CALLBACK_TYPE JSObjectCallAsFunctionCallback
#endif
#endif

#ifndef JS_CONSTRUCTOR_CALLBACK_TYPE
#if USE_ENGINE_V8
#define JS_CONSTRUCTOR_CALLBACK_TYPE FunctionCallback
#elif USE_ENGINE_JSC
#define JS_CONSTRUCTOR_CALLBACK_TYPE JSObjectCallAsConstructorCallback
#endif
#endif

#ifndef JS_ARRAY_TYPE
#if USE_ENGINE_V8
#define JS_ARRAY_TYPE Local<Array>
#elif USE_ENGINE_JSC
#define JS_ARRAY_TYPE JSObjectRef
#endif
#endif

#ifndef GET_JS_CONTEXT_FUNCTION
#if USE_ENGINE_V8
#define  GET_JS_CONTEXT_FUNCTION GetIsolate
#elif USE_ENGINE_JSC
#define  GET_JS_CONTEXT_FUNCTION GetContext
#endif
#endif

#ifndef INTERNAL_JS_CONTEXT_NAME
#if USE_ENGINE_V8
#define  INTERNAL_JS_CONTEXT_NAME mIsolate
#elif USE_ENGINE_JSC
#define  INTERNAL_JS_CONTEXT_NAME mContext
#endif
#endif

#ifndef JSOBJECT_INITIALIZE_CALLBACK_PARAMETERS
#if USE_ENGINE_V8
#define JSOBJECT_INITIALIZE_CALLBACK_PARAMETERS
#elif USE_ENGINE_JSC
#define JSOBJECT_INITIALIZE_CALLBACK_PARAMETERS JSContextRef context, JSObjectRef object
#endif
#endif

#ifndef PERSISTENT_WEAK_CALLBACK_PARAMETERS
#if USE_ENGINE_V8
#define PERSISTENT_WEAK_CALLBACK_PARAMETERS const WeakCallbackInfo<JsObject>& data
#elif USE_ENGINE_JSC
#define PERSISTENT_WEAK_CALLBACK_PARAMETERS JSObjectRef object
#endif
#endif

#ifndef EMPTY_JS_VALUE
#if USE_ENGINE_V8
#define EMPTY_JS_VALUE Local<Value>()
#elif USE_ENGINE_JSC
#define EMPTY_JS_VALUE nullptr
#endif
#endif

#ifndef EMPTY_JS_OBJECT
#if USE_ENGINE_V8
#define EMPTY_JS_OBJECT Local<Object>()
#elif USE_ENGINE_JSC
#define EMPTY_JS_OBJECT nullptr
#endif
#endif

#endif /* defines_h */

#ifndef UNITY_INSTANCE_TYPE
#define UNITY_INSTANCE_TYPE "unity_instance_type"
#endif

#ifndef JS_INSTANCE_HANDLE
#define JS_INSTANCE_HANDLE "js_instance_handle"
#endif

#ifndef PROTOTYPE
#define PROTOTYPE "prototype"
#endif

#ifndef APPLY
#define APPLY "apply"
#endif

#ifndef VALUE
#define VALUE "value"
#endif

#ifndef NAME
#define NAME "name"
#endif

#ifndef FULLNAME
#define FULLNAME "fullname"
#endif

#ifndef MILLION_BYTES
#define MILLION_BYTES 1024 * 1024
#endif

///////////////////////////////////////////////////////////////////

#ifndef max
#define  max(a, b) (a > b ? a : b)
#endif

#ifndef min
#define  min(a, b) (a < b ? a : b)
#endif

#ifndef SAFE_STRING
#define SAFE_STRING(x) x ? x : ""
#endif

#ifndef SAFE_VALUE
#define SAFE_VALUE(a, b) a ? a : b
#endif

#ifndef BTOS
#define BTOS(b) b ? "true" : "false"
#endif

#ifndef VALID_DEFAULT
#define VALID_DEFAULT(value, default) value ? value : default
#endif

#ifndef SAFE_CALL
#define SAFE_CALL(object, operation) if (object) object operation
#endif

#ifndef DEFINE_BASE_CHILD_TYPE
#define DEFINE_BASE_CHILD_TYPE static BaseChildTypes TYPE
#endif

#ifndef ASSIGN_BASE_CHILD_TYPE
#define ASSIGN_BASE_CHILD_TYPE(__TYPE__, value) \
BaseChildTypes __TYPE__::TYPE = value
#endif

#ifndef CHECK_BASE_VALID_FUNCTION
#define CHECK_BASE_VALID_FUNCTION(__TYPE__) \
static bool IsValid(void* handle) {\
	__TYPE__* target = reinterpret_cast<__TYPE__*>(handle); \
	return 0 != (__TYPE__::TYPE & target->mType); \
}
#endif

#ifndef CONVERT_TO_BASE_CHILD
#define CONVERT_TO_BASE_CHILD(__TYPE__) \
static __TYPE__* Convert(void* handle) {\
    if (!handle) return nullptr;\
	__TYPE__* target = reinterpret_cast<__TYPE__*>(handle); \
	return IsValid(target) ? target : nullptr; \
}
#endif

///////////////////////////////////////////////////////////////////

#if DEBUG

#include "extra/log/Log.h"

#ifndef DEBUG_LOG
#if __ANDROID__
#define DEBUG_LOG(message, ...) syslog(7, message, __VA_ARGS__)
#else
#define DEBUG_LOG debug_log
#endif
#endif

#else

#ifndef DEBUG_LOG
#define DEBUG_LOG // 
#endif

#endif
