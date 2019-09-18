#include "defines.h"

EXTERN_BEGIN

DLL_EXPORT int General_Typescript_Parameter_GetType(void* environment, void* pointer, int index);

DLL_EXPORT char* General_Typescript_Parameter_GetTypeName(void* environment, void* pointer, int index);

DLL_EXPORT void* General_Typescript_Parameter_GetHandle(void* environment, void* pointer, int index);

DLL_EXPORT void* General_Typescript_Parameter_GetField(void* environment, void* pointer, int index);

DLL_EXPORT bool General_Typescript_Parameter_ToBoolean(void* environment, void* pointer, int index);

DLL_EXPORT double General_Typescript_Parameter_ToNumber(void* environment, void* pointer, int index);

DLL_EXPORT char* General_Typescript_Parameter_ToString(void* environment, void* pointer, int index);

DLL_EXPORT int General_Typescript_Parameter_GetArrayLength(void* environment, void* pointer, int index);

DLL_EXPORT char* General_Typescript_Parameter_GetArrayString(void* environment, void* pointer, int index, int elementIndex);

DLL_EXPORT void* General_Typescript_Parameter_ToArray(void* environment, void* pointer, int index, int type, int subType);

EXTERN_END
