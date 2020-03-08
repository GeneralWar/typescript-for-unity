//
//  class.m
//  typescript
//
//  Created by 朱嘉灵 on 2018/10/15.
//  Copyright © 2018年 朱嘉灵. All rights reserved.
//

#include "defines.h"
#include "core/class/Class.h"
#include "extra/log/Log.h"
#include "Utils.apple.h"
#include "core/object/Object.h"
#include "core/function/Function.h"
#include "core/property/Property.h"
#include "core/function/Parameters.h"

extern ConstructorCallback sConstructorCallback;

extern StaticFunctionCallback sStaticFunctionCallback;
extern InstanceFunctionCallback sInstanceFunctionCallback;

extern StaticPropertyGetter sStaticPropertyGetter;
extern StaticPropertySetter sStaticPropertySetter;

extern InstancePropertyGetter sInstancePropertyGetter;
extern InstancePropertySetter sInstancePropertySetter;

extern int RegisterCaller(JSContextRef context, const JSValueRef& caller);

static unsigned long long pick_static_caller(JSContextRef context, JSObjectRef target, const bool& isConstructor)
{
    void* handle = nullptr;
    if (isConstructor)
    {
        JSObjectRef prototype = JsObject::GetPrototypeFromConstructor(context, target);
        handle = JSObjectGetPrivate(prototype);
    }
    else
    {
        handle = JsObject::GetNativeObjectHandle(context, target);
    }
    return (unsigned long long)handle;
}

JSObjectRef onConstructorCall(JSContextRef context, JSObjectRef constructor, size_t argumentCount, const JSValueRef arguments[], JSValueRef* exception)
{
    if (*exception)
    {
        LogError(JsObject::ToString(context, *exception));
        return nullptr;
    }
    if (constructor)
    {
        TypescriptClass* instance = reinterpret_cast<TypescriptClass*>((void*)pick_static_caller(context, constructor, true));
        if (instance)
        {
            JsObject* result = instance->CreateInstance(arguments, (int)argumentCount);
            return result ? result->GetObject(): nullptr;
        }
    }
    return nullptr;
}

JSValueRef onStaticFunctionCall (JSContextRef context, JSObjectRef function, JSObjectRef thisObject, size_t argumentCount, const JSValueRef arguments[], JSValueRef* exception)
{
    if (*exception)
    {
        LogError(JsObject::ToString(context, *exception));
        return nullptr;
    }
    if (function)
    {
        TypescriptStaticFunction* instance = TypescriptStaticFunction::Convert((void*)pick_static_caller(context, function, false));
#if DEBUG
        std::string classname = JsObject::GetString(context, thisObject, FULLNAME);
        std::string functionName = JsObject::GetString(context, function, FULLNAME);
        assert(instance->GetFullname() == functionName);
#endif
        if (instance)
        {
            Parameters parameters(arguments, (int)argumentCount);
            JsObject* result = instance->Invoke(arguments, (int)argumentCount);
            return result ? result->GetValue() : nullptr;
        }
    }
    return nullptr;
}

struct InstanceData
{
    JsObject* caller;
    Base* instance;
};

static InstanceData pick_instance_data(JSContextRef context, JSObjectRef function, JSObjectRef thisObject)
{
    JsObject* caller = JsObject::Create(context, nullptr, thisObject);
    void* handle = JsObject::GetNativeObjectHandle(context, function);
    Base* instance = Base::Convert(handle);
    return { caller, instance };
}

JSValueRef onInstanceFunctionCall (JSContextRef context, JSObjectRef function, JSObjectRef thisObject, size_t argumentCount, const JSValueRef arguments[], JSValueRef* exception)
{
    if (*exception)
    {
        LogError(JsObject::ToString(context, *exception));
        return nullptr;
    }
    Parameters parameters(arguments, (int)argumentCount);
    InstanceData data = pick_instance_data(context, function, thisObject);
#if DEBUG
    std::string instanceType = JsObject::GetString(context, thisObject, UNITY_INSTANCE_TYPE);
    std::string functionName = JsObject::GetString(context, function, FULLNAME);
    assert(data.caller->GetTarget()->IsOrSubClassOf(data.instance->GetParent()));
#endif
    JsObject* result = sInstanceFunctionCallback(data.caller, data.instance, data.instance->GetName().c_str(), &parameters, parameters.count());
    return result ? result->GetValue() : nullptr;
}

JSValueRef onStaticPropertyGetterCall (JSContextRef context, JSObjectRef function, JSObjectRef thisObject, size_t argumentCount, const JSValueRef arguments[], JSValueRef* exception)
{
    if (*exception)
    {
        LogError(JsObject::ToString(context, *exception));
        return nullptr;
    }
    if (function)
    {
        TypescriptStaticProperty* instance = TypescriptStaticProperty::Convert((void*)pick_static_caller(context, function, false));
#if DEBUG
        std::string classname = JsObject::GetString(context, thisObject, FULLNAME);
        std::string functionName = JsObject::GetString(context, function, FULLNAME);
        assert(instance->GetFullname() == functionName);
#endif
        if (instance)
        {
            JsObject* result = sStaticPropertyGetter(instance);
            return result ? result->GetValue() : nullptr;
        }
    }
    return nullptr;
}

JSValueRef onStaticPropertySetterCall (JSContextRef context, JSObjectRef function, JSObjectRef thisObject, size_t argumentCount, const JSValueRef arguments[], JSValueRef* exception)
{
    if (*exception)
    {
        LogError(JsObject::ToString(context, *exception));
        return nullptr;
    }
//    if (function)
//    {
//        TypescriptStaticProperty* instance = TypescriptStaticProperty::Convert((void*)pick_static_caller(context, function));
//        if (instance)
//        {
//            Parameters parameters(arguments, (int)argumentCount);
//            sStaticPropertySetter(instance, parameters.address());
//        }
//    }
    return nullptr;
}

JSValueRef onInstancePropertyGetterCall (JSContextRef context, JSObjectRef function, JSObjectRef thisObject, size_t argumentCount, const JSValueRef arguments[], JSValueRef* exception)
{
    if (*exception)
    {
        LogError(JsObject::ToString(context, *exception));
        return nullptr;
    }
    InstanceData data = pick_instance_data(context, function, thisObject);
#if DEBUG
    std::string instanceType = JsObject::GetString(context, thisObject, UNITY_INSTANCE_TYPE);
    std::string functionName = JsObject::GetString(context, function, FULLNAME);
    assert(data.caller->GetTarget()->IsOrSubClassOf(data.instance->GetParent()));
#endif
    JsObject* result = sInstancePropertyGetter(data.caller, data.instance, data.instance->GetName().c_str());
    return result ? result->GetValue() : nullptr;
}

JSValueRef onInstancePropertySetterCall (JSContextRef context, JSObjectRef function, JSObjectRef thisObject, size_t argumentCount, const JSValueRef arguments[], JSValueRef* exception)
{
    if (*exception)
    {
        LogError(JsObject::ToString(context, *exception));
        return nullptr;
    }
    InstanceData data = pick_instance_data(context, function, thisObject);
#if DEBUG
    std::string instanceType = JsObject::GetString(context, thisObject, UNITY_INSTANCE_TYPE);
    std::string functionName = JsObject::GetString(context, function, FULLNAME);
    assert(data.caller->GetTarget()->IsOrSubClassOf(data.instance->GetParent()));
#endif
    Parameters parameters(arguments, (int)argumentCount);
    sInstancePropertySetter(data.caller, data.instance, data.instance->GetName().c_str(), parameters.address());
    return nullptr;
}

JSValueRef onApplyCall (JSContextRef context, JSObjectRef function, JSObjectRef thisObject, size_t argumentCount, const JSValueRef arguments[], JSValueRef* exception)
{
    return nullptr;
}
