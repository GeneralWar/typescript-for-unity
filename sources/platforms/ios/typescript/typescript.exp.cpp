//
//  typescript.m
//  typescript
//
//  Created by 朱嘉灵 on 2018/10/12.
//  Copyright © 2018年 朱嘉灵. All rights reserved.
//

extern "C" {
#import "typescript.ios.h"
}
#import "core/environment.ios.h"
#import "utils.h"
#import "defines.h"

extern "C"
{
    void* General_Typescript_Initialize()
    {
        Environment* runtime = new EnvironmentIOS();
        if (runtime->Initialize())
        {
            return runtime;
        }
        delete runtime;
        return nullptr;
    }

    void General_Typescript_Bind(void* environment)
    {
        EnvironmentIOS* runtime = reinterpret_cast<EnvironmentIOS*>(environment);
        if (runtime)
        {
            runtime->Bind();
        }
    }
    
    const char* General_Typescript_ExecuteString(void* environment, const char* content)
    {
        EnvironmentIOS* runtime = reinterpret_cast<EnvironmentIOS*>(environment);
        return ReturnStringToCSharp(runtime ? runtime->ExecuteString(content) : "");
    }

    const char* General_Typescript_ExecuteScript(void* environment, const char* content, const char* filename)
    {
        EnvironmentIOS* runtime = reinterpret_cast<EnvironmentIOS*>(environment);
        return ReturnStringToCSharp(runtime ? runtime->ExecuteScript(content, filename) : "");
    }

    void* General_Typescript_DeclareNamespace(void* environment, const char* name)
    {
        EnvironmentIOS* runtime = reinterpret_cast<EnvironmentIOS*>(environment);
        return runtime ? runtime->DeclareNamespace(name) : nullptr;
    }

    void* General_Typescript_DeclareClass(void* environment, const char* name, const char* base)
    {
        EnvironmentIOS* runtime = reinterpret_cast<EnvironmentIOS*>(environment);
        return runtime ? runtime->DeclareClass(name, base) : nullptr;
    }

    void* General_Typescript_BindStaticFunction(void* environment, const char* name)
    {
        EnvironmentIOS* runtime = reinterpret_cast<EnvironmentIOS*>(environment);
        return runtime ? runtime->BindStaticFunction(name) : nullptr;
    }
    
    void General_Typescript_Finalize(void* environment)
    {
        EnvironmentIOS* runtime = reinterpret_cast<EnvironmentIOS*>(environment);
        if (runtime)
        {
            delete runtime;
        }
    }
}
