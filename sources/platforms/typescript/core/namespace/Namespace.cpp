#include "Namespace.h"
#include "../../extra/log/Log.h"
#include "../class/Class.h"
#include "../enum/Enum.h"

ASSIGN_BASE_CHILD_TYPE(TypescriptNamespace, BaseChildTypes::BaseChildType_Namespace);

TypescriptNamespace* TypescriptNamespace::Create(const std::string& name, Base* parent)
{
	return Base::Create<TypescriptNamespace>(name, parent);
}

TypescriptNamespace::TypescriptNamespace(const std::string& name, Base* parent) : Base(TYPE, name, parent) { }

TypescriptNamespace::~TypescriptNamespace() { }

TypescriptNamespace* TypescriptNamespace::DeclareNamespace(const std::string& name)
{
	TypescriptNamespace* instance = nullptr;
	if (mNamespaces.end() == mNamespaces.find(name))
	{
		instance = TypescriptNamespace::Create(name, this);
		mNamespaces[name] = instance;
		instance->Bind();
	}
	else
	{
		LogError("There is already an namespace called %s!", name.c_str());
	}
	return instance;
}

TypescriptClass* TypescriptNamespace::DeclareClass(const std::string& name, const std::string& base, const bool& hasConstructor, const bool& isStatic)
{
	TypescriptClass* instance = nullptr;
	if (mClasses.end() == mClasses.find(name))
	{
		instance = TypescriptClass::Create(name, base, hasConstructor, isStatic, this);
		mClasses[name] = instance;
        instance->Bind();
	}
	else
	{
		LogError("There is already a class called %s!", name.c_str());
	}
	return instance;
}

TypescriptEnum* TypescriptNamespace::DeclareEnum(const std::string& name)
{
	TypescriptEnum* instance = nullptr;
	if (mEnums.end() == mEnums.find(name))
	{
		instance = TypescriptEnum::Create(name, this);
		mEnums[name] = instance;
		instance->Bind();
	}
	else
	{
		LogError("There is already a enum called %s!", name.c_str());
	}
	return instance;
}
