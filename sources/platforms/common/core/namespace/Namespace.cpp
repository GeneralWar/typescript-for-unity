#include "Namespace.h"
#include "../../extra/log/Log.h"
#include "../class/Class.h"
#include "../enum/Enum.h"

TypescriptNamespace::TypescriptNamespace(const std::string& name, Environment* environment) : Base(name, environment) { }

TypescriptNamespace::TypescriptNamespace(const std::string& name, TypescriptNamespace* parent) : Base(name, parent){ }

TypescriptNamespace::~TypescriptNamespace()
{
	//for (std::pair<std::string, std::shared_ptr<TypescriptNamespace>> pair : mNamespaces)
	//{
	//	delete pair.second;
	//}
	//for (std::pair<std::string, std::shared_ptr<TypescriptClass>> pair : mClasses)
	//{
	//	delete pair.second;
	//}
	//for (std::pair<std::string, TypescriptEnum*> pair : mEnums)
	//{
	//	delete pair.second;
	//}
	mNamespaces.clear();
	mClasses.clear();
	mEnums.clear();
}

std::shared_ptr<TypescriptNamespace> TypescriptNamespace::DeclareNamespace(const std::string& name)
{
	std::shared_ptr<TypescriptNamespace> child = nullptr;
	if (mNamespaces.end() == mNamespaces.find(name))
	{
		child = std::shared_ptr<TypescriptNamespace>(new TypescriptNamespace(name, this));
		mNamespaces[name] = child;
	}
	else
	{
		LogError("There is already an namespace called %s!", name.c_str());
	}
	return child;
}

std::shared_ptr<TypescriptClass> TypescriptNamespace::DeclareClass(const std::string& name, const std::string& base)
{
	std::shared_ptr<TypescriptClass> child = nullptr;
	if (mClasses.end() == mClasses.find(name))
	{
		child = std::shared_ptr<TypescriptClass>(new TypescriptClass(name, base, this));
		mClasses[name] = child;
	}
	else
	{
		LogError("There is already a class called %s!", name.c_str());
	}
	return child;
}

std::shared_ptr<TypescriptEnum> TypescriptNamespace::DeclareEnum(const std::string& name)
{
	std::shared_ptr<TypescriptEnum> child = nullptr;
	if (mEnums.end() == mEnums.find(name))
	{
		child = std::shared_ptr<TypescriptEnum>(new TypescriptEnum(name, this));
		mEnums[name] = child;
	}
	else
	{
		LogError("There is already a enum called %s!", name.c_str());
	}
	return child;
}

void TypescriptNamespace::Bind()
{
	Base::Bind();
    for (auto pair : mEnums)
    {
        pair.second->Bind();
    }
	for (auto pair : mClasses)
	{
		pair.second->Bind();
	}
    for (auto pair : mNamespaces)
    {
        pair.second->Bind();
    }
}

