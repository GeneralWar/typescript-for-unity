#include "delegates.h"
#include "../../defines.h"

EXTERN_BEGIN

DLL_EXPORT void General_Typescript_Class_BindConstructorCallback(ConstructorCallback callback);

DLL_EXPORT void* General_Typescript_Class_BindStaticFunction(void* handle, const char* name);
DLL_EXPORT void* General_Typescript_Class_BindInstanceFunction(void* handle, const char* name);

DLL_EXPORT void General_Typescript_Class_BindFunctionCallback(StaticFunctionCallback staticCallback, InstanceFunctionCallback instanceCallback);

DLL_EXPORT void* General_Typescript_Class_BindStaticProperty(void* handle, const char* name, bool hasGetter, bool hasSetter);
DLL_EXPORT void* General_Typescript_Class_BindInstanceProperty(void* handle, const char* name, bool hasGetter, bool hasSetter);

DLL_EXPORT void General_Typescript_Class_BindPropertyCallback(StaticPropertyGetter staticGetter, StaticPropertySetter staticSetter, InstancePropertyGetter instanceGetter, InstancePropertySetter instanceSetter);

DLL_EXPORT void* General_Typescript_Class_DeclareClass(void* handle, const char* name, const char* base, bool hasConstructor, bool isStatic);

DLL_EXPORT void* General_Typescript_Class_DeclareEnum(void* handle, const char* name);

DLL_EXPORT void General_Typescript_Class_Register(void* handle, const char* parentType);

EXTERN_END
