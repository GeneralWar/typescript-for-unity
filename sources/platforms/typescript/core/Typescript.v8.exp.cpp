#include "header.h"
#include "core/namespace/Namespace.h"
#include "core/class/Class.h"
#include "extra/console/console.h"
#include "delegates.h"
#include "core/Base.h"
#include "extra/log/Log.h"
#include "core/function/Function.h"
#include "utils.h"
#include "extra/require/require.h"
#include "core/Environment.h"
#include "core/Typescript.exp.h"
#include "core/object/Object.h"

static StartupData *sNativeData = nullptr;
StartupData *sSnapshotData = nullptr;

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

void General_Typescript_Request_GarbageCollection(Environment* runtime)
{
	if (!runtime)
	{
		return;
	}
	Isolate* isolate = runtime->GetIsolate();
	isolate->RequestGarbageCollectionForTesting(v8::Isolate::kFullGarbageCollection);
}
