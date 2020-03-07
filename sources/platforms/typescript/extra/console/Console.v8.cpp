#include "extra/console/console.h"
#include "extra/log/Log.h"
#include "core/class/Class.h"
#include "core/namespace/Namespace.h"

std::string pick_contents(const FunctionCallbackInfo<Value>& info)
{
    Isolate* isolate = info.GetIsolate();

    int length = info.Length();
    std::string content = "";
    for (int i = 0; i < length; ++i)
    {
        String::Utf8Value element(isolate, info[i]->ToString(isolate));
        content.append(content.empty() ? *element : (std::string(" ") + *element));
    }
    return content;
}

void console_log(const FunctionCallbackInfo<Value>& info)
{
    Log(pick_contents(info));
}

void console_warn(const FunctionCallbackInfo<Value>& info)
{
    LogWarning(pick_contents(info));
}

void console_error(const FunctionCallbackInfo<Value>& info)
{
    LogError(pick_contents(info));
}

