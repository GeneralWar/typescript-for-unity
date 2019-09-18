#include "../Base.h"
#pragma once

class TypescriptStaticProperty : public Base
{
private:
	static std::map<unsigned long long, TypescriptStaticProperty*> sInstances;
public:
	static TypescriptStaticProperty* GetInstance(const unsigned long long& handle);
private :
	bool mHasGetter;
	bool mHasSetter;
public:
	TypescriptStaticProperty(const std::string& name, Base* parent, const bool& hasGetter, const bool& hasSetter);
	virtual ~TypescriptStaticProperty() override;

	virtual void Bind() override; // depends platform

	void Bind(Base* parent); // depends platform
};
