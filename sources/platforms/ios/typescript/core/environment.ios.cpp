//
//  EnvironmentIOS.cpp
//  typescript
//
//  Created by 朱嘉灵 on 2018/12/12.
//  Copyright © 2018 朱嘉灵. All rights reserved.
//

#include "../utils.h"
#include "../ocUtils.h"
#include "environment.ios.h"
#include "core/class/Class.h"
#include "core/function/Function.h"
#include "core/namespace/Namespace.h"
#include "extra/log/Log.h"
#include "core/function/Constructor.h"
#include "object/object.ios.h"

void EnvironmentIOS::release()
{
    Environment::release();
}

bool EnvironmentIOS::Initialize()
{
    mContext = CreateContext();
//    mContext = JSGlobalContextCreate(nullptr);
//    jss
    return true;
}

void EnvironmentIOS::Bind()
{
    this->bindExtra();
    
    for (auto instance : mNamespaces)
    {
        instance->Bind();
    }
    for (auto instance : mClasses)
    {
        instance->Bind();
    }
    for (auto instance : mFunctions)
    {
        instance->Bind();
    }
    
    TypescriptClass::Derive();
    
    CreateGlobalObject(mContext, "exports");
    object_initialize(mContext);
    //    constructor_initialize(context);
}

std::string EnvironmentIOS::ExecuteString(const char *sourceContent)
{
//    JSCheckScriptSyntax
    JSValueRef exception = 0;
    JSStringRef contentString = JSStringCreateWithUTF8CString(sourceContent);
    JSValueRef result = JSEvaluateScript(mContext, contentString, 0, 0, 0, &exception);
    JSStringRelease(contentString);
    if (exception)
    {
        LogError(JSValue_To_String(mContext, exception).c_str());
        return "-1";
    }
    return JSValue_To_String(mContext, result).c_str();
}

JSValueRef EnvironmentIOS::execute(const char* content, const char* filename)
{
    JSValueRef exception = 0;
    JSStringRef contentString = JSStringCreateWithUTF8CString(content);
    JSStringRef sourceUrl = JSStringCreateWithUTF8CString(filename);
    JSValueRef result = JSEvaluateScript(mContext, contentString, 0, sourceUrl, 0, &exception);
    JSStringRelease(sourceUrl);
    JSStringRelease(contentString);
    if (exception)
    {
        LogError(JSValue_To_String(mContext, exception));
        return JSValueMakeString(mContext, JSStringCreateWithUTF8CString("-1"));
    }
    return result;
}

std::string EnvironmentIOS::ExecuteScript(const char *sourceContent, const char *filename)
{
    return JSValue_To_String(mContext, this->execute(sourceContent, filename)).c_str();
}

void* EnvironmentIOS::Require(const char *sourceContent, const char *filename)
{
    JSValueRef result = execute(sourceContent, filename);
//    CheckConstructors(mContext, result);
    return (void*)result;
}

JSValueRef EnvironmentIOS::GetGlobalObject()
{
    return JSContextGetGlobalObject(mContext);
}
