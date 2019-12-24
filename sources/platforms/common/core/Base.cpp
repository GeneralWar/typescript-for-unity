#include "Base.h"
#include "Environment.h"

std::map<std::string, Base*> Base::sInstances;

Base* Base::GetInstance(const std::string& name)
{
	auto result = sInstances.find(name);
	return sInstances.end() == result ? nullptr : result->second;
}

Base::Base(Environment* environment, const std::string& name, Base* parent) : mEnvironment(environment), mName(name), mParent(parent), mFullname(parent ? parent->GetFullname() + "." + name : name), mReference(), mJsObject()
{
	sInstances[mFullname] = this;
	if (parent)
	{
		parent->mChildren[mName] = this;
	}
}

Base::Base(const std::string& name, Base* parent) : Base(parent->GetEnvironment(), name, parent)
{
	assert(parent);
}

Base::Base(const std::string& name, Environment* environment) :Base(environment, name, nullptr) { }
