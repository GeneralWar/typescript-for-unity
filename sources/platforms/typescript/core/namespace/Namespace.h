#include <map>
#include "../Base.h"
#pragma once

class TypescriptEnum;
class TypescriptClass;

class TypescriptNamespace : public Base
{
private:
	DEFINE_BASE_CHILD_TYPE;
public:
	CONVERT_TO_BASE_CHILD(TypescriptNamespace);
	CHECK_BASE_VALID_FUNCTION(TypescriptNamespace);
public:
	static TypescriptNamespace* Create(const std::string& name, Base* parent);
protected:
	std::map<std::string, TypescriptNamespace*> mNamespaces;
	std::map<std::string, TypescriptClass*> mClasses;
	std::map<std::string, TypescriptEnum*> mEnums;
public:
	TypescriptNamespace(const std::string& name, Base* parent);
	~TypescriptNamespace();

	TypescriptNamespace* DeclareNamespace(const std::string& name);
	TypescriptClass* DeclareClass(const std::string& name, const std::string& base, const bool& hasConstructor, const bool& isStatic);
	TypescriptEnum* DeclareEnum(const std::string& name);
};
