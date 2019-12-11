#include "core/function/Function.h"
#include "delegates.h"
#include "core/function/Parameters.h"
#include "../Object.v8.h"
#include "../Environment.v8.h"
#include "../Reference.v8.h"

extern StaticFunctionCallback sStaticFunctionCallback;

void TypescriptStaticFunction::Bind()
{
	EnvironmentV8* runtime = reinterpret_cast<EnvironmentV8*>(mEnvironment);
	Isolate* isolate = runtime->GetIsolate();
	Local<FunctionTemplate> functionTemplate = FunctionTemplate::New(isolate, mCallback, BigInt::NewFromUnsigned(isolate, (unsigned long long)this));
	mReference = new ReferenceWindows(functionTemplate);
	this->BindToParent();
}

void TypescriptStaticFunction::Bind(Base* parent)
{
	if (mReference)
	{
		delete mReference;
		EnvironmentV8* runtime = reinterpret_cast<EnvironmentV8*>(mEnvironment);
		Isolate* isolate = runtime->GetIsolate();
		Local<FunctionTemplate> functionTemplate = FunctionTemplate::New(isolate, mCallback, BigInt::NewFromUnsigned(isolate, (unsigned long long)this));
		mReference = new ReferenceWindows(functionTemplate);
		this->BindToParent(parent);
	}
}

int TypescriptStaticFunction::Invoke(const FunctionCallbackInfo<Value>& info)
{
	Parameters parameters(info);
	return sStaticFunctionCallback(this, parameters.address(), parameters.count());
}
