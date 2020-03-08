#include "core/function/Parameters.h"
#include "extra/log/Log.h"
#include "utils.h"
#include "core/JSTypes.h"
#include "core/function/Parameters.exp.h"
#include "core/Environment.h"
#include "core/object/Object.h"

Local<Value> get_parameter(void* pointer, const int& index)
{
	Parameters* parameters = reinterpret_cast<Parameters*>(pointer);
	return parameters ? parameters->Get(index) : Local<Value>();
}

int General_Typescript_Parameter_GetType(Environment* runtime, void* pointer, int index)
{
	Local<Value> value = get_parameter(pointer, index);
	if (value.IsEmpty()) return TYPE_NULL;

	if (value->IsString())
	{
		return TYPE_STRING;
	}
	if (value->IsBoolean())
	{
		return TYPE_BOOLEAN;
	}
	if (value->IsNumber() || value->IsBigInt())
	{
		return TYPE_NUMBER;
	}
	if (value->IsObject())
	{
		if (value->IsArray())
		{
			return TYPE_ARRAY;
		}
		Local<Object> object = value.As<Object>();
		if (object->IsConstructor())
		{
			return TYPE_CONSTRUCTOR;
		}
		if (object->IsFunction())
		{
			return TYPE_FUNCTION;
		}
		return TYPE_OBJECT;
	}
	if (value->IsUndefined())
	{
		return TYPE_UNDEFINED;
	}
	if (value->IsNull())
	{
		return TYPE_NULL;
	}

	if (!runtime) return TYPE_UNKNOWN;
	Isolate* isolate = runtime->GetIsolate();
	if (!isolate) return TYPE_UNKNOWN;

	String::Utf8Value typeString(isolate, value->TypeOf(isolate));
	const char* type = *typeString;
	LogError("Try to get unknown type : %s!", type);
	return TYPE_UNKNOWN;
}

char* General_Typescript_Parameter_GetTypeName(Environment* runtime, void* pointer, int index)
{
	if (!runtime) return ReturnStringToCSharp("");
	Isolate* isolate = runtime->GetIsolate();
	if (!isolate) return ReturnStringToCSharp("");

	Local<Value> value = get_parameter(pointer, index);
	if (value.IsEmpty()) return ReturnStringToCSharp("");

	const std::string type = GetObjectType(isolate, value.As<Object>());
	DEBUG_LOG("Get parameter type for %d : %s\n", index, type.c_str());
	return ReturnStringToCSharp(type);
}

void* General_Typescript_Parameter_GetHandle(Environment* runtime, void* pointer, int index)
{
	if (!runtime) return nullptr;
	Isolate* isolate = runtime->GetIsolate();
	if (!isolate) return nullptr;

	Local<Value> value = get_parameter(pointer, index);
	if (value.IsEmpty()) return nullptr;

	Local<Object> object = value.As<Object>();
	return JsObject::Convert(isolate, object);
}

void* General_Typescript_Parameter_GetField(Environment* runtime, void* pointer, int index)
{
	if (!runtime) return nullptr;
	Isolate* isolate = runtime->GetIsolate();
	if (!isolate) return nullptr;

	Local<Value> value = get_parameter(pointer, index);
	if (value.IsEmpty()) return nullptr;

	Local<Object> object = value.As<Object>();
	JsObject* instance = JsObject::Convert(isolate, object);
	return instance ? instance->GetInstanceField() : nullptr;
}

bool General_Typescript_Parameter_ToBoolean(Environment* runtime, void* pointer, int index)
{
	if (!runtime) return false;
	Isolate* isolate = runtime->GetIsolate();
	if (!isolate) return false;

	Local<Value> value = get_parameter(pointer, index);
	return JsObject::ToBoolean(isolate, value);
}

double General_Typescript_Parameter_ToNumber(Environment* runtime, void* pointer, int index)
{
	if (!runtime) return 0;
	Isolate* isolate = runtime->GetIsolate();
	if (!isolate) return .0;

	Local<Value> value = get_parameter(pointer, index);
	return JsObject::ToDouble(isolate, value);
}

char* General_Typescript_Parameter_ToString(Environment* runtime, void* pointer, int index)
{
	if (!runtime) return ReturnStringToCSharp("");
	Isolate* isolate = runtime->GetIsolate();
	if (!isolate) return ReturnStringToCSharp("");

	Local<Value> value = get_parameter(pointer, index);
	return ReturnStringToCSharp(isolate, value);
}

int General_Typescript_Parameter_GetArrayLength(Environment* runtime, void* pointer, int index)
{
	if (!runtime) return -1;
	Isolate* isolate = runtime->GetIsolate();
	if (!isolate) return -1;

	Local<Value> value = get_parameter(pointer, index);
	return ArrayGetLength(isolate, value);
}

char* General_Typescript_Parameter_GetArrayString(Environment* runtime, void* pointer, int index, int elementIndex)
{
	if (!runtime) return ReturnStringToCSharp("");
	Isolate* isolate = runtime->GetIsolate();
	if (!isolate) return ReturnStringToCSharp("");

	Local<Value> value = get_parameter(pointer, index);
	if (value->IsArray())
	{
		return ReturnStringToCSharp(isolate, value.As<Array>()->Get(elementIndex));
	}
	return ReturnStringToCSharp("");
}

//template<typename T> void* convert_to_array<T>(

void* General_Typescript_Parameter_ToArray(Environment* runtime, void* pointer, int index, int type, int subType)
{
	if (!runtime) return ReturnStringToCSharp("");
	Isolate* isolate = runtime->GetIsolate();
	if (!isolate) return ReturnStringToCSharp("");

	Local<Value> value = get_parameter(pointer, index);
	if (value->IsArray())
	{
		Local<Array> localArray = value.As<Array>();
		int length = localArray->Length();
		if (TYPE_BOOLEAN == type)
		{
			char* buffer = new char[sizeof(int) + length];
			memcpy(buffer, &length, sizeof(int));
			char* p = buffer + sizeof(int);
			for (int i = 0; i < length; ++i, ++p)
			{
				*p = localArray->Get(i)->BooleanValue(isolate);
			}
			return buffer;
		}
		else if (TYPE_NUMBER == type)
		{
			Local<Context> context = isolate->GetCurrentContext();
			if (TYPE_NUMBER_BYTE == subType)
			{
				char* buffer = new char[sizeof(int) + sizeof(unsigned char) * length];
				memcpy(buffer, &length, sizeof(int));
				unsigned* p = (unsigned*)(buffer + sizeof(int));
				for (int i = 0; i < length; ++i, ++p)
				{
					Maybe<int> maybe = localArray->Get(i)->Int32Value(context);
					*p = (unsigned char)(maybe.IsNothing() ? 0 : maybe.ToChecked());
				}
				return buffer;
			}
			else if (TYPE_NUMBER_SBYTE == subType)
			{
				char* buffer = new char[sizeof(int) + sizeof(char) * length];
				memcpy(buffer, &length, sizeof(int));
				char* p = (char*)(buffer + sizeof(int));
				for (int i = 0; i < length; ++i, ++p)
				{
					Maybe<int> maybe = localArray->Get(i)->Int32Value(context);
					*p = (char)(maybe.IsNothing() ? 0 : maybe.ToChecked());
				}
				return buffer;
			}
			else if (TYPE_NUMBER_INT16 == subType)
			{
				char* buffer = new char[sizeof(int) + sizeof(short) * length];
				memcpy(buffer, &length, sizeof(int));
				short* p = (short*)(buffer + sizeof(int));
				for (int i = 0; i < length; ++i, ++p)
				{
					Maybe<int> maybe = localArray->Get(i)->Int32Value(context);
					*p = (short)(maybe.IsNothing() ? 0 : maybe.ToChecked());
				}
				return buffer;
			}
			else if (TYPE_NUMBER_UINT16 == subType)
			{
				char* buffer = new char[sizeof(int) + sizeof(unsigned short) * length];
				memcpy(buffer, &length, sizeof(int));
				unsigned* p = (unsigned*)(buffer + sizeof(int));
				for (int i = 0; i < length; ++i, ++p)
				{
					Maybe<int> maybe = localArray->Get(i)->Int32Value(context);
					*p = (unsigned short)(maybe.IsNothing() ? 0 : maybe.ToChecked());
				}
				return buffer;
			}
			else if (TYPE_NUMBER_INT32 == subType)
			{
				char* buffer = new char[sizeof(int) + sizeof(int) * length];
				memcpy(buffer, &length, sizeof(int));
				int* p = (int*)(buffer + sizeof(int));
				for (int i = 0; i < length; ++i, ++p)
				{
					Maybe<int> maybe = localArray->Get(i)->Int32Value(context);
					*p = (int)(maybe.IsNothing() ? 0 : maybe.ToChecked());
				}
				return buffer;
			}
			else if (TYPE_NUMBER_UINT32 == subType)
			{
				char* buffer = new char[sizeof(int) + sizeof(unsigned int) * length];
				memcpy(buffer, &length, sizeof(int));
				unsigned* p = (unsigned*)(buffer + sizeof(int));
				for (int i = 0; i < length; ++i, ++p)
				{
					Maybe<int> maybe = localArray->Get(i)->Int32Value(context);
					*p = (unsigned int)(maybe.IsNothing() ? 0 : maybe.ToChecked());
				}
				return buffer;
			}
			else if (TYPE_NUMBER_INT64 == subType)
			{
				char* buffer = new char[sizeof(int) + sizeof(long int) * length];
				memcpy(buffer, &length, sizeof(int));
				long* p = (long*)(buffer + sizeof(int));
				for (int i = 0; i < length; ++i, ++p)
				{
					Local<Value> value = localArray->Get(i);
					if (value->IsBigInt())
					{
						*p = (long int)(value->ToBigInt(context).ToLocalChecked()->Int64Value());
					}
					else
					{
						Maybe<int> maybe = localArray->Get(i)->Int32Value(context);
						*p = (long int)(maybe.IsNothing() ? 0 : maybe.ToChecked());
					}
				}
				return buffer;
			}
			else if (TYPE_NUMBER_UINT64 == subType)
			{
				char* buffer = new char[sizeof(int) + sizeof(unsigned long int) * length];
				memcpy(buffer, &length, sizeof(int));
				unsigned* p = (unsigned*)(buffer + sizeof(int));
				for (int i = 0; i < length; ++i, ++p)
				{
					Local<Value> value = localArray->Get(i);
					if (value->IsBigInt())
					{
						*p = (unsigned long int)(value->ToBigInt(context).ToLocalChecked()->Uint64Value());
					}
					else
					{
						Maybe<int> maybe = localArray->Get(i)->Int32Value(context);
						*p = (unsigned long int)(maybe.IsNothing() ? 0 : maybe.ToChecked());
					}
				}
				return buffer;
			}
			else if (TYPE_NUMBER_SINGLE == subType)
			{
				char* buffer = new char[sizeof(int) + sizeof(float) * length];
				memcpy(buffer, &length, sizeof(int));
				float* p = (float*)(buffer + sizeof(int));
				for (int i = 0; i < length; ++i, ++p)
				{
					Maybe<double> maybe = localArray->Get(i)->NumberValue(context);
					*p = (float)(maybe.IsNothing() ? 0 : maybe.ToChecked());
				}
				return buffer;
			}
			else if (TYPE_NUMBER_DOUBLE == subType)
			{
				char* buffer = new char[sizeof(int) + sizeof(double) * length];
				memcpy(buffer, &length, sizeof(int));
				double* p = (double*)(buffer + sizeof(int));
				for (int i = 0; i < length; ++i, ++p)
				{
					Maybe<double> maybe = localArray->Get(i)->NumberValue(context);
					*p = (double)(maybe.IsNothing() ? 0 : maybe.ToChecked());
				}
				return buffer;
			}
		}
	}
	return nullptr;
}

void* General_Typescript_Parameter_ToFunction(Environment* runtime, void* pointer, int index)
{
	if (!runtime) return nullptr;
	Isolate* isolate = runtime->GetIsolate();
	if (!isolate) return nullptr;

	Local<Value> value = get_parameter(pointer, index);
	return value->IsFunction() ? JsObject::Create(isolate, nullptr, value.As<Object>()) : nullptr;
}