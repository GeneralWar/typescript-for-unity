#include "defines.h"
#ifndef typescript_h
#define typescript_h

class Environment;

EXTERN_BEGIN

#if _WIN32
DLL_EXPORT void General_Typescript_SetNativeDataBlob(const char* buffer, int size);

DLL_EXPORT void General_Typescript_SetSnapshotDataBlob(const char* buffer, int size);
#endif

DLL_EXPORT void* General_Typescript_Initialize();

DLL_EXPORT const char* General_Typescript_ExecuteString(void* environment, const char* sourceContent);

DLL_EXPORT const char* General_Typescript_ExecuteScript(void* environment, const char* sourceContent, const char* filename);

DLL_EXPORT void* General_Typescript_DeclareNamespace(void* environment, const char* name);

DLL_EXPORT void* General_Typescript_DeclareClass(void* environment, const char* name, const char* base, bool hasConstructor, bool isStatic);

DLL_EXPORT void* General_Typescript_BindStaticFunction(void* environment, const char* name);

DLL_EXPORT void General_Typescript_Finalize(void* environment);

DLL_EXPORT void General_Typescript_Request_GarbageCollection(Environment* runtime);

DLL_EXPORT void General_Typescript_DebugLog(const char* message);

DLL_EXPORT void General_Typescript_DebugLogWarning(const char* message, const char* stackTraces);

DLL_EXPORT void General_Typescript_DebugLogError(const char* message, const char* stackTraces);

EXTERN_END
#endif /* typescript_h */
