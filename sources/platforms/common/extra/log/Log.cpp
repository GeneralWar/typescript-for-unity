#include "Log.h"
#include <stdarg.h>
#include "defines.h"

OnStringChange sLogCallback = nullptr;
OnStringChange sLogWarningCallback = nullptr;
OnStringChange sLogErrorCallback = nullptr;

extern "C"
{
    DLL_EXPORT void General_Typescript_BindLogCallback(OnStringChange log, OnStringChange logWarning, OnStringChange logError)
    {
        sLogCallback = log;
        sLogErrorCallback = logError;
        sLogWarningCallback = logWarning;
    }
}

void Log(const char* content, ...)
{
	va_list list;
	va_start(list, content);
	char buffer[1024]{};
	vsprintf(buffer, content, list);
	va_end(list);
	if (sLogCallback)
	{
		sLogCallback(buffer);
	}
}

void Log(const std::string content, ...)
{
	va_list list;
	va_start(list, content);
	char buffer[1024]{};
	vsprintf(buffer, content.c_str(), list);
	va_end(list);
	if (sLogCallback)
	{
		sLogCallback(buffer);
	}
}

void LogWarning(const char* content, ...)
{
	va_list list;
	va_start(list, content);
	char buffer[1024]{};
	vsprintf(buffer, content, list);
	va_end(list);
	if (sLogWarningCallback)
	{
		sLogWarningCallback(buffer);
	}
}

void LogWarning(const std::string content, ...)
{
	va_list list;
	va_start(list, content);
	char buffer[1024]{};
	vsprintf(buffer, content.c_str(), list);
	va_end(list);
	if (sLogWarningCallback)
	{
		sLogWarningCallback(buffer);
	}
}

void LogError(const char* content, ...)
{
	va_list list;
	va_start(list, content);
	char buffer[1024]{};
	vsprintf(buffer, content, list);
	va_end(list);
	if (sLogErrorCallback)
	{
		sLogErrorCallback(buffer);
	}
}

void LogError(const std::string content, ...)
{
	va_list list;
	va_start(list, content);
	char buffer[1024]{};
	vsprintf(buffer, content.c_str(), list);
	va_end(list);
	if (sLogErrorCallback)
	{
		sLogErrorCallback(buffer);
	}
}
