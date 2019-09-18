#include "core/class/Class.h"
#include "delegates.h"
#include "defines.h"
#include "../../utils.h"
#include "core/function/Function.h"
#include "core/property/Property.h"
#include "core/function/Parameters.h"

extern ConstructorCallback sConstructorCallback;

extern void onConstructorCall(const FunctionCallbackInfo<Value>& info);
extern void onStaticFunctionCall(const FunctionCallbackInfo<Value>& info);
extern void onStaticPropertyGetterCall(const FunctionCallbackInfo<Value>& info);
extern void onStaticPropertySetterCall(const FunctionCallbackInfo<Value>& info);

void TypescriptClass::bind()
{
	Isolate* isolate = GetIsolate(this);
	if (!isolate) return;

	Base::Bind();
	Local<ObjectTemplate> self = GetTemplate(this).As<ObjectTemplate>();
	self->Set(String::NewFromUtf8(isolate, "apply"), FunctionTemplate::New(isolate));
	if (mHasConstructor)
	{
		self->SetCallAsFunctionHandler(onConstructorCall, BigInt::NewFromUnsigned(isolate, (unsigned long long)this));
	}
	self->Set(String::NewFromUtf8(isolate, UNITY_INSTANCE_IS_TYPE), String::NewFromUtf8(isolate, mFullname.c_str()));
}

int TypescriptClass::CreateInstance(const FunctionCallbackInfo<Value>& info)
{
	Parameters parameters(info);
	return sConstructorCallback(this, parameters.address(), parameters.count());
}
