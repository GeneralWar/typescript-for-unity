#include "Enum.h"
#include "Enum.exp.h"
#include "extra/log/Log.h"
#if USE_ENGINE_V8
#include "Utils.h"
#endif

void General_Typescript_Enum_SetValue(void* handle, const char* name, long int value)
{
    TypescriptEnum* instance = TypescriptEnum::Convert(handle);
    if (instance)
    {
#if USE_ENGINE_V8
        Isolate* isolate = instance->GetIsolate();
        HandleScope handleScope(isolate);
#endif
        instance->SetValue(SAFE_STRING(name), value);
    }
    else
    {
        LogError("Try to set value for enum, but there is no handle!");
    }
}

void General_Typescript_Enum_Register(void* handle)
{
    TypescriptEnum* instance = TypescriptEnum::Convert(handle);
    if (instance)
    {
#if USE_ENGINE_V8
        Isolate* isolate = instance->GetIsolate();
        HandleScope handleScope(isolate);
#endif
        instance->Register();
    }
    else
    {
        LogError("Try to register enum, but there is no handle!");
    }
}
