#include <map>
#include <vector>
#include <string>
#include "../Base.h"
#include "delegates.h"
#include "defines.h"
#pragma once
#ifndef CLASS_H
#define CLASS_H

class TypescriptEnum;
class TypescriptNamespace;
class TypescriptStaticFunction;
class TypescriptStaticProperty;

class TypescriptClass : public Base
{
private:
	static std::map<std::string, TypescriptClass*> sClasses;
public:
	static TypescriptClass* GetClass(const std::string& name);
	static void Derive();
private:
	std::string mBaseClassName;
	TypescriptClass* mBaseClass;
	std::vector<TypescriptClass*> mDerivedClasses;
	std::map<std::string, std::shared_ptr<Base>> mNestedClasses;
	std::map<std::string, std::shared_ptr<TypescriptStaticFunction>> mStaticFunctions;
	std::map<std::string, std::shared_ptr<TypescriptStaticProperty>> mStaticProperties;
public:
	TypescriptClass(const std::string& name, const std::string& base, Environment* environment);
	TypescriptClass(const std::string& name, const std::string& base, Base* space);
	TypescriptClass(const std::string& name, Environment* environment);
	TypescriptClass(const std::string& name, Base* space);

	~TypescriptClass();
private:
	bool mHasConstructor;
public:
	std::shared_ptr<TypescriptStaticFunction> BindStaticFunction(const std::string& name);
	void BindStaticFunction(const std::string& name, JS_FUNCTION_CALLBACK_TYPE callback);

	std::shared_ptr<TypescriptStaticProperty> BindStaticProperty(const std::string& name, const bool& hasGetter, const bool& hasSetter);

	void BindConstructor(const bool& real);

	virtual void Bind() override;
protected:
	void bind(); // depends platform

	// Set instance as derived class of this class.
	void derive(TypescriptClass* instance);
	bool isDerived() const { return !mBaseClassName.empty(); }
	bool isBaseClass() const { return !mBaseClass && mDerivedClasses.size(); }

	// Copy static functions and properties from this class to it's derived classes.
	void derive();
	// Copy static functions and properties from base type.
	void deriveFromParent(TypescriptClass* instance);
public:
	int CreateInstance(JS_PARAMETERS);
public:
	Base* DeclareClass(const std::string& name);
	Base* DeclareEnum(const std::string& name);
};

#endif
