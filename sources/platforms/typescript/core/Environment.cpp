#include "Environment.h"
#include "core/class/Class.h"
#include "core/function/Function.h"
#include "core/namespace/Namespace.h"
#include "Utils.h"
#include "core/object/Object.h"

Environment* Environment::sInstance = nullptr;

std::vector<std::string> Environment::sSuperClassNames;

Environment* Environment::Create()
{
    if (!sInstance)
    {
        sInstance = new Environment;
    }
    return sInstance;
}

Environment::Environment() : Base(BaseChildTypes::BaseChildType_Environment, "", nullptr), mIsRunning(false)
{

}

Environment::~Environment() 
{
	this->release();
}

void Environment::Release(void* handle)
{
    Environment* runtime = reinterpret_cast<Environment*>(handle);
    delete runtime;
    sInstance = nullptr;
}

void Environment::release()
{
	mClasses.clear();
	mFunctions.clear();
	mNamespaces.clear();

	if (INTERNAL_JS_CONTEXT_NAME)
	{
		INTERNAL_JS_CONTEXT_NAME = nullptr;
	}
}

bool Environment::Initialize()
{
    if (this->initialize())
    {
        return true;
    }
    return false;
}

JsObject* Environment::CreateGlobalObject(JS_CONTEXT_TYPE context, const char* name)
{
    JsObject* object = JsObject::Create(context, nullptr);
    mJsObject->Set(name, object);
    return object;
}

std::string Environment::ExecuteString(const char* sourceContent)
{
	return this->execute(sourceContent);
}

void* Environment::Require(const char* sourceContent, const char* filename)
{
	throw std::logic_error("The method or operation is not implemented.");
}

TypescriptNamespace* Environment::DeclareNamespace(const char* name)
{
	TypescriptNamespace* instance = TypescriptNamespace::Create(name, this);
	mNamespaces.push_back(instance);
	instance->Bind();
	return instance;
}

TypescriptClass* Environment::DeclareClass(const char* name, const char* base, const bool& hasConstructor, const bool& isStatic)
{
	TypescriptClass* instance = TypescriptClass::Create(name, base, hasConstructor, isStatic, this);
	mClasses.push_back(instance);
	instance->Bind();
	return instance;
}

TypescriptStaticFunction* Environment::BindStaticFunction(const char* name)
{
	TypescriptStaticFunction* instance = TypescriptStaticFunction::Create(name, this);
	mFunctions.push_back(instance);
	instance->Bind();
	return instance;
}

