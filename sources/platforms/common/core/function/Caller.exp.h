#include "defines.h"

EXTERN_BEGIN

DLL_EXPORT char* General_Typescript_Caller_GetTypeName(void* environment, int index);

DLL_EXPORT void* General_Typescript_Caller_GetHandle(void* environment, int index);

DLL_EXPORT void* General_Typescript_Caller_GetField(void* environment, void* pointer, int index);

EXTERN_END
