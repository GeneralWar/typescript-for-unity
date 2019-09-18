#include "console.h"
#include "core/class/Class.h"
#include <memory>

#ifdef __APPLE__
extern JSValueRef console_log(JSContextRef context, JSObjectRef function, JSObjectRef thisObject, size_t argumentCount, const JSValueRef arguments[], JSValueRef* exception);
extern JSValueRef console_warn(JSContextRef context, JSObjectRef function, JSObjectRef thisObject, size_t argumentCount, const JSValueRef arguments[], JSValueRef* exception);
extern JSValueRef console_error(JSContextRef context, JSObjectRef function, JSObjectRef thisObject, size_t argumentCount, const JSValueRef arguments[], JSValueRef* exception);
#else
extern void console_log(const FunctionCallbackInfo<Value>& info);
extern void console_warn(const FunctionCallbackInfo<Value>& info);
extern void console_error(const FunctionCallbackInfo<Value>& info);
#endif

std::unique_ptr<TypescriptClass> Console::sConsole;

void Console::Initialize(Environment* environment)
{
    if (!sConsole)
    {
        sConsole = std::unique_ptr<TypescriptClass>(new TypescriptClass("General_Console", environment));
        sConsole->BindStaticFunction("log", console_log);
        sConsole->BindStaticFunction("warn", console_warn);
        sConsole->BindStaticFunction("error", console_error);
    }
}

void Console::Bind()
{
	if (sConsole)
	{
		sConsole->Bind();
	}
}

void Console::Release()
{
	if (sConsole)
	{
		sConsole = nullptr;
	}
}
