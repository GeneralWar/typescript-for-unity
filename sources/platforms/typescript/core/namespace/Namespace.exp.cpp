#include "Namespace.h"
#include "../class/Class.h"
#include "core/namespace/Namespace.exp.h"

void* General_Typescript_Namespace_DeclareNamespace(void* handle, const char* name)
{
//    DEBUG_LOG("%s : 0x%x, %s", "General_Typescript_Namespace_DeclareNamespace", handle, name);
	TypescriptNamespace* instance = TypescriptNamespace::Convert(handle);
	if (!instance) return nullptr;
#if USE_ENGINE_V8
	Isolate* isolate = instance->GetIsolate();
	HandleScope handleScope(isolate);
#endif
	return instance->DeclareNamespace(SAFE_STRING(name));
}

void* General_Typescript_Namespace_DeclareClass(void* handle, const char* name, const char* base, bool hasConstructor, bool isStatic)
{
//    DEBUG_LOG("%s : 0x%x, %s, %s, %s", "General_Typescript_Namespace_DeclareClass", handle, name, base, BTOS(hasConstructor));
	TypescriptNamespace* instance = TypescriptNamespace::Convert(handle);
	if (!instance) return nullptr;
#if USE_ENGINE_V8
	Isolate* isolate = instance->GetIsolate();
	HandleScope handleScope(isolate);
#endif
	return instance->DeclareClass(SAFE_STRING(name), base, hasConstructor, isStatic);
}

void* General_Typescript_Namespace_DeclareEnum(void* handle, const char* name)
{
//    DEBUG_LOG("%s : 0x%x, %s", "General_Typescript_Namespace_DeclareEnum", handle, name);
	TypescriptNamespace* instance = TypescriptNamespace::Convert(handle);
	if (!instance) return nullptr;
#if USE_ENGINE_V8
	Isolate* isolate = instance->GetIsolate();
	HandleScope handleScope(isolate);
#endif
	return instance->DeclareEnum(SAFE_STRING(name));
}
