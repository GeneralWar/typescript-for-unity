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
	self->Set(String::NewFromUtf8(isolate, APPLY), FunctionTemplate::New(isolate));
	if (mHasConstructor)
	{
		self->SetCallAsFunctionHandler(onConstructorCall, BigInt::NewFromUnsigned(isolate, (unsigned long long)this));
	}
	self->Set(String::NewFromUtf8(isolate, UNITY_INSTANCE_BINDED_TYPE), String::NewFromUtf8(isolate, mFullname.c_str()));
}

void onEmptyCall(const FunctionCallbackInfo<Value>& info)
{
	//int n = 0;
}

void TypescriptClass::bindConstructor()
{
	Isolate* isolate = GetIsolate(this);
	if (!isolate) return;
	HandleScope handleScope(isolate);
	Local<Context> context = isolate->GetCurrentContext();
	Local<Object> parent = nullptr == mParent ? context->Global() : mParent->GetJsObject();

	Local<Object> self = Function::New(context, onConstructorCall, BigInt::NewFromUnsigned(isolate, (unsigned long long)this)).ToLocalChecked();
	self->Set(String::NewFromUtf8(isolate, APPLY), Function::New(context, onEmptyCall).ToLocalChecked());
	Local<String> localName = String::NewFromUtf8(isolate, mName.c_str());
	self->Set(String::NewFromUtf8(isolate, NAME), localName);
	Local<String> localFullname = String::NewFromUtf8(isolate, mFullname.c_str());
	self->Set(String::NewFromUtf8(isolate, UNITY_INSTANCE_BINDED_TYPE), localFullname);
	self->Set(String::NewFromUtf8(isolate, FULLNAME, NewStringType::kNormal).ToLocalChecked(), localFullname);

	parent->Set(localName, self);
}

void TypescriptClass::inherit()
{
	TypescriptClass* parentClass = GetClass(mBaseClassName);
	if (nullptr == parentClass)
	{
		return;
	}
	Isolate* isolate = GetIsolate(this);
	HandleScope handleScope(isolate);
	Local<Context> context = isolate->GetCurrentContext();

	Local<Object> self = this->GetJsObject();
	Local<Object> parent = parentClass->GetJsObject();
	MaybeLocal<Array> maybeArray = parent->GetOwnPropertyNames(context);
	if (maybeArray.IsEmpty())
	{
		return;
	}
	Local<Array> array = maybeArray.ToLocalChecked();
	for (int i = array->Length() - 1; i >= 0; --i)
	{
		Local<Value> key = array->Get(i);
		if (self->Has(context, key).FromMaybe(false))
		{
			continue;
		}
		self->Set(context, key, parent->Get(key));
	}
}

int TypescriptClass::CreateInstance(const FunctionCallbackInfo<Value>& info)
{
	Parameters parameters(info);
	return sConstructorCallback(this, parameters.address(), parameters.count());
}
