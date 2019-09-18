#include "defines.h"
#include "delegates.h"

OnReadStringFromFile sReadStringFromFileCallback;

extern "C"
{
	DLL_EXPORT void General_Typescript_Extension_BindReadStringFromFileCallback(OnReadStringFromFile callback)
	{
		sReadStringFromFileCallback = callback;
	}
}