#include "core/class/Class.h"
#include "core/class/Class.exp.h"
#include "defines.h"
#include "delegates.h"
#include "core/function/Function.h"
#include "core/property/Property.h"
#include "../../utils.h"
#include "../Object.win.h"
#include "core/function/Parameters.h"
#include "extra/log/Log.h"
#include "core/function/Constructor.h"

extern ConstructorCallback sConstructorCallback;
extern StaticFunctionCallback sStaticFunctionCallback;
extern InstanceFunctionCallback sInstanceFunctionCallback;

extern StaticPropertyGetter sStaticPropertyGetter;
extern StaticPropertySetter sStaticPropertySetter;
extern InstancePropertyGetter sInstancePropertyGetter;
extern InstancePropertySetter sInstancePropertySetter;

void check_function_result(int index, const FunctionCallbackInfo<Value>& info)
{
	if (index > -1)
	{
		//Local<Value> value = GetReturnValue(info.GetIsolate(), index);
		//Isolate* isolate = info.GetIsolate();
		//Local<Object> global = isolate->GetCurrentContext()->Global();
		//global->Set(BigInt::New(isolate, (long int)&index), value);
		//info.GetReturnValue().Set(value);
		info.GetReturnValue().Set(GetReturnValue(info.GetIsolate(), index));
		ReleaseReturnValue(index);
	}
}

static unsigned long long pick_static_caller(const FunctionCallbackInfo<Value>& info)
{
	Isolate* isolate = info.GetIsolate();
	Local<Context> context = isolate->GetCurrentContext();
	return ValueToUInt64(info.Data());
}

void onConstructorCall(const FunctionCallbackInfo<Value>& info)
{
	TypescriptClass* instance = reinterpret_cast<TypescriptClass*>(pick_static_caller(info));
	if (instance)
	{
		check_function_result(instance->CreateInstance(info), info);
	}
	else
	{
		LogError("Try to call constructor function, but there is no binding!");
	}
}

void onStaticFunctionCall(const FunctionCallbackInfo<Value>& info)
{
	TypescriptStaticFunction* instance = TypescriptStaticFunction::GetInstance(pick_static_caller(info));
	if (instance)
	{
		check_function_result(instance->Invoke(info), info);
	}
	else
	{
		LogError("Try to call static function, but there is no binding!");
	}
}

static int pick_instance_caller(const FunctionCallbackInfo<Value>& info)
{
	return RegisterCaller(info.GetIsolate(), info.This());
}

void onInstanceFunctionCall(const FunctionCallbackInfo<Value>& info)
{
	int index = pick_instance_caller(info);
	Parameters parameters(info);
	Isolate* isolate = info.GetIsolate();
	String::Utf8Value property(isolate, info.Data().As<Object>()->Get(String::NewFromUtf8(isolate, PROPERTY_KEY)));
	check_function_result(sInstanceFunctionCallback(index, *property, parameters.address(), parameters.count()), info);
}

void onStaticPropertyGetterCall(const FunctionCallbackInfo<Value>& info)
{
	TypescriptStaticProperty* instance = TypescriptStaticProperty::GetInstance(pick_static_caller(info));
	if (instance)
	{
		check_function_result(sStaticPropertyGetter(instance), info);
	}
}

void onStaticPropertySetterCall(const FunctionCallbackInfo<Value>& info)
{
	TypescriptStaticProperty* instance = TypescriptStaticProperty::GetInstance(pick_static_caller(info));
	if (instance)
	{
		Parameters parameters(info);
		Isolate* isolate = info.GetIsolate();
		sStaticPropertySetter(instance, &parameters);
	}
}

void onInstancePropertyGetterCall(const FunctionCallbackInfo<Value>& info)
{
	int index = pick_instance_caller(info);
	Isolate* isolate = info.GetIsolate();
	String::Utf8Value property(isolate, info.Data().As<Object>()->Get(String::NewFromUtf8(isolate, PROPERTY_KEY)));
	check_function_result(sInstancePropertyGetter(index, *property), info);
}

void onInstancePropertySetterCall(const FunctionCallbackInfo<Value>& info)
{
	int index = pick_instance_caller(info);
	Parameters parameters(info);
	Isolate* isolate = info.GetIsolate();
	String::Utf8Value property(isolate, info.Data().As<Object>()->Get(String::NewFromUtf8(isolate, PROPERTY_KEY)));
	sInstancePropertySetter(index, *property, &parameters);
}