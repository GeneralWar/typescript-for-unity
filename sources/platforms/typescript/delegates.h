#pragma once

class JsObject;

typedef void (*OnIsolate)(void* isolate);
typedef void (*OnStringChange)(const char* value);

typedef void (*GarbageCollectionCallback)(const void* value);

typedef JsObject* (*ConstructorCallback)(void* constructor, void* arguments, int count);
typedef JsObject* (*StaticFunctionCallback)(void* handle, void* arguments, int count);
typedef JsObject* (*InstanceFunctionCallback)(void* caller, void* handle, const char* name, void* arguments, int count);

typedef JsObject* (*StaticPropertyGetter)(void* handle);
typedef void (*StaticPropertySetter)(void* handle, void* value);

typedef JsObject* (*InstancePropertyGetter)(void* caller, void* handle, const char* name);
typedef void (*InstancePropertySetter)(void* caller, void* handle, const char* name, void* value);

typedef char* (*OnReadStringFromFile)(const char* filename);
