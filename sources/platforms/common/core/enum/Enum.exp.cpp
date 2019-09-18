#include "Enum.h"
#include "Enum.exp.h"
#include "extra/log/Log.h"

void General_Typescript_Enum_SetValue(void* handle, const char* name, long int value)
{
    TypescriptEnum* instance = reinterpret_cast<TypescriptEnum*>(handle);
    if (instance)
    {
        instance->SetValue(name, value);
    }
    else
    {
        LogError("Try to set value for enum, but there is no handle!");
    }
}
