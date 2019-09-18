#pragma once
#include <string>
#include <vector>
#include <memory>
//#include <string.h>

class TypescriptClass;
class TypescriptNamespace;
class TypescriptStaticFunction;

class Environment
{
protected:
    static std::vector<std::string> sSuperClassNames;
public:
    static void AppendCustomSuperClassName(const char* fullname);
    static bool IsCustomSuperClassName(const char* fullname);
    static bool IsCustomSuperClassName(const std::string& fullname);
protected:
	std::vector<std::shared_ptr<TypescriptClass>> mClasses;
	std::vector<std::shared_ptr<TypescriptNamespace>> mNamespaces;
	std::vector<std::shared_ptr<TypescriptStaticFunction>> mFunctions;

	virtual void release();

	void bindExtra();
public:
    Environment() { }
	virtual bool Initialize() = 0;
    virtual ~Environment() { }

	virtual void Bind() = 0;

	virtual std::string ExecuteString(const char* sourceContent) = 0;
	virtual std::string ExecuteScript(const char* sourceContent, const char* filename) = 0;
	virtual void* Require(const char* sourceContent, const char* filename) = 0;

	void* DeclareNamespace(const char* name);
	void* DeclareClass(const char* name, const char* base);
	void* BindStaticFunction(const char* name);
};
