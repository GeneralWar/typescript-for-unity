//
//  ocUtils.h
//  typescript
//
//  Created by 朱嘉灵 on 2018/12/12.
//  Copyright © 2018 朱嘉灵. All rights reserved.
//

#ifndef contextUtils_h
#define contextUtils_h

#include <JavaScriptCore/JavaScriptCore.h>

JSContextRef CreateContext();

JSValueRef DefineProperty(JSContextRef context, JSValueRef target, void* handle, const char* name, JSObjectCallAsFunctionCallback getter, JSObjectCallAsFunctionCallback setter);

#endif /* contextUtils_h */
