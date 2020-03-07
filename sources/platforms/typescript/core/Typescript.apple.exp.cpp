//
//  typescript.cpp
//  typescript
//
//  Created by 朱嘉灵 on 2018/10/12.
//  Copyright © 2018年 朱嘉灵. All rights reserved.
//

#include "core/Typescript.exp.h"
#include "core/Environment.h"

extern "C" JS_EXPORT void JSSynchronousGarbageCollectForDebugging(JSContextRef);

void General_Typescript_Request_GarbageCollection(Environment* runtime)
{
    if (!runtime) return;
    
    JSContextRef context = runtime->GetContext();
    if (!context) return;
    
#if DEBUG
    JSSynchronousGarbageCollectForDebugging(context);
#else
    JSGarbageCollect(context);
#endif
}
