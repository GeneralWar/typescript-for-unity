//
//  contextUtils.m
//  typescript
//
//  Created by 朱嘉灵 on 2018/12/12.
//  Copyright © 2018 朱嘉灵. All rights reserved.
//

#import "ocUtils.h"
#include "defines.h"
#include "extra/log/Log.h"
#import <Foundation/Foundation.h>

JSContext* sContext;

JSContextRef CreateContext()
{
    sContext = [[JSContext alloc] init];
    sContext.exceptionHandler = ^(JSContext* context, JSValue* exception)
    {
        NSString* content = [exception toString];
        LogError(content.UTF8String);
    };
    return const_cast<JSContextRef>(sContext.JSGlobalContextRef);
}

JSValueRef DefineProperty(JSContextRef contextRef, JSValueRef target, void* handle, const char* name, JSObjectCallAsFunctionCallback getCallback, JSObjectCallAsFunctionCallback setCallback)
{
    JSContext* context = [JSContext contextWithJSGlobalContextRef:JSContextGetGlobalContext(contextRef)];
    JSValue* value = [JSValue valueWithJSValueRef:target inContext:context];

    JSValue* descriptor = [JSValue valueWithNewObjectInContext:context];
    if (getCallback)
    {
        JSObjectRef function = JSObjectMakeFunctionWithCallback(contextRef, 0, getCallback);
        JSValue* getter = descriptor[JSPropertyDescriptorGetKey] = [JSValue valueWithJSValueRef: function inContext:context];
        getter[[NSString stringWithUTF8String:PROPERTY_KEY]] = [NSString stringWithUTF8String:name];
        if (handle)
        {
            getter[[NSString stringWithUTF8String:OBJECT_KEY]] = [NSNumber numberWithDouble:(double)(unsigned long long)handle];
        }
    }
    if (setCallback)
    {
        JSObjectRef function = JSObjectMakeFunctionWithCallback(contextRef, 0, setCallback);
        JSValue* setter = descriptor[JSPropertyDescriptorSetKey] = [JSValue valueWithJSValueRef: function inContext:context];
        setter[[NSString stringWithUTF8String:PROPERTY_KEY]] = [NSString stringWithUTF8String:name];
        if (handle)
        {
            setter[[NSString stringWithUTF8String:OBJECT_KEY]] = [NSNumber numberWithDouble:(double)(unsigned long long)handle];
        }
    }
    [value defineProperty:[NSString stringWithUTF8String:name] descriptor:descriptor];
    return descriptor.JSValueRef;
//    JSObjectRef object = ValueToObject(contextRef, target);
//    JSStringRef jsName = JSStringCreateWithUTF8CString(name);
//    JSValueRef result = JSObjectGetProperty(contextRef, object, jsName, nullptr);
//    JSStringRelease(jsName);
//    return result;
}
