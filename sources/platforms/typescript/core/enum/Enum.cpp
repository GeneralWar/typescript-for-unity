#include "Enum.h"
#include "delegates.h"
#include "core/namespace/Namespace.h"
#include "core/function/Function.h"
#include "core/object/Object.h"

ASSIGN_BASE_CHILD_TYPE(TypescriptEnum, BaseChildTypes::BaseChildType_Enum);

TypescriptEnum* TypescriptEnum::Create(const std::string& name, Base* parent)
{
	return Base::Create<TypescriptEnum>(name, parent);
}

TypescriptEnum::TypescriptEnum(const std::string& name, Base* parent) : Base(TYPE, name, parent) { }

TypescriptEnum::~TypescriptEnum() { }

void TypescriptEnum::SetValue(const char* name, const long int& value)
{
	mValues[name] = value;
}

void TypescriptEnum::Bind()
{
    
}

void TypescriptEnum::Register()
{
    if (mJsObject) return;
    
    this->bind();
    this->bindNativeInstance();
    mJsObject->BindTo(mName, mParent ? mParent->GetJsObject() : nullptr);
    
    for (auto pair : mValues)
    {
        mJsObject->Set(pair.first, pair.second);
        mJsObject->Set(pair.second, pair.first);
    }
}
