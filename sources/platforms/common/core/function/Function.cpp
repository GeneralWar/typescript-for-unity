#include "Function.h"
#include "delegates.h"
#include "core/function/Parameters.h"

#ifdef __APPLE__
extern JSValueRef onStaticFunctionCall (JSContextRef context, JSObjectRef function, JSObjectRef thisObject, size_t argumentCount, const JSValueRef arguments[], JSValueRef* exception);
#else
extern void onStaticFunctionCall(const FunctionCallbackInfo<Value>& info);
#endif

std::map<unsigned long long, TypescriptStaticFunction*> TypescriptStaticFunction::sInstances;

TypescriptStaticFunction* TypescriptStaticFunction::GetInstance(const unsigned long long& handle)
{
	auto result = sInstances.find(handle);
	return sInstances.end() == result ? nullptr : result->second;
}

TypescriptStaticFunction::TypescriptStaticFunction(const std::string& name, Environment* environment) : TypescriptStaticFunction(name, environment, onStaticFunctionCall) { }

TypescriptStaticFunction::TypescriptStaticFunction(const std::string& name, Environment* environment, JS_FUNCTION_CALLBACK_TYPE callback) : Base(name, environment), mCallback(callback)
{
	sInstances[(unsigned long long)this] = this;
}

TypescriptStaticFunction::TypescriptStaticFunction(const std::string& name, Base* parent) : TypescriptStaticFunction(name, parent, onStaticFunctionCall) { }

TypescriptStaticFunction::TypescriptStaticFunction(const std::string& name, Base* parent, JS_FUNCTION_CALLBACK_TYPE callback) : Base(name, parent), mCallback(callback)
{
	sInstances[(unsigned long long)this] = this;
}

TypescriptStaticFunction::~TypescriptStaticFunction()
{
	auto result = sInstances.find((unsigned long long)this);
	if (sInstances.end() != result)
	{
		sInstances.erase(result);
	}
}
