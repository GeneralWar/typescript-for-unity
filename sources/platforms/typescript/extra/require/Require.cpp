#include "Require.h"
#include "core/Base.h"
#include "core/Environment.h"
#include "core/function/Function.h"
//
//  require.cpp
//  typescript
//
//  Created by 朱嘉灵 on 2018/12/21.
//  Copyright © 2018 朱嘉灵. All rights reserved.
//

static TypescriptStaticFunction* sRequire;

std::stack<std::string> Require::sRequireStack;
std::map<std::string, JS_OBJECT_TYPE> Require::sRequireCache;

void Require::Initialize(Environment* environment)
{
    if (!sRequire)
    {
        sRequire = TypescriptStaticFunction::Create("require", environment, Require::onRequireCall);
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
