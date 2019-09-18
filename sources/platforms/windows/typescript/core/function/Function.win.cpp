#include "core/function/Function.h"
#include "delegates.h"
#include "core/function/Parameters.h"
#include "../Object.win.h"
#include "../Environment.win.h"
#include "../Reference.win.h"

extern StaticFunctionCallback sStaticFunctionCallback;

void TypescriptStaticFunction::Bind()
{
	EnvironmentWindows* runtime = reinterpret_cast<EnvironmentWindows*>(mEnvironment);
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
		EnvironmentWindows* runtime = reinterpret_cast<EnvironmentWindows*>(mEnvironment);
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
