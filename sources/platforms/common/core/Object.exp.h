#include "delegates.h"
#include "defines.h"
#pragma once

EXTERN_BEGIN

DLL_EXPORT void* General_Typescript_CreateBuffer(int size);

DLL_EXPORT bool General_Typescript_Object_HasProperty(void* environment, void* handle, const char* name);

DLL_EXPORT bool General_Typescript_Object_HasFunction(void* environment, void* handle, const char* name);

DLL_EXPORT int General_Typescript_Object_CallFunction(void* environment, void* handle, const char* name, unsigned char* arguments);

DLL_EXPORT void General_Typescript_Object_CallFunctionWithoutResult(void* environment, void* handle, const char* name, unsigned char* arguments);

EXTERN_END
