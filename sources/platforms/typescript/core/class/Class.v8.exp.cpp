#include "core/class/Class.h"
#include "defines.h"
#include "delegates.h"
#include "core/class/Class.exp.h"
#include "core/function/Function.h"
#include "core/property/Property.h"
#include "utils.h"
#include "core/function/Parameters.h"
#include "extra/log/Log.h"
#include "core/object/Object.h"

extern ConstructorCallback sConstructorCallback;
extern StaticFunctionCallback sStaticFunctionCallback;
extern InstanceFunctionCallback sInstanceFunctionCallback;

extern StaticPropertyGetter sStaticPropertyGetter;
extern StaticPropertySetter sStaticPropertySetter;
extern InstancePropertyGetter sInstancePropertyGetter;
extern InstancePropertySetter sInstancePropertySetter;

void check_function_result(const FunctionCallbackInfo<Value>& info, JsObject* result)
{
	if (result)
	{
		info.GetReturnValue().Set(result->GetValue());
	}
	else
	{
		info.GetReturnValue().Set(Undefined(info.GetIsolate()));
	}
}

void check_function_result(const FunctionCallbackInfo<Value>& info, void* handle)
{
	check_function_result(info, JsObject::Find(handle));
}

static unsigned long long pick_static_caller(const FunctionCallbackInfo<Value>& info)
{
	return JsObject::ToUint64(info.GetIsolate(), info.Data());
}

void onConstructorCall(const FunctionCallbackInfo<Value>& info)
{
	TypescriptClass* instance = TypescriptClass::Convert((void*)pick_static_caller(info));
	if (instance)
	{
		Isolate* isolate = info.GetIsolate();
		HandleScope scope(isolate);

		JsObject* object = instance->HasConstructor() ? instance->CreateInstance(info) : JsObject::Instantiate(isolate, instance->GetPrototype());
		if (object)
		{
			instance->Instantiate(JsObject::Create(isolate, nullptr, object->GetObject()));
		}
		check_function_result(info, object);
	}
	else
	{
		LogError("Try to call constructor function, but there is no binding!");
	}
}

void onStaticFunctionCall(const FunctionCallbackInfo<Value>& info)
{
	TypescriptFunction* instance = TypescriptStaticFunction::Convert((void*)pick_static_caller(info));
	if (instance)
	{
		check_function_result(info, instance->Invoke(info));
	}
	else
	{
		LogError("Try to call static function, but there is no binding!");
	}
}

struct InstanceData
{
	JsObject* caller;
	Base* instance;
};

static InstanceData pick_instance_data(const FunctionCallbackInfo<Value>& info)
{
	JsObject* caller = JsObject::Create(info.GetIsolate(), nullptr, info.This());
	Base* instance = Base::Convert(JsObject::ToHandle(info.GetIsolate(), info.Data()));
	return { caller, instance };
}

void onInstanceFunctionCall(const FunctionCallbackInfo<Value>& info)
{
	Isolate* isolate = info.GetIsolate();
	HandleScope scope(isolate);

	InstanceData data = pick_instance_data(info);
	Parameters parameters(info);
	check_function_result(info, sInstanceFunctionCallback(data.caller, data.instance, data.instance ? data.instance->GetName().c_str() : nullptr, parameters.address(), parameters.count()));
}

void onStaticPropertyGetterCall(const FunctionCallbackInfo<Value>& info)
{
	TypescriptProperty* instance = TypescriptStaticProperty::Convert((void*)pick_static_caller(info));
	if (instance)
	{
		Isolate* isolate = info.GetIsolate();
		HandleScope scope(isolate);

		check_function_result(info, sStaticPropertyGetter(instance));
	}
}

void onStaticPropertySetterCall(const FunctionCallbackInfo<Value>& info)
{
	TypescriptProperty* instance = TypescriptInstanceProperty::Convert((void*)pick_static_caller(info));
	if (instance)
	{
		Parameters parameters(info);
		Isolate* isolate = info.GetIsolate();
		HandleScope scope(isolate);

		sStaticPropertySetter(instance, &parameters);
	}
}

void onInstancePropertyGetterCall(const FunctionCallbackInfo<Value>& info)
{
	Isolate* isolate = info.GetIsolate();
	HandleScope scope(isolate);

	InstanceData data = pick_instance_data(info);
	check_function_result(info, sInstancePropertyGetter(data.caller, data.instance, data.instance ? data.instance->GetName().c_str() : nullptr));
}

void onInstancePropertySetterCall(const FunctionCallbackInfo<Value>& info)
{
	Isolate* isolate = info.GetIsolate();
	HandleScope scope(isolate);

	InstanceData data = pick_instance_data(info);
	Parameters parameters(info);
	sInstancePropertySetter(data.caller, data.instance, data.instance ? data.instance->GetName().c_str() : nullptr, &parameters);
}