#include "Class.h"
#include "delegates.h"
#include "defines.h"
#include "core/namespace/Namespace.h"
#include "core/function/Function.h"
#include "core/property/Property.h"
#include "extra/log/Log.h"
#include "core/enum/Enum.h"
#include "core/Environment.h"
#include "core/object/Object.h"
#include "core/function/Parameters.h"
#include "Utils.h"

extern DEFINE_JS_FUNCTION_CALLBACK(onStaticFunctionCall);
extern DEFINE_JS_FUNCTION_CALLBACK(onStaticPropertyGetterCall);
extern DEFINE_JS_FUNCTION_CALLBACK(onStaticPropertySetterCall);

extern ConstructorCallback sConstructorCallback;

ASSIGN_BASE_CHILD_TYPE(TypescriptClass, BaseChildTypes::BaseChildType_Class);

std::map<std::string, TypescriptClass*> TypescriptClass::sClasses;

void TypescriptClass::Clear()
{
	sClasses.clear();
}

TypescriptClass* TypescriptClass::FindClass(const std::string& name)
{
	auto result = sClasses.find(name);
	return sClasses.end() == result ? nullptr : result->second;
}

TypescriptClass* TypescriptClass::FindBaseClass(const std::string& name)
{
	size_t index = name.find_last_of('.');
	if (std::string::npos == index)
	{
		return nullptr;
	}
	std::string basename = name.substr(0, index);
	TypescriptClass* instance = FindClass(basename);
	if (!instance)
	{
		instance = FindBaseClass(basename);
	}
	return instance;
}

//TypescriptClass* TypescriptClass::Create(const std::string& name, const std::string& base, bool hasConstructor, Base* space)
//{
//	auto instance = Base::Create<TypescriptClass>(name, base, hasConstructor, space);
//	sClasses[instance->GetFullname()] = instance;
//	return instance;
//}

TypescriptClass* TypescriptClass::Create(const std::string& name, const std::string& base, bool hasConstructor, bool isStatic, Base* space)
{
	TypescriptClass* instance = Base::Create<TypescriptClass>(name, base, hasConstructor, isStatic, space);
	sClasses[instance->GetFullname()] = instance;
	return instance;
}

TypescriptClass::TypescriptClass(const std::string& name, const std::string& base, bool hasConstructor, bool isStatic, Base* parent) : Base(TYPE, name, parent),
#ifdef USE_ENGINE_JSC
    mJsClass(),
#endif
    mHasConstructor(hasConstructor), mBaseClassName(base), mBaseClass(), mPrototype(), mIsStatic(isStatic) { }

TypescriptClass::~TypescriptClass()
{
	auto result = sClasses.find(mFullname);
	if (sClasses.end() != result)
	{
		sClasses.erase(result);
	}
}

void TypescriptClass::Bind()
{
    if (mIsStatic)
    {
        this->bind();
		this->bindInformation();
		this->bindNativeInstance();
        mJsObject->BindTo(mName, mParent ? mParent->GetJsObject() : nullptr);
    }
}

void TypescriptClass::inherit(JsObject* constructor, JsObject* prototype)
{
	if (constructor)
	{
        for (auto instance : mStaticFunctions)
        {
            instance.second->BindTo(constructor);
        }
        for (auto instance : mStaticProperties)
        {
            instance.second->BindTo(constructor);
        }
    }
    if (prototype)
    {
        for (auto instance : mInstanceFunctions)
        {
            instance.second->BindTo(prototype);
        }
        for (auto instance : mInstanceProperties)
        {
            instance.second->BindTo(prototype);
        }
	}
}

void TypescriptClass::implement(JsObject* constructor, JsObject* prototype)
{
	assert(constructor && prototype);

	SAFE_CALL(mBaseClass, ->implement(constructor, prototype));
	for (auto pair : mInstanceFunctions)
	{
		prototype->Set(pair.first, pair.second->GetJsObject());
	}
	for (auto pair : mStaticFunctions)
	{
		JsObject* object = pair.second->GetJsObject();
		constructor->Set(pair.first, object);
	}
	for (auto pair : mInstanceProperties)
	{
		TypescriptProperty* property = pair.second;
		prototype->DefineProperty(property->GetName(), property);
	}
	for (auto pair : mStaticProperties)
	{
		TypescriptProperty* property = pair.second;
		constructor->DefineProperty(property->GetName(), property);
	}
}

TypescriptStaticFunction* TypescriptClass::BindStaticFunction(const std::string& name)
{
	TypescriptStaticFunction* instance = TypescriptStaticFunction::Create(name, this);
	mStaticFunctions[name] = instance;
	instance->Bind();
	return instance;
}

void TypescriptClass::BindStaticFunction(const std::string& name, JS_FUNCTION_CALLBACK_TYPE callback)
{
	TypescriptStaticFunction* instance = TypescriptStaticFunction::Create(name, this, (JS_FUNCTION_CALLBACK_TYPE)callback);
	mStaticFunctions[name] = instance;
	instance->Bind();
}

TypescriptInstanceFunction* TypescriptClass::BindInstanceFunction(const std::string& name)
{
	TypescriptInstanceFunction* instance = TypescriptInstanceFunction::Create(name, this);
	mInstanceFunctions[name] = instance;
	instance->Bind();
	return instance;
}

TypescriptStaticProperty* TypescriptClass::BindStaticProperty(const std::string& name, const bool& hasGetter, const bool& hasSetter)
{
	TypescriptStaticProperty* instance = TypescriptStaticProperty::Create(name, this, hasGetter, hasSetter);
	mStaticProperties[name] = instance;
	return instance;
}

TypescriptInstanceProperty* TypescriptClass::BindInstanceProperty(const std::string& name, const bool& hasGetter, const bool& hasSetter)
{
	TypescriptInstanceProperty* instance = TypescriptInstanceProperty::Create(name, this, hasGetter, hasSetter);
	mInstanceProperties[name] = instance;
	return instance;
}

TypescriptClass* TypescriptClass::getBaseClass()
{
	if (nullptr == mBaseClass && !mBaseClassName.empty())
	{
		mBaseClass = FindClass(mBaseClassName);
	}
	return mBaseClass;
}

TypescriptClass* TypescriptClass::DeclareClass(const std::string& name, const std::string& base, const bool& hasConstructor, const bool& isStatic)
{
	TypescriptClass* instance = nullptr;
	auto iterator = mNestedClasses.find(name);
	if (mNestedClasses.end() == iterator)
	{
		instance = TypescriptClass::Create(name, base, hasConstructor, isStatic, this);
		mNestedClasses[name] = instance;
		instance->Bind();
	}
	else
	{
		LogError("There is already a class called %s!", name.c_str());
		instance = dynamic_cast<TypescriptClass*>(iterator->second);
	}
	return instance;
}

TypescriptEnum* TypescriptClass::DeclareEnum(const std::string& name)
{
	TypescriptEnum* instance = nullptr;
	auto iterator = mNestedClasses.find(name);
	if (mNestedClasses.end() == iterator)
	{
		instance = TypescriptEnum::Create(name, this);
		mNestedClasses[name] = instance;
		instance->Bind();
	}
	else
	{
		LogError("There is already a enum called %s!", name.c_str());
		instance = dynamic_cast<TypescriptEnum*>(iterator->second);
	}
	return instance;
}

JsObject* TypescriptClass::CreateInstance(JS_CONTEXT_TYPE isolate, const std::string& type)
{
	return TypescriptClass::CreateInstance(isolate, type, -1);
}

JsObject* TypescriptClass::CreateInstance(JS_CONTEXT_TYPE isolate, const std::string& type, const size_t& size)
{
	if (!isolate) return nullptr;

	JsObject* instance = Instantiate(isolate, type, size);
	instance->Set(UNITY_INSTANCE_TYPE, type);
//    TypescriptClass* typeInstance = FindClass(type);
//    if (typeInstance)
//    {
//        typeInstance->Instantiate(instance);
//    }
	return instance;
}

JsObject* TypescriptClass::CreateInstance(JS_PARAMETERS)
{
#if USE_ENGINE_V8
	Parameters parameters(info);
#else
    Parameters parameters(arguments, argumentCount);
#endif
	JsObject* instance = sConstructorCallback(this, parameters.address(), parameters.count());
    assert(instance->GetTarget() == this);
	return instance;
}

void TypescriptClass::Instantiate(JsObject* target)
{
	if (!target) return;

	TypescriptClass* baseClass = this->getBaseClass();
	if (baseClass)
	{
		baseClass->Instantiate(target);
	}
	for (auto iterator : mInstanceFunctions)
	{
		iterator.second->BindTo(target);
	}
	for (auto iterator : mInstanceProperties)
	{
		iterator.second->BindTo(target);
	}
}

void TypescriptClass::bindInformation()
{
    mJsObject->Set(NAME, mName);
    mJsObject->Set(FULLNAME, mFullname);
    mJsObject->MakePersistent();
}

bool TypescriptClass::IsOrSubClassOf(Base *target)
{
    TypescriptClass* targetType = TypescriptClass::Convert(target);
    if (!targetType) return false;
    TypescriptClass* parentType = this;
    while (parentType)
    {
        if (parentType == targetType) return true;
        parentType = parentType->mBaseClass;
    }
    return false;
}

/*static*/ TypescriptClass* TypescriptClass::Derive(TypescriptClass *baseType, const std::string &fullname, const JS_OBJECT_TYPE constructor)
{
    std::string name = fullname.substr(baseType->GetFullname().size() + 1);
    TypescriptClass* instance = new TypescriptClass(name, baseType->GetFullname(), true, false, baseType);
    instance->mJsObject = JsObject::Create(instance->GET_JS_CONTEXT_FUNCTION(), instance, constructor);
    instance->bindInformation();
    instance->bindNativeInstance();
    instance->mBaseClass = baseType;
#if USE_ENGINE_V8
	Isolate* isolate = instance->GetIsolate();
	Local<Object> prototype = JsObject::GetObject(isolate, constructor, PROTOTYPE);
	JsObject::Set(isolate, prototype, JS_INSTANCE_HANDLE, (Local<Value>)Undefined(isolate));
	//instance->mPrototype = JsObject::Create(isolate, instance, prototype);
#endif
    assert(instance->GetFullname() == fullname);
    return sClasses[fullname] = instance;
}
