//
//  return.exp.cpp
//  typescript
//
//  Created by 朱嘉灵 on 2018/12/29.
//  Copyright © 2018 朱嘉灵. All rights reserved.
//

#include "header.h"
#include "core/function/Return.exp.h"
#include "../environment.ios.h"
#include "../object/object.ios.h"
#include "../../utils.h"

extern JSValueRef onInstanceFunctionCall (JSContextRef context, JSObjectRef function, JSObjectRef thisObject, size_t argumentCount, const JSValueRef arguments[], JSValueRef* exception);
extern JSValueRef onInstancePropertyGetterCall (JSContextRef context, JSObjectRef function, JSObjectRef thisObject, size_t argumentCount, const JSValueRef arguments[], JSValueRef* exception);
extern JSValueRef onInstancePropertySetterCall (JSContextRef context, JSObjectRef function, JSObjectRef thisObject, size_t argumentCount, const JSValueRef arguments[], JSValueRef* exception);

static std::map<int, JSValueRef> sReturnValues;

static int create_return_value(const JSValueRef& value)
{
    int index = -1;
    if (sReturnValues.size())
    {
        for (auto it = sReturnValues.begin(); sReturnValues.end() != it; ++it)
        {
            if (it->first > index)
            {
                index = it->first;
            }
        }
    }
    sReturnValues[++index] = value;
    return index;
}

JSValueRef GetReturnValue(JSContextRef context, int index)
{
    auto result = sReturnValues.find(index);
    return sReturnValues.end() == result ? nullptr : sReturnValues[index];
}

void ReleaseReturnValue(int index)
{
    auto result = sReturnValues.find(index);
    if (sReturnValues.end() == result) return;
    sReturnValues.erase(result);
}

int General_Typescript_Return_CreateString(void* environment, const char* value)
{
    EnvironmentIOS* runtime = reinterpret_cast<EnvironmentIOS*>(environment);
    if (!runtime) return -1;
    
    JSStringRef content = JSStringCreateWithUTF8CString(value);
    int result = create_return_value(JSValueMakeString(runtime->GetContext(), content));
    JSStringRelease(content);
    return result;
}

int General_Typescript_Return_CreateNumber(void* environment, double value)
{
    EnvironmentIOS* runtime = reinterpret_cast<EnvironmentIOS*>(environment);
    if (!runtime) return -1;
    
    return create_return_value(JSValueMakeNumber(runtime->GetContext(), value));
}

int General_Typescript_Return_CreateBoolean(void* environment, bool value)
{
    EnvironmentIOS* runtime = reinterpret_cast<EnvironmentIOS*>(environment);
    if (!runtime) return -1;
    
    return create_return_value(JSValueMakeBoolean(runtime->GetContext(), value));
}

int General_Typescript_Return_CreateWithHandle(void* environment, const char* type, void* handle)
{
    EnvironmentIOS* runtime = reinterpret_cast<EnvironmentIOS*>(environment);
    if (!runtime) return -1;
    
    return create_return_value(CreateObject(runtime->GetContext(), type, handle));
}

int General_Typescript_Return_CreateWithField(void* environment, const char* type, void* handle, int size)
{
    EnvironmentIOS* runtime = reinterpret_cast<EnvironmentIOS*>(environment);
    if (!runtime) return -1;
    
    return create_return_value(CreateObject(runtime->GetContext(), type, handle, size));
}

void General_Typescript_Return_MakePersistent(void* environment, int index)
{
    JSContextRef context = GetContext(environment);
    if (!context) return;
    
    JSValueRef value = GetReturnValue(context, index);
    if (IsValueValid(context, value))
    {
        MakePersistent(context, value);
    }
}

void General_Typescript_Return_BindInstanceFunction(void* environment, int index, const char* name)
{
    EnvironmentIOS* runtime = reinterpret_cast<EnvironmentIOS*>(environment);
    if (!runtime) return;
    JSContextRef context = runtime->GetContext();
    JSValueRef instance = GetReturnValue(context, index);

    JSValueRef function = JSObjectMakeFunctionWithCallback(context, 0, onInstanceFunctionCall);
    SetValuePropertyWithString(context, function, PROPERTY_KEY, name);
//    SetValueProperty(context, function, "object", instance);
    SetValueProperty(context, instance, name, function);
}

void General_Typescript_Return_BindInstanceProperty(void* environment, int index, const char* name, bool hasGetter, bool hasSetter)
{
    EnvironmentIOS* runtime = reinterpret_cast<EnvironmentIOS*>(environment);
    if (!runtime) return;
    JSContextRef context = runtime->GetContext();
    JSValueRef instance = GetReturnValue(context, index);
    BindProperty(context, instance, name, hasGetter ? onInstancePropertyGetterCall : nullptr, hasSetter ? onInstancePropertySetterCall : nullptr, nullptr);
}
