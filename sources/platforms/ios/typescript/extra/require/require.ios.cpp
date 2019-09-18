//
//  require.cpp
//  typescript
//
//  Created by 朱嘉灵 on 2018/12/20.
//  Copyright © 2018 朱嘉灵. All rights reserved.
//
#include "extra/require/require.h"
#include "core/function/Function.h"
#include "../../core/environment.ios.h"
#include "header.h"
#include "../../utils.h"
#include "extension/files/FileUtility.h"
#include "extra/log/Log.h"
#include "core/function/Constructor.h"

JSValueRef onRequireCall(JSContextRef context, JSObjectRef function, JSObjectRef thisObject, size_t argumentCount, const JSValueRef arguments[], JSValueRef* exception)
{
    std::string filename = JSValue_To_String(context, arguments[0]);
    if (std::string::npos == filename.find(".gts"))
    {
        filename += ".gts";
    }
    std::string realname = filename;
    realname.replace(filename.rfind(".gts"), 4, ".js");
    std::string content = FileUtility::ReadStringFromFile(filename);
    
    JSStringRef contentString = JSStringCreateWithUTF8CString(content.c_str());
    JSStringRef urlString = JSStringCreateWithUTF8CString(realname.c_str());
    JSValueRef result = JSEvaluateScript(context, contentString, nullptr, urlString, 0, exception);
    JSStringRelease(urlString);
    JSStringRelease(contentString);
    if (*exception)
    {
        LogError(JSValue_To_String(context, *exception));
        return nullptr;
    }
    if (IsValueValid(context, result))
    {
        CheckConstructors(context, result);
    }
    return result;
}
