#include "Base.h"
#include "Environment.h"

std::map<std::string, Base*> Base::sInstances;

Base* Base::GetInstance(const std::string& name)
{
	auto result = sInstances.find(name);
	return sInstances.end() == result ? nullptr : result->second;
}

Base::Base(const std::string& name, Base* parent) : mName(name), mFullname(parent ? parent->GetFullname() + "." + name : name), mParent(parent), mEnvironment(parent ? parent->GetEnvironment() : nullptr), mReference(nullptr)
{
	sInstances[mFullname] = this;
    if (parent)
    {
        parent->mChildren[mName] = this;
    }
}

Base::Base(const std::string& name, Environment* isolate) : mName(name), mFullname(name), mParent(nullptr), mEnvironment(isolate), mReference(nullptr)
{
	sInstances[mFullname] = this;
}

Base::~Base()
{
	//if (mParent)
	//{
	//	mParent->Remove(this);
	//}
}
