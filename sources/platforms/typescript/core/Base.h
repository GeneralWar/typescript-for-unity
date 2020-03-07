#pragma once
#include "header.h"
#include "defines.h"

class JsObject;
class Environment;

enum BaseChildTypes
{
	BaseChildType_Base = 1,
	BaseChildType_Namespace = 1 << 1,
	BaseChildType_Class = 1 << 2,
	BaseChildType_Enum = 1 << 3,
	BaseChildType_Function = 1 << 4,
	BaseChildType_StaticFunction = 1 << 5,
	BaseChildType_InstanceFunction = 1 << 6,
	BaseChildType_Property = 1 << 7,
	BaseChildType_StaticProperty = 1 << 8,
	BaseChildType_InstanceProperty = 1 << 9,
	BaseChildType_Environment = 1 << 30,
};

class Base
{
private:
	DEFINE_BASE_CHILD_TYPE;
	static std::set<Base*> sInstances;
public:
	static int GetInstanceCount() { return (int)sInstances.size(); }
	template <class T, class... TArgs> static T* Create(TArgs&&... args);
	static Base* Convert(JsObject* target);
	CONVERT_TO_BASE_CHILD(Base);
	CHECK_BASE_VALID_FUNCTION(Base);
private:
	std::list<Base*> mChildren;
protected:
	int mType;
	std::string mName;
	std::string mFullname;

	JsObject* mJsObject;
	void dettachJsObject() { mJsObject = nullptr; }

	Base* mParent;
	JS_CONTEXT_TYPE INTERNAL_JS_CONTEXT_NAME;

	Base(const int& type, const std::string& name, Base* parent);
public:
	virtual ~Base();
    
    const bool CheckType(const BaseChildTypes& type) const;

	Base* GetParent() const { return mParent; }

	JsObject* GetJsObject() { return mJsObject; }

	const std::string& GetFullname() const { return mFullname; }
	const std::string& GetName() const { return mName; }

	JS_CONTEXT_TYPE GET_JS_CONTEXT_FUNCTION() { return INTERNAL_JS_CONTEXT_NAME; }

	virtual void Bind();
protected:
	virtual void bind();
	void bindNativeInstance();
public:
    virtual bool IsOrSubClassOf(Base* target);
    
	friend class JsObject;
};

//template <class T, class... TArgs> static std::shared_ptr<T> Base::Create(TArgs&&... args)
//{
//	std::shared_ptr<T> shared = std::make_shared<T>(args...);
//	SAFE_CALL(shared->mParent, ->mChildren[shared->GetName()] = shared);
//	return shared;
//}
template <class T, class... TArgs> T* Base::Create(TArgs&&... args)
{
	T* instance = new T(args...);
	SAFE_CALL(instance->mParent, ->mChildren.push_back(instance));
	return instance;
}
