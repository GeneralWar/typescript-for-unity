#include "Environment.h"
#include "core/class/Class.h"
#include "core/function/Function.h"
#include "core/namespace/Namespace.h"
#include "extra/require/require.h"
#include "extra/console/console.h"

Environment* Environment::sInstance = nullptr;

std::vector<std::string> Environment::sSuperClassNames;

Environment::Environment() : mIsRunning(false)
{
	sInstance = this;
}

Environment* Environment::GetInstance()
{
	return sInstance;
}

void Environment::AppendCustomSuperClassName(const char* fullname)
{
    const std::string name = fullname;
    auto iterator = std::find(sSuperClassNames.begin(), sSuperClassNames.end(), name);
    if (sSuperClassNames.end() == iterator)
    {
        sSuperClassNames.push_back(name);
    }
}

bool Environment::IsCustomSuperClassName(const char *fullname)
{
    return IsCustomSuperClassName(std::string(fullname));
}

bool Environment::IsCustomSuperClassName(const std::string& fullname)
{
    auto iterator = std::find(sSuperClassNames.begin(), sSuperClassNames.end(), fullname);
    return sSuperClassNames.end() != iterator;
}

void Environment::release()
{
	//for (auto instance : mNamespaces)
	//{
	//	delete instance;
	//}
	//for (auto instance : mClasses)
	//{
	//	delete instance;
	//}
	//for (auto instance : mFunctions)
	//{
	//	delete instance;
	//}
	mClasses.clear();
	mFunctions.clear();
	mNamespaces.clear();

	Require::Release();
	Console::Release();
}

void Environment::bindExtra()
{
	Require::Initialize(this);
	Require::Bind();
	Console::Initialize(this);
	Console::Bind();
}

void* Environment::DeclareNamespace(const char* name)
{
	std::shared_ptr<TypescriptNamespace> instance = std::shared_ptr<TypescriptNamespace>(new TypescriptNamespace(name, this));
    mNamespaces.push_back(instance);
	return instance.get();
}

void* Environment::DeclareClass(const char* name, const char* base)
{
	std::shared_ptr<TypescriptClass> instance = std::shared_ptr<TypescriptClass>(new TypescriptClass(name, base, this));
    mClasses.push_back(instance);
	return instance.get();
}

void* Environment::BindStaticFunction(const char* name)
{
	std::shared_ptr<TypescriptStaticFunction> instance = std::shared_ptr<TypescriptStaticFunction>(new TypescriptStaticFunction(name, this));
	mFunctions.push_back(instance);
	return instance.get();
}

