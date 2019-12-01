#include "defines.h"
#ifndef typescript_h
#define typescript_h


EXTERN_BEGIN

#if _WIN32
DLL_EXPORT void General_Typescript_SetNativeDataBlob(const char* buffer, int size);

DLL_EXPORT void General_Typescript_SetSnapshotDataBlob(const char* buffer, int size);
#endif

DLL_EXPORT void* General_Typescript_Initialize();

DLL_EXPORT bool General_Typescript_Is_Initialized();

DLL_EXPORT void General_Typescript_Bind(void* environment);

DLL_EXPORT const char* General_Typescript_ExecuteString(void* environment, const char* sourceContent);

DLL_EXPORT const char* General_Typescript_ExecuteScript(void* environment, const char* sourceContent, const char* filename);

DLL_EXPORT void* General_Typescript_DeclareNamespace(void* environment, const char* name);

DLL_EXPORT void* General_Typescript_DeclareClass(void* environment, const char* name, const char* base);

DLL_EXPORT void* General_Typescript_BindStaticFunction(void* environment, const char* name);

//DLL_EXPORT void General_Typescript_ReleaseHandle(void* environment, unsigned long long handle);
//
//DLL_EXPORT void General_Typescript_ReleaseMemory(void* environment, unsigned long long* handles, int size);

DLL_EXPORT void General_Typescript_Finalize(void* environment);

DLL_EXPORT void General_Typescript_AppendCustomSuperClassName(const char* fullname);

EXTERN_END

#endif /* typescript_h */
