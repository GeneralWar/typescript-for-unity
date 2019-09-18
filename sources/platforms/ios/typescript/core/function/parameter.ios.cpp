//
//  base.m
//  typescript
//
//  Created by 朱嘉灵 on 2018/10/12.
//  Copyright © 2018年 朱嘉灵. All rights reserved.
//

#include "core/function/Parameters.h"

Parameters::Parameters(const JSValueRef arguments[], const int& count) : mValues(const_cast<JSValueRef*>(arguments)), mCount(count) { }
