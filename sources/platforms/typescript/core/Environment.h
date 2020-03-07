#pragma once
#include <string>
#include <vector>
#include <memory>
#include "header.h"
#include "defines.h"
#include "Base.h"

class JsObject;
class TypescriptClass;
class TypescriptNamespace;
class TypescriptStaticFunction;

class Environment : public Base
{
protected:
	static Environment* sInstance;
	static std::vector<std::string> sSuperClassNames;
public:
	static Environment* Create();
	static void Release(void* environment);
    
    static Environment* GetInstance() { return sInstance; }
protected:
	bool mIsRunning;

	std::vector<TypescriptClass*> mClasses;
	std::vector<TypescriptNamespace*> mNamespaces;
	std::vector<TypescriptStaticFunction*> mFunctions;

	void release();

	Environment();
	virtual ~Environment();
public:
	bool Initialize();

	bool IsRunning() const { return mIsRunning; }
protected:
    bool initialize();
	virtual void bind() override;
private:
	std::string execute(const char* content, void* origin = nullptr);
public:
    JsObject* CreateGlobalObject(JS_CONTEXT_TYPE context, const char* name);
    
	std::string ExecuteString(const char* sourceContent);
	std::string ExecuteScript(const char* sourceContent, const char* filename);
	void* Require(const char* sourceContent, const char* filename);

	TypescriptClass* DeclareClass(const char* name, const char* base, const bool& hasConstructor, const bool& isStatic);
	TypescriptNamespace* DeclareNamespace(const char* name);
	TypescriptStaticFunction* BindStaticFunction(const char* name);
public:
    static bool ClearException(JS_VALUE_TYPE* exception);
};
