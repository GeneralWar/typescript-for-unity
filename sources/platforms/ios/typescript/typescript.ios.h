//
//  typescript.ios.h
//  typescript
//
//  Created by 朱嘉灵 on 2018/12/19.
//  Copyright © 2018 朱嘉灵. All rights reserved.
//

#ifndef typescript_ios_h
#define typescript_ios_h
#include "defines.h"

void* Environment_Initialize(void);

void Environment_Bind(void* environment);

const char* Environment_ExecuteString(void* environment, const char* content);

const char* Environment_ExecuteScript(void* environment, const char* content, const char* filename);

void* Environment_DeclareNamespace(void* environment, const char* name);

void* Environment_DeclareClass(void* environment, const char* name, const char* base);

void* Environment_BindStaticFunction(void* environment, const char* name);

#endif /* typescript_ios_h */
