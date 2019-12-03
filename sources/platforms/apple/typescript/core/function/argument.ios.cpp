//
//  argument.ios.cpp
//  typescript
//
//  Created by 朱嘉灵 on 2019/1/16.
//  Copyright © 2019 朱嘉灵. All rights reserved.
//

#include "core/function/Argument.h"

#define TYPE_Boolean 0
#define TYPE_SByte 1
#define TYPE_Byte 2
#define TYPE_Int16 3
#define TYPE_UInt16 4
#define TYPE_Int32 5
#define TYPE_UInt32 6
#define TYPE_Int64 7
#define TYPE_UInt64 8
#define TYPE_Single 9
#define TYPE_Double 10
#define TYPE_String 11

JSValueRef Argument::Deserialize(JSContextRef context, unsigned char*& buffer)
{
    JSValueRef value = nullptr;
    short type = *(short*)buffer;
    buffer += 2;
    short size = *(short*)buffer;
    buffer += 2;
    switch (type)
    {
        case TYPE_Boolean:
            value = JSValueMakeBoolean(context, *(bool*)buffer);
            break;
        case TYPE_SByte:
            value = JSValueMakeNumber(context, (double)*(char*)buffer);
            break;
        case TYPE_Byte:
            value = JSValueMakeNumber(context, (double)*(unsigned char*)buffer);
            break;
        case TYPE_Int16:
            value = JSValueMakeNumber(context, (double)*(short*)buffer);
            break;
        case TYPE_UInt16:
            value = JSValueMakeNumber(context, (double)*(unsigned short*)buffer);
            break;
        case TYPE_Int32:
            value = JSValueMakeNumber(context, (double)*(int*)buffer);
            break;
        case TYPE_UInt32:
            value = JSValueMakeNumber(context, (double)*(unsigned int*)buffer);
            break;
        case TYPE_Int64:
            value = JSValueMakeNumber(context, (double)*(long long*)buffer);
            break;
        case TYPE_UInt64:
            value = JSValueMakeNumber(context, (double)*(unsigned long long*)buffer);
            break;
        case TYPE_Single:
            value = JSValueMakeNumber(context, (double)*(float*)buffer);
            break;
        case TYPE_Double:
            value = JSValueMakeNumber(context, *(double*)buffer);
            break;
        case TYPE_String:
        {
            char* temp = new char[size + 1];
            memset(temp, 0, size + 1);
            memcpy(buffer, temp, size);
            JSStringRef string = JSStringCreateWithUTF8CString(temp);
            value = JSValueMakeString(context, string);
            JSStringRelease(string);
            delete[] temp;
        }
            break;
    }
    buffer += size;
    return value;
}
