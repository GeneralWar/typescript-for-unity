//
//  console.m
//  typescript
//
//  Created by 朱嘉灵 on 2018/10/12.
//  Copyright © 2018年 朱嘉灵. All rights reserved.
//

#include "Utils.apple.h"
#include "extra/log/Log.h"
#include "core/object/Object.h"

std::string pick_content(JSContextRef context, const JSValueRef arguments[], int count)
{
    std::string content = "";
    for (int i = 0; i < count; ++i)
    {
        std::string element = JsObject::ToString(context, arguments[i]);
        content.append(content.empty() ? element : (std::string(" ") + element));
    }
    return content;
}

JSValueRef console_log(JSContextRef context, JSObjectRef function, JSObjectRef thisObject, size_t argumentCount, const JSValueRef arguments[], JSValueRef* exception)
{
    Log(pick_content(context, arguments, (int)argumentCount));
    return 0;
}

JSValueRef console_warn(JSContextRef context, JSObjectRef function, JSObjectRef thisObject, size_t argumentCount, const JSValueRef arguments[], JSValueRef* exception)
{
    LogWarning(pick_content(context, arguments, (int)argumentCount));
    return 0;
}

JSValueRef console_error(JSContextRef context, JSObjectRef function, JSObjectRef thisObject, size_t argumentCount, const JSValueRef arguments[], JSValueRef* exception)
{
    LogError(pick_content(context, arguments, (int)argumentCount));
    return 0;
}
