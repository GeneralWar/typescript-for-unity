//
//  utils.h
//  typescript
//
//  Created by 朱嘉灵 on 2018/11/22.
//  Copyright © 2018年 朱嘉灵. All rights reserved.
//

#ifndef utils_h
#define utils_h

#include <string>
#include <JavaScriptCore/JavaScriptCore.h>
#include "core/Base.h"

JSContextRef GetContext(Base* base);
JSContextRef GetContext(void* environment);

JSValueRef GetValue(Base* base);
JSValueRef GetParentValue(Base* base);

std::string JSValue_To_String(JSContextRef context, JSValueRef value);

std::string JSString_To_String(JSStringRef value);

unsigned long long JSValue_To_Uint64(JSContextRef context, JSValueRef value);

double JSValue_To_Number(JSContextRef context, JSValueRef value);

bool JSValue_To_Boolean(JSContextRef context, JSValueRef value);

char* ReturnStringToCSharp(const char* content);
char* ReturnStringToCSharp(const std::string& content);
char* ReturnStringToCSharp(JSStringRef content);
char* ReturnStringToCSharp(JSContextRef context, JSValueRef content);

void SetValueProperty(JSContextRef context, JSValueRef target, const char* name, JSValueRef property);
void SetObjectProperty(JSContextRef context, JSObjectRef target, const char* name, JSValueRef property);

void SetValuePropertyWithString(JSContextRef context, JSValueRef target, const char* name, const char* property);
void SetObjectPropertyWithString(JSContextRef context, JSObjectRef target, const char* name, const char* property);

void SetValuePropertyWithInt(JSContextRef context, JSValueRef target, const char* name, int property);
void SetObjectPropertyWithInt(JSContextRef context, JSObjectRef target, const char* name, int property);

void SetValuePropertyWithLong(JSContextRef context, JSValueRef target, const char* name, long int property);
void SetObjectPropertyWithLong(JSContextRef context, JSObjectRef target, const char* name, long int property);

void SetValuePropertyWithBoolean(JSContextRef context, JSValueRef target, const char* name, bool property);
void SetObjectPropertyWithBoolean(JSContextRef context, JSObjectRef target, const char* name, bool property);

JSValueRef GetValueProperty(JSContextRef context, JSValueRef target, const char* name);
JSValueRef GetValueProperty(JSContextRef context, JSValueRef target, const int& index);
JSValueRef GetObjectProperty(JSContextRef context, JSObjectRef target, const char* name);
JSValueRef GetObjectProperty(JSContextRef context, JSObjectRef target, const int& index);

std::string GetValuePropertyWithString(JSContextRef context, JSValueRef target, const char* name);
std::string GetObjectPropertyWithString(JSContextRef context, JSObjectRef target, const char* name);

bool IsValueValid(JSContextRef context, JSValueRef handle);
bool IsObjectValid(JSContextRef context, JSValueRef handle);

std::string GetCustomType(JSContextRef context, JSObjectRef object);
std::string GetCustomType(JSContextRef context, JSValueRef object);

int GetValueType(JSContextRef context, JSValueRef value);

int ArrayGetLength(JSContextRef context, JSValueRef value);

JSValueRef BindProperty(JSContextRef context, JSValueRef instance, const char* name, JSObjectCallAsFunctionCallback getter, JSObjectCallAsFunctionCallback setter, void* data);
JSValueRef BindProperty(JSContextRef context, JSObjectRef instance, const char* name, JSObjectCallAsFunctionCallback getter, JSObjectCallAsFunctionCallback setter, void* data);

#endif /* utils_h */
