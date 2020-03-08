#include "defines.h"

EXTERN_BEGIN

DLL_EXPORT void* General_Typescript_Namespace_DeclareNamespace(void* handle, const char* name);

DLL_EXPORT void* General_Typescript_Namespace_DeclareClass(void* handle, const char* name, const char* base, bool hasConstructor, bool isStatic);

DLL_EXPORT void* General_Typescript_Namespace_DeclareEnum(void* handle, const char* name);

EXTERN_END
