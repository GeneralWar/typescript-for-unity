#include "core/class/Class.h"
#include "core/class/Class.exp.h"
//
//  Class.exp.cpp
//  typescript
//
//  Created by 朱嘉灵 on 2018/12/13.
//  Copyright © 2018 朱嘉灵. All rights reserved.
//


ConstructorCallback sConstructorCallback;

StaticFunctionCallback sStaticFunctionCallback;
InstanceFunctionCallback sInstanceFunctionCallback;

StaticPropertyGetter sStaticPropertyGetter;
StaticPropertySetter sStaticPropertySetter;

InstancePropertyGetter sInstancePropertyGetter;
InstancePropertySetter sInstancePropertySetter;

void General_Typescript_Class_BindConstructorCallback(ConstructorCallback callback)
{
	sConstructorCallback = callback;
}

void General_Typescript_Class_BindConstructor(void* handle, bool real)
{
	TypescriptClass* instance = reinterpret_cast<TypescriptClass*>(handle);
	if (instance)
	{
		instance->BindConstructor(real);
	}
}

void* General_Typescript_Class_BindStaticFunction(void* handle, const char* name)
{
	TypescriptClass* instance = reinterpret_cast<TypescriptClass*>(handle);
	return instance ? (void*)instance->BindStaticFunction(name).get() : nullptr;
}

void General_Typescript_Class_BindFunctionCallback(StaticFunctionCallback staticCallback, InstanceFunctionCallback instanceCallback)
{
	sStaticFunctionCallback = staticCallback;
	sInstanceFunctionCallback = instanceCallback;
}

void* General_Typescript_Class_BindStaticProperty(void* handle, const char* name, bool hasGetter, bool hasSetter)
{
	TypescriptClass* instance = reinterpret_cast<TypescriptClass*>(handle);
	return instance ? (void*)instance->BindStaticProperty(name, hasGetter, hasSetter).get() : nullptr;
}

void General_Typescript_Class_BindPropertyCallback(StaticPropertyGetter staticGetter, StaticPropertySetter staticSetter, InstancePropertyGetter instanceGetter, InstancePropertySetter instanceSetter)
{
	sStaticPropertyGetter = staticGetter;
	sStaticPropertySetter = staticSetter;
	sInstancePropertyGetter = instanceGetter;
	sInstancePropertySetter = instanceSetter;
}

void* General_Typescript_Class_DeclareClass(void* handle, const char* name)
{
	TypescriptClass* instance = reinterpret_cast<TypescriptClass*>(handle);
	return instance ? (void*)instance->DeclareClass(name) : nullptr;
}

void* General_Typescript_Class_DeclareEnum(void* handle, const char* name)
{
	TypescriptClass* instance = reinterpret_cast<TypescriptClass*>(handle);
	return instance ? (void*)instance->DeclareEnum(name) : nullptr;
}
