////
////  object.m
////  typescript
////
////  Created by 朱嘉灵 on 2018/10/20.
////  Copyright © 2018年 朱嘉灵. All rights reserved.
////

#include "header.h"
#include "core/Object.exp.h"
#include "../../utils.h"
#include "../environment.ios.h"
#include "core/function/Function.h"
#include "extra/log/Log.h"
#include "core/function/Argument.h"
#include "../object/object.ios.h"

static JSValueRef call_function(JSContextRef context, void* handle, const char* name, unsigned char* arguments)
{
    JSValueRef value = GetPersistent(context, handle);
    if (!IsValueValid(context, value)) return nullptr;
    
    JSValueRef property = GetValueProperty(context, value, name);
    JSValueRef exception = nullptr;
    JSObjectRef instance = ValueToObject(context, property);
    if (exception)
    {
        LogError(JSValue_To_String(context, exception));
        return nullptr;
    }
    if (JSObjectIsFunction(context, instance))
    {
        std::vector<JSValueRef> parameters;
        if (arguments)
        {
            int count = *(int*)arguments;
            unsigned char* start = arguments + 4;
            for (int i = 0; i < count; ++i)
            {
                parameters.push_back(Argument::Deserialize(context, start));
            }
        }
        JSValueRef result = JSObjectCallAsFunction(context, instance, ValueToObject(context, value), (int)parameters.size(), parameters.data(), &exception);
        if (exception)
        {
            LogError(JSValue_To_String(context, exception));
        }
        return result;
    }
    return nullptr;
}

bool General_Typescript_Object_HasProperty(void* environment, void* handle, const char* name)
{
    JSContextRef context = GetContext(environment);
    if (!context) return false;
    JSValueRef instance = GetPersistent(context, handle);
    if (!IsValueValid(context, instance)) return false;
    JSValueRef property = GetValueProperty(context, instance, name);
    return IsValueValid(context, property);
}

bool General_Typescript_Object_HasFunction(void* environment, void* handle, const char* name)
{
    JSContextRef context = GetContext(environment);
    if (!context) return false;
    JSValueRef instance = GetPersistent(context, handle);
    if (!IsValueValid(context, instance)) return false;
    JSValueRef property = GetValueProperty(context, instance, name);
    if(!IsValueValid(context, property)) return false;
    return JSObjectIsFunction(context, ValueToObject(context, property));
}

int General_Typescript_Object_CallFunction(void* environment, void* handle, const char* name, unsigned char* arguments)
{
    JSContextRef context = GetContext(environment);
    if (!context) return -1;
    JSValueRef result = call_function(context, handle, name, arguments);
    return result ? RegisterResultValue(context, result) : -1;
}

void General_Typescript_Object_CallFunctionWithoutResult(void* environment, void* handle, const char* name, unsigned char* arguments)
{
    JSContextRef context = GetContext(environment);
    if (!context) return;
    call_function(context, handle, name, arguments);
}
