//
//  enum.m
//  typescript
//
//  Created by 朱嘉灵 on 2018/11/23.
//  Copyright © 2018年 朱嘉灵. All rights reserved.
//

#include "core/enum/Enum.h"
#include "../../utils.h"

void TypescriptEnum::Bind()
{
    JSContextRef context = GetContext(this);
    if (!context) return;
    
    Base::Bind();
    for (auto pair : mValues)
    {
        SetValuePropertyWithLong(context, mReference, pair.first.c_str(), pair.second);
    }
}
