//
//  require.cpp
//  typescript
//
//  Created by 朱嘉灵 on 2018/12/20.
//  Copyright © 2018 朱嘉灵. All rights reserved.
//
#include "extra/require/require.h"
#include "../../utils.apple.h"
#include "extension/files/FileUtility.h"
#include "extra/log/Log.h"
#include "core/class/Class.h"
#include "core/object/Object.h"
#include "core/Environment.h"

JSValueRef Require::onRequireCall(JSContextRef context, JSObjectRef function, JSObjectRef thisObject, size_t argumentCount, const JSValueRef arguments[], JSValueRef* exception)
{
    std::string filename = JsObject::ToString(context, arguments[0]);
    if (Require::GetRequireStackSize() > 0)
    {
        filename = FileUtility::CombinePath(FileUtility::GetDirectoryName(Require::RequirePeek()), filename);
    }
    
    if (std::string::npos == filename.find(".js"))
    {
        filename += ".js";
    }
    
    JSValueRef result = nullptr;
    JSObjectRef global = JSContextGetGlobalObject(context);
    JSValueRef existed = JsObject::GetValue(context, global, filename);
    if (existed && JsObject::IsValid(context, existed))
    {
        result = existed;
    }
    else
    {
        Require::RequirePush(filename);
        
        std::string content = FileUtility::ReadStringFromFile(filename);
        JSStringRef contentString = JSStringCreateWithUTF8CString(content.c_str());
        JSStringRef urlString = JSStringCreateWithUTF8CString(filename.c_str());
        result = JSEvaluateScript(context, contentString, nullptr, urlString, 0, exception);
        JSStringRelease(urlString);
        JSStringRelease(contentString);
        
        if (Environment::ClearException(exception))
        {
            return nullptr;
        }
        if (JsObject::IsValid(context, result))
        {
            TypescriptClass::CheckConstructors(context, result);
        }
        JsObject::Set(context, global, filename, result);
        
        Require::RequirePop();
    }
    return result;
}
