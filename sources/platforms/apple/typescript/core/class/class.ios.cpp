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
#include "../../utils.h"
#include "../object/object.ios.h"
#include "core/function/Constructor.h"
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

JSValueRef check_return_value(JSContextRef context, int result)
{
    return GetReturnValue(context, result);
}

static unsigned long long pick_static_caller(JSContextRef context, JSObjectRef target)
{
    return JSValue_To_Uint64(context, GetObjectProperty(context, target, OBJECT_KEY));
}

static int pick_instance_caller(JSContextRef context, JSObjectRef target)
{
    return RegisterCaller(context, (JSValueRef)target);
}

JSValueRef check_function_result(JSContextRef context, int index)
{
    if (index > -1)
    {
        JSValueRef result = GetReturnValue(context, index);
        ReleaseReturnValue(index);
        return result;
    }
    return nullptr;
}

JSObjectRef onConstructorCall(JSContextRef context, JSObjectRef constructor, size_t argumentCount, const JSValueRef arguments[], JSValueRef* exception)
{
    if (*exception)
    {
        LogError(JSValue_To_String(context, *exception));
        return nullptr;
    }
    if (constructor)
    {
        TypescriptClass* instance = reinterpret_cast<TypescriptClass*>((void*)pick_static_caller(context, constructor));
        if (instance)
        {
            int result = instance->CreateInstance(arguments, (int)argumentCount);
            JSValueRef value = check_function_result(context, result);
            return value ? ValueToObject(context, value) : nullptr;
        }
    }
    return nullptr;
}

JSValueRef onStaticFunctionCall (JSContextRef context, JSObjectRef function, JSObjectRef thisObject, size_t argumentCount, const JSValueRef arguments[], JSValueRef* exception)
{
    if (*exception)
    {
        LogError(JSValue_To_String(context, *exception));
        return nullptr;
    }
    if (function)
    {
        TypescriptStaticFunction* instance = reinterpret_cast<TypescriptStaticFunction*>(TypescriptStaticFunction::GetInstance(pick_static_caller(context, function)));
        if (instance)
        {
            Parameters parameters(arguments, (int)argumentCount);
            return check_return_value(context, instance->Invoke(arguments, (int)argumentCount));
        }
    }
    return nullptr;
}

JSValueRef onInstanceFunctionCall (JSContextRef context, JSObjectRef function, JSObjectRef thisObject, size_t argumentCount, const JSValueRef arguments[], JSValueRef* exception)
{
    if (*exception)
    {
        LogError(JSValue_To_String(context, *exception));
        return nullptr;
    }
    Parameters parameters(arguments, (int)argumentCount);
    int caller = pick_instance_caller(context, thisObject);
    std::string name = GetObjectPropertyWithString(context, function, PROPERTY_KEY);
    return check_return_value(context, sInstanceFunctionCallback(caller, name.c_str(), &parameters, parameters.count()));
}

JSValueRef onStaticPropertyGetterCall (JSContextRef context, JSObjectRef function, JSObjectRef thisObject, size_t argumentCount, const JSValueRef arguments[], JSValueRef* exception)
{
    if (*exception)
    {
        LogError(JSValue_To_String(context, *exception));
        return nullptr;
    }
    if (function)
    {
        TypescriptStaticProperty* instance = TypescriptStaticProperty::GetInstance(pick_static_caller(context, function));
        if (instance)
        {
            return check_return_value(context, sStaticPropertyGetter(instance));
        }
    }
    return nullptr;
}

JSValueRef onStaticPropertySetterCall (JSContextRef context, JSObjectRef function, JSObjectRef thisObject, size_t argumentCount, const JSValueRef arguments[], JSValueRef* exception)
{
    if (*exception)
    {
        LogError(JSValue_To_String(context, *exception));
        return nullptr;
    }
    if (function)
    {
        TypescriptStaticProperty* instance = TypescriptStaticProperty::GetInstance(pick_static_caller(context, function));
        if (instance)
        {
            Parameters parameters(arguments, (int)argumentCount);
            sStaticPropertySetter(instance, parameters.address());
        }
    }
    return nullptr;
}

JSValueRef onInstancePropertyGetterCall (JSContextRef context, JSObjectRef function, JSObjectRef thisObject, size_t argumentCount, const JSValueRef arguments[], JSValueRef* exception)
{
    if (*exception)
    {
        LogError(JSValue_To_String(context, *exception));
        return nullptr;
    }
    int caller = pick_instance_caller(context, thisObject);
    std::string property = JSValue_To_String(context, GetObjectProperty(context, function, PROPERTY_KEY));
    int result = sInstancePropertyGetter(caller, property.c_str());
    return check_function_result(context, result);
}

JSValueRef onInstancePropertySetterCall (JSContextRef context, JSObjectRef function, JSObjectRef thisObject, size_t argumentCount, const JSValueRef arguments[], JSValueRef* exception)
{
    if (*exception)
    {
        LogError(JSValue_To_String(context, *exception));
        return nullptr;
    }
    int caller = pick_instance_caller(context, thisObject);
    std::string property = JSValue_To_String(context, GetObjectProperty(context, function, PROPERTY_KEY));
    Parameters parameters(arguments, (int)argumentCount);
    sInstancePropertySetter(caller, property.c_str(), parameters.address());
    return nullptr;
}

JSValueRef onApplyCall (JSContextRef context, JSObjectRef function, JSObjectRef thisObject, size_t argumentCount, const JSValueRef arguments[], JSValueRef* exception)
{
    return CreateValue(context);
}

void TypescriptClass::bind()
{
    JSContextRef context = GetContext(this);
    if (!context) return;

    JSValueRef self = nullptr;
    if (mHasConstructor)
    {
        JSValueRef exception = 0;
        JSContextRef context = GetContext(this);
        
        JSObjectRef constructor = JSObjectMakeConstructor(context, nullptr, onConstructorCall);
        if (exception)
        {
            LogError(JSValue_To_String(context, exception));
            return;
        }
        
        self = mReference = mJsObject = constructor;
        SetValueProperty(context, self, OBJECT_KEY, JSValueMakeNumber(context, (double)(unsigned long long)this));
        SetValuePropertyWithString(context, self, FULLNAME, mFullname.c_str());
        if (exception)
        {
            LogError(JSValue_To_String(context, exception));
        }
    }
    else
    {
        Base::Bind();
        self = mReference;
    }
    JSStringRef applyName = JSStringCreateWithUTF8CString(APPLY);
    JSObjectRef apply = JSObjectMakeFunctionWithCallback(context, applyName, onApplyCall);
    JSObjectSetProperty(context, ValueToObject(context, self), applyName, apply, 0, nullptr);
    JSStringRelease(applyName);
    
    SetValuePropertyWithString(context, self, UNITY_INSTANCE_IS_TYPE, mFullname.c_str());
    SetValueProperty(context, GetParentValue(this), mName.c_str(), self);
}

void TypescriptClass::bindConstructor()
{
    this->bind();
}

void TypescriptClass::inherit()
{
    if (nullptr == mParent) return;
    
    JSObjectRef self = this->GetJsObject();
    assert(self);
    
    JSContextRef context = GetContext(this);
    if (!context) return;
    
    JSObjectRef parent = mParent->GetJsObject();
    JSPropertyNameArrayRef names = JSObjectCopyPropertyNames(context, parent);
    size_t length = JSPropertyNameArrayGetCount(names);
    for (size_t i = 0; i < length; ++i)
    {
        JSStringRef name = JSPropertyNameArrayGetNameAtIndex(names, i);
        if (JSObjectHasProperty(context, self, name))
        {
            continue;
        }
        JSObjectSetProperty(context, self, name, JSObjectGetProperty(context, parent, name, nullptr), kJSPropertyAttributeNone, nullptr);
    }
    JSPropertyNameArrayRelease(names);
}

int TypescriptClass::CreateInstance(const JSValueRef *arguments, const int &argumentCount)
{
    Parameters parameters(arguments, argumentCount);
    return sConstructorCallback(this, parameters.address(), parameters.count());
}

//#import "class.h"
//#import "console.h"
//#import "convertion.h"
//#import "utils.h"
//#import "object.h"
//
//extern StaticFunctionCallback sStaticFunctionCallback;
//
//@implementation TypescriptClass
//
//-(id) init:(NSString*)name WithParent:(TypescriptBase*) parent
//{
//    self = [super init :name WithParent:parent];
//    if (self)
//    {
//        _staticFunctions = [[NSMutableDictionary<NSString*, TypescriptStaticFunction*> alloc] init];
//        _staticProperties = [[NSMutableDictionary<NSString*, TypescriptStaticProperty*> alloc] init];
//    }
//    return self;
//}
//
//-(id) init:(NSString*)name WithContext:(JSContextRef) context
//{
//    self = [super init :name WithContext:context];
//    if (self)
//    {
//        _staticFunctions = [[NSMutableDictionary<NSString*, TypescriptStaticFunction*> alloc] init];
//        _staticProperties = [[NSMutableDictionary<NSString*, TypescriptStaticProperty*> alloc] init];
//    }
//    return self;
//}
//
//-(void) bind
//{
//    if (_constructor)
//    {
//        [_constructor bind];
//        _self = _constructor.handle;
//    }
//    else
//    {
//        [super bind];
//    }
//    SetValuePropertyWithString(_context, _self, UNITY_INSTANCE_IS_TYPE, _fullname.UTF8String);
//    for (NSString* name in _staticFunctions)
//    {
//        [_staticFunctions[name] bind];
//    }
//    for (NSString* name in _staticProperties)
//    {
//        [_staticProperties[name] bind];
//    }
//}
//
//-(bool) real
//{
//    return _real;
//}
//
//-(TypescriptConstructor*) bindConstructor:(bool) real
//{
//    _real = real;
//    _constructor = _parent ? [[TypescriptConstructor alloc] init:_name WithParent:_parent] : [[TypescriptConstructor alloc] init:_name WithContext:_context];
//    return _constructor;
//}
//
//-(TypescriptStaticFunction*) bindStaticFunction:(NSString*)name WithCallback:(StaticFunctionCallback)callback
//{
//    TypescriptStaticFunction* instance = [[TypescriptStaticFunction alloc] init:name :self WithCallback:callback];
//    [_staticFunctions setValue:instance forKey:name];
//
//    return instance;
//}
//
//-(TypescriptStaticFunction*) bindStaticFunction:(NSString*)name
//{
//    return [self bindStaticFunction:name WithCallback:sStaticFunctionCallback];
//}
//
//-(TypescriptStaticProperty*) bindStaticProperty:(NSString*)name :(Boolean)hasGetter :(Boolean)hasSetter
//{
//    TypescriptStaticProperty* instance = [[TypescriptStaticProperty alloc] init:name :self :hasGetter :hasSetter];
//    [_staticProperties setValue:instance forKey:name];
//    return instance;
//}
//
//@end
