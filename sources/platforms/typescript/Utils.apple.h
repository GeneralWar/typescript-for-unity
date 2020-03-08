//
//  utils.h
//  typescript
//
//  Created by 朱嘉灵 on 2018/11/22.
//  Copyright © 2018年 朱嘉灵. All rights reserved.
//

#ifndef utils_h
#define utils_h

#include <string>
#include <JavaScriptCore/JavaScriptCore.h>
#include "core/Base.h"

char* ReturnStringToCSharp(const JSStringRef content);

int GetValueType(JSContextRef context, JSValueRef value);

#endif /* utils_h */
