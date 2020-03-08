#include <map>
#include <vector>
#include <string>
#include "../Base.h"
#include "delegates.h"
#include "defines.h"
#pragma once
#ifndef CLASS_H
#define CLASS_H

class JsObject;
class TypescriptEnum;
class TypescriptNamespace;
class TypescriptFunction;
class TypescriptProperty;
class TypescriptStaticFunction;
class TypescriptStaticProperty;
class TypescriptInstanceFunction;
class TypescriptInstanceProperty;

class TypescriptClass : public Base
{
private:
	DEFINE_BASE_CHILD_TYPE;
public:
	CONVERT_TO_BASE_CHILD(TypescriptClass);
	CHECK_BASE_VALID_FUNCTION(TypescriptClass);
	static std::map<std::string, TypescriptClass*> sClasses;
public:
	static void Clear();
	static TypescriptClass* FindClass(const std::string& name);
	static TypescriptClass* FindBaseClass(const std::string& name);

	static void CheckConstructors(JS_CONTEXT_TYPE isolate, const JS_VALUE_TYPE value);

	static JsObject* Instantiate(JS_CONTEXT_TYPE isolate, const std::string& type, const size_t& size);
	static JsObject* CreateInstance(JS_CONTEXT_TYPE isolate, const std::string& type);
	static JsObject* CreateInstance(JS_CONTEXT_TYPE isolate, const std::string& type, const size_t& size);

	static TypescriptClass* Create(const std::string& name, const std::string& base, bool hasConstructor, bool isStatic, Base* parent);
private:
	bool mIsStatic;
	std::string mBaseClassName;
	TypescriptClass* mBaseClass;
#ifdef USE_ENGINE_JSC
	JSClassRef mJsClass;
public:
	JSClassRef GetJsClass() const { return mJsClass; }
private:
#endif
	std::vector<TypescriptClass*> mDerivedClasses;
	std::map<std::string, Base*> mNestedClasses;
	// 不可删除，用以管理TypescriptStaticFunction的释放
	std::map<std::string, TypescriptFunction*> mStaticFunctions;
	std::map<std::string, TypescriptFunction*> mInstanceFunctions;
	// 不可删除，用以管理TypescriptStaticProperty的释放
	std::map<std::string, TypescriptProperty*> mStaticProperties;
	std::map<std::string, TypescriptProperty*> mInstanceProperties;
public:
	TypescriptClass(const std::string& name, const std::string& base, bool hasConstructor, bool isStatic, Base* parent);
	~TypescriptClass();
private:
	bool mHasConstructor;
	JsObject* mPrototype;
public:
	bool HasConstructor() const { return mHasConstructor; }

	TypescriptStaticFunction* BindStaticFunction(const std::string& name);
	void BindStaticFunction(const std::string& name, JS_FUNCTION_CALLBACK_TYPE callback);
	TypescriptInstanceFunction* BindInstanceFunction(const std::string& name);

	TypescriptStaticProperty* BindStaticProperty(const std::string& name, const bool& hasGetter, const bool& hasSetter);
	TypescriptInstanceProperty* BindInstanceProperty(const std::string& name, const bool& hasGetter, const bool& hasSetter);

	virtual void bind() override;

	JsObject* GetPrototype() { return mPrototype; }
protected:
	void bindInformation();

	// Inherit static functions and properties from parent class dynamically.
	void inherit(JsObject* constructor, JsObject* prototype);

	void implement(JsObject* constructor, JsObject* prototype);

	TypescriptClass* getBaseClass();
public:
	JsObject* CreateInstance(JS_PARAMETERS);
	void Instantiate(JsObject* target);
public:
	TypescriptClass* DeclareClass(const std::string& name, const std::string& base, const bool& hasConstructor, const bool& isStatic);
	TypescriptEnum* DeclareEnum(const std::string& name);

	virtual void Bind() override;

	void Register(const std::string& parentType);

	virtual bool IsOrSubClassOf(Base* target) override;

	// Derive a custom class declared from js.
	static TypescriptClass* Derive(TypescriptClass* baseType, const std::string& fullname, const JS_OBJECT_TYPE constructor);
};

#endif
