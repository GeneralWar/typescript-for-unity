#ifndef defines_h
#define defines_h

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


#ifndef JS_CONTEXT_TYPE
#if defined(_WIN32) || defined(__ANDROID__)
#define  JS_CONTEXT_TYPE Isolate*
#elif __APPLE__
#define  JS_CONTEXT_TYPE JSContextRef
#endif
#endif

#ifndef JS_VALUE_TYPE
#if defined(_WIN32) || defined(__ANDROID__)
#define  JS_VALUE_TYPE Local<Value>
#elif __APPLE__
#define  JS_VALUE_TYPE JSValueRef
#endif
#endif

#ifndef JS_VALUE_REFERENCE_TYPE
#if defined(_WIN32) || defined(__ANDROID__)
#define  JS_VALUE_REFERENCE_TYPE Local<Value>&
#elif __APPLE__
#define  JS_VALUE_REFERENCE_TYPE JSValueRef&
#endif
#endif

#ifndef JS_OBJECT_TYPE
#if defined(_WIN32) || defined(__ANDROID__)
#define  JS_OBJECT_TYPE Local<Object>
#elif __APPLE__
#define  JS_OBJECT_TYPE JSObjectRef
#endif
#endif

#ifndef JS_PARAMETERS
#if defined(_WIN32) || defined(__ANDROID__)
#define  JS_PARAMETERS const FunctionCallbackInfo<Value>& info
#elif __APPLE__
#define  JS_PARAMETERS const JSValueRef arguments[], const int& argumentCount
#endif
#endif

#ifndef JS_PARAMETER_TYPE
#if defined(_WIN32) || defined(__ANDROID__)
#define JS_PARAMETER_TYPE FunctionCallbackInfo<Value>
#elif __APPLE__
#define JS_PARAMETER_TYPE JSValueRef*
#endif
#endif

#ifndef JS_FUNCTION_CALLBACK_TYPE
#if defined(_WIN32) || defined(__ANDROID__)
#define JS_FUNCTION_CALLBACK_TYPE const FunctionCallback
#elif __APPLE__
#define JS_FUNCTION_CALLBACK_TYPE JSObjectCallAsFunctionCallback
#endif
#endif

#ifndef REFERENCE
#if defined(_WIN32) || defined(__ANDROID__)
#define REFERENCE Reference*
#elif __APPLE__
#define REFERENCE JSValueRef
#endif
#endif

#endif /* defines_h */

#ifndef UNITY_INSTANCE_HANDLE
#define UNITY_INSTANCE_HANDLE "unity_instance_handle"
#endif

#ifndef UNITY_INSTANCE_FIELD
#define UNITY_INSTANCE_FIELD "unity_instance_field"
#endif

#ifndef UNITY_INSTANCE_FIELD_SIZE
#define UNITY_INSTANCE_FIELD_SIZE "unity_instance_field_size"
#endif

#ifndef UNITY_INSTANCE_TYPE
#define UNITY_INSTANCE_TYPE "unity_instance_type"
#endif

#ifndef UNITY_INSTANCE_IS_TYPE
#define UNITY_INSTANCE_IS_TYPE "unity_instance_is_type"
#endif

#ifndef UNITY_INSTANCE_CUSTOM_TYPE
#define UNITY_INSTANCE_CUSTOM_TYPE "unity_instance_custom_type"
#endif

#ifndef CUSTOM_BEHAVIOUR_PREFIX
#define CUSTOM_BEHAVIOUR_PREFIX "General.Typescript.Custom.Behaviour"
#endif

#ifndef PROPERTY_KEY
#define PROPERTY_KEY "function_call_property"
#endif

#ifndef OBJECT_KEY
#define OBJECT_KEY "function_call_object"
#endif

///////////////////////////////////////////////////////////////////

#ifndef max
#define  max(a, b) (a > b ? a : b)
#endif

#ifndef min
#define  min(a, b) (a < b ? a : b)
#endif
