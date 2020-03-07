//
//  object.apple.cpp
//  typescript-mac
//
//  Created by 朱嘉灵 on 2020/1/6.
//  Copyright © 2020 朱嘉灵. All rights reserved.
//

#include "header.h"
#include "core/object/Object.h"
#include "extra/log/Log.h"
#include "core/Base.h"
#include "core/function/Argument.h"
#include "../../utils.apple.h"
#include "core/class/Class.h"
#include "core/Environment.h"
#include "core/property/Property.h"

extern DEFINE_JS_FUNCTION_CALLBACK(onStaticPropertyGetterCall);
extern DEFINE_JS_FUNCTION_CALLBACK(onStaticPropertySetterCall);
extern DEFINE_JS_FUNCTION_CALLBACK(onInstancePropertyGetterCall);
extern DEFINE_JS_FUNCTION_CALLBACK(onInstancePropertySetterCall);

static JsObject* sDefinePropertyMethod = nullptr;
static JsObject* sCheckPropertyNativeHandleMethod = nullptr;

static JSStringRef sProtytypeName = nullptr;
static JSStringRef sNativeObjectHandleName = nullptr;
static JSStringRef sUnityInstanceFieldSizeName = nullptr;

static JSValueRef sUndefined = nullptr;

/*static*/ std::unordered_map<void *, JsObject *> JsObject::sJsToNativeMap;

/*static*/ GarbageCollectionCallback JsObject::sGarbageCollectionCallback = nullptr;

static bool sInitialized = false;

/*static*/ bool JsObject::Initialize(JSContextRef context)
{
    if (sInitialized)
    {
        return true;
    }
    
    sProtytypeName = JSStringCreateWithUTF8CString(PROTOTYPE);
    sNativeObjectHandleName = JSStringCreateWithUTF8CString(NATIVE_OBJECT_HANDLE);
    sUnityInstanceFieldSizeName = JSStringCreateWithUTF8CString(UNITY_INSTANCE_FIELD_SIZE);
    
    sUndefined = JSValueMakeUndefined(context);
    
    JsObject* globalObject = Environment::GetInstance()->GetJsObject();
    JsObject* staticObject = globalObject->GetJsObject("Object");
    sDefinePropertyMethod = staticObject->GetJsObject("defineProperty");
    sDefinePropertyMethod->MakePersistent();
    
    JSValueRef exception = nullptr;
    JSStringRef methodContent = JSStringCreateWithUTF8CString("((o, p, h) => { d = Object.getOwnPropertyDescriptor(o, p); if (!d || !d.get) return false; return d.get.native_object_handle == h; })");
    JSValueRef methodValue = JSEvaluateScript(context, methodContent, nullptr, nullptr, 0, &exception);
    sCheckPropertyNativeHandleMethod = new JsObject(context, nullptr, JSValueToObject(context, methodValue,  nullptr), 0);
    sCheckPropertyNativeHandleMethod->MakePersistent();
    JSStringRelease(methodContent);
    Environment::ClearException(&exception);
    
    return true;
}

/*static*/ JsObject *JsObject::Create(JSContextRef context, Base *target)
{
    if (!context) return nullptr;
    TypescriptClass* typeInstance = TypescriptClass::Convert(target);
    JSClassRef jsClass = typeInstance ? typeInstance->GetJsClass() : nullptr;
    JSObjectRef jsObject = JSObjectMake(context, jsClass, nullptr);
    return Create(context, target, jsObject);
}

/*static*/ JsObject* JsObject::Create(JSContextRef context, Base* target, const JSValueRef value)
{
    if (!context || !JsObject::IsValid(context, value)) return nullptr;
    if (JSValueIsObject(context, value))
    {
        return Create(context, target, JSValueToObject(context, value, nullptr));
    }
    else if (JSValueIsString(context, value))
    {
        return CreateString(context, JsObject::ToString(context, value));
    }
    else if (JSValueIsBoolean(context, value))
    {
        return CreateBoolean(context, JsObject::ToBoolean(context, value));
    }
    else if (JSValueIsNumber(context, value))
    {
        return CreateDouble(context, JsObject::ToDouble(context, value));
    }
    else if (JSValueIsNull(context, value))
    {
        return new JsObject(context, target, nullptr, JsTypes::TYPE_NULL);
    }
    else if (JSValueIsUndefined(context, value))
    {
        return new JsObject(context, target, nullptr, JsTypes::TYPE_UNDEFINED);
    }
    assert(0);
    return nullptr;
}

/*static*/ JsObject *JsObject::Create(JSContextRef context, Base *target, const JSObjectCallAsFunctionCallback callback, const void *handle)
{
    if (!context) return nullptr;
    JSObjectRef function = JSObjectMakeFunctionWithCallback(context, nullptr, callback);
    JSObjectSetProperty(context, function, sNativeObjectHandleName, JSValueMakeNumber(context, (double)reinterpret_cast<unsigned long long>(const_cast<void*>(handle))), 0, nullptr);
    return Create(context, target, function);
}

extern JSValueRef onApplyCall(JSContextRef context, JSObjectRef function, JSObjectRef thisObject, size_t argumentCount, const JSValueRef arguments[], JSValueRef* exception);

/*static*/ JsObject *JsObject::Create(JSContextRef context, Base *target, const JSObjectCallAsConstructorCallback callback, const void *handle)
{
    if (!context) return nullptr;
    TypescriptClass* instance = TypescriptClass::Convert(target);
    assert(instance);
    
    JSObjectRef constructor = JSObjectMakeConstructor(context, instance->GetJsClass(), callback);
    
    JSValueRef prototypeValue = JSObjectGetProperty(context, constructor, sProtytypeName, nullptr);
    JSObjectRef prototypeObject = JSValueToObject(context, prototypeValue, nullptr);
    JSObjectSetPrivate(prototypeObject, const_cast<void*>(handle));
    
    JSStringRef applyName = JSStringCreateWithUTF8CString(APPLY);
    JSObjectRef apply = JSObjectMakeFunctionWithCallback(context, applyName, onApplyCall);
    JSObjectSetProperty(context, constructor, applyName, apply, 0, nullptr);
    JSStringRelease(applyName);
    
    return Create(context, target, constructor);
}

/*static*/ JsObject *JsObject::Create(JSContextRef context, Base *target, const JSObjectCallAsFunctionCallback callback, const std::string &name)
{
    if (!context) return nullptr;
    JSObjectRef function = JSObjectMakeFunctionWithCallback(context, nullptr, callback);
    JsObject::Set(context, function, FUNCTION_CALL_PROPERTY, name.c_str());
    return Create(context, target, function);
}

/*static*/ JsObject* JsObject::CreateArray(JSContextRef context, const int& length)
{
    if (!context) return nullptr;
    JSStringRef content = JSStringCreateWithUTF8CString("[]");
    JSValueRef value = JSValueMakeFromJSONString(context, content);
    JSStringRelease(content);
    return Create(context, nullptr, JSValueToObject(context, value, nullptr));
}

/*static*/ JsObject* JsObject::CreateArray(JSContextRef context, JsObject** elements, const int& length)
{
    if (!context) return nullptr;
    JsObject* array = CreateArray(context, length);
    for (int i = 0; i < length; ++i)
    {
        JsObject* object = elements[i];
        array->Set(i, object->GetValue());
    }
    return array;
}

///*static*/ JsObject *JsObject::Instantiate(JSContextRef context, JSObjectRef constructor)
//{
//    if (!context) return nullptr;
//    if (!constructor)
//    {
//        DEBUG_LOG("Try to instantiate but constructor is null, return a default js object!");
//        return nullptr;
//    }
//
//    if (JsObject::IsValid(context, constructor) && JSObjectIsConstructor(context, constructor))
//    {
//        JSValueRef exception = nullptr;
//        JSObjectRef instance = JSObjectCallAsConstructor(context, constructor, 0, 0, &exception);
//        if (exception)
//        {
//            LogError(JsObject::ToString(context, exception));
//        }
//
//        JSObjectRef prototype = JSValueToObject(context, JsObject::GetValue(context, constructor, "prototype"), &exception);
//        if (exception)
//        {
//            LogError(JsObject::ToString(context, exception));
//        }
//        if (instance)
//        {
//            JSObjectSetPrototype(context, JSValueToObject(context, instance, 0), prototype);
//        }
//        return Create(context, nullptr, instance);
//    }
//#if DEBUG
//    assert(0);
//#endif
//    LogError("Failed to instantiate value!");
//    return JsObject::Create(context, nullptr);
//}

/*static*/ JsObject* JsObject::Convert(JSContextRef context, const JSObjectRef jsObject)
{
    if (!context || !jsObject || !JsObject::IsValid(context, jsObject))
        return nullptr;

    auto finder = sJsToNativeMap.find(jsObject);
    if (sJsToNativeMap.end() == finder) return nullptr;

    JsObject* instance = finder->second;
    assert(instance->mPersistent == jsObject);
    return instance;
}

/*static*/ JsObject *JsObject::Find(void *handle)
{
    auto finder = sJsToNativeMap.find(handle);
    return sJsToNativeMap.end() == finder ? nullptr : finder->second;
}

/*static*/ void JsObject::Clear()
{
    for (auto iterator : sJsToNativeMap)
    {
        JsObject *instance = iterator.second;
        instance->removeTarget();
        delete instance;
    }
    sJsToNativeMap.clear();
}

/*static*/ void JsObject::onInitialize(JSContextRef context, JSObjectRef object)
{
    // useless callback
}

/*static*/ void JsObject::onFinalize(JSObjectRef object)
{
    auto finder = sJsToNativeMap.find(object);
    // 析构函数会被多次调用，从派生类向基类
    // assert(sJsToNativeMap.end() != finder);
    if (sJsToNativeMap.end() == finder)
    {
        return;
    }
    
    JsObject* instance = finder->second;
#if DEBUG
    assert(instance && !instance->mReferenceCount);
#endif
    // TODO:也许这个应该移到析构函数中。
    if (!instance->mStructure)
    {
        // TODO:脚本对象在JS中失去引用，不代表CS层不再需要调用此对象
        sGarbageCollectionCallback(instance);
    }
    
    sJsToNativeMap.erase(finder);
    delete instance;
}

JsObject::JsObject(JSContextRef context, Base* target, const NumberData& data, const JsTypes& jsType, const int& subType) : mContext(context), mPersistent(nullptr), mTarget(target), mType(jsType), mSubType(subType), mNumber(), mString(), mStructure(), mReferenceCount(0)
{
#if DEBUG
    assert(jsType || subType);
#endif
    if (!context) return;
    
    mNumber = new NumberData;
    memcpy(mNumber, &data, sizeof(NumberData));
}

JsObject::JsObject(JSContextRef context, Base* target, const std::string& value) : mContext(context), mPersistent(nullptr), mTarget(target), mType(JsTypes::TYPE_STRING), mSubType(), mNumber(), mString(), mStructure(), mReferenceCount(0)
{
    if (!context) return;
    
    mString = new char[value.length() + 1];
    strcpy(mString, value.c_str());
}

JsObject::JsObject(JSContextRef context, Base* target, JSObjectRef object, const size_t& size) : mContext(context), mPersistent(object), mTarget(target), mType(), mSubType(), mNumber(), mString(), mStructure(), mReferenceCount(0)
{
#if DEBUG
    assert(object);
#endif
    if (!context || !object) return;
    
    if (JSValueIsArray(context, object))
    {
        mType = JsTypes::TYPE_ARRAY;
    }
    else if (JSObjectIsConstructor(context, object))
    {
        mType = JsTypes::TYPE_CONSTRUCTOR;
    }
    else if (JSObjectIsFunction(context, object))
    {
        mType = JsTypes::TYPE_FUNCTION;
    }
#if DEBUG
    else if (!JSValueIsObject(context, object))
    {
        assert(0);
    }
#endif
    else if (target && target->GetJsObject() && !target->GetJsObject()->Equals(object))
    {
        mType = JsTypes::TYPE_INSTANCE;
        if (size)
        {
            mStructure = new StructureData(size);
        }
    }
    else
    {
        mType = JsTypes::TYPE_OBJECT;
    }
    
    sJsToNativeMap[object] = this;
}

JsObject::~JsObject()
{
    if (mString)
    {
        delete[] mString;
    }
    else if (mNumber)
    {
        delete mNumber;
    }
    else if (mStructure)
    {
        delete mStructure;
    }

    if (mTarget)
    {
        // TODO: something to do with Base instance.
#if DEBUG
        //assert(0);
#endif
    }
}

bool JsObject::IsObject() const
{
    if (!mPersistent)
        return false;
    return JSValueIsObject(mContext, (JSValueRef)mPersistent);
}

JSValueRef JsObject::GetValue()
{
    if (mPersistent)
    {
        return (JSValueRef)mPersistent;
    }
    switch (mType)
    {
        case JsTypes::TYPE_BOOLEAN:
            return JSValueMakeBoolean(mContext, mNumber ? mNumber->boolean : false);
        case JsTypes::TYPE_STRING:
        {
            JSStringRef jsString = JSStringCreateWithUTF8CString(SAFE_STRING(mString));
            JSValueRef jsValue = JSValueMakeString(mContext, jsString);
            JSStringRelease(jsString);
            return jsValue;
        }
        case JsTypes::TYPE_NULL:
            return JSValueMakeNull(mContext);
        case JsTypes::TYPE_UNDEFINED:
            return JSValueMakeUndefined(mContext);
        case JsTypes::TYPE_NUMBER:
            switch (mSubType)
            {
                case JsNumberTypes::TYPE_NUMBER_SBYTE:
                    return JSValueMakeNumber(mContext, (double)(mNumber ? mNumber->int8 : 0));
                case JsNumberTypes::TYPE_NUMBER_BYTE:
                    return JSValueMakeNumber(mContext, (double)(mNumber ? mNumber->uint8 : 0));
                case JsNumberTypes::TYPE_NUMBER_INT16:
                    return JSValueMakeNumber(mContext, (double)(mNumber ? mNumber->int16 : 0));
                case JsNumberTypes::TYPE_NUMBER_UINT16:
                    return JSValueMakeNumber(mContext, (double)(mNumber ? mNumber->uint16 : 0));
                case JsNumberTypes::TYPE_NUMBER_INT32:
                    return JSValueMakeNumber(mContext, (double)(mNumber ? mNumber->int32 : 0));
                case JsNumberTypes::TYPE_NUMBER_UINT32:
                    return JSValueMakeNumber(mContext, (double)(mNumber ? mNumber->uint32 : 0));
                case JsNumberTypes::TYPE_NUMBER_INT64:
                    return JSValueMakeNumber(mContext, (double)(mNumber ? mNumber->int64 : 0));
                case JsNumberTypes::TYPE_NUMBER_UINT64:
                    return JSValueMakeNumber(mContext, (double)(mNumber ? mNumber->uint64 : 0));
                case JsNumberTypes::TYPE_NUMBER_SINGLE:
                    return JSValueMakeNumber(mContext, (double)(mNumber ? mNumber->float32 : 0));
                case JsNumberTypes::TYPE_NUMBER_DOUBLE:
                    return JSValueMakeNumber(mContext, mNumber ? mNumber->float64 : 0);
            }
        case JsTypes::TYPE_INSTANCE:
            return mPersistent;
        case JsTypes::TYPE_OBJECT:
        case JsTypes::TYPE_ARRAY:
        case JsTypes::TYPE_FUNCTION:
        case JsTypes::TYPE_CONSTRUCTOR:
        case JsTypes::TYPE_UNKNOWN:
            assert(0);
            break;
    }
    return nullptr;
}

JSObjectRef JsObject::GetObject()
{
    if (JSValueIsObject(mContext, (JSValueRef)mPersistent))
    {
        return mPersistent;
    }
    return nullptr;
}

void JsObject::MakePersistent()
{
    if (mPersistent && JsObject::IsValid(mContext, mPersistent))
    {
        ++mReferenceCount;
        JSValueProtect(mContext, mPersistent);
    }
}

void JsObject::MakeWeak()
{
    if (mPersistent && JsObject::IsValid(mContext, mPersistent))
    {
        JSValueUnprotect(mContext, mPersistent);
        --mReferenceCount;
        if (0 == mReferenceCount)
        {
            JsObject::onFinalize(mPersistent);
        }
    }
}

bool JsObject::Equals(const JSValueRef other)
{
    return JSValueIsEqual(mContext, mPersistent, other, nullptr);
}

bool JsObject::Equals(const JSObjectRef other)
{
    return mPersistent && JSValueIsEqual(mContext, mPersistent, other, nullptr);
}

void JsObject::SetTarget(Base *target)
{
    mTarget = target;
}

void JsObject::BindTo(const std::string &name, JsObject *target)
{
    JSObjectRef parent = target ? target->GetObject() : JSContextGetGlobalObject(mContext);
    JsObject::Set(mContext, parent, name.c_str(), this->GetValue());
}

bool JsObject::Has(const std::string &name)
{
    if (!mPersistent || !JSValueIsObject(mContext, mPersistent)) return false;
    
    JSObjectRef object = JSValueToObject(mContext, mPersistent, nullptr);
    return JsObject::IsValid(mContext, JsObject::GetValue(mContext, object, name.c_str()));
}

bool JsObject::Set(const std::string &name, JsObject *value)
{
    return this->Set(name, value ? value->GetValue() : JSValueMakeNull(mContext));
}

/*static*/ void JsObject::Set(const JSContextRef context, const JSObjectRef target, const std::string &name, const JSObjectRef value)
{
    if (!context || !target) return;
    JSValueRef exception = nullptr;
    JSStringRef nameString = JSStringCreateWithUTF8CString(name.c_str());
    JSObjectSetProperty(context, target, nameString, value, 0, &exception);
    JSStringRelease(nameString);
    if (exception)
    {
        LogError(JsObject::ToString(context, exception).c_str());
    }
}

bool JsObject::Set(const std::string &name, const JSValueRef value)
{
    return JsObject::Set(mContext, mPersistent, name, value);
}

/*static*/ bool JsObject::Set(const JSContextRef context, const JSObjectRef target, const std::string& name, const JSValueRef value)
{
    if (!target || !JSValueIsObject(context, target)) return false;
    
    JSValueRef exception = 0;
    JSStringRef jsName = JSStringCreateWithUTF8CString(name.c_str());
    JSObjectSetProperty(context, target, jsName, SAFE_VALUE(value, JSValueMakeNull(context)), 0, &exception);
    JSStringRelease(jsName);
    if (exception)
    {
        LogError(JsObject::ToString(context, exception).c_str());
        return false;
    }
    return true;
}

JsObject *JsObject::GetJsObject(const std::string &name)
{
    if (!mPersistent || !JSValueIsObject(mContext, mPersistent)) return nullptr;
    
    JSObjectRef object = JSValueToObject(mContext, mPersistent, nullptr);
    JSValueRef property = JsObject::GetValue(mContext, object, name.c_str());
    JsObject *value = JsObject::Convert(mContext, JSValueToObject(mContext, property, nullptr));
    if ((!value && JsObject::IsValid(mContext, property)))
    {
        value = JsObject::Create(mContext, nullptr, property);
    }
    return value;
}

/*static*/ JSValueRef JsObject::GetValue(const JSContextRef context, const JSObjectRef target, const std::string& name)
{
    if (!context || !JSValueIsObject(context, target) || !JsObject::IsValid(context, target)) return nullptr;
    
    JSStringRef jsString = JSStringCreateWithUTF8CString(name.c_str());
    JSValueRef value = JSObjectGetProperty(context, target, jsString, nullptr);
    JSStringRelease(jsString);
    return value;
}

/*static*/ JSObjectRef JsObject::GetObject(const JSContextRef context, const JSObjectRef target, const std::string &name)
{
    if (!context || !target)
        return nullptr;
    
    JSStringRef propertyName = JSStringCreateWithUTF8CString(name.c_str());
    JSValueRef property = JSObjectGetProperty(context, target, propertyName, 0);
    JSStringRelease(propertyName);
    return JSValueToObject(context, property, nullptr);
}

bool JsObject::Set(const unsigned long long& index, JsObject* object)
{
    return this->Set(index, object->GetValue());
}

bool JsObject::Set(const unsigned long long& index, const JSValueRef value)
{
    if (!mPersistent || !JSValueIsObject(mContext, mPersistent))
        return false;
    JSObjectRef object = JSValueToObject(mContext, mPersistent, nullptr);
    JSObjectSetPropertyAtIndex(mContext, object, (unsigned int)index, value, nullptr);
    return true;
}

/*static*/ JSValueRef JsObject::Get(const JSContextRef context, const JSObjectRef target, const unsigned int& index)
{
    if (!context || !JSValueIsObject(context, target) || !JsObject::IsValid(context, target)) return nullptr;
    
    return JSObjectGetPropertyAtIndex(context, target, index, nullptr);
}

bool JsObject::Set(const unsigned long long& index, const std::string& value)
{
    if (!mPersistent || !JSValueIsObject(mContext, mPersistent))
        return false;
    JSObjectRef object = JSValueToObject(mContext, mPersistent, nullptr);
    JSStringRef jsValue = JSStringCreateWithUTF8CString(value.c_str());
    JSObjectSetPropertyAtIndex(mContext, object, (unsigned int)index, JSValueMakeString(mContext, jsValue), nullptr);
    JSStringRelease(jsValue);
    return true;
}

bool JsObject::Set(const std::string &name, const std::string &value)
{
    if (!mPersistent || !JSValueIsObject(mContext, mPersistent))
        return false;
    JSObjectRef object = JSValueToObject(mContext, mPersistent, nullptr);
    return JsObject::Set(mContext, object, name.c_str(), value.c_str());
}

std::string JsObject::GetString(const std::string &name)
{
    if (!mPersistent || !JSValueIsObject(mContext, mPersistent)) return "";
    
    JSObjectRef object = JSValueToObject(mContext, mPersistent, nullptr);
    JSValueRef property = JsObject::GetValue(mContext, object, name.c_str());
    return JsObject::ToString(mContext, property);
}

bool JsObject::Set(const std::string &name, const unsigned long long &value)
{
    if (!mPersistent || !JSValueIsObject(mContext, mPersistent))
        return false;
    JSObjectRef object = JSValueToObject(mContext, mPersistent, nullptr);
    return JsObject::Set(mContext, object, name.c_str(), value);
}

/*static*/ bool JsObject::Set(const JSContextRef context, const JSObjectRef target, const std::string& name, const std::string& value)
{
    JSStringRef jsString = JSStringCreateWithUTF8CString(value.c_str());
    bool result = JsObject::Set(context, target, name, JSValueMakeString(context, jsString));
    JSStringRelease(jsString);
    return result;
}

unsigned long long JsObject::GetUint64(const std::string &name)
{
    return JsObject::GetUint64(mContext, mPersistent, name);
}

/*static*/ unsigned long long JsObject::GetUint64(const JSContextRef context, const JSObjectRef target, const std::string& name)
{
    JSValueRef value = JsObject::GetValue(context, target, name);
    return value ? JsObject::ToUint64(context, value) : 0;
}

bool JsObject::DefineProperty(const std::string& name, const TypescriptProperty* property)
{
    JSContextRef context = mContext;
    JSObjectRef instance = mPersistent;
    if (!mPersistent || !JSValueIsObject(mContext, instance)) return false;
    
    unsigned long long nativeHandle = reinterpret_cast<unsigned long long>(property);
    
    JSStringRef propertyName = JSStringCreateWithUTF8CString(name.c_str());
    bool hasProperty = JSObjectHasProperty(context, instance, propertyName);
    if (hasProperty && NAME != name)
    {
        std::vector<JSValueRef> arguments(3);
        arguments.data()[0] = instance;
        arguments.data()[1] = JSValueMakeString(context, propertyName);
        arguments.data()[2] = JSValueMakeNumber(context, (double)nativeHandle);
        JsObject* result = sCheckPropertyNativeHandleMethod->CallAsFunction(arguments, true);
        assert(result);
        if (result->ToBoolean())
        {
            LogWarning("Try to define property %s but there is already a property with same name ...", property->GetFullname().c_str());
            JSStringRelease(propertyName);
            return false;
        }
    }
    JSStringRelease(propertyName);
    
    const bool isStatic = property->CheckType(BaseChildTypes::BaseChildType_StaticProperty);
    JSObjectRef jsGetter = property->HasGetter() ? JSObjectMakeFunctionWithCallback(context, nullptr, isStatic ? onStaticPropertyGetterCall : onInstancePropertyGetterCall) : nullptr;
    JSObjectRef jsSetter = property->HasSetter() ? JSObjectMakeFunctionWithCallback(context, nullptr, isStatic ? onStaticPropertySetterCall : onInstancePropertySetterCall) : nullptr;
    assert(jsGetter);
    
    JSObjectRef descriptor = JSObjectMake(context, nullptr, nullptr);
//    JsObject:Set(context, descriptor, "configurable", JSValueMakeBoolean(mContext, true));
    if (jsGetter)
    {
        JsObject::Set(context, descriptor, "get", jsGetter);
        JsObject::Set(context, jsGetter, NATIVE_OBJECT_HANDLE, nativeHandle);
#if DEBUG
        JsObject::Set(context, jsGetter, FULLNAME, property->GetFullname());
#endif
    }
    if (jsSetter)
    {
        JsObject::Set(context, descriptor, "set", jsSetter);
        JsObject::Set(context, jsSetter, NATIVE_OBJECT_HANDLE, nativeHandle);
#if DEBUG
        JsObject::Set(context, jsSetter, FULLNAME, property->GetFullname());
#endif
    }
    
    std::vector<JSValueRef> arguments(3);
    JSValueRef* argumentData = arguments.data();
    JSStringRef jsPropertyName = JSStringCreateWithUTF8CString(name.c_str());
    argumentData[0] = instance;
    argumentData[1] = JSValueMakeString(context, jsPropertyName);
    argumentData[2] = descriptor;
    sDefinePropertyMethod->CallAsFunction(arguments);
    JSStringRelease(jsPropertyName);
    
    return true;
}

std::vector<JSValueRef> JsObject::deserializeParameters(JsObject* jsObject)
{
    std::vector<JSValueRef> parameters;
    if (jsObject)
    {
        JSValueRef value = jsObject->GetValue();
        if (JSValueIsArray(mContext, value))
        {
            JSObjectRef array = JSValueToObject(mContext, value, nullptr);
            JSValueRef lengthValue = JsObject::GetValue(mContext, array, "length");
            uint32_t length = JsObject::ToUint32(mContext, lengthValue);
            if (length > 0)
            {
                parameters.resize((size_t)length);
                for (uint32_t i = 0; i < length; ++i)
                {
                    parameters.data()[i] = JSObjectGetPropertyAtIndex(mContext, array, i, nullptr);
                }
            }
        }
        else
        {
            parameters.push_back(value);
        }
    }
    return parameters;
}

JSValueRef JsObject::CallAsConstructor()
{
    if (!mPersistent || !JSObjectIsConstructor(mContext, mPersistent))
    {
        return nullptr;
    }
    
    JSValueRef exception = nullptr;
    JSValueRef result = JSObjectCallAsConstructor(mContext, mPersistent, 0, nullptr, &exception);
    if (Environment::ClearException(&exception))
    {
        return nullptr;
    }
    return result;
}

JsObject* JsObject::CallFunction(const std::string& name, const std::vector<JSValueRef>& arguments, const bool& needResult)
{
    JSObjectRef object = this->GetObject();
    if (!JsObject::IsValid(mContext, object)) return nullptr;
    
    JSValueRef property = JsObject::GetValue(mContext, object, name.c_str());;
    if (JsObject::IsValid(mContext, property))
    {
        JSValueRef exception = nullptr;
        JSObjectRef function = JSValueToObject(mContext, property, nullptr);
        JSValueRef result = JSObjectCallAsFunction(mContext, function, object, arguments.size(), arguments.data(), &exception);
        if (exception)
        {
            LogError(JsObject::ToString(mContext, exception));
        }
        return needResult ? JsObject::Create(mContext, nullptr, result) : nullptr;
    }
    return nullptr;
}

JsObject* JsObject::CallAsFunction(const std::vector<JSValueRef>& arguments, const bool& needResult)
{
    JSObjectRef function = this->GetObject();
    if (!JsObject::IsValid(mContext, function)) return nullptr;
    
    JSValueRef exception = nullptr;
    JSValueRef result = JSObjectCallAsFunction(mContext, function, nullptr, arguments.size(), arguments.data(), &exception);
    if (exception)
    {
        LogError(JsObject::ToString(mContext, exception));
    }
    return needResult ? JsObject::Create(mContext, nullptr, result) : nullptr;
}

bool JsObject::ToBoolean()
{
    return ToBoolean(mContext, this->GetValue());
}

/*static*/ bool JsObject::ToBoolean(JSContextRef context, const JSValueRef value)
{
    if (!value)
        return false;
    return JSValueToBoolean(context, value);
}

std::string JsObject::ToString()
{
    return ToString(mContext, this->GetValue());
}

/*static*/ std::string JsObject::ToString(JSContextRef context, const JSValueRef value)
{
    if (!value) return "";
    
    JSValueRef exception = nullptr;
    JSStringRef jsString = JSValueToStringCopy(context, value, &exception);
    if (exception)
    {
        LogError(JsObject::ToString(context, exception).c_str());
    }
    if (jsString)
    {
        std::string value = JsObject::ToString(context, jsString);
        JSStringRelease(jsString);
        return value;
    }
    return "";
}

/*static*/ std::string JsObject::ToString(JSContextRef context, const JSStringRef value)
{
    if (!value) return "";
    
    char* buffer = 0;
    unsigned long length = JSStringGetMaximumUTF8CStringSize(value) + 1;
    buffer = (char*)malloc(length);
    JSStringGetUTF8CString(value, buffer, length);
    std::string result = buffer;
    free(buffer);
    
    return result;
}

int JsObject::ToInt32()
{
    return ToInt32(mContext, this->GetValue());
}

/*static*/ int JsObject::ToInt32(JSContextRef context, const JSValueRef value)
{
    return (int)JsObject::ToDouble(context, value);
}

unsigned int JsObject::ToUint32()
{
    return ToUint32(mContext, this->GetValue());
}

/*static*/ unsigned int JsObject::ToUint32(JSContextRef context, const JSValueRef value)
{
    return (unsigned int)JsObject::ToDouble(context, value);
}

long long JsObject::ToInt64()
{
    return ToInt64(mContext, this->GetValue());
}

/*static*/ long long JsObject::ToInt64(JSContextRef context, const JSValueRef value)
{
    return (long long)JsObject::ToDouble(context, value);
}

unsigned long long JsObject::ToUint64()
{
    return ToUint64(mContext, this->GetValue());
}

/*static*/ unsigned long long JsObject::ToUint64(JSContextRef context, const JSValueRef value)
{
    return (unsigned long long)JsObject::ToDouble(context, value);
}

float JsObject::ToSingle()
{
    return ToSingle(mContext, this->GetValue());
}

/*static*/ float JsObject::ToSingle(JSContextRef context, const JSValueRef value)
{
    return (float)JsObject::ToDouble(context, value);
}

double JsObject::ToDouble()
{
    return ToDouble(mContext, this->GetValue());
}

/*static*/ double JsObject::ToDouble(JSContextRef context, const JSValueRef value)
{
    if (!value) return 0;
    return JSValueToNumber(context, value, nullptr);
}

//////////////////////////////////////////////////////////////////////////

/*static*/ bool JsObject::IsValid(JSContextRef context, const JSObjectRef object)
{
    return IsValid(context, (JSValueRef)object);
}

/*static*/ bool JsObject::IsValid(JSContextRef context, const JSValueRef value)
{
    if (!context)
        return false;

    if (!value)
    {
        return false;
    }
    if (JSValueIsNull(context, value) || JSValueIsUndefined(context, value))
    {
        return false;
    }
    if (!JSValueIsBoolean(context, value) && !JSValueToBoolean(context, value))
    {
        return false;
    }
    return true;
}

///*static*/ JSValueRef JsObject::GetJsValue()(JSContextRef context, JSObjectRef target, const std::string& name)
//{
//    return target->Get(String::NewFromUtf8(target->Getcontext(), name.c_str())).As<Object>();
//}
//
///*static*/ void JsObject::SetJsValue(JSContextRef context, JS_OBJECT_TYPE& target, const std::string& name, JSValueRef& value)
//{
//    JSValueRef exception = 0;
//    JSObjectRef object = JSValueToObject(context, target, &exception);
//    if (exception)
//    {
//        LogError(JsObject::ToString(context, exception).c_str());
//        return;
//    }
//    SetObjectProperty(context, object, name, property);
//}

/*static*/ JSObjectRef JsObject::GetPrototypeFromConstructor(const JSContextRef context, const JSObjectRef constructor)
{
    JSValueRef prototypeValue = JSObjectGetProperty(context, constructor, sProtytypeName, nullptr);
    return JSValueToObject(context, prototypeValue, nullptr);
}

/*static*/ void* JsObject::GetNativeObjectHandle(const JSContextRef context, const JSObjectRef object)
{
    JSValueRef handleValue = JSObjectGetProperty(context, object, sNativeObjectHandleName, nullptr);
    return JsObject::ToHandle(context, handleValue);
}

/*static*/ bool JsObject::Set(const JSContextRef context, const JSObjectRef target, const std::string& name, const unsigned long long value)
{
    return JsObject::Set(context, target, name, JSValueMakeNumber(context, (double)value));
}

/*static*/ std::string JsObject::GetString(const JSContextRef context, const JSObjectRef target, const std::string& name)
{
    JSValueRef value = JsObject::GetValue(context, target, name);
    return value ? JsObject::ToString(context, value) : "";
}
