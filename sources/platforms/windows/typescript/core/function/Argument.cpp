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

Local<Value> Argument::Deserialize(Isolate* isolate, unsigned char*& buffer)
{
	Local<Value> value;
	short type = *(short*)buffer;
	buffer += 2;
	short size = *(short*)buffer;
	buffer += 2;
	switch (type)
	{
	case TYPE_Boolean:
		value = Boolean::New(isolate, *(bool*)buffer);
		break;
	case TYPE_SByte:
		value = Integer::New(isolate, (int)*(char*)buffer);
		break;
	case TYPE_Byte:
		value = Integer::New(isolate, (int)*(unsigned char*)buffer);
		break;
	case TYPE_Int16:
		value = Integer::New(isolate, (int)*(short*)buffer);
		break;
	case TYPE_UInt16:
		value = Integer::New(isolate, (int)*(unsigned short*)buffer);
		break;
	case TYPE_Int32:
		value = Integer::New(isolate, *(int*)buffer);
		break;
	case TYPE_UInt32:
		value = Integer::NewFromUnsigned(isolate, *(unsigned int*)buffer);
		break;
	case TYPE_Int64:
		value = BigInt::New(isolate, *(long long*)buffer);
		break;
	case TYPE_UInt64:
		value = BigInt::NewFromUnsigned(isolate, *(unsigned long long*)buffer);
		break;
	case TYPE_Single:
		value = Number::New(isolate, (double)*(float*)buffer);
		break;
	case TYPE_Double:
		value = Number::New(isolate, *(double*)buffer);
		break;
	case TYPE_String:
		value = String::NewFromUtf8(isolate, (char*)buffer);
		break;
	}
	buffer += size;
	return value;
}
