//
//  object.h
//  typescript
//
//  Created by 朱嘉灵 on 2018/11/30.
//  Copyright © 2018年 朱嘉灵. All rights reserved.
//

#ifndef object_h
#define object_h

#include <JavaScriptCore/JavaScriptCore.h>

#ifndef LOCAL_INSTANCE_TYPE
#define LOCAL_INSTANCE_TYPE "local_instance_type"
#endif

#ifndef UNITY_INSTANCE_ID
#define UNITY_INSTANCE_ID "unity_instance_id"
#endif

#ifndef UNITY_INSTANCE_HANDLE
#define UNITY_INSTANCE_HANDLE "unity_instance_handle"
#endif

#ifndef UNITY_INSTANCE_INSTANTIATED
#define UNITY_INSTANCE_INSTANTIATED "unity_instance_instantiated"
#endif

#ifndef UNITY_INSTANCE_FIELD
#define UNITY_INSTANCE_FIELD "unity_instance_field"
#endif

#ifndef UNITY_INSTANCE_FIELD_SIZE
#define UNITY_INSTANCE_FIELD_SIZE "unity_instance_field_size"
#endif

#ifndef UNITY_INSTANCE_TYPE
#define UNITY_INSTANCE_TYPE "unity_instance_type"
#endif

#ifndef UNITY_INSTANCE_IS_TYPE
#define UNITY_INSTANCE_IS_TYPE "unity_instance_is_type"
#endif

#ifndef UNITY_INSTANCE_CUSTOM_TYPE
#define UNITY_INSTANCE_CUSTOM_TYPE "unity_instance_custom_type"
#endif

void object_initialize(JSContextRef context);

JSObjectRef CreateObject(JSContextRef context);
JSObjectRef CreateObject(JSContextRef context, const char* type, void* handle);
JSObjectRef CreateObject(JSContextRef context, const char* type, void* field, int size);

JSValueRef CreateValue(JSContextRef context);
JSValueRef CreateValue(JSContextRef context, const char* type, void* handle);
JSValueRef CreateValue(JSContextRef context, const char* type, void* field, int size);

void* GetObjectHandle(JSContextRef context, JSValueRef value);
void* GetObjectField(JSContextRef context, JSValueRef value);

JSObjectRef CreateGlobalObject(JSContextRef context, const char* name);

void MakePersistent(JSContextRef context, JSValueRef value);
JSValueRef GetPersistent(JSContextRef context, void* handle);

void ReleaseHandle(JSContextRef context, void* handle);
void ReleaseMemory(JSContextRef context, void* handles[], int size);

#endif /* object_h */
