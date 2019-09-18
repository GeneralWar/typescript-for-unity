#include "defines.h"

EXTERN_BEGIN

DLL_EXPORT int General_Typescript_Return_CreateString(void* environment, const char* value);

DLL_EXPORT int General_Typescript_Return_CreateNumber(void* environment, double value);

DLL_EXPORT int General_Typescript_Return_CreateBoolean(void* environment, bool value);

DLL_EXPORT int General_Typescript_Return_CreateWithHandle(void* environment, const char* type, void* handle);

DLL_EXPORT int General_Typescript_Return_CreateWithField(void* environment, const char* type, void* handle, int size);

DLL_EXPORT void General_Typescript_Return_MakePersistent(void* environment, int index);

DLL_EXPORT void General_Typescript_Return_BindInstanceFunction(void* environment, int index, const char* name);

DLL_EXPORT void General_Typescript_Return_BindInstanceProperty(void* environment, int index, const char* name, bool hasGetter, bool hasSetter);

EXTERN_END
