#include <map>
#include "../Base.h"
#include "delegates.h"
#pragma once

class Constructor;
class TypescriptStaticFunction;
class TypescriptProperty;

class TypescriptEnum : public Base
{
private:
	DEFINE_BASE_CHILD_TYPE;
public:
	CONVERT_TO_BASE_CHILD(TypescriptEnum);
	CHECK_BASE_VALID_FUNCTION(TypescriptEnum);
public:
	static TypescriptEnum* Create(const std::string& name, Base* parent);
private:
	std::map<std::string, long int> mValues;
public:
	TypescriptEnum(const std::string& name, Base* space);
	~TypescriptEnum();
public:
	void SetValue(const char* name, const long int& value);
    
    virtual void Bind() override;
    
    void Register();
};
