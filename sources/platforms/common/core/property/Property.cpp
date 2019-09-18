#include "Property.h"

std::map<unsigned long long, TypescriptStaticProperty*> TypescriptStaticProperty::sInstances;

TypescriptStaticProperty* TypescriptStaticProperty::GetInstance(const unsigned long long& handle)
{
	auto result = sInstances.find(handle);
	return sInstances.end() == result ? nullptr : result->second;
}

TypescriptStaticProperty::TypescriptStaticProperty(const std::string& name, Base* parent, const bool& hasGetter, const bool& hasSetter) : Base(name, parent), mHasGetter(hasGetter), mHasSetter(hasSetter)
{
	sInstances[(unsigned long long)this] = this;
}

TypescriptStaticProperty::~TypescriptStaticProperty()
{
	auto result = sInstances.find((unsigned long long)this);
	if (sInstances.end() != result)
	{
		sInstances.erase(result);
	}
}