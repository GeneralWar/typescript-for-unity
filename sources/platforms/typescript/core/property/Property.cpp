#include "Property.h"
#include "defines.h"
#include "core/object/Object.h"

ASSIGN_BASE_CHILD_TYPE(TypescriptProperty, BaseChildTypes::BaseChildType_Property);
ASSIGN_BASE_CHILD_TYPE(TypescriptStaticProperty, BaseChildTypes::BaseChildType_StaticProperty);
ASSIGN_BASE_CHILD_TYPE(TypescriptInstanceProperty, BaseChildTypes::BaseChildType_InstanceProperty);

TypescriptProperty::TypescriptProperty(const BaseChildTypes& type, const std::string& name, Base* parent, const bool& hasGetter, const bool& hasSetter) : Base(TYPE | type, name, parent), mHasGetter(hasGetter), mHasSetter(hasSetter) { }

TypescriptProperty::~TypescriptProperty() { }

void TypescriptProperty::bind() { }

TypescriptStaticProperty* TypescriptStaticProperty::Create(const std::string& name, Base* parent, const bool& hasGetter, const bool& hasSetter)
{
	return Base::Create<TypescriptStaticProperty>(name, parent, hasGetter, hasSetter);
}

TypescriptStaticProperty::TypescriptStaticProperty(const std::string& name, Base* parent, const bool& hasGetter, const bool& hasSetter) : TypescriptProperty(TYPE, name, parent, hasGetter, hasSetter) { }

TypescriptInstanceProperty* TypescriptInstanceProperty::Create(const std::string& name, Base* parent, const bool& hasGetter, const bool& hasSetter)
{
	return Base::Create<TypescriptInstanceProperty>(name, parent, hasGetter, hasSetter);
}

TypescriptInstanceProperty::TypescriptInstanceProperty(const std::string& name, Base* parent, const bool& hasGetter, const bool& hasSetter) : TypescriptProperty(TYPE, name, parent, hasGetter, hasSetter) { }

void TypescriptStaticProperty::BindTo(JsObject* target)
{
	if (!target) return;
    target->DefineProperty(mName, this);
}

void TypescriptInstanceProperty::BindTo(JsObject* target)
{
	if (!target) return;
    target->DefineProperty(mName, this);
}
