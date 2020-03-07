//
//  parameter.exp.cpp
//  typescript
//
//  Created by 朱嘉灵 on 2018/12/28.
//  Copyright © 2018 朱嘉灵. All rights reserved.
//

#include "header.h"
#include "defines.h"
#include "core/JSTypes.h"
#include "core/function/Parameters.h"
#include "core/function/Parameters.exp.h"
#include "core/Environment.h"
#include "../../utils.apple.h"
#include "core/object/Object.h"
#include "utils.h"

int General_Typescript_Parameter_GetType(Environment* runtime, void* pointer, int index)
{
    if (!runtime) return TYPE_NULL;
    
    Parameters* parameters = reinterpret_cast<Parameters*>(pointer);
    JSValueRef value = parameters->Get(index);
    return GetValueType(runtime->GetContext(), value);
}

char* General_Typescript_Parameter_GetTypeName(Environment* runtime, void* pointer, int index)
{
    if (!runtime) return ReturnStringToCSharp("");
    JSContextRef context = runtime->GetContext();
    
    Parameters* parameters = reinterpret_cast<Parameters*>(pointer);
    JSValueRef value = parameters->Get(index);
    if(!JsObject::IsValid(context, value)) return ReturnStringToCSharp("");
    
    const std::string type = GetObjectType(context, JSValueToObject(context, value, nullptr));
    DEBUG_LOG("Get parameter type for %d : %s\n", index, type.c_str());
    return ReturnStringToCSharp(type);
}

void* General_Typescript_Parameter_GetHandle(Environment* runtime, void* pointer, int index)
{
    if (!runtime) return nullptr;
    JSContextRef context = runtime->GetContext();
    
    Parameters* parameters = reinterpret_cast<Parameters*>(pointer);
    JSValueRef jsValue = parameters->Get(index);
    if (!JSValueIsObject(context, jsValue)) return nullptr;
    
    JSObjectRef jsObject = JSValueToObject(context, jsValue, nullptr);
    if(!JsObject::IsValid(context, jsValue)) return nullptr;
    
    return JsObject::Convert(context, jsObject);
}

void* General_Typescript_Parameter_GetField(Environment* runtime, void* pointer, int index)
{
    if (!runtime) return nullptr;
    JSContextRef context = runtime->GetContext();
    
    Parameters* parameters = reinterpret_cast<Parameters*>(pointer);
    JSValueRef jsValue = parameters->Get(index);
    if (!JSValueIsObject(context, jsValue)) return nullptr;
    
    JSObjectRef jsObject = JSValueToObject(context, jsValue, nullptr);
    if(!JsObject::IsValid(context, jsValue)) return nullptr;
    
    JsObject* instance = JsObject::Convert(context, jsObject);
    return instance ? instance->GetInstanceField() : nullptr;
}

bool General_Typescript_Parameter_ToBoolean(Environment* runtime, void* pointer, int index)
{
    if (!runtime) return false;
    JSContextRef context = runtime->GetContext();
    
    Parameters* parameters = reinterpret_cast<Parameters*>(pointer);
    JSValueRef value = parameters->Get(index);
    if(!JsObject::IsValid(context, value)) return false;
    
    return JSValueToBoolean(context, value);
}

double General_Typescript_Parameter_ToNumber(Environment* runtime, void* pointer, int index)
{
    if (!runtime) return 0;
    JSContextRef context = runtime->GetContext();
    
    Parameters* parameters = reinterpret_cast<Parameters*>(pointer);
    JSValueRef value = parameters->Get(index);
    if(!JsObject::IsValid(context, value)) return 0;
    
    return JsObject::ToDouble(context, value);
}

char* General_Typescript_Parameter_ToString(Environment* runtime, void* pointer, int index)
{
    if (!runtime) return ReturnStringToCSharp("");
    JSContextRef context = runtime->GetContext();
    
    Parameters* parameters = reinterpret_cast<Parameters*>(pointer);
    JSValueRef value = parameters->Get(index);
    if(!JsObject::IsValid(context, value)) return ReturnStringToCSharp("");
    
    return ReturnStringToCSharp(context, value);
}

int General_Typescript_Parameter_GetArrayLength(Environment* runtime, void* pointer, int index)
{
    if (!runtime) return -1;
    JSContextRef context = runtime->GetContext();
    
    Parameters* parameters = reinterpret_cast<Parameters*>(pointer);
    JSValueRef value = parameters->Get(index);
    return ArrayGetLength(context, value);
}

char* General_Typescript_Parameter_GetArrayString(Environment* runtime, void* pointer, int index, int elementIndex)
{
    if (!runtime) return ReturnStringToCSharp("");
    JSContextRef context = runtime->GetContext();
    
    Parameters* parameters = reinterpret_cast<Parameters*>(pointer);
    JSValueRef value = parameters->Get(index);
    JSValueRef property = JsObject::Get(context, JSValueToObject(context, value, nullptr), elementIndex);
    return ReturnStringToCSharp(context, property);
}

void* General_Typescript_Parameter_ToArray(Environment* runtime, void* pointer, int index, int type, int subType)
{
    if (!runtime) return ReturnStringToCSharp("");
    JSContextRef context = runtime->GetContext();
    
    Parameters* parameters = reinterpret_cast<Parameters*>(pointer);
    JSValueRef value = parameters->Get(index);
    if (JSValueIsArray(context, value))
    {
        JSObjectRef jsObject = JSValueToObject(context, value, nullptr);
        int length = ArrayGetLength(context, value);
        if (TYPE_BOOLEAN == type)
        {
            char* buffer = new char[sizeof(int) + length];
            memcpy(buffer, &length, sizeof(int));
            char* p = buffer + sizeof(int);
            for (int i = 0; i < length; ++i, ++p)
            {
                JSValueRef property = JsObject::Get(context, JSValueToObject(context, jsObject, nullptr), i);
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
                        JSValueRef property = JsObject::Get(context, JSValueToObject(context, jsObject, nullptr), i);
                        *p = (unsigned char)JsObject::ToDouble(context, property);
                    }
                    return buffer;
                }
                default:
                    LogWarning("General_Typescript_Parameter_ToArray undefined sub number type : %d", subType);
                    break;
            }
        }
    }
    return nullptr;
}

void* General_Typescript_Parameter_ToFunction(Environment* runtime, void* pointer, int index)
{
    if (!runtime) return nullptr;
    JSContextRef context = runtime->GetContext();
    if (!context) return nullptr;
    
    Parameters* parameters = reinterpret_cast<Parameters*>(pointer);
    JSValueRef value = parameters->Get(index);
    JSObjectRef object = JSValueToObject(context, value, nullptr);
    return JSObjectIsFunction(context, object) ? JsObject::Create(context, nullptr, object) : nullptr;
}
