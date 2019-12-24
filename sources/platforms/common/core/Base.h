#include <map>
#include <string>
#include "header.h"
#include "defines.h"
#pragma once

class Environment;
class Reference;

class Base
{
private:
	static std::map<std::string, Base*> sInstances;
	std::map<std::string, Base*> mChildren;

	Base(Environment* isolate, const std::string& name, Base* parent);
public:
	static Base* GetInstance(const std::string& name);
protected:
	std::string mName;
	std::string mFullname;

	Base* mParent;
	Environment* mEnvironment;
	REFERENCE mReference;
	JS_PERSISTENT_OBJECT_TYPE mJsObject;

	Base(const std::string& name, Base* parent);
	Base(const std::string& name, Environment* isolate);

    void BindToParent(Base* parent = nullptr); // depends platform
public:
	virtual ~Base();

	Base* GetParent() const { return mParent; }

	const std::string& GetFullname() { return mFullname; }
	const std::string& GetName() { return mName; }

	Environment* GetEnvironment() { return mEnvironment; }
	REFERENCE GetReference() { return mReference; }
	JS_OBJECT_TYPE GetJsObject(); // depends platform

	virtual void Bind(); // depends platform
};
