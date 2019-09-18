#include "Enum.h"
#include "delegates.h"
#include "core/namespace/Namespace.h"
#include "core/function/Function.h"

TypescriptEnum::TypescriptEnum(const std::string& name, Environment* environment) : Base(name, environment) { }

TypescriptEnum::TypescriptEnum(const std::string& name, Base* space) : Base(name, space) { }

TypescriptEnum::~TypescriptEnum() { }

void TypescriptEnum::SetValue(const char* name, const long int& value)
{
	mValues[name] = value;
}
