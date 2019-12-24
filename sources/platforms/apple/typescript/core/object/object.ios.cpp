//
//  object.c
//  typescript
//
//  Created by 朱嘉灵 on 2018/11/30.
//  Copyright © 2018年 朱嘉灵. All rights reserved.
//

#include "object.ios.h"
#include "utils.h"
#include "defines.h"
#include "core/function/Constructor.h"

//static std::map<NSValue*, NSValue*>* sInstanceHandles;

JSObjectRef sPersistents;

void object_initialize(JSContextRef context)
{
    sPersistents = CreateGlobalObject(context, "persistents");
}

JSObjectRef CreateObject(JSContextRef context)
{
    JSObjectRef object = JSObjectMake(context, nullptr, nullptr);
    return object;
}

JSObjectRef CreateObject(JSContextRef context, const char* type, void* handle)
{
    JSObjectRef value = InstantiateObject(context, type);
    if (!value)
    {
        value = CreateObject(context);
    }
    SetValuePropertyWithString(context, value, UNITY_INSTANCE_TYPE, type);
    SetValueProperty(context, value, UNITY_INSTANCE_HANDLE, JSValueMakeNumber(context, (double)(unsigned long long)handle));
    return value;
}

JSObjectRef CreateObject(JSContextRef context, const char* type, void* field, int size)
{
    JSObjectRef value = CreateObject(context);
    SetObjectPropertyWithString(context, value, UNITY_INSTANCE_TYPE, type);
    SetObjectProperty(context, value, UNITY_INSTANCE_FIELD, JSValueMakeNumber(context, (double)(unsigned long long)field));
    SetObjectProperty(context, value, UNITY_INSTANCE_FIELD_SIZE, JSValueMakeNumber(context, (double)size));
    return value;
}

JSValueRef CreateValue(JSContextRef context)
{
    JSStringRef content = JSStringCreateWithUTF8CString("{}");
    JSValueRef value = JSValueMakeFromJSONString(context, content);
    JSStringRelease(content);
    return value;
}

JSValueRef CreateValue(JSContextRef context, const char* type, void* handle)
{
    JSValueRef value = InstantiateObject(context, type);
    if (!value)
    {
        value = CreateValue(context);
    }
    SetValuePropertyWithString(context, value, UNITY_INSTANCE_TYPE, type);
    SetValueProperty(context, value, UNITY_INSTANCE_HANDLE, JSValueMakeNumber(context, (double)(unsigned long long)handle));
    return value;
}

JSValueRef CreateValue(JSContextRef context, const char* type, void* field, int size)
{
    JSValueRef value = CreateValue(context);
    SetValuePropertyWithString(context, value, UNITY_INSTANCE_TYPE, type);
    SetValueProperty(context, value, UNITY_INSTANCE_FIELD, JSValueMakeNumber(context, (double)(unsigned long long)field));
    SetValueProperty(context, value, UNITY_INSTANCE_FIELD_SIZE, JSValueMakeNumber(context, (double)size));
    return value;
}

void* GetObjectHandle(JSContextRef context, JSValueRef value)
{
    JSValueRef property = GetValueProperty(context, value, UNITY_INSTANCE_HANDLE);
    if (IsValueValid(context, property))
    {
        return (void*)(unsigned long long)JSValue_To_Number(context, property);
    }
    return nullptr;
}

void* GetObjectField(JSContextRef context, JSValueRef value)
{
    JSValueRef property = GetValueProperty(context, value, UNITY_INSTANCE_FIELD);
    if (IsValueValid(context, property))
    {
        return (void*)(unsigned long long)JSValue_To_Number(context, property);
    }
    return nullptr;
}

JSObjectRef CreateGlobalObject(JSContextRef context, const char* name)
{
    // instable creation
    JSObjectRef object = CreateObject(context);
    JSValueRef global = JSContextGetGlobalObject(context);
    SetValueProperty(context, global, name, object);
    return object;
}

//void InstantiateObject(JSContextRef context, JSObjectRef target, JSObjectRef real, JSObjectRef constructor)
//{
////    JSValueRef exception = 0;
////    {
////        JSPropertyNameArrayRef propertyNames = JSObjectCopyPropertyNames(context, real);
////        size_t count = JSPropertyNameArrayGetCount(propertyNames);
////        for (size_t i = 0; i < count; ++i)
////        {
////            JSStringRef nameString = JSPropertyNameArrayGetNameAtIndex(propertyNames, i);
////            JSValueRef property = JSObjectGetProperty(context, real, nameString, &exception);
////            if (exception)
////            {
////                LogError(JSValue_To_NSString(context, exception).UTF8String);
////            }
////            JSObjectSetProperty(context, target, nameString, property, 0, &exception);
////            if (exception)
////            {
////                LogError(JSValue_To_NSString(context, exception).UTF8String);
////            }
////            JSStringRelease(nameString);
////        }
////        JSPropertyNameArrayRelease(propertyNames);
////    }
////
////    {
////        JSObjectRef prototype = ValueToObject(context, GetObjectProperty(context, constructor, "prototype"));
////        JSObjectSetPrototype(context, target, prototype);
////    }
//}

void MakePersistent(JSContextRef context, JSValueRef value)
{
    if (!IsObjectValid(context, sPersistents)) return;
    
    JSValueRef property = GetValueProperty(context, value, UNITY_INSTANCE_HANDLE);
    if (!IsValueValid(context, property)) return;
    SetObjectProperty(context, sPersistents, JSValue_To_String(context, property).c_str(), value);
}

JSValueRef GetPersistent(JSContextRef context, void* handle)
{
    if (!IsObjectValid(context, sPersistents)) return nullptr;
    
    char buffer[32];
    sprintf(buffer, "%llu", (unsigned long long)handle);
    return GetObjectProperty(context, sPersistents, buffer);
}

void ReleaseHandle(JSContextRef context, void* handle)
{
//    [sInstanceHandles removeObjectForKey:[NSNumber valueWithPointer:handle]];
}

void ReleaseMemory(JSContextRef context, void* handles[], int size)
{
//    for (int i = size - 1; i >= 0; -- i)
//    {
//        ReleaseHandle(context, handles[i]);
//    }
}
