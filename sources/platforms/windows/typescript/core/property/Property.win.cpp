#include "core/property/Property.h"
#include "../../utils.h"

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
	if (mReference)
	{
		this->BindToParent(parent);
	}
}
