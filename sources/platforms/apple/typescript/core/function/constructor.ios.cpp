////
////  constructor.ios.cpp
////  typescript
////
////  Created by 朱嘉灵 on 2018/12/21.
////  Copyright © 2018 朱嘉灵. All rights reserved.
////
//
#include "core/function/Constructor.h"
#include "../object/object.ios.h"
#include "extra/log/Log.h"
#include "../../utils.h"
#include "header.h"

std::map<std::string, JSObjectRef> sConstructors;

void CheckConstructors(JSContextRef context, const JSValueRef& handle)
{
    JSValueRef exception = 0;
    JSObjectRef target = JSValueToObject(context, handle, &exception);
    JSPropertyNameArrayRef propertyNames = JSObjectCopyPropertyNames(context, target);
    size_t count = JSPropertyNameArrayGetCount(propertyNames);
    for (size_t i = 0; i < count; ++i)
    {
        JSStringRef nameString = JSPropertyNameArrayGetNameAtIndex(propertyNames, i);
        JSValueRef property = JSObjectGetProperty(context, target, nameString, &exception);
        JSStringRelease(nameString);
        if (exception)
        {
            LogError(JSValue_To_String(context, exception));
            continue;
        }
        if (!property) continue;
        
        JSObjectRef propertyObject = JSValueToObject(context, property, &exception);
        if (JSObjectIsConstructor(context, propertyObject))
        {
            std::string name = GetObjectPropertyWithString(context, propertyObject, "name");
            char customName[128];
            sprintf(customName, "%s.%s", CUSTOM_BEHAVIOUR_PREFIX, name.c_str());
            sConstructors[customName] = propertyObject;
        }
        else if (IsValueValid(context, property))
        {
            CheckConstructors(context, property);
        }
    }
}

JSObjectRef InstantiateObject(JSContextRef context, const std::string& name)
{
    JSObjectRef instance = nullptr;
    JSValueRef exception = nullptr;
    auto finder = sConstructors.find(name);
    if (sConstructors.end() == finder) return nullptr;
    
    JSObjectRef constructor = finder->second;
    if (constructor)
    {
        instance = JSObjectCallAsConstructor(context, constructor, 0, 0, &exception);
        if (exception)
        {
            LogError(JSValue_To_String(context, exception));
        }

        JSObjectRef prototype = JSValueToObject(context, GetObjectProperty(context, constructor, "prototype"), &exception);
        if (exception)
        {
            LogError(JSValue_To_String(context, exception));
        }
        JSObjectSetPrototype(context, JSValueToObject(context, instance, 0), prototype);
    }
    return instance;
}
