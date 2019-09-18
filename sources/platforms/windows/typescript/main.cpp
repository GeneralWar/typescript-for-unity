#include "header.h"
#include "core/namespace/Namespace.h"
#include "core/class/Class.h"
#include "extra/console/console.h"
#include "delegates.h"
#include "core/Base.h"
#include "extra/log/Log.h"
#include "core/Object.win.h"
#include "core/function/Function.h"
#include "utils.h"
#include "core/function/Constructor.h"
#include "extra/require/require.h"
#include "core/Environment.win.h"
#include "core/Typescript.exp.h"
using namespace v8;

static StartupData *sNativeData = nullptr;
StartupData *sSnapshotData = nullptr;

void onFileCheckError(const char* file, int line, const char* message)
{
	//LogError(message);
	int n = 0;
}

void General_Typescript_SetNativeDataBlob(const char* buffer, int size)
{
	if (!sNativeData)
	{
		sNativeData = (StartupData*)malloc(sizeof(StartupData));
		sNativeData->data = (char*)malloc(size);
		memcpy(const_cast<char*>(sNativeData->data), buffer, size);
		memcpy(&sNativeData->raw_size, &size, sizeof(int));
		V8::SetNativesDataBlob(sNativeData);
	}
}

void General_Typescript_SetSnapshotDataBlob(const char* buffer, int size)
{
	if (!sSnapshotData)
	{
		sSnapshotData = (StartupData*)malloc(sizeof(StartupData));
		sSnapshotData->data = (char*)malloc(size);
		memcpy(const_cast<char*>(sSnapshotData->data), buffer, size);
		memcpy(&sSnapshotData->raw_size, &size, sizeof(int));
		V8::SetSnapshotDataBlob(sSnapshotData);
	}
}

void* General_Typescript_Initialize()
{
	EnvironmentWindows* environment = new EnvironmentWindows();
	if (environment->Initialize())
	{
		return environment;
	}
	delete environment;
	return nullptr;
}

void General_Typescript_Bind(void* environment)
{
	EnvironmentWindows* runtime = reinterpret_cast<EnvironmentWindows*>(environment);
	if (runtime)
	{
		runtime->Bind();
	}
}

const char* General_Typescript_ExecuteString(void* environment, const char* sourceContent)
{
	EnvironmentWindows* runtime = reinterpret_cast<EnvironmentWindows*>(environment);
	return ReturnStringToCSharp(runtime ? runtime->ExecuteString(sourceContent).c_str() : "");
}

const char* General_Typescript_ExecuteScript(void* environment, const char* sourceContent, const char* filename)
{
	EnvironmentWindows* runtime = reinterpret_cast<EnvironmentWindows*>(environment);
	return ReturnStringToCSharp(runtime ? runtime->ExecuteScript(sourceContent, filename).c_str() : "");
}

void* General_Typescript_DeclareNamespace(void* environment, const char* name)
{
	EnvironmentWindows* runtime = reinterpret_cast<EnvironmentWindows*>(environment);
	return runtime ? runtime->DeclareNamespace(name) : nullptr;
}

void* General_Typescript_DeclareClass(void* environment, const char* name, const char* base)
{
	EnvironmentWindows* runtime = reinterpret_cast<EnvironmentWindows*>(environment);
	return runtime ? runtime->DeclareClass(name, base) : nullptr;
}

void* General_Typescript_BindStaticFunction(void* environment, const char* name)
{
	EnvironmentWindows* runtime = reinterpret_cast<EnvironmentWindows*>(environment);
	return runtime ? runtime->BindStaticFunction(name) : nullptr;
}

void General_Typescript_Finalize(void* environment)
{
	EnvironmentWindows* runtime = reinterpret_cast<EnvironmentWindows*>(environment);
	if (runtime)
	{
		delete runtime;
	}
}

//#include <jni.h>
//
//extern "C" __attribute__ ((visibility ("default"))) void
//Java_com_soulfire_typescript_MainActivity_test(
//        JNIEnv* env,
//        jobject /* this */) {
//    General_Typescript_Initialize();
//}