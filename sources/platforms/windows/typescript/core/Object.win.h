#include "header.h"
#pragma once
using namespace v8;

void object_initialize(Isolate* isolate);
void object_finalize(Isolate* isolate);

Local<Object> CreateObject(Isolate* isolate, const char*type, void* handle);
Local<Object> CreateObject(Isolate* isolate, const char*type, void* handle, int size);

void* GetObjectHandle(Isolate*isolate, const Local<Value>& local);
void* GetObjectHandle(Isolate*isolate, const Local<Object>& local);

void* GetObjectField(Isolate*isolate, const Local<Value>& local);
void* GetObjectField(Isolate*isolate, const Local<Object>& local);

void MakePersistent(Isolate* isolate, const Local<Object>& local);
Local<Object> GetPersistent(Isolate* isolate, void* handle);

void ReleaseHandle(unsigned long long& handle);
void ReleaseHandles(unsigned long long* handles, const int& size);