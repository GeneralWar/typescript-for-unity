#include <map>
#include "../Base.h"
#include "delegates.h"
#pragma once

class Constructor;
class TypescriptStaticFunction;
class TypescriptStaticProperty;

class TypescriptEnum : public Base
{
private:
	std::map<std::string, long int> mValues;
public:
	TypescriptEnum(const std::string& name, Environment* environment);
	TypescriptEnum(const std::string& name, Base* space);

	~TypescriptEnum();
public:
	void SetValue(const char* name, const long int& value);

	virtual void Bind() override; // depends platform
};
