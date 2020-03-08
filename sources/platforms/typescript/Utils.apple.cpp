//
//  utils.c
//  typescript
//
//  Created by 朱嘉灵 on 2018/11/22.
//  Copyright © 2018年 朱嘉灵. All rights reserved.
//

#include "Utils.h"
#include "core/Base.h"
#include "extra/log/Log.h"
#include "core/Environment.h"
#include "core/JSTypes.h"
#include "core/object/Object.h"

#define CUSTOM_BEHAVIOUR_PREFIX "General.Typescript.Custom.Behaviour"

char* ReturnStringToCSharp(const char* content)
{
    int length = (int)strlen(content);
    char* buffer = (char*)malloc(length + 1);
    strcpy(buffer, content);
    DEBUG_LOG("ReturnStringToCSharp : %s", buffer);
    return buffer;
}

char* ReturnStringToCSharp(const std::string& content)
{
    return ReturnStringToCSharp(content.c_str());
}

char* ReturnStringToCSharp(const JSStringRef content)
{
    return ReturnStringToCSharp(JsObject::ToString(nullptr, content));
}

char* ReturnStringToCSharp(const JSContextRef context, const JSValueRef content)
{
    return ReturnStringToCSharp(JsObject::ToString(context, content));
}

int GetValueType(const JSContextRef context, const JSValueRef value)
{
    if (!JsObject::IsValid(context, value)) return TYPE_NULL;
    
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
            JSObjectRef object = JSValueToObject(context, value, 0);
            if (JSObjectIsFunction(context, object))
            {
                return JSObjectIsConstructor(context, object) ? TYPE_CONSTRUCTOR : TYPE_FUNCTION;
            }
            return TYPE_OBJECT;
    }
    return TYPE_UNKNOWN;
}

int ArrayGetLength(const JSContextRef context, const JSValueRef value)
{
    if (!JSValueIsArray(context, value)) return -1;
    JSObjectRef object = JSValueToObject(context, value, 0);
    JSValueRef length = JsObject::GetValue(context, object, "length");
    return (int)JSValueToNumber(context, length, nullptr);
}

static std::string jstype_to_string(const JSType& type)
{
    switch(type)
    {
        case kJSTypeUndefined:
            return "undefined";
        case kJSTypeNull:
            return "null";
        case kJSTypeBoolean:
            return "boolean";
        case kJSTypeNumber:
            return "number";
        case kJSTypeString:
            return "string";
        case kJSTypeObject:
//            if (JSValueIsArray(context, value))
//            {
//                return "object";
//            }
//            JSObjectRef object = JSValueToObject(context, value, 0);
//            if (JSObjectIsFunction(context, object))
//            {
//                return "object";
//            }
            return "object";
        default:
            return "undefined";
    }
}

std::string GetCustomType(const JSContextRef context, const JSObjectRef object)
{
    if (JSObjectIsConstructor(context, object))
    {
        return JsObject::ToString(context, JsObject::GetValue(context, object, FULLNAME));
    }
    else if (JSValueIsObject(context, (JSValueRef)object))
    {
        return JsObject::ToString(context, JsObject::GetValue(context, object, UNITY_INSTANCE_TYPE));
    }
    return jstype_to_string(JSValueGetType(context, (JSValueRef)object));
}

std::string GetObjectType(const JSContextRef context, const JSObjectRef value)
{
    if (!value) return "";

    JSValueRef property = JsObject::GetValue(context, value, UNITY_INSTANCE_TYPE);
    if (JsObject::IsValid(context, value))
    {
        return GetCustomType(context, value);
    }
    else
    {
        return JsObject::ToString(context, property);
    }
}
