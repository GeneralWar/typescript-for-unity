#include "../Base.h"
#include "defines.h"
#include "delegates.h"
#pragma once

class JsObject;

class TypescriptFunction : public Base
{
private:
	DEFINE_BASE_CHILD_TYPE;
protected:
	JS_FUNCTION_CALLBACK_TYPE mCallback;
public:
	TypescriptFunction(const BaseChildTypes& type, const std::string& name, Base* parent, JS_FUNCTION_CALLBACK_TYPE callback);
	virtual ~TypescriptFunction() override;

	virtual void bind() override;

	void BindTo(JsObject* target); 

	virtual JsObject* Invoke(JS_PARAMETERS) = 0;
};

/////////////////////////////////////////////////////////////////////////

class TypescriptStaticFunction : public TypescriptFunction
{
private:
	DEFINE_BASE_CHILD_TYPE;
public:
	CONVERT_TO_BASE_CHILD(TypescriptStaticFunction);
	CHECK_BASE_VALID_FUNCTION(TypescriptStaticFunction);
public:
	static TypescriptStaticFunction* Create(const std::string& name, Base* parent, JS_FUNCTION_CALLBACK_TYPE callback = nullptr);
public:
	TypescriptStaticFunction(const std::string& name, Base* parent, JS_FUNCTION_CALLBACK_TYPE callback);
	virtual ~TypescriptStaticFunction();

	virtual JsObject* Invoke(JS_PARAMETERS) override; 
};

/////////////////////////////////////////////////////////////////////////
class TypescriptInstanceFunction : public TypescriptFunction
{
private:
	DEFINE_BASE_CHILD_TYPE;
public:
	CONVERT_TO_BASE_CHILD(TypescriptInstanceFunction);
	CHECK_BASE_VALID_FUNCTION(TypescriptInstanceFunction);
public:
	static TypescriptInstanceFunction* Create(const std::string& name, Base* parent, JS_FUNCTION_CALLBACK_TYPE callback = nullptr);
public:
	TypescriptInstanceFunction(const std::string& name, Base* parent, JS_FUNCTION_CALLBACK_TYPE callback);
	virtual ~TypescriptInstanceFunction() override;

	virtual void Bind() override;

	virtual JsObject* Invoke(JS_PARAMETERS) override; 
};