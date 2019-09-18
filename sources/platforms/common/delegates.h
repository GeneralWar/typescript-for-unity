#pragma once

typedef void(*OnIsolate)(void* isolate);
typedef void(*OnStringChange)(const char* value);

typedef int(*ConstructorCallback)(void* constructor, void* arguments, int count);
typedef int(*StaticFunctionCallback)(void* handle, void* arguments, int count);
typedef int(*InstanceFunctionCallback)(int index, const char* name, void* arguments, int count);

typedef int(*StaticPropertyGetter)(void* handle);
typedef void(*StaticPropertySetter)(void* handle, void* value);
typedef int(*InstancePropertyGetter)(int index, const char* name);
typedef void(*InstancePropertySetter)(int index, const char* name, void* value);

typedef char*(*OnReadStringFromFile)(const char* filename);
