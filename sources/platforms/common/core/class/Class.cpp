#include "Class.h"
#include "delegates.h"
#include "defines.h"
#include "core/namespace/Namespace.h"
#include "core/function/Function.h"
#include "core/function/Constructor.h"
#include "core/property/Property.h"
#include "../../extra/log/Log.h"
#include "../enum/Enum.h"

std::map<std::string, TypescriptClass*> TypescriptClass::sClasses;

TypescriptClass* TypescriptClass::GetClass(const std::string& name)
{
	auto result = sClasses.find(name);
	return sClasses.end() == result ? nullptr : result->second;
}

void TypescriptClass::Derive()
{
	for (auto pair : sClasses)
	{
		TypescriptClass* instance = pair.second;
		if (instance->isBaseClass())
		{
			instance->derive();
		}
	}
}

TypescriptClass::TypescriptClass(const std::string& name, const std::string& base, Environment* environment) : Base(name, environment), mHasConstructor(false), mBaseClassName(base)
{
	sClasses[mFullname] = this;
}

TypescriptClass::TypescriptClass(const std::string& name, const std::string& base, Base* space) : Base(name, space), mHasConstructor(false), mBaseClassName(base)
{
	sClasses[mFullname] = this;
}

TypescriptClass::TypescriptClass(const std::string& name, Environment* environment) : TypescriptClass(name, "", environment) { }

TypescriptClass::TypescriptClass(const std::string& name, Base* space) : TypescriptClass(name, "", space) { }

TypescriptClass::~TypescriptClass()
{
	auto result = sClasses.find(mFullname);
	if (sClasses.end() != result)
	{
		sClasses.erase(result);
	}
	//for (auto pair : mStaticFunctions)
	//{
	//	delete pair.second;
	//}
	mNestedClasses.clear();
	mStaticFunctions.clear();
}

std::shared_ptr<TypescriptStaticFunction> TypescriptClass::BindStaticFunction(const std::string& name)
{
    return mStaticFunctions[name] = std::shared_ptr<TypescriptStaticFunction>(new TypescriptStaticFunction(name, this));
}

void TypescriptClass::BindStaticFunction(const std::string& name, JS_FUNCTION_CALLBACK_TYPE callback)
{
    mStaticFunctions[name] = std::shared_ptr<TypescriptStaticFunction>(new TypescriptStaticFunction(name, this, (JS_FUNCTION_CALLBACK_TYPE)callback));
}

std::shared_ptr<TypescriptStaticProperty> TypescriptClass::BindStaticProperty(const std::string& name, const bool& hasGetter, const bool& hasSetter)
{
	return mStaticProperties[name] = std::shared_ptr<TypescriptStaticProperty>(new TypescriptStaticProperty(name, this, hasGetter, hasSetter));
}

void TypescriptClass::BindConstructor(const bool& real)
{
	mHasConstructor = real;
}

void TypescriptClass::Bind()
{
	if (mBaseClassName.size())
	{
		mBaseClass = TypescriptClass::GetClass(mBaseClassName);
		if (mBaseClass)
		{
			mBaseClass->derive(this);
		}
	}
	this->bind();
	for (auto pair : mStaticFunctions)
	{
		pair.second->Bind();
	}
	for (auto pair : mStaticProperties)
	{
		pair.second->Bind();
	}
	for (auto pair : mNestedClasses)
	{
		pair.second->Bind();
	}
}

void TypescriptClass::derive(TypescriptClass* instance)
{
	mDerivedClasses.push_back(instance);
}

void TypescriptClass::derive()
{
	for (TypescriptClass* instance : mDerivedClasses)
	{
		instance->deriveFromParent(this);
		instance->derive();
	}
}

void TypescriptClass::deriveFromParent(TypescriptClass* base)
{
    if (base)
    {
        for (auto pair : base->mStaticFunctions)
        {
            pair.second->Bind(this);
            mStaticFunctions[pair.first] = pair.second;
        }

        for (auto pair : base->mStaticProperties)
        {
            pair.second->Bind(this);
            mStaticProperties[pair.first] = pair.second;
        }
    }
}

Base* TypescriptClass::DeclareClass(const std::string& name)
{
	std::shared_ptr<TypescriptClass> child = nullptr;
	if (mNestedClasses.end() == mNestedClasses.find(name))
	{
		child = std::shared_ptr<TypescriptClass>(new TypescriptClass(name, this));
		mNestedClasses[name] = child;
	}
	else
	{
		LogError("There is already a class called %s!", name.c_str());
	}
	return child.get();
}

Base* TypescriptClass::DeclareEnum(const std::string& name)
{
	std::shared_ptr<TypescriptEnum> child = nullptr;
	if (mNestedClasses.end() == mNestedClasses.find(name))
	{
		child = std::shared_ptr<TypescriptEnum>(new TypescriptEnum(name, this));
		mNestedClasses[name] = child;
	}
	else
	{
		LogError("There is already a enum called %s!", name.c_str());
	}
	return child.get();
}
