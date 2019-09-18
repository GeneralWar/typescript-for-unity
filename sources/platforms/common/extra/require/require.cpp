#include "require.h"
#include "core/function/Function.h"
//
//  require.cpp
//  typescript
//
//  Created by 朱嘉灵 on 2018/12/21.
//  Copyright © 2018 朱嘉灵. All rights reserved.
//

#ifdef __APPLE__
extern JSValueRef onRequireCall(JSContextRef context, JSObjectRef function, JSObjectRef thisObject, size_t argumentCount, const JSValueRef arguments[], JSValueRef* exception);
#else
extern void onRequireCall(const FunctionCallbackInfo<Value>& info);
#endif

std::unique_ptr<TypescriptStaticFunction> sRequire;

std::stack<std::string> Require::sRequireStack;

void Require::Initialize(Environment* environment)
{
    if (!sRequire)
    {
        Environment* runtime = reinterpret_cast<Environment*>(environment);
        if (!runtime) return;
        sRequire = std::unique_ptr<TypescriptStaticFunction>(new TypescriptStaticFunction("require", runtime, onRequireCall));
    }
}

void Require::Bind()
{
    if (sRequire)
    {
        sRequire->Bind();
    }
}

void Require::Release()
{
	if (sRequire)
	{
		sRequire = nullptr;
	}
}

int Require::RequirePush(const std::string& filename)
{
	sRequireStack.push(filename);
	return (int)sRequireStack.size();
}

int Require::RequirePop()
{
	sRequireStack.pop();
	return (int)sRequireStack.size();
}