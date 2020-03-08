//
//  Typescript.exp.cpp
//  typescript-mac
//
//  Created by 朱嘉灵 on 2020/1/6.
//  Copyright © 2020 朱嘉灵. All rights reserved.
//

#include "Typescript.exp.h"
#include "Environment.h"
#include "object/Object.h"
#include "class/Class.h"
#include "Utils.h"
#include "extra/require/Require.h"
#include "extra/console/Console.h"

void* General_Typescript_Initialize()
{
    Environment* environment = Environment::Create();
    if (environment->Initialize())
    {
#if USE_ENGINE_V8
        HandleScope handleScope(environment->GetIsolate());
#endif
        environment->Bind();
        
        JS_CONTEXT_TYPE context = environment->GET_JS_CONTEXT_FUNCTION();
        
        JsObject::Initialize(context);
        
        environment->CreateGlobalObject(context, "exports");
        
        Require::Initialize(environment);
        Require::Bind();
        Console::Initialize(environment);
        Console::Bind();
        
        environment->ExecuteString("console.log = General_Console.log;");
        environment->ExecuteString("console.warn = General_Console.warn;");
        environment->ExecuteString("console.error = General_Console.error;");
        
        return environment;
    }
    Environment::Release(environment);
    return nullptr;
}

const char* General_Typescript_ExecuteString(void* environment, const char* sourceContent)
{
    Environment* runtime = reinterpret_cast<Environment*>(environment);
    return ReturnStringToCSharp(runtime ? runtime->ExecuteString(SAFE_STRING(sourceContent)).c_str() : "");
}

const char* General_Typescript_ExecuteScript(void* environment, const char* sourceContent, const char* filename)
{
    Environment* runtime = reinterpret_cast<Environment*>(environment);
    return ReturnStringToCSharp(runtime ? runtime->ExecuteScript(SAFE_STRING(sourceContent), SAFE_STRING(filename)).c_str() : "");
}

void* General_Typescript_DeclareNamespace(void* environment, const char* name)
{
    Environment* runtime = reinterpret_cast<Environment*>(environment);
    if (!runtime)
    {
        return nullptr;
    }
#if USE_ENGINE_V8
    Isolate* isolate = runtime->GetIsolate();
    HandleScope handleScope(isolate);
#endif
    return runtime->DeclareNamespace(SAFE_STRING(name));
}

void* General_Typescript_DeclareClass(void* environment, const char* name, const char* base, bool hasConstructor, bool isStatic)
{
    Environment* runtime = reinterpret_cast<Environment*>(environment);
    if (!runtime)
    {
        return nullptr;
    }
#if USE_ENGINE_V8
    Isolate* isolate = runtime->GetIsolate();
    HandleScope handleScope(isolate);
#endif
    return runtime->DeclareClass(SAFE_STRING(name), SAFE_STRING(base), hasConstructor, isStatic);
}

void* General_Typescript_BindStaticFunction(void* environment, const char* name)
{
    Environment* runtime = reinterpret_cast<Environment*>(environment);
    if (!runtime)
    {
        return nullptr;
    }
#if USE_ENGINE_V8
    Isolate* isolate = runtime->GetIsolate();
    HandleScope handleScope(isolate);
#endif
    return runtime->BindStaticFunction(SAFE_STRING(name));
}

void General_Typescript_Finalize(void* environment)
{
    Environment* runtime = reinterpret_cast<Environment*>(environment);
    if (!runtime)
    {
        return;
    }
#if USE_ENGINE_V8
    Isolate* isolate = runtime->GetIsolate();
    HandleScope handleScope(isolate);
#endif
    Require::Release();
    Console::Release();
    
    JsObject::Clear();
    TypescriptClass::Clear();
    Environment::Release(environment);
}

void General_Typescript_DebugLog(const char* message)
{
    DEBUG_LOG("\n\n%s\n\n", message);
}

void General_Typescript_DebugLogWarning(const char* message, const char* stackTraces)
{
    if (strlen(stackTraces))
    {
        DEBUG_LOG("\n\n[WARN] %s\n%s\n\n", message, stackTraces);
    }
    else
    {
        DEBUG_LOG("\n\n[WARN] %s\n\n", message);
    }
}

void General_Typescript_DebugLogError(const char* message, const char* stackTraces)
{
    if (strlen(stackTraces))
    {
        DEBUG_LOG("\n\n[ERROR] %s\n%s\n\n", message, stackTraces);
    }
    else
    {
        DEBUG_LOG("\n\n[ERROR] %s\n\n", message);
    }
}
