#include "Function.h"
#include "delegates.h"
#include "core/function/Parameters.h"
#include "../object/Object.h"
#include "../class/Class.h"

#ifdef __APPLE__
extern JSValueRef onStaticFunctionCall (JSContextRef context, JSObjectRef function, JSObjectRef thisObject, size_t argumentCount, const JSValueRef arguments[], JSValueRef* exception);
#else
extern void onStaticFunctionCall(const FunctionCallbackInfo<Value>& info);
#endif

ASSIGN_BASE_CHILD_TYPE(TypescriptFunction, BaseChildTypes::BaseChildType_Function);
ASSIGN_BASE_CHILD_TYPE(TypescriptStaticFunction, BaseChildTypes::BaseChildType_StaticFunction);
ASSIGN_BASE_CHILD_TYPE(TypescriptInstanceFunction, BaseChildTypes::BaseChildType_InstanceFunction);

TypescriptFunction::TypescriptFunction(const BaseChildTypes& type, const std::string& name, Base* parent, JS_FUNCTION_CALLBACK_TYPE callback) : Base(TYPE | type, name, parent), mCallback(callback) { }

TypescriptFunction::~TypescriptFunction() { }

void TypescriptFunction::bind()
{
	if (mJsObject) return;
	mJsObject = JsObject::Create(INTERNAL_JS_CONTEXT_NAME, this, mCallback, this);
    mJsObject->Set(NAME, mName);
    mJsObject->Set(FULLNAME, mFullname);
    mJsObject->MakePersistent();
}

void TypescriptFunction::BindTo(JsObject* target)
{
	if (!mJsObject)
	{
		this->Base::Bind();
	}
	target->Set(mName, mJsObject);
}

TypescriptStaticFunction* TypescriptStaticFunction::Create(const std::string& name, Base* parent, JS_FUNCTION_CALLBACK_TYPE callback)
{
	return Base::Create<TypescriptStaticFunction>(name, parent, VALID_DEFAULT(callback, onStaticFunctionCall));
}

TypescriptStaticFunction::TypescriptStaticFunction(const std::string& name, Base* parent, JS_FUNCTION_CALLBACK_TYPE callback) : TypescriptFunction(TYPE, name, parent, callback) { }

TypescriptStaticFunction::~TypescriptStaticFunction() { }

extern StaticFunctionCallback sStaticFunctionCallback;
extern DEFINE_JS_FUNCTION_CALLBACK(onInstanceFunctionCall);

JsObject* TypescriptStaticFunction::Invoke(JS_PARAMETERS)
{
#if USE_ENGINE_V8
    Parameters parameters(info);
#else
    Parameters parameters(arguments, argumentCount);
#endif
	JsObject* result = sStaticFunctionCallback(this, parameters.address(), parameters.count());
	return result;
}

TypescriptInstanceFunction* TypescriptInstanceFunction::Create(const std::string& name, Base* parent, JS_FUNCTION_CALLBACK_TYPE callback)
{
	return Base::Create<TypescriptInstanceFunction>(name, parent, VALID_DEFAULT(callback, onInstanceFunctionCall));
}

TypescriptInstanceFunction::TypescriptInstanceFunction(const std::string& name, Base* parent, JS_FUNCTION_CALLBACK_TYPE callback) : TypescriptFunction(TYPE, name, parent, callback) { }

TypescriptInstanceFunction::~TypescriptInstanceFunction() { }

void TypescriptInstanceFunction::Bind()
{
	assert(mParent);

	this->bind();
	this->bindNativeInstance();
}

JsObject* TypescriptInstanceFunction::Invoke(JS_PARAMETERS)
{
#if DEBUG
	assert(0);
#endif
	return nullptr;
}
