#include "defines.h"

EXTERN_BEGIN

DLL_EXPORT void General_Typescript_Result_Release(void* environment, int index);

DLL_EXPORT int General_Typescript_Result_GetJsType(void* environment, int index);

DLL_EXPORT double General_Typescript_Result_ToNumber(void* environment, int index);

DLL_EXPORT char* General_Typescript_Result_ToString(void* environment, int index);

DLL_EXPORT bool General_Typescript_Result_ToBoolean(void* environment, int index);

EXTERN_END
