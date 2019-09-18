#include "Typescript.exp.h"
#include "Environment.h"

extern "C"
{
	DLL_EXPORT void General_Typescript_ReleaseHandle(void* environment, unsigned long long handle)
	{
		//ReleaseHandle(handle);
	}

	DLL_EXPORT void General_Typescript_ReleaseMemory(void* environment, unsigned long long* handles, int size)
	{
		//ReleaseHandles(handles, size);
	}
    
    DLL_EXPORT void General_Typescript_AppendCustomSuperClassName(const char* fullname)
    {
        Environment::AppendCustomSuperClassName(fullname);
    }
}
