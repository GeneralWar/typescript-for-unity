//
//  base.m
//  typescript
//
//  Created by 朱嘉灵 on 2018/10/12.
//  Copyright © 2018年 朱嘉灵. All rights reserved.
//

#include "core/Base.h"
#include "../utils.h"
#include "extra/log/Log.h"
#include "object/object.ios.h"

void Base::BindToParent(Base* parent)
{
    JSValueRef parentValue = parent ? GetValue(parent) : GetParentValue(this);
    if (!parentValue)
    {
        LogError("Cannot find parent for object : %s", mName.c_str());
        return;
    }
    
    JSContextRef context = GetContext(this);
    if (!context)
    {
        LogError("There is no context for binding!!!");
        return;
    }
    
    JSValueRef self = mReference;
    if (parentValue && self && context)
    {
        SetValueProperty(context, parentValue, mName.c_str(), self);
    }
}

void Base::Bind()
{
    JSContextRef context = GetContext(this);
    if (!context)
    {
        LogError("There is no context for binding!!!");
        return;
    }
    
    JSValueRef self = CreateValue(context);
    SetValuePropertyWithString(context, self, "name", mName.c_str());
    mReference = self;
    this->BindToParent(mParent);
}
