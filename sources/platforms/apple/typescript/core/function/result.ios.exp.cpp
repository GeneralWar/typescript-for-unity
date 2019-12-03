//
//  result.exp.cpp
//  typescript
//
//  Created by 朱嘉灵 on 2018/12/29.
//  Copyright © 2018 朱嘉灵. All rights reserved.
//

#include "header.h"
#include "../../utils.h"
#include "../environment.ios.h"
#include "core/function/Result.exp.h"
#include <mutex>

static std::map<int, JSValueRef> sResultValues;

static std::mutex sMutex;

static int create_result_value(JSContextRef context, const JSValueRef& value)
{
    int index = -1;
    sMutex.lock();
    for (auto it = sResultValues.begin(); sResultValues.end() != it; ++it)
    {
        if (it->first > index)
        {
            index = it->first;
        }
    }
    sResultValues[++index] = value;
    sMutex.unlock();
    return index;
}

JSValueRef get_result_value(JSContextRef context, int index)
{
    auto result = sResultValues.find(index);
    return sResultValues.end() == result ? nullptr : sResultValues[index];
}

int RegisterResultValue(JSContextRef context, const JSValueRef& value)
{
    return create_result_value(context, value);
}

void ReleaseResultValue(int index)
{
    sMutex.lock();
    auto result = sResultValues.find(index);
    if (sResultValues.end() == result) return;
    sResultValues.erase(result);
    if (!sResultValues.size())
    {
        std::map<int, JSValueRef> temp;
        sResultValues.swap(temp);
    }
    sMutex.unlock();
}


void General_Typescript_Result_Release(void* environment, int index)
{
    ReleaseResultValue(index);
}

int General_Typescript_Result_GetJsType(void* environment, int index)
{
    EnvironmentIOS* runtime = reinterpret_cast<EnvironmentIOS*>(environment);
    if (!runtime) return -1;
    
    JSContextRef context = runtime->GetContext();
    return GetValueType(context, get_result_value(context, index));
}

double General_Typescript_Result_ToNumber(void* environment, int index)
{
    EnvironmentIOS* runtime = reinterpret_cast<EnvironmentIOS*>(environment);
    if (!runtime) return 0;
    
    JSContextRef context = runtime->GetContext();
    return JSValue_To_Number(context, get_result_value(context, index));
    
}

char* General_Typescript_Result_ToString(void* environment, int index)
{
    EnvironmentIOS* runtime = reinterpret_cast<EnvironmentIOS*>(environment);
    if (!runtime) return ReturnStringToCSharp("");
    
    JSContextRef context = runtime->GetContext();
    return ReturnStringToCSharp(context, get_result_value(context, index));
}

bool General_Typescript_Result_ToBoolean(void* environment, int index)
{
    EnvironmentIOS* runtime = reinterpret_cast<EnvironmentIOS*>(environment);
    if (!runtime) return ReturnStringToCSharp("");
    
    JSContextRef context = runtime->GetContext();
    return JSValueToBoolean(context, get_result_value(context, index));
}
