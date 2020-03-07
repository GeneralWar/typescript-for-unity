//
//  class.apple.cpp
//  typescript-mac
//
//  Created by 朱嘉灵 on 2020/1/6.
//  Copyright © 2020 朱嘉灵. All rights reserved.
//

#include "core/class/Class.h"
#include "core/object/Object.h"
#include "Utils.h"
#include "Utils.apple.h"
#include "core/function/Function.h"
#include "core/property/Property.h"
#include "core/Environment.h"

extern DEFINE_JS_FUNCTION_CALLBACK(onStaticFunctionCall);
extern DEFINE_JS_CONSTRUCTOR_CALLBACK(onConstructorCall);

/*static*/ void TypescriptClass::CheckConstructors(JSContextRef context, const JSValueRef value)
{
    JSValueRef exception = nullptr;
    JSObjectRef target = JSValueToObject(context, value, &exception);
    if (Environment::ClearException(&exception))
    {
        return;
    }
    
    JSPropertyNameArrayRef propertyNames = JSObjectCopyPropertyNames(context, target);
    size_t count = JSPropertyNameArrayGetCount(propertyNames);
    for (size_t i = 0; i < count; ++i)
    {
        JSStringRef nameString = JSPropertyNameArrayGetNameAtIndex(propertyNames, i);
        std::string name = JsObject::ToString(context, nameString);
        JSValueRef property = JSObjectGetProperty(context, target, nameString, &exception);
        JSStringRelease(nameString);
        if (Environment::ClearException(&exception))
        {
            continue;
        }
        
        if (!property || !JSValueIsObject(context, property))
        {
            continue;
        }
        
        JSObjectRef propertyObject = JSValueToObject(context, property, &exception);
        if (JSObjectIsConstructor(context, propertyObject))
        {
            std::string fullname = GetCustomType(context, propertyObject) + "." + name;
            JsObject::Set(context, propertyObject, FULLNAME, fullname.c_str());
            if (fullname.empty()) continue;
            
            TypescriptClass* baseType = TypescriptClass::FindBaseClass(fullname);
            if (!baseType)
            {
                LogWarning("Try to declare class %s but no base type found ...", fullname.c_str());
                continue;
            }
            
            TypescriptClass::Derive(baseType, fullname, propertyObject);
        }
        else if (JsObject::IsValid(context, propertyObject))
        {
            CheckConstructors(context, property);
        }
    }
}

/*static*/ JsObject* TypescriptClass::Instantiate(JSContextRef context, const std::string& type, const size_t& size)
{
    TypescriptClass* typeInstance = TypescriptClass::FindClass(type);
    if (typeInstance)
    {
        JSObjectRef jsObject = nullptr;
        JSClassRef jsClass = typeInstance->GetJsClass();
        if (jsClass)
        {
            jsObject = JSObjectMake(context, jsClass, nullptr);
        }
        else
        {
            JsObject* constructor = typeInstance->GetJsObject();
            JSValueRef result = constructor->CallAsConstructor();
            if (JSValueIsObject(context, result))
            {
                jsObject = JSValueToObject(context, result, nullptr);
            }
        }
        
        JsObject* instance = JsObject::Create(context, typeInstance, jsObject, size);
//        typeInstance->Instantiate(instance);
        return instance;
    }
    LogError("Try to create an instance of %s but no type instance found!");
    return JsObject::Create(context, nullptr);
}

void TypescriptClass::bind()
{
    if (mJsObject) return;

    if (mIsStatic)
    {
        mJsObject = JsObject::Create(INTERNAL_JS_CONTEXT_NAME, this, (JS_CONSTRUCTOR_CALLBACK_TYPE)onConstructorCall, this);
    }
}

void TypescriptClass::Register(const std::string& parentType)
{
    mBaseClassName = parentType;
    if (mJsObject) return;
    
    JSClassDefinition definition = { };
    definition.version = 0;
    definition.className = mName.c_str();
    definition.attributes = kJSClassAttributeNone;
//    definition.initialize = JsObject::onInitialize;
    definition.finalize = JsObject::onFinalize;

    if (!mBaseClass && !mBaseClassName.empty())
    {
        mBaseClass = TypescriptClass::FindClass(mBaseClassName);
    }
    if (mBaseClass)
    {
        definition.parentClass = mBaseClass->mJsClass;
    }
    size_t instanceFunctionCount = mInstanceFunctions.size() + 1;
    if (instanceFunctionCount > 1)
    {
        std::vector<JSStaticFunction> instanceFunctions(instanceFunctionCount);
        JSStaticFunction* functionPointer = instanceFunctions.data();
        memset(functionPointer, 0, sizeof(JSStaticFunction) * instanceFunctionCount);
        for (std::map<std::string, TypescriptFunction*>::iterator iterator = mInstanceFunctions.begin(); mInstanceFunctions.end() != iterator; ++iterator)
        {
            functionPointer->name = iterator->first.data();
            functionPointer->callAsFunction = onStaticFunctionCall;
            functionPointer->attributes = kJSPropertyAttributeNone;
            ++functionPointer;
        }
        definition.staticFunctions = instanceFunctions.data();
    }
    //    std::vector<JSStaticValue> staticProperties(mStaticProperties.size());
    //    for (auto pair : mStaticProperties)
    //    {
    //        staticProperties.push_back({ pair.first.c_str(), onStaticPropertyGetterCall, onStaticPropertySetterCall, kJSPropertyAttributeNone });
    //    }
    //    definition.staticValues = staticProperties.data();
    
    mJsClass = JSClassCreate(&definition);
    
    mJsObject = JsObject::Create(INTERNAL_JS_CONTEXT_NAME, this, (JS_CONSTRUCTOR_CALLBACK_TYPE)onConstructorCall, this);
    mJsObject->Set(NAME, mName);
    mJsObject->Set(FULLNAME, mFullname);
    mJsObject->MakePersistent();
    
    mPrototype = mJsObject->GetJsObject(PROTOTYPE);
    mPrototype->SetTarget(this);
    assert(mPrototype);
    
    for (auto pair : mInstanceFunctions)
    {
        mPrototype->Set(pair.first, pair.second->GetJsObject());
    }
    for (auto pair : mStaticFunctions)
    {
        JsObject* object = pair.second->GetJsObject();
        mJsObject->Set(pair.first, object);
    }
    for (auto pair : mInstanceProperties)
    {
        TypescriptProperty* property = pair.second;
        mPrototype->DefineProperty(property->GetName(), property);
    }
    for (auto pair : mStaticProperties)
    {
        TypescriptProperty* property = pair.second;
        mJsObject->DefineProperty(property->GetName(), property);
    }
        
    this->bindNativeInstance();

	assert(mParent);
    mJsObject->BindTo(mName, mParent ? mParent->GetJsObject() : nullptr);
}
