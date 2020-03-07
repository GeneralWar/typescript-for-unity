#include "../Base.h"
#pragma once

class JsObject;

class TypescriptProperty : public Base
{
private:
	DEFINE_BASE_CHILD_TYPE;
protected:
	bool mHasGetter;
	bool mHasSetter;
public:
	TypescriptProperty(const BaseChildTypes& type, const std::string& name, Base* parent, const bool& hasGetter, const bool& hasSetter);
	virtual ~TypescriptProperty() override;
    
    bool HasGetter() const { return mHasGetter; }
    bool HasSetter() const { return mHasSetter; }

	virtual void bind() override;

	virtual void BindTo(JsObject* target) = 0;
};

class TypescriptStaticProperty : public TypescriptProperty
{
private:
	DEFINE_BASE_CHILD_TYPE;
public:
	CONVERT_TO_BASE_CHILD(TypescriptStaticProperty);
	CHECK_BASE_VALID_FUNCTION(TypescriptStaticProperty);
public:
	static TypescriptStaticProperty* Create(const std::string& name, Base* parent, const bool& hasGetter, const bool& hasSetter);
public:
	TypescriptStaticProperty(const std::string& name, Base* parent, const bool& hasGetter, const bool& hasSetter);
	virtual void BindTo(JsObject* target) override;
};

class TypescriptInstanceProperty : public TypescriptProperty
{
private:
	DEFINE_BASE_CHILD_TYPE;
public:
	CONVERT_TO_BASE_CHILD(TypescriptInstanceProperty);
	CHECK_BASE_VALID_FUNCTION(TypescriptInstanceProperty);
public:
	static TypescriptInstanceProperty* Create(const std::string& name, Base* parent, const bool& hasGetter, const bool& hasSetter);
public:
	TypescriptInstanceProperty(const std::string& name, Base* parent, const bool& hasGetter, const bool& hasSetter);
	virtual void BindTo(JsObject* target) override;
};
