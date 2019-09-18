#include "../Base.h"
#include "defines.h"
#include "delegates.h"
#pragma once

class TypescriptStaticFunction : public Base
{
private:
	static std::map<unsigned long long, TypescriptStaticFunction*> sInstances;
public:
	static TypescriptStaticFunction* GetInstance(const unsigned long long& handle);
private:
	JS_FUNCTION_CALLBACK_TYPE mCallback;
public:
	TypescriptStaticFunction(const std::string& name, Environment* environment);
	TypescriptStaticFunction(const std::string& name, Environment* environment, JS_FUNCTION_CALLBACK_TYPE callback);
	TypescriptStaticFunction(const std::string& name, Base* parent);
	TypescriptStaticFunction(const std::string& name, Base* parent, JS_FUNCTION_CALLBACK_TYPE callback);

	virtual ~TypescriptStaticFunction() override;

	virtual void Bind() override; // depends platform

	void Bind(Base* parent); // depends platform

	int Invoke(JS_PARAMETERS); // depends platform
};

JS_VALUE_TYPE GetReturnValue(JS_CONTEXT_TYPE context, int index); // depends platform
void ReleaseReturnValue(int index); // depends platform

int RegisterCaller(JS_CONTEXT_TYPE context, const JS_VALUE_REFERENCE_TYPE caller); // depends platform
void ReleaseCaller(int index); // depends platform

int RegisterResultValue(JS_CONTEXT_TYPE context, const JS_VALUE_REFERENCE_TYPE value); // depends platform
//void ReleaseResultValue(int index);
