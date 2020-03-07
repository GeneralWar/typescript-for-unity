#include "defines.h"

class Environment;

EXTERN_BEGIN

DLL_EXPORT int General_Typescript_Parameter_GetType(Environment* runtime, void* pointer, int index);

DLL_EXPORT char* General_Typescript_Parameter_GetTypeName(Environment* runtime, void* pointer, int index);

DLL_EXPORT void* General_Typescript_Parameter_GetHandle(Environment* runtime, void* pointer, int index);

DLL_EXPORT void* General_Typescript_Parameter_GetField(Environment* runtime, void* pointer, int index);

DLL_EXPORT bool General_Typescript_Parameter_ToBoolean(Environment* runtime, void* pointer, int index);

DLL_EXPORT double General_Typescript_Parameter_ToNumber(Environment* runtime, void* pointer, int index);

DLL_EXPORT char* General_Typescript_Parameter_ToString(Environment* runtime, void* pointer, int index);

DLL_EXPORT int General_Typescript_Parameter_GetArrayLength(Environment* runtime, void* pointer, int index);

DLL_EXPORT char* General_Typescript_Parameter_GetArrayString(Environment* runtime, void* pointer, int index, int elementIndex);

DLL_EXPORT void* General_Typescript_Parameter_ToArray(Environment* runtime, void* pointer, int index, int type, int subType);

DLL_EXPORT void* General_Typescript_Parameter_ToFunction(Environment* runtime, void* pointer, int index);

EXTERN_END
