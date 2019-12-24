#include "core/property/Property.h"
#include "../../utils.h"
#include "../Environment.v8.h"
#include "extra/log/Log.h"

extern void onStaticPropertyGetterCall(const FunctionCallbackInfo<Value>& info);
extern void onStaticPropertySetterCall(const FunctionCallbackInfo<Value>& info);

void TypescriptStaticProperty::Bind()
{
	Isolate* isolate = GetIsolate(this);
	if (!isolate) return;

	auto instance = BigInt::NewFromUnsigned(isolate, (unsigned long long)this);
	auto parent = GetTemplate(mParent);
	parent->SetAccessorProperty(String::NewFromUtf8(isolate, mName.c_str()), mHasGetter ? FunctionTemplate::New(isolate, onStaticPropertyGetterCall, instance) : Local<FunctionTemplate>(),
		mHasSetter ? FunctionTemplate::New(isolate, onStaticPropertySetterCall, instance) : Local<FunctionTemplate>());
}

void TypescriptStaticProperty::Bind(Base* parent)
{
	EnvironmentV8* runtime = reinterpret_cast<EnvironmentV8*>(mEnvironment);
	Isolate* isolate = runtime->GetIsolate();
	// static binding
	if (mReference)
	{
		this->BindToParent(parent);
	}
	// dynamic binding
	else if (mEnvironment->IsRunning())
	{
		HandleScope handleScope(isolate);
		Local<Context> context = isolate->GetCurrentContext();
		auto instance = BigInt::NewFromUnsigned(isolate, (unsigned long long)this);
		Local<Object> parentObject = nullptr == mParent ? Local<Object>() : mParent->GetJsObject();
		if (parentObject.IsEmpty())
		{
			LogError("Try to bind static property [%s] dynamically, but there is no js object for parent!", mName.c_str());
			return;
		}
		parentObject->SetAccessorProperty(String::NewFromUtf8(isolate, mName.c_str()), mHasGetter ? Function::New(context, onStaticPropertyGetterCall, instance).ToLocalChecked() : Local<Function>(),
			mHasSetter ? Function::New(context, onStaticPropertySetterCall, instance).ToLocalChecked() : Local<Function>());
	}
}
