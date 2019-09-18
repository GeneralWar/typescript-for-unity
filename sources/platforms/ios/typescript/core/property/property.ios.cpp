//
//  base.m
//  typescript
//
//  Created by 朱嘉灵 on 2018/10/12.
//  Copyright © 2018年 朱嘉灵. All rights reserved.
//

#include "core/property/Property.h"
#include "../../utils.h"
#include "../../ocUtils.h"
#include "../object/object.ios.h"
#include "header.h"

extern JSValueRef onStaticPropertyGetterCall (JSContextRef context, JSObjectRef function, JSObjectRef thisObject, size_t argumentCount, const JSValueRef arguments[], JSValueRef* exception);
extern JSValueRef onStaticPropertySetterCall (JSContextRef context, JSObjectRef function, JSObjectRef thisObject, size_t argumentCount, const JSValueRef arguments[], JSValueRef* exception);

void TypescriptStaticProperty::Bind()
{
    JSContextRef context = GetContext(this);
    JSValueRef parent = GetParentValue(this);
//    DefineProperty(context, parent, (void*)this, mName.c_str(), mHasGetter ? onStaticPropertyGetterCall : nullptr, mHasSetter ? onStaticPropertySetterCall : nullptr);    

    mReference = BindProperty(context, parent, mName.c_str(), mHasGetter ? onStaticPropertyGetterCall : nullptr, mHasSetter ? onStaticPropertySetterCall : nullptr, this);
//    JSValueRef descriptor = CreateObject(context);
//    if (mHasGetter)
//    {
//        JSObjectRef function = JSObjectMakeFunctionWithCallback(context, 0, onStaticPropertyGetterCall);
//        SetValueProperty(context, descriptor, "get", function);
//    }
//    if (mHasSetter)
//    {
//        JSObjectRef function = JSObjectMakeFunctionWithCallback(context, 0, onStaticPropertySetterCall);
//        SetValueProperty(context, descriptor, "set", function);
//    }
//    SetValueProperty(context, parent, mName.c_str(), descriptor);
    //    JSContext* context = [JSContext contextWithJSGlobalContextRef:JSContextGetGlobalContext(contextRef)];
    //    JSValue* value = [JSValue valueWithJSValueRef:target inContext:context];
    //
    //    JSValue* descriptor = [JSValue valueWithNewObjectInContext:context];
    //    if (getCallback)
    //    {
    //        JSObjectRef function = JSObjectMakeFunctionWithCallback(contextRef, 0, getCallback);
    //        JSValue* getter = descriptor[JSPropertyDescriptorGetKey] = [JSValue valueWithJSValueRef: function inContext:context];
    //        getter[@"object"] = [NSNumber valueWithPointer:handle];
    //    }
    //    if (setCallback)
    //    {
    //        JSObjectRef function = JSObjectMakeFunctionWithCallback(contextRef, 0, setCallback);
    //        JSValue* setter = descriptor[JSPropertyDescriptorSetKey] = [JSValue valueWithJSValueRef: function inContext:context];
    //        setter[@"object"] = [NSNumber valueWithPointer:handle];
    //    }
    //
    //    [value defineProperty:[NSString stringWithUTF8String:name] descriptor:descriptor];
}

void TypescriptStaticProperty::Bind(Base *parent)
{
    if (mReference)
    {
        this->BindToParent(parent);
    }
}

//#import "property.h"
//#import "utils.h"
//
//extern JSValueRef Get_StaticProperty (JSContextRef context, JSObjectRef function, JSObjectRef thisObject, size_t argumentCount, const JSValueRef arguments[], JSValueRef* exception);
//
//extern JSValueRef Set_StaticProperty (JSContextRef context, JSObjectRef function, JSObjectRef thisObject, size_t argumentCount, const JSValueRef arguments[], JSValueRef* exception);
//
//@implementation TypescriptStaticProperty
//
//-(id) init:(NSString*) name :(TypescriptBase*) parent :(Boolean) hasGetter :(Boolean) hasSetter
//{
//    self = [super init:name WithParent:parent];
//    if (self){
//        _hasGetter = hasGetter;
//        _hasSetter = hasSetter;
//    }
//    return self;
//}
//
//-(void) bind
//{
//    [super bind];
//    
////    JSValueRef descriptor = [TypescriptBase CreateNewObject:_context];
////    if (_hasGetter)
////    {
////        JSObjectRef function = JSObjectMakeFunctionWithCallback(_context, 0, Get_StaticProperty);
////        SetValueProperty(_context, descriptor, JSPropertyDescriptorGetKey.UTF8String, function);
////        SetObjectProperty(_context, function, "object", _self);
////    }
////    if (_hasSetter)
////    {
////        JSObjectRef function = JSObjectMakeFunctionWithCallback(_context, 0, Set_StaticProperty);
////        SetValueProperty(_context, descriptor, JSPropertyDescriptorSetKey.UTF8String, function);
////        SetObjectProperty(_context, function, "object", _self);
////    }
//////    [[JSValue valueWithJSValueRef:_parent.handle inContext:[JSContext contextWithJSGlobalContextRef:JSContextGetGlobalContext(_context)]] defineProperty:_name descriptor:[JSValue valueWithJSValueRef:descriptor inContext:[JSContext contextWithJSGlobalContextRef:JSContextGetGlobalContext(_context)]]];
////    SetValueProperty(_context, _parent.handle, _name.UTF8String, descriptor);
//    
//    JSContext* context = [JSContext contextWithJSGlobalContextRef:JSContextGetGlobalContext(_context)];
//    JSValue* value = [JSValue valueWithJSValueRef:_parent.handle inContext:context];
//
//    JSValue* descriptor = [JSValue valueWithNewObjectInContext:context];
//    if (_hasGetter)
//    {
//        JSObjectRef function = JSObjectMakeFunctionWithCallback(context.JSGlobalContextRef, 0, Get_StaticProperty);
//        JSValue* getter = descriptor[JSPropertyDescriptorGetKey] = [JSValue valueWithJSValueRef: function inContext:context];
//        getter[@"object"] = [JSValue valueWithJSValueRef:_self inContext:context];
//    }
//    if (_hasSetter)
//    {
//        JSObjectRef function = JSObjectMakeFunctionWithCallback(context.JSGlobalContextRef, 0, Set_StaticProperty);
//        JSValue* setter = descriptor[JSPropertyDescriptorSetKey] = [JSValue valueWithJSValueRef: function inContext:context];
//        setter[@"object"] = [JSValue valueWithJSValueRef:_self inContext:context];
//    }
//
//    [value defineProperty:_name descriptor:descriptor];
//}
//
//@end
//
