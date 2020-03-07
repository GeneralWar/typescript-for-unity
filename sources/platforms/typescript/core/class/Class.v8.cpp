#include "core/class/Class.h"
#include "defines.h"
#include "utils.h"
#include "core/object/Object.h"
#include "core/function/Function.h"
#include "core/property/Property.h"
#include "core/Environment.h"

extern DEFINE_JS_CONSTRUCTOR_CALLBACK(onConstructorCall);

/*static*/ void TypescriptClass::CheckConstructors(Isolate *isolate, const Local<Value> value)
{
	if (!value->IsObject())
		return;

	Local<Object> object = value.As<Object>();
	Local<Array> properties = object->GetOwnPropertyNames(isolate->GetCurrentContext()).ToLocalChecked();
	for (int i = (int)properties->Length() - 1; i >= 0; --i)
	{
		Local<Value> key = properties->Get(i);
		Local<Object> property = object->Get(key).As<Object>();
		if (property.IsEmpty())
		{
			continue;
		}
		if (property->IsConstructor())
		{
			Local<Object> constructor = property.As<Object>();
			std::string fullname = GetCustomType(isolate, property) + "." + std::string(*String::Utf8Value(isolate, key));
			JsObject::Set(isolate, constructor, FULLNAME, fullname);
			if (fullname.empty()) continue;

			TypescriptClass* baseType = TypescriptClass::FindBaseClass(fullname);
			if (!baseType)
			{
				LogWarning("Try to declare class %s but no base type found ...", fullname.c_str());
				continue;
			}

			constructor->Set(String::NewFromUtf8(isolate, JS_INSTANCE_HANDLE), Undefined(isolate));
			TypescriptClass::Derive(baseType, fullname, constructor);
		}
		else if (property->IsObject())
		{
			CheckConstructors(isolate, property);
		}
	}
}

/*static*/ JsObject* TypescriptClass::Instantiate(Isolate *isolate, const std::string& type, const size_t& size)
{
	JsObject *instance = nullptr;
	TypescriptClass* typeInstance = TypescriptClass::FindClass(type);
	if (typeInstance)
	{
		JsObject* prototype = typeInstance->GetPrototype();
		if (prototype)
		{
			instance = JsObject::Instantiate(isolate, typeInstance->GetPrototype());
		}
		else
		{
			instance = JsObject::Create(isolate, typeInstance, typeInstance->GetJsObject()->CallAsConstructor());
			instance->GetObject()->SetPrototype(isolate->GetCurrentContext(), JsObject::GetObject(isolate, typeInstance->GetJsObject()->GetObject(), PROTOTYPE));
		}
	}
	else
	{
		instance = JsObject::Create(isolate, nullptr);
	}
	return instance;
}

void TypescriptClass::bind()
{
	if (mJsObject) return;

	mJsObject = JsObject::Create(INTERNAL_JS_CONTEXT_NAME, this, (JS_CONSTRUCTOR_CALLBACK_TYPE)onConstructorCall, this);
	mJsObject->Set(NAME, mName);
	mJsObject->Set(FULLNAME, mFullname);
	mPrototype = mJsObject->GetJsObject(PROTOTYPE);
	mPrototype->SetTarget(this);

	this->inherit(mJsObject, mPrototype);
}

void TypescriptClass::Register(const std::string& parentType)
{
	mBaseClassName = parentType;
	if (mJsObject) return;

	if (!mBaseClass && !mBaseClassName.empty())
	{
		mBaseClass = TypescriptClass::FindClass(mBaseClassName);
	}

	mJsObject = JsObject::Create(INTERNAL_JS_CONTEXT_NAME, this, (JS_CONSTRUCTOR_CALLBACK_TYPE)onConstructorCall, this);
	mJsObject->Set(NAME, mName);
	mJsObject->Set(FULLNAME, mFullname);
	mJsObject->MakePersistent();

	mPrototype = mJsObject->GetJsObject(PROTOTYPE);
	assert(mPrototype);
	mPrototype->SetTarget(this);

	this->implement(mJsObject, mPrototype);

	this->bindNativeInstance();

	assert(mParent);
	mJsObject->BindTo(mName, mParent ? mParent->GetJsObject() : nullptr);
}