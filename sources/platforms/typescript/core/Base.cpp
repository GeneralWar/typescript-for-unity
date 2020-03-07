#include "Base.h"
#include "defines.h"
#include "Utils.h"
#include "Environment.h"
#include "object/Object.h"
#include "class/Class.h"

#define GENERAL_NATIVE_INSTANCE "general_native_instance"

ASSIGN_BASE_CHILD_TYPE(Base, BaseChildTypes::BaseChildType_Base);

std::set<Base*> Base::sInstances;

Base* Base::Convert(JsObject* target)
{
	if (!target) return nullptr;
	Base* handle = reinterpret_cast<Base*>(target->GetUint64(GENERAL_NATIVE_INSTANCE));
	return sInstances.end() == sInstances.find(handle) ? nullptr : handle;
}

Base::Base(const int& type, const std::string& name, Base* parent) :
	INTERNAL_JS_CONTEXT_NAME(parent ? parent->GET_JS_CONTEXT_FUNCTION() : nullptr), 
	mType(BaseChildTypes::BaseChildType_Base | type), mName(name), mParent(parent), mJsObject()
{
	if (parent)
	{
		std::string parentName = parent->GetFullname();
		mFullname = parentName.empty() ? name : parent->GetFullname() + "." + name;
	}
	else
	{
		mFullname = name;
	}
	sInstances.insert(this);
}

Base::~Base()
{
    
}

const bool Base::CheckType(const BaseChildTypes &type) const
{
    return 0 != (mType & type);
}

void Base::Bind()
{
//    DEBUG_LOG("Try to bind %s ...", mFullname.c_str());
	this->bind();
	this->bindNativeInstance();
	mJsObject->BindTo(mName, mParent ? mParent->GetJsObject() : nullptr);
}

void Base::bind()
{
	if (mJsObject)
	{
#if DEBUG
		assert(0);
#endif
		return;
	}

	mJsObject = JsObject::Create(INTERNAL_JS_CONTEXT_NAME, this);
	mJsObject->Set(NAME, mName);
	mJsObject->Set(FULLNAME, mFullname);
    mJsObject->MakePersistent();
}

void Base::bindNativeInstance()
{
	mJsObject->Set(GENERAL_NATIVE_INSTANCE, (unsigned long long)this);
}

bool Base::IsOrSubClassOf(Base *target)
{
    return false;
}
