//
//  parameter.exp.cpp
//  typescript
//
//  Created by 朱嘉灵 on 2018/12/28.
//  Copyright © 2018 朱嘉灵. All rights reserved.
//

#include "core/JSTypes.h"
#include "core/function/Parameters.h"
#include "core/function/Parameters.exp.h"
#include "../environment.ios.h"
#include "../../utils.h"
#include "../object/object.ios.h"
#include "header.h"

int General_Typescript_Parameter_GetType(void* environment, void* pointer, int index)
{
    EnvironmentIOS* runtime = reinterpret_cast<EnvironmentIOS*>(environment);
    if (!runtime) return TYPE_NULL;
    
    Parameters* parameters = reinterpret_cast<Parameters*>(pointer);
    JSValueRef value = parameters->Get(index);
    return GetValueType(runtime->GetContext(), value);
}

char* General_Typescript_Parameter_GetTypeName(void* environment, void* pointer, int index)
{
    EnvironmentIOS* runtime = reinterpret_cast<EnvironmentIOS*>(environment);
    if (!runtime) return ReturnStringToCSharp("");
    JSContextRef context = runtime->GetContext();
    
    Parameters* parameters = reinterpret_cast<Parameters*>(pointer);
    JSValueRef value = parameters->Get(index);
    if(!IsValueValid(context, value)) return ReturnStringToCSharp("");
    
    JSValueRef isType = GetValueProperty(context, value, UNITY_INSTANCE_IS_TYPE);
    if (IsValueValid(context, isType) && JSValueIsString(context, isType))
    {
        std::string type = JSValue_To_String(context, isType);
        if (Environment::IsCustomSuperClassName(type))
        {
            return ReturnStringToCSharp(GetCustomType(context, ValueToObject(context, value)));
        }
        return ReturnStringToCSharp(type.c_str());
    }
    return ReturnStringToCSharp(JSValue_To_String(context, GetValueProperty(context, value, UNITY_INSTANCE_TYPE)));
}

void* General_Typescript_Parameter_GetHandle(void* environment, void* pointer, int index)
{
    EnvironmentIOS* runtime = reinterpret_cast<EnvironmentIOS*>(environment);
    if (!runtime) return nullptr;
    JSContextRef context = runtime->GetContext();
    
    Parameters* parameters = reinterpret_cast<Parameters*>(pointer);
    JSValueRef value = parameters->Get(index);
    if(!IsValueValid(context, value)) return nullptr;
    
    return (void*)JSValue_To_Uint64(context, GetValueProperty(context, value, UNITY_INSTANCE_HANDLE));
}

void* General_Typescript_Parameter_GetField(void* environment, void* pointer, int index)
{
    EnvironmentIOS* runtime = reinterpret_cast<EnvironmentIOS*>(environment);
    if (!runtime) return nullptr;
    JSContextRef context = runtime->GetContext();
    
    Parameters* parameters = reinterpret_cast<Parameters*>(pointer);
    JSValueRef value = parameters->Get(index);
    if(!IsValueValid(context, value)) return nullptr;
    
    return (void*)JSValue_To_Uint64(context, GetValueProperty(context, value, UNITY_INSTANCE_FIELD));
}

bool General_Typescript_Parameter_ToBoolean(void* environment, void* pointer, int index)
{
    EnvironmentIOS* runtime = reinterpret_cast<EnvironmentIOS*>(environment);
    if (!runtime) return false;
    JSContextRef context = runtime->GetContext();
    
    Parameters* parameters = reinterpret_cast<Parameters*>(pointer);
    JSValueRef value = parameters->Get(index);
    if(!IsValueValid(context, value)) return false;
    
    return JSValueToBoolean(context, value);
}

double General_Typescript_Parameter_ToNumber(void* environment, void* pointer, int index)
{
    EnvironmentIOS* runtime = reinterpret_cast<EnvironmentIOS*>(environment);
    if (!runtime) return 0;
    JSContextRef context = runtime->GetContext();
    
    Parameters* parameters = reinterpret_cast<Parameters*>(pointer);
    JSValueRef value = parameters->Get(index);
    if(!IsValueValid(context, value)) return 0;
    
    return JSValue_To_Number(context, value);
}

char* General_Typescript_Parameter_ToString(void* environment, void* pointer, int index)
{
    EnvironmentIOS* runtime = reinterpret_cast<EnvironmentIOS*>(environment);
    if (!runtime) return ReturnStringToCSharp("");
    JSContextRef context = runtime->GetContext();
    
    Parameters* parameters = reinterpret_cast<Parameters*>(pointer);
    JSValueRef value = parameters->Get(index);
    if(!IsValueValid(context, value)) return ReturnStringToCSharp("");
    
    return ReturnStringToCSharp(context, value);
}

int General_Typescript_Parameter_GetArrayLength(void* environment, void* pointer, int index)
{
    
    EnvironmentIOS* runtime = reinterpret_cast<EnvironmentIOS*>(environment);
    if (!runtime) return -1;
    JSContextRef context = runtime->GetContext();
    
    Parameters* parameters = reinterpret_cast<Parameters*>(pointer);
    JSValueRef value = parameters->Get(index);
    return ArrayGetLength(context, value);
}

char* General_Typescript_Parameter_GetArrayString(void* environment, void* pointer, int index, int elementIndex)
{
    EnvironmentIOS* runtime = reinterpret_cast<EnvironmentIOS*>(environment);
    if (!runtime) return ReturnStringToCSharp("");
    JSContextRef context = runtime->GetContext();
    
    Parameters* parameters = reinterpret_cast<Parameters*>(pointer);
    JSValueRef value = parameters->Get(index);
    JSValueRef property = GetValueProperty(context, value, elementIndex);
    return ReturnStringToCSharp(context, property);
}

void* General_Typescript_Parameter_ToArray(void* environment, void* pointer, int index, int type, int subType)
{
    EnvironmentIOS* runtime = reinterpret_cast<EnvironmentIOS*>(environment);
    if (!runtime) return ReturnStringToCSharp("");
    JSContextRef context = runtime->GetContext();
    
    Parameters* parameters = reinterpret_cast<Parameters*>(pointer);
    JSValueRef value = parameters->Get(index);
    if (JSValueIsArray(context, value))
    {
        int length = ArrayGetLength(context, value);
        if (TYPE_BOOLEAN == type)
        {
            char* buffer = new char[sizeof(int) + length];
            memcpy(buffer, &length, sizeof(int));
            char* p = buffer + sizeof(int);
            for (int i = 0; i < length; ++i, ++p)
            {
                JSValueRef property = GetValueProperty(context, value, i);
                *p = JSValueToBoolean(context, property);
            }
            return buffer;
        }
        else if (TYPE_NUMBER == type)
        {
            switch (subType)
            {
                case TYPE_NUMBER_BYTE:
                {
                    char* buffer = new char[sizeof(int) + sizeof(unsigned char) * length];
                    memcpy(buffer, &length, sizeof(int));
                    char* p = buffer + sizeof(int);
                    for (int i = 0; i < length; ++i, p += sizeof(unsigned char))
                    {
                        JSValueRef property = GetValueProperty(context, value, i);
                        *p = (unsigned char)JSValue_To_Number(context, property);
                    }
                    return buffer;
                }
            }
        }
    }
    return nullptr;
}
