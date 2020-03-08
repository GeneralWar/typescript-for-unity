#pragma once
#include "header.h"
#include "core/Base.h"

char* ReturnStringToCSharp(const char* value);
char* ReturnStringToCSharp(const std::string& value);
char* ReturnStringToCSharp(JS_CONTEXT_TYPE isolate, const JS_VALUE_TYPE value);

void ArrayRemove(JS_CONTEXT_TYPE isolate, const JS_ARRAY_TYPE array, const char* value);
int ArrayGetLength(JS_CONTEXT_TYPE isolate, const JS_VALUE_TYPE array);

std::string GetCustomType(JS_CONTEXT_TYPE isolate, const JS_OBJECT_TYPE value);
std::string GetObjectType(JS_CONTEXT_TYPE isolate, const JS_OBJECT_TYPE value);
std::string GetSafeType(const char* origin);

std::vector<std::string> GetObjectPropertyNames(const JS_OBJECT_TYPE target);

template <typename K, typename V> std::vector<V> MapToVector(const std::map<K, V>& map)
{
	std::vector<V> collection(map.size());
	for (typename std::map<K, V>::const_iterator iterator = map.begin(); map.end() != iterator; ++iterator)
	{
		collection.push_back(iterator->second);
	}
	return collection;
}
