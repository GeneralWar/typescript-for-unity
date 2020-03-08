#include "Log.h"
#include <mutex>
#include <stdarg.h>
#include "defines.h"

OnStringChange sLogCallback = nullptr;
OnStringChange sLogWarningCallback = nullptr;
OnStringChange sLogErrorCallback = nullptr;

static char sLogBuffer[MILLION_BYTES];
static char sTempBuffer[MILLION_BYTES];

std::mutex sTempMutex;
std::mutex sBufferMutex;

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
	//sBufferMutex.lock();
	va_list list;
	va_start(list, content);
	vsprintf(sLogBuffer, content, list);
	va_end(list);
	if (sLogCallback)
	{
		sLogCallback(sLogBuffer);
	}
	//sBufferMutex.unlock();
}

void Log(const std::string content, ...)
{
	//sBufferMutex.lock();
	va_list list;
	va_start(list, content);
	vsprintf(sLogBuffer, content.c_str(), list);
	va_end(list);
	if (sLogCallback)
	{
		sLogCallback(sLogBuffer);
	}
	//sBufferMutex.unlock();
}

void LogWarning(const char* content, ...)
{
	//sTempMutex.lock();
	va_list list;
	va_start(list, content);
	vsprintf(sTempBuffer, content, list);
	va_end(list);
	if (sLogWarningCallback)
	{
		//sBufferMutex.lock();
		char sLogBuffer[1024];
		sprintf(sLogBuffer, "%s %s\n", "[WARN]", sTempBuffer);
		sLogWarningCallback(sLogBuffer);
		//sBufferMutex.unlock();
	}
	//sTempMutex.unlock();
}

void LogWarning(const std::string content, ...)
{
	//sTempMutex.lock();
	va_list list;
	va_start(list, content);
	vsprintf(sTempBuffer, content.c_str(), list);
	va_end(list);
	if (sLogWarningCallback)
	{
		//sBufferMutex.lock();
		char sLogBuffer[1024];
		sprintf(sLogBuffer, "%s %s\n", "[WARN]", sTempBuffer);
		sLogWarningCallback(sLogBuffer);
		//sBufferMutex.unlock();
	}
	//sTempMutex.unlock();
}

void LogError(const char* content, ...)
{
	//sTempMutex.lock();
	va_list list;
	va_start(list, content);
	vsprintf(sTempBuffer, content, list);
	va_end(list);
	if (sLogErrorCallback)
	{
		//sBufferMutex.lock();
		char sLogBuffer[1024];
		sprintf(sLogBuffer, "%s %s\n", "[ERROR]", sTempBuffer);
		sLogErrorCallback(sLogBuffer);
		//sBufferMutex.unlock();
	}
	//sTempMutex.unlock();
}

void LogError(const std::string content, ...)
{
	//sTempMutex.lock();
	va_list list;
	va_start(list, content);
	vsprintf(sTempBuffer, content.c_str(), list);
	va_end(list);
	if (sLogErrorCallback)
	{
		//sBufferMutex.lock();
		char sLogBuffer[1024];
		sprintf(sLogBuffer, "%s %s\n", "[ERROR]", sTempBuffer);
		sLogErrorCallback(sLogBuffer);
		//sBufferMutex.unlock();
	}
	//sTempMutex.unlock();
}

#if WINDOWS
#include <windows.h>
#include <debugapi.h>
#elif __APPLE__
#import <Foundation/Foundation.h>
#endif

static char sDebugLogBuffer[1024 * 1024 * 1];

void debug_log(const char* content, ...)
{
	va_list list;
	va_start(list, content);
	vsprintf(sDebugLogBuffer, content, list);
	va_end(list);
#if WINDOWS
	OutputDebugStringA(sDebugLogBuffer);
#elif __APPLE__
    NSLog(@"%@\n", [NSString stringWithUTF8String:sDebugLogBuffer]);
#endif
}
