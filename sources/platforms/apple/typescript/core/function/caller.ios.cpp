#include "core/function/Function.h"
#include "delegates.h"
#include "core/function/Parameters.h"
#include "../object/object.ios.h"
#include "../../utils.h"
#include "core/function/Caller.exp.h"
#include "../environment.ios.h"

static std::map<int, JSValueRef> sCallers;

static int create_caller(JSContextRef context, const JSValueRef& value)
{
    int index = -1;
    if (sCallers.size())
    {
        for (auto it = sCallers.begin(); sCallers.end() != it; ++it)
        {
            if (it->first > index)
            {
                index = it->first;
            }
        }
    }
    sCallers[++index] = value;
    return index;
}

int RegisterCaller(JSContextRef context, const JSValueRef& caller)
{
    return create_caller(context, caller);
}

static JSValueRef get_caller(JSContextRef context, int index)
{
    auto result = sCallers.find(index);
    return sCallers.end() == result ? nullptr : result->second;
}

void ReleaseCaller(int index)
{
    auto result = sCallers.find(index);
    if (sCallers.end() == result) return;
    sCallers.erase(result);
}


char* General_Typescript_Caller_GetTypeName(void* environment, int index)
{
    EnvironmentIOS* runtime = reinterpret_cast<EnvironmentIOS*>(environment);
    if (!runtime) return ReturnStringToCSharp("");
    
    JSContextRef context = runtime->GetContext();
    if (!context) return ReturnStringToCSharp("");
    
    JSValueRef value = get_caller(context, index);
    if (!IsValueValid(context, value)) return ReturnStringToCSharp("");
    
    JSValueRef isType = GetValueProperty(context, value, UNITY_INSTANCE_IS_TYPE);
    //String::Utf8Value content(context, isType);
    if (IsValueValid(context, isType))
    {
        std::string type = JSValue_To_String(context, isType);
        if (Environment::IsCustomSuperClassName(type))
        {
            return ReturnStringToCSharp(GetCustomType(context, value).c_str());
        }
        return ReturnStringToCSharp(type);
    }
    else
    {
        JSValueRef property = GetValueProperty(context, value, UNITY_INSTANCE_TYPE);
        return ReturnStringToCSharp(IsValueValid(context, property) ? JSValue_To_String(context, property).c_str() : "");
    }
}

void* General_Typescript_Caller_GetHandle(void* environment, int index)
{
    EnvironmentIOS* runtime = reinterpret_cast<EnvironmentIOS*>(environment);
    if (!runtime) return nullptr;
    
    JSContextRef context = runtime->GetContext();
    if (!context) return nullptr;
    
    JSValueRef value = get_caller(context, index);
    return IsValueValid(context, value) ? GetObjectHandle(context, value) : nullptr;
}

void* General_Typescript_Caller_GetField(void* environment, void* pointer, int index)
{
    EnvironmentIOS* runtime = reinterpret_cast<EnvironmentIOS*>(environment);
    if (!runtime) return nullptr;
    
    JSContextRef context = runtime->GetContext();
    if (!context) return nullptr;
    
    JSValueRef value = get_caller(context, index);
    return IsValueValid(context, value) ? GetObjectField(context, value) : nullptr;
}
