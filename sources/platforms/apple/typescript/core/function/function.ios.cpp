////
////  base.m
////  typescript
////
////  Created by 朱嘉灵 on 2018/10/12.
////  Copyright © 2018年 朱嘉灵. All rights reserved.
////

#include "utils.h"
#include "defines.h"
#include "core/function/Function.h"
#include "core/function/Parameters.h"
#include "extra/log/Log.h"

extern StaticFunctionCallback sStaticFunctionCallback;

void TypescriptStaticFunction::Bind()
{
    this->Bind(mParent);
}

void TypescriptStaticFunction::Bind(Base* parent)
{
    JSContextRef context = GetContext(this);
    
    JSObjectRef self = JSObjectMakeFunctionWithCallback(context, 0, mCallback);
    if (self)
    {
        mReference = self;
        SetValueProperty(context, self, OBJECT_KEY, JSValueMakeNumber(context, (unsigned long long)this));
        this->BindToParent(parent);
    }
}

int TypescriptStaticFunction::Invoke(const JSValueRef arguments[], const int& argumentCount)
{
    Parameters parameters(const_cast<JSValueRef*>(arguments), argumentCount);
    return sStaticFunctionCallback(this, parameters.address(), parameters.count());
}
