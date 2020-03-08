#include "delegates.h"
#include "defines.h"
#pragma once

class JsObject;

EXTERN_BEGIN

DLL_EXPORT void* General_Typescript_Object_CreateBoolean(void* environment, bool value);

DLL_EXPORT void* General_Typescript_Object_CreateInt32(void* environment, int value);

DLL_EXPORT void* General_Typescript_Object_CreateUint32(void* environment, unsigned int value);

DLL_EXPORT void* General_Typescript_Object_CreateInt64(void* environment, long long value);

DLL_EXPORT void* General_Typescript_Object_CreateUint64(void* environment, unsigned long long value);

DLL_EXPORT void* General_Typescript_Object_CreateFloat(void* environment, float value);

DLL_EXPORT void* General_Typescript_Object_CreateDouble(void* environment, double value);

DLL_EXPORT void* General_Typescript_Object_CreateString(void* environment, const char* value);

DLL_EXPORT void* General_Typescript_Object_CreateInstanceHandle(void* environment, const char* type);

DLL_EXPORT void* General_Typescript_Object_CreateWithField(void* environment, const char* type, int size);

DLL_EXPORT void* General_Typescript_Object_CreateArrayWithLength(void* environment, int length);

DLL_EXPORT void* General_Typescript_Object_CreateArrayWithElements(void* environment, JsObject** elements, int length);

DLL_EXPORT void General_Typescript_SetGarbageCollectionCallback(GarbageCollectionCallback callback);

DLL_EXPORT void General_Typescript_Object_MakePersistent(void* environment, JsObject* instance);

DLL_EXPORT void General_Typescript_Object_MakeWeak(void* environment, JsObject* instance);

DLL_EXPORT bool General_Typescript_Object_HasProperty(void* environment, JsObject* instance, const char* name);

DLL_EXPORT bool General_Typescript_Object_HasFunction(void* environment, JsObject* instance, const char* name);

DLL_EXPORT void* General_Typescript_Object_CallFunction(void* environment, JsObject* instance, const char* name, JsObject* arguments);

DLL_EXPORT void General_Typescript_Object_CallFunctionWithoutResult(void* environment, JsObject* instance, const char* name, JsObject* arguments);

DLL_EXPORT void* General_Typescript_Object_CallAsFunction(void* environment, JsObject* instance, JsObject* arguments);

DLL_EXPORT int General_Typescript_Object_GetJsType(void* environment, JsObject* instance);

DLL_EXPORT char* General_Typescript_Object_GetTypeName(void* environment, void* caller);

DLL_EXPORT void* General_Typescript_Object_GetField(void* environment, void* pointer, void* caller);

DLL_EXPORT bool General_Typescript_Object_ToBoolean(void* environment, JsObject* instance);

DLL_EXPORT char* General_Typescript_Object_ToString(void* environment, JsObject* instance);

DLL_EXPORT int General_Typescript_Object_ToInt32(void* environment, JsObject* instance);

DLL_EXPORT unsigned int General_Typescript_Object_ToUint32(void* environment, JsObject* instance);

DLL_EXPORT long long General_Typescript_Object_ToInt64(void* environment, JsObject* instance);

DLL_EXPORT unsigned long long General_Typescript_Object_ToUint64(void* environment, JsObject* instance);

DLL_EXPORT float General_Typescript_Object_ToFloat(void* environment, JsObject* instance);

DLL_EXPORT double General_Typescript_Object_ToDouble(void* environment, JsObject* instance);

EXTERN_END
