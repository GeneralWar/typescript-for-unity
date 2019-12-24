//
//  utils.c
//  typescript
//
//  Created by 朱嘉灵 on 2018/11/22.
//  Copyright © 2018年 朱嘉灵. All rights reserved.
//

#include "utils.h"
#include "core/Base.h"
#include "extra/log/Log.h"
#include "core/environment.ios.h"
#include "core/JSTypes.h"
#include "core/object/object.ios.h"
#include "ocUtils.h"

#define CUSTOM_BEHAVIOUR_PREFIX "General.Typescript.Custom.Behaviour"

JSContextRef GetContext(Base* base)
{
    if (base)
    {
        EnvironmentIOS* runtime = reinterpret_cast<EnvironmentIOS*>(base->GetEnvironment());
        if (runtime)
        {
            return runtime->GetContext();
        }
    }
    return nullptr;
}

JSContextRef GetContext(void* environment)
{
    EnvironmentIOS* runtime = reinterpret_cast<EnvironmentIOS*>(environment);
    if (!runtime) return nullptr;
    return runtime->GetContext();
}

JSValueRef GetValue(Base* base)
{
    return base ? base->GetReference() : nullptr;
}

JSValueRef GetParentValue(Base* base)
{
    if (base)
    {
        Base* parent = base->GetParent();
        if (parent)
        {
            return parent->GetReference();
        }
        else
        {
            EnvironmentIOS* runtime = reinterpret_cast<EnvironmentIOS*>(base->GetEnvironment());
            if (runtime)
            {
                return runtime->GetGlobalObject();
            }
        }
    }
    return nullptr;
}

JSObjectRef ValueToObject(JSContextRef context, JSValueRef value)
{
    JSValueRef exception = nullptr;
    JSObjectRef object = JSValueToObject(context, value, &exception);
    if (exception)
    {
        std::string message = JSValue_To_String(context, exception);
        LogError("[Error] Failed to convert JSValue to JSObject. %s", message.c_str());
        return nullptr;
    }
    return object;
}

std::string JSValue_To_String(JSContextRef context, JSValueRef value)
{
    if (!value || !IsValueValid(context, value)) return "";
    
    JSValueRef exception = 0;
    JSStringRef string = JSValueToStringCopy(context, value, &exception);
    if (exception)
    {
        JSStringRelease(string);
        LogError(JSValue_To_String(context, exception).c_str());
        return 0;
    }
    if (string)
    {
        std::string value = JSString_To_String(string);
        JSStringRelease(string);
        return value;
    }
    return 0;
}

std::string JSString_To_String(JSStringRef value)
{
    if (!value) return "";
    
    char* buffer = 0;
    unsigned long length = JSStringGetMaximumUTF8CStringSize(value) + 1;
    buffer = (char*)malloc(length);
    
    JSStringGetUTF8CString(value, buffer, length);
    std::string result = buffer;
    free(buffer);
    return result;
}

unsigned long long JSValue_To_Uint64(JSContextRef context, JSValueRef value)
{
    return (unsigned long long) JSValue_To_Number(context, value);
}

double JSValue_To_Number(JSContextRef context, JSValueRef value)
{
    if (!value || !IsValueValid(context, value)) return 0;
    
    JSValueRef exception = 0;
    double result = JSValueToNumber(context, value, &exception);
    if (exception)
    {
        LogError(JSValue_To_String(context, exception).c_str());
    }
    return result;
}

bool JSValue_To_Boolean(JSContextRef context, JSValueRef value)
{
    return value ? JSValueToBoolean(context, value) : false;
}

char* ReturnStringToCSharp(const char* content)
{
    int length = (int)strlen(content);
    char* buffer = (char*)malloc(length + 1);
    strcpy(buffer, content);
    return buffer;
}

char* ReturnStringToCSharp(const std::string& content)
{
    return ReturnStringToCSharp(content.c_str());
}

char* ReturnStringToCSharp(JSStringRef content)
{
    return ReturnStringToCSharp(JSString_To_String(content));
}

char* ReturnStringToCSharp(JSContextRef context, JSValueRef content)
{
    return ReturnStringToCSharp(JSValue_To_String(context, content));
}

void SetValueProperty(JSContextRef context, JSValueRef target, const char* name, JSValueRef property)
{
    JSObjectRef object = ValueToObject(context, target);
    SetObjectProperty(context, object, name, property);
}

void SetObjectProperty(JSContextRef context, JSObjectRef target, const char* name, JSValueRef property)
{
    if (!context || !target) return;
    
    JSValueRef exception = 0;
    JSStringRef nameString = JSStringCreateWithUTF8CString(name);
    JSObjectSetProperty(context, target, nameString, property, 0, &exception);
    JSStringRelease(nameString);
    if (exception)
    {
        LogError(JSValue_To_String(context, exception).c_str());
    }
}

void SetValuePropertyWithString(JSContextRef context, JSValueRef target, const char* name, const char* property)
{
    JSStringRef propertyString = JSStringCreateWithUTF8CString(property);
    JSValueRef propertyValue = JSValueMakeString(context, propertyString);
    SetValueProperty(context, target, name, propertyValue);
    JSStringRelease(propertyString);
}

void SetObjectPropertyWithString(JSContextRef context, JSObjectRef target, const char* name, const char* property)
{
    JSStringRef propertyString = JSStringCreateWithUTF8CString(property);
    JSValueRef propertyValue = JSValueMakeString(context, propertyString);
    SetObjectProperty(context, target, name, propertyValue);
    JSStringRelease(propertyString);
}

void SetValuePropertyWithInt(JSContextRef context, JSValueRef target, const char* name, int property)
{
    char buffer[16];
    sprintf(buffer, "%d", property);
    SetValueProperty(context, target, name, JSValueMakeNumber(context, (double)property));
    //    SetValuePropertyWithString(context, target, name, buffer);
}

void SetObjectPropertyWithInt(JSContextRef context, JSObjectRef target, const char* name, int property)
{
    char buffer[16];
    sprintf(buffer, "%d", property);
    SetObjectProperty(context, target, name, JSValueMakeNumber(context, (double)property));
    //    SetObjectPropertyWithString(context, target, name, buffer);
}

void SetValuePropertyWithLong(JSContextRef context, JSValueRef target, const char* name, long int property)
{
    char buffer[16];
    sprintf(buffer, "%ld", property);
    SetValueProperty(context, target, name, JSValueMakeNumber(context, (double)property));
}

void SetObjectPropertyWithLong(JSContextRef context, JSObjectRef target, const char* name, long int property)
{
    char buffer[16];
    sprintf(buffer, "%ld", property);
    SetObjectProperty(context, target, name, JSValueMakeNumber(context, (double)property));
}

void SetValuePropertyWithBoolean(JSContextRef context, JSValueRef target, const char* name, bool property)
{
    SetValueProperty(context, target, name, JSValueMakeBoolean(context, property));
}

void SetObjectPropertyWithBoolean(JSContextRef context, JSObjectRef target, const char* name, bool property)
{
    SetObjectProperty(context, target, name, JSValueMakeBoolean(context, property));
}

JSValueRef GetValueProperty(JSContextRef context, JSValueRef target, const char* name)
{
    return GetObjectProperty(context, ValueToObject(context, target), name);
}

JSValueRef GetValueProperty(JSContextRef context, JSValueRef target, const int& index)
{
    return GetObjectProperty(context, ValueToObject(context, target), index);
}

JSValueRef GetObjectProperty(JSContextRef context, JSObjectRef target, const char* name)
{
    if (!context || !target) return nullptr;
    
    JSStringRef propertyName = JSStringCreateWithUTF8CString(name);
    JSValueRef property = JSObjectGetProperty(context, target, propertyName, 0);
    JSStringRelease(propertyName);
    return property;
}

JSValueRef GetObjectProperty(JSContextRef context, JSObjectRef target, const int& index)
{
    char buffer[16] {};
    sprintf(buffer, "%d", index);
    return GetObjectProperty(context, target, buffer);
}

std::string GetValuePropertyWithString(JSContextRef context, JSValueRef target, const char* name)
{
    return GetObjectPropertyWithString(context, ValueToObject(context, target), name);
}

std::string GetObjectPropertyWithString(JSContextRef context, JSObjectRef target, const char* name)
{
    JSValueRef property = GetObjectProperty(context, target, name);
    return property ? JSValue_To_String(context, property) : "";
}

bool IsValueValid(JSContextRef context, JSValueRef handle)
{
    return handle && !JSValueIsNull(context, handle) && !JSValueIsUndefined(context, handle);
}

bool IsObjectValid(JSContextRef context, JSValueRef handle)
{
    return IsValueValid(context, (JSValueRef)handle);
}

std::string GetCustomType(JSContextRef context, JSValueRef object)
{
    return GetCustomType(context, ValueToObject(context, object));
}

std::string GetCustomType(JSContextRef context, JSObjectRef object)
{
    if (JSObjectIsConstructor(context, object))
    {
        JSValueRef name = GetObjectProperty(context, object, "name");
        if (IsValueValid(context, name))
        {
            char buffer[128];
            sprintf(buffer, "%s.%s", CUSTOM_BEHAVIOUR_PREFIX, JSValue_To_String(context, name).c_str());
            return buffer;
        }
    }
    return "";
}

int GetValueType(JSContextRef context, JSValueRef value)
{
    if (!IsValueValid(context, value)) return TYPE_NULL;
    
    JSType type = JSValueGetType(context, value);
    switch(type)
    {
        case kJSTypeUndefined:
            return TYPE_UNDEFINED;
        case kJSTypeNull:
            return TYPE_NULL;
        case kJSTypeBoolean:
            return TYPE_BOOLEAN;
        case kJSTypeNumber:
            return TYPE_NUMBER;
        case kJSTypeString:
            return TYPE_STRING;
        case kJSTypeObject:
            if (JSValueIsArray(context, value))
            {
                return TYPE_ARRAY;
            }
            JSObjectRef object = ValueToObject(context, value);
            if (JSObjectIsFunction(context, object))
            {
                return JSObjectIsConstructor(context, object) ? TYPE_CONSTRUCTOR : TYPE_FUNCTION;
            }
            return TYPE_OBJECT;
    }
    return TYPE_UNKNOWN;
}

int ArrayGetLength(JSContextRef context, JSValueRef value)
{
    if (!JSValueIsArray(context, value)) return -1;
    JSObjectRef object = ValueToObject(context, value);
    JSValueRef length = GetObjectProperty(context, object, "length");
    return (int)JSValueToNumber(context, length, 0);
}

JSValueRef BindProperty(JSContextRef context, JSValueRef instance, const char* name, JSObjectCallAsFunctionCallback getter, JSObjectCallAsFunctionCallback setter, void* data)
{
    JSObjectRef object = ValueToObject(context, instance);
    return BindProperty(context, object, name, getter, setter, data);
}

JSValueRef BindProperty(JSContextRef context, JSObjectRef instance, const char* name, JSObjectCallAsFunctionCallback getter, JSObjectCallAsFunctionCallback setter, void* data)
{
//    JSObjectRef descriptor = CreateObject(context);
//    if (getter)
//    {
//        JSObjectRef function = JSObjectMakeFunctionWithCallback(context, 0, getter);
//        SetObjectProperty(context, descriptor, JSPropertyDescriptorGetKey.UTF8String, function);
//    }
//    if (setter)
//    {
//        JSObjectRef function = JSObjectMakeFunctionWithCallback(context, 0, setter);
//        SetObjectProperty(context, descriptor, JSPropertyDescriptorSetKey.UTF8String, function);
//    }
//    SetObjectProperty(context, instance, name, descriptor);
    JSValueRef property = GetObjectProperty(context, instance, name);
    if (IsValueValid(context, property)) return property;
    
    return DefineProperty(context, instance, data, name, getter, setter);
}
