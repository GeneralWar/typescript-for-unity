//
//  Environment.cpp
//  typescript
//
//  Created by 朱嘉灵 on 2018/12/12.
//  Copyright © 2018 朱嘉灵. All rights reserved.
//

#include "utils.h"
#include "../utils.apple.h"
#include "core/Environment.h"
#include "core/class/Class.h"
#include "core/function/Function.h"
#include "core/namespace/Namespace.h"
#include "extra/log/Log.h"
#include "core/object/Object.h"
#include "types/Exception.h"

bool Environment::initialize()
{
    mContext = JSGlobalContextCreate(nullptr);
    return true;
}

void Environment::bind()
{
    JSObjectRef global = JSContextGetGlobalObject(mContext);
    mJsObject = JsObject::Create(mContext, this, global);
    mJsObject->Set(NAME, "global");
    mJsObject->Set(FULLNAME, "global");
}

std::string Environment::execute(const char* content, void* filename)
{
    JSValueRef result = nullptr;
    JSValueRef exception = nullptr;
    JSStringRef contentString = JSStringCreateWithUTF8CString(content);
    JSStringRef sourceUrl = filename ? JSStringCreateWithUTF8CString((char*)filename) : nullptr;
    bool syntax = JSCheckScriptSyntax(mContext, contentString, sourceUrl, 1, &exception);
    if (syntax)
    {
        result = JSEvaluateScript(mContext, contentString, nullptr, sourceUrl, 1, &exception);
    }
    else
    {
        LogError("Unknown syntax error : %s", JsObject::ToString(mContext, exception).c_str());
    }
    if (sourceUrl)
    {
        JSStringRelease(sourceUrl);
    }
    JSStringRelease(contentString);
    if (Environment::ClearException(&exception))
    {
        return "-1";
    }
    return JsObject::ToString(mContext, result);
}

std::string Environment::ExecuteScript(const char *sourceContent, const char *filename)
{
    return this->execute(sourceContent, const_cast<char*>(filename));
}

/*static*/ bool Environment::ClearException(JSValueRef *exception)
{
    if (*exception)
    {
        JSContextRef context = sInstance->mContext;
        
        Exception result;
        result.message = JsObject::ToString(context, *exception);
        
        JSType type = JSValueGetType(context, *exception);
        
        if (type == kJSTypeObject)
        {
            JSObjectRef jsObject = JSValueToObject(context, *exception, nullptr);
            JSStringRef stackKey = JSStringCreateWithUTF8CString("stack");
            JSValueRef stackValue = JSObjectGetProperty(context, jsObject, stackKey, nullptr);
            if (stackKey != nullptr)
            {
                type = JSValueGetType(context, stackValue);
                if (type == kJSTypeString)
                {
                    JSStringRef stackString = JSValueToStringCopy(context, stackValue, nullptr);
                    result.stack = JsObject::ToString(context, stackString);
                    JSStringRelease(stackString);
                }
                JSStringRelease(stackKey);
            }
            
            std::string line;
            std::string column;
            JSPropertyNameArrayRef nameArray = JSObjectCopyPropertyNames(context, jsObject);
            size_t count =JSPropertyNameArrayGetCount(nameArray);
            for (size_t i = 0; i < count; ++i)
            {
                JSStringRef jsName = JSPropertyNameArrayGetNameAtIndex(nameArray, i);
                JSValueRef jsValue = JSObjectGetProperty(context, jsObject, jsName, nullptr);
                
                std::string name = JsObject::ToString(context, jsName);
                
                JSStringRef jsString = JSValueToStringCopy(context, jsValue, nullptr);
                std::string value = JsObject::ToString(context, jsString);
                JSStringRelease(jsString);
                
                if ("line" == name)
                {
                    line = value;
                    result.lineIndex = JsObject::ToUint32(context, jsValue);
                }
                else if ("column" == name)
                {
                    column = value;
                }
                else if ("sourceURL" == name)
                {
                    result.filePath = value;
                }
            }
            
            result.location = result.filePath + ":" + line + ":" + column;
            JSPropertyNameArrayRelease(nameArray);
        }
        
        LogError(result.ToString());
        
        *exception = nullptr;
        return true;
    }
    return false;
}
