#include "../Base.h"
#include <map>
#pragma once

class TypescriptEnum;
class TypescriptClass;

class TypescriptNamespace : public Base
{
protected:
	std::map<std::string, std::shared_ptr<TypescriptNamespace>> mNamespaces;
	std::map<std::string, std::shared_ptr<TypescriptClass>> mClasses;
	std::map<std::string, std::shared_ptr<TypescriptEnum>> mEnums;
public:
	TypescriptNamespace(const std::string& name, Environment* environment);
	TypescriptNamespace(const std::string& name, TypescriptNamespace* parent);
	~TypescriptNamespace();

	std::shared_ptr<TypescriptNamespace> DeclareNamespace(const std::string& name);
	std::shared_ptr<TypescriptClass> DeclareClass(const std::string& name, const std::string& base);
	std::shared_ptr<TypescriptEnum> DeclareEnum(const std::string& name);

	virtual void Bind() override;
};