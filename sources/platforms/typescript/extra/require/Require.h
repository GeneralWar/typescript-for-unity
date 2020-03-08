#pragma once
#include "header.h"
#include "defines.h"

class Environment;

class Require
{
private:
	static std::stack<std::string> sRequireStack;
    static std::map<std::string, JS_OBJECT_TYPE> sRequireCache;
public:
	static void Initialize(Environment* environment);

	static void Bind();

	static void Release();

	static int RequirePush(const std::string& filename);
	static int RequirePop();
	static std::string RequirePeek() { return sRequireStack.top(); }
	static int GetRequireStackSize() { return (int)sRequireStack.size(); }
    
#ifdef __APPLE__
    static JSValueRef onRequireCall(JSContextRef context, JSObjectRef function, JSObjectRef thisObject, size_t argumentCount, const JSValueRef arguments[], JSValueRef* exception);
#else
    static void onRequireCall(const FunctionCallbackInfo<Value>& info);
#endif
};
