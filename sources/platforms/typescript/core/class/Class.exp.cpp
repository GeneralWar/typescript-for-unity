//
//  Class.exp.cpp
//  typescript
//
//  Created by 朱嘉灵 on 2018/12/13.
//  Copyright © 2018 朱嘉灵. All rights reserved.
//

#include "Class.h"
#include "Class.exp.h"

ConstructorCallback sConstructorCallback;

StaticFunctionCallback sStaticFunctionCallback;
InstanceFunctionCallback sInstanceFunctionCallback;

StaticPropertyGetter sStaticPropertyGetter;
StaticPropertySetter sStaticPropertySetter;

InstancePropertyGetter sInstancePropertyGetter;
InstancePropertySetter sInstancePropertySetter;

void General_Typescript_Class_BindConstructorCallback(ConstructorCallback callback)
{
//    DEBUG_LOG("%s : 0x%x", "General_Typescript_Class_BindConstructorCallback", callback);
	sConstructorCallback = callback;
}

void* General_Typescript_Class_BindStaticFunction(void* handle, const char* name)
{
//    DEBUG_LOG("%s : 0x%x, %s", "General_Typescript_Class_BindStaticFunction", handle, name);
	TypescriptClass* instance = TypescriptClass::Convert(handle);
	if (!instance) return nullptr;
#if USE_ENGINE_V8
	Isolate* isolate = instance->GetIsolate();
	HandleScope handleScope(isolate);
#endif
	return (void*)instance->BindStaticFunction(SAFE_STRING(name));
}

void* General_Typescript_Class_BindInstanceFunction(void* handle, const char* name)
{
//    DEBUG_LOG("%s : 0x%x, %s", "General_Typescript_Class_BindInstanceFunction", handle, name);
	TypescriptClass* instance = TypescriptClass::Convert(handle);
	if (!instance) return nullptr;
#if USE_ENGINE_V8
	Isolate* isolate = instance->GetIsolate();
	HandleScope handleScope(isolate);
#endif
	return (void*)instance->BindInstanceFunction(SAFE_STRING(name));
}

void General_Typescript_Class_BindFunctionCallback(StaticFunctionCallback staticCallback, InstanceFunctionCallback instanceCallback)
{
//    DEBUG_LOG("%s : 0x%x, 0x%x", "General_Typescript_Class_BindFunctionCallback", staticCallback, instanceCallback);
	sStaticFunctionCallback = staticCallback;
	sInstanceFunctionCallback = instanceCallback;
}

void* General_Typescript_Class_BindStaticProperty(void* handle, const char* name, bool hasGetter, bool hasSetter)
{
//    DEBUG_LOG("%s : 0x%x, %s, %s, %s", "General_Typescript_Class_BindStaticProperty", handle, name, BTOS(hasGetter), BTOS(hasSetter));
	TypescriptClass* instance = TypescriptClass::Convert(handle);
	if (!instance) return nullptr;
#if USE_ENGINE_V8
	Isolate* isolate = instance->GetIsolate();
	HandleScope handleScope(isolate);
#endif
	return (void*)instance->BindStaticProperty(SAFE_STRING(name), hasGetter, hasSetter);
}

void* General_Typescript_Class_BindInstanceProperty(void* handle, const char* name, bool hasGetter, bool hasSetter)
{
//    DEBUG_LOG("%s : 0x%x, %s, %s, %s", "General_Typescript_Class_BindInstanceProperty", handle, name, BTOS(hasGetter), BTOS(hasSetter));
	TypescriptClass* instance = TypescriptClass::Convert(handle);
	if (!instance) return nullptr;
#if USE_ENGINE_V8
	Isolate* isolate = instance->GetIsolate();
	HandleScope handleScope(isolate);
#endif
	return (void*)instance->BindInstanceProperty(SAFE_STRING(name), hasGetter, hasSetter);
}

void General_Typescript_Class_BindPropertyCallback(StaticPropertyGetter staticGetter, StaticPropertySetter staticSetter, InstancePropertyGetter instanceGetter, InstancePropertySetter instanceSetter)
{
//    DEBUG_LOG("%s : 0x%x, 0x%x, 0x%x, 0x%x", "General_Typescript_Class_BindPropertyCallback", staticGetter, staticSetter, instanceGetter, instanceSetter);
	sStaticPropertyGetter = staticGetter;
	sStaticPropertySetter = staticSetter;
	sInstancePropertyGetter = instanceGetter;
	sInstancePropertySetter = instanceSetter;
}

void* General_Typescript_Class_DeclareClass(void* handle, const char* name, const char* base, bool hasConstructor, bool isStatic)
{
//    DEBUG_LOG("%s : 0x%x, %s, %s, %s", "General_Typescript_Class_DeclareClass", handle, name, base, BTOS(hasConstructor));
	TypescriptClass* instance = TypescriptClass::Convert(handle);
	if (!instance) return nullptr;
#if USE_ENGINE_V8
	Isolate* isolate = instance->GetIsolate();
	HandleScope handleScope(isolate);
#endif
	return (void*)instance->DeclareClass(SAFE_STRING(name), SAFE_STRING(base), hasConstructor, isStatic);
}

void* General_Typescript_Class_DeclareEnum(void* handle, const char* name)
{
//    DEBUG_LOG("%s : 0x%x, %s", "General_Typescript_Class_DeclareEnum", handle, name);
	TypescriptClass* instance = TypescriptClass::Convert(handle);
	if (!instance) return nullptr;
#if USE_ENGINE_V8
	Isolate* isolate = instance->GetIsolate();
	HandleScope handleScope(isolate);
#endif
	return (void*)instance->DeclareEnum(SAFE_STRING(name));
}

void General_Typescript_Class_Register(void* handle, const char* parentType)
{
    TypescriptClass* instance = TypescriptClass::Convert(handle);
    if (!instance) return;
#if USE_ENGINE_V8
    Isolate* isolate = instance->GetIsolate();
    HandleScope handleScope(isolate);
#endif
    instance->Register(SAFE_STRING(parentType));
}
