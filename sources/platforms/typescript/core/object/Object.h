#pragma once
#include "header.h"
#include "defines.h"
#include "delegates.h"
#include "core/JSTypes.h"
#include "types/NumberData.h"
#include "types/StructureData.h"

#include <unordered_map>

#undef GetObject

#ifndef UNITY_INSTANCE_FIELD_SIZE
#define UNITY_INSTANCE_FIELD_SIZE "unity_instance_field_size"
#endif

#ifndef FUNCTION_CALL_PROPERTY
#define FUNCTION_CALL_PROPERTY "function_call_property"
#endif

#ifndef NATIVE_OBJECT_HANDLE
#define NATIVE_OBJECT_HANDLE "native_object_handle"
#endif

class Base;
class TypescriptProperty;

class JsObject
{
private:
	static std::unordered_map<void*, JsObject*> sJsToNativeMap;
public:
    static bool Initialize(JS_CONTEXT_TYPE context);
    
	static JsObject* Create(JS_CONTEXT_TYPE context, Base* target);
	static JsObject* Create(JS_CONTEXT_TYPE context, Base* target, const JS_VALUE_TYPE value);
	static JsObject* Create(JS_CONTEXT_TYPE context, Base* target, const JS_OBJECT_TYPE object, const size_t& size = 0);
	static JsObject* Create(JS_CONTEXT_TYPE context, Base* target, const JS_FUNCTION_CALLBACK_TYPE callback, const void* handle);
#if USE_ENGINE_JSC
    static JsObject* Create(JS_CONTEXT_TYPE context, Base* target, const JS_CONSTRUCTOR_CALLBACK_TYPE callback, const void* handle);
#endif
	static JsObject* Create(JS_CONTEXT_TYPE context, Base* target, const JS_FUNCTION_CALLBACK_TYPE callback, const std::string& name);

	static JsObject* CreateBoolean(JS_CONTEXT_TYPE context, const bool& value);
	static JsObject* CreateString(JS_CONTEXT_TYPE context, const std::string& value);
	static JsObject* CreateInt32(JS_CONTEXT_TYPE context, const int& value);
	static JsObject* CreateUint32(JS_CONTEXT_TYPE context, const unsigned int& value);
	static JsObject* CreateInt64(JS_CONTEXT_TYPE context, const long long& value);
	static JsObject* CreateUint64(JS_CONTEXT_TYPE context, const unsigned long long& value);
	static JsObject* CreateSingle(JS_CONTEXT_TYPE context, const float& value);
	static JsObject* CreateDouble(JS_CONTEXT_TYPE context, const double& value);
	static JsObject* CreateArray(JS_CONTEXT_TYPE context, const int& length = 0);
	static JsObject* CreateArray(JS_CONTEXT_TYPE context, JsObject** elements, const int& length);
#if USE_ENGINE_V8
	static JsObject* Instantiate(JS_CONTEXT_TYPE context, JsObject* prototype);
#endif

	static JsObject* Convert(JS_CONTEXT_TYPE context, const JS_OBJECT_TYPE value);

	static JsObject* Find(void* handle);

	static void SetGarbageCollectionCallback(GarbageCollectionCallback callback) { sGarbageCollectionCallback = callback; }

	static void Clear();
private:
	//static JS_PERSISTENT_OBJECT_TYPE sPersistentCollection;
	static GarbageCollectionCallback sGarbageCollectionCallback;
    static void onInitialize(JSOBJECT_INITIALIZE_CALLBACK_PARAMETERS);
    static void onFinalize(PERSISTENT_WEAK_CALLBACK_PARAMETERS);
private:
	Base* mTarget;
    
    int mReferenceCount;
    
    JsTypes mType;
    int mSubType;
    
    char* mString;
    NumberData* mNumber;
    StructureData* mStructure;
    
	JS_PERSISTENT_OBJECT_TYPE mPersistent;
	JS_CONTEXT_TYPE INTERNAL_JS_CONTEXT_NAME;

    JsObject(JS_CONTEXT_TYPE context, Base* target, const NumberData& data, const JsTypes& jsType, const int& subType = 0);
    JsObject(JS_CONTEXT_TYPE context, Base* target, const std::string& value);
	JsObject(JS_CONTEXT_TYPE context, Base* target, JS_OBJECT_TYPE value, const size_t& size);
	~JsObject();
protected:
	void removeTarget();
public:
	bool IsObject() const;

	Base* GetTarget() { return mTarget; }

	JS_CONTEXT_TYPE GET_JS_CONTEXT_FUNCTION() { return INTERNAL_JS_CONTEXT_NAME; }

	JS_VALUE_TYPE GetValue();
	JS_OBJECT_TYPE GetObject();

	void MakePersistent();
	void MakeWeak();
    
    bool Equals(JsObject* other);
    bool Equals(const JS_VALUE_TYPE other);
    bool Equals(const JS_OBJECT_TYPE other);

    void SetTarget(Base* target);
    
	void BindTo(const std::string& name, JsObject* target);

	bool Has(const std::string& name);

	bool Set(const std::string& name, JsObject* value);
    static void Set(JS_CONTEXT_TYPE context, const JS_OBJECT_TYPE target, const std::string& name, const JS_OBJECT_TYPE value);
    
    bool Set(const std::string& name, const JS_VALUE_TYPE value);
    static bool Set(JS_CONTEXT_TYPE context, const JS_OBJECT_TYPE target, const std::string& name, const JS_VALUE_TYPE value);
    
	JsObject* GetJsObject(const std::string& name);
    static JS_VALUE_TYPE GetValue(JS_CONTEXT_TYPE context, const JS_OBJECT_TYPE target, const std::string& name);
    static JS_OBJECT_TYPE GetObject(JS_CONTEXT_TYPE context, const JS_OBJECT_TYPE target, const std::string& name);
    
    bool Set(const unsigned long long& index, JsObject* value);
    bool Set(const unsigned long long& index, const JS_VALUE_TYPE value);
    static JS_VALUE_TYPE Get(JS_CONTEXT_TYPE context, const JS_OBJECT_TYPE target, const unsigned int& index);

	bool Set(const std::string& name, const std::string& value);
    static bool Set(JS_CONTEXT_TYPE context, const JS_OBJECT_TYPE target, const std::string& name, const std::string& value);
    
	std::string GetString(const std::string& name);
    static std::string GetString(JS_CONTEXT_TYPE context, const JS_OBJECT_TYPE target, const std::string& name);
    
	bool Set(const unsigned long long& index, const std::string& value);
	std::string GetString(const unsigned long long& index);

	bool Set(const std::string& name, const unsigned long long& value);
    static bool Set(JS_CONTEXT_TYPE context, const JS_OBJECT_TYPE target, const std::string& name, const unsigned long long value);
    
	unsigned long long GetUint64(const std::string& name);
    static unsigned long long GetUint64(JS_CONTEXT_TYPE context, const JS_OBJECT_TYPE target, const std::string& name);

	void* GetInstanceField();

	//bool Get(const std::string& name, const void* handle, const int& size);
protected:
	std::vector<JS_VALUE_TYPE> deserializeParameters(JsObject* jsObject);
public:
	bool DefineProperty(const std::string& name, const TypescriptProperty* property);
    
    JS_VALUE_TYPE CallAsConstructor();
    
    JsObject* CallFunction(const std::string& name, JsObject* arguments, const bool& needResult = false);
    JsObject* CallFunction(const std::string& name, const std::vector<JsObject*>& arguments, const bool& needResult = false);
    JsObject* CallFunction(const std::string& name, const std::vector<JS_VALUE_TYPE>& arguments, const bool& needResult = false);
    
    JsObject* CallAsFunction(JsObject* arguments, const bool& needResult = false);
    JsObject* CallAsFunction(const std::vector<JsObject*>& arguments, const bool& needResult = false);
    JsObject* CallAsFunction(const std::vector<JS_VALUE_TYPE>& arguments, const bool& needResult = false);

	bool ToBoolean();
    static bool ToBoolean(JS_CONTEXT_TYPE context, const JS_VALUE_TYPE value);
    
	std::string ToString();
    static std::string ToString(JS_CONTEXT_TYPE context, const JS_VALUE_TYPE value);
#if USE_ENGINE_JSC
    static std::string ToString(JS_CONTEXT_TYPE context, const JSStringRef value);
#endif
    
	int ToInt32();
    static int ToInt32(JS_CONTEXT_TYPE context, const JS_VALUE_TYPE value);
    
	unsigned int ToUint32();
    static unsigned int ToUint32(JS_CONTEXT_TYPE context, const JS_VALUE_TYPE value);
    
	long long ToInt64();
    static long long ToInt64(JS_CONTEXT_TYPE context, const JS_VALUE_TYPE value);
    
	unsigned long long ToUint64();
    static unsigned long long ToUint64(JS_CONTEXT_TYPE context, const JS_VALUE_TYPE value);
    
	float ToSingle();
    static float ToSingle(JS_CONTEXT_TYPE context, const JS_VALUE_TYPE value);
    
	double ToDouble();
    static double ToDouble(JS_CONTEXT_TYPE context, const JS_VALUE_TYPE value);
    static void* ToHandle(JS_CONTEXT_TYPE context, const JS_VALUE_TYPE value);
public:
	static bool IsValid(JS_CONTEXT_TYPE context, const JS_OBJECT_TYPE object);
	static bool IsValid(JS_CONTEXT_TYPE context, const JS_VALUE_TYPE value);

    
//    static JS_VALUE_TYPE GetJsValue(JS_CONTEXT_TYPE context, JS_OBJECT_TYPE& target, const std::string& name);
//    static void SetJsValue(JS_CONTEXT_TYPE context, JS_OBJECT_TYPE& target, const std::string& name, JS_OBJECT_TYPE& value);
    
    static JS_OBJECT_TYPE GetPrototypeFromConstructor(JS_CONTEXT_TYPE context, const JS_OBJECT_TYPE constructor);
    static void* GetNativeObjectHandle(JS_CONTEXT_TYPE context, const JS_OBJECT_TYPE object);
    
    friend class TypescriptClass;
};
