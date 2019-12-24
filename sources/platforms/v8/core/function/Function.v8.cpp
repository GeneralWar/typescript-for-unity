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
	EnvironmentV8* runtime = reinterpret_cast<EnvironmentV8*>(mEnvironment);
	Isolate* isolate = runtime->GetIsolate();
	// static binding
	if (mReference)
	{
		delete mReference;
		Local<FunctionTemplate> functionTemplate = FunctionTemplate::New(isolate, mCallback, BigInt::NewFromUnsigned(isolate, (unsigned long long)this));
		mReference = new ReferenceWindows(functionTemplate);
		this->BindToParent(parent);
	}
	// dynamic binding
	else if (runtime->IsRunning())
	{
		HandleScope handleScope(isolate);
		Local<Context> context = isolate->GetCurrentContext();
		MaybeLocal<Function> maybeFunction = Function::New(context, mCallback, BigInt::NewFromUnsigned(isolate, (unsigned long long)this));
		mJsObject.Reset(isolate, maybeFunction.ToLocalChecked());
		this->BindToParent(parent);
	}
}

int TypescriptStaticFunction::Invoke(const FunctionCallbackInfo<Value>& info)
{
	Parameters parameters(info);
	return sStaticFunctionCallback(this, parameters.address(), parameters.count());
}
