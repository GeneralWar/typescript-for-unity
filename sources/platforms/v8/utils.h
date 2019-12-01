#include "header.h"
#include "core/Base.h"
#pragma once

using namespace v8;

Isolate* GetIsolate(Base* base);
Isolate* GetIsolate(void* environment);
Local<Template> GetTemplate(Base* base);
Local<Template> GetParentTemplate(Base* base);

Local<Object> CreateGlobalObject(Isolate* isolate, const char* name);

unsigned long long ValueToUInt64(const Local<Value>& value);

bool ValueToBoolean(Local<Value>& value);
double ValueToDouble(Local<Value>& value);

char* ReturnStringToCSharp(const char* value);
char* ReturnStringToCSharp(const std::string& value);
char* ReturnStringToCSharp(Isolate* isolate, const Local<Value>& value);

void ArrayRemove(Isolate* isolate, Local<Array>& array, const char* value);
int ArrayGetLength(Isolate* isolate, Local<Value>& array);

std::string GetCustomType(const Local<Object>& value);
std::string GetObjectType(const Local<Object>& value);

std::vector<std::string> GetObjectPropertyNames(const Local<Object>& target);