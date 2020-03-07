#include "Object.h"
#include "core/Base.h"
#include "types/NumberData.h"

/*static*/ JsObject* JsObject::Create(JS_CONTEXT_TYPE context, Base* target, const JS_OBJECT_TYPE object, const size_t& size)
{
    if (!context || !JsObject::IsValid(context, object)) return nullptr;
    
    JsObject* instance = Convert(context, object);
    if (nullptr == instance || !instance->Equals(object))
    {
        instance = new JsObject(context, target, object, size);
    }
    return instance;
}

/*static*/ JsObject *JsObject::CreateBoolean(JS_CONTEXT_TYPE context, const bool &value)
{
	if (!context) return nullptr;
	NumberData data{};
	data.boolean = value;
	return new JsObject(context, nullptr, data, JsTypes::TYPE_BOOLEAN);
}

/*static*/ JsObject *JsObject::CreateString(JS_CONTEXT_TYPE context, const std::string &value)
{
	if (!context) return nullptr;
	return new JsObject(context, nullptr, value);
}

/*static*/ JsObject *JsObject::CreateInt32(JS_CONTEXT_TYPE context, const int &value)
{
	if (!context) return nullptr;
	NumberData data{};
	data.int32 = value;
	return new JsObject(context, nullptr, data, JsTypes::TYPE_NUMBER, JsNumberTypes::TYPE_NUMBER_INT32);
}

/*static*/ JsObject *JsObject::CreateUint32(JS_CONTEXT_TYPE context, const unsigned int &value)
{
	if (!context) return nullptr;
	NumberData data{};
	data.uint32 = value;
	return new JsObject(context, nullptr, data, JsTypes::TYPE_NUMBER, JsNumberTypes::TYPE_NUMBER_UINT32);
}

/*static*/ JsObject *JsObject::CreateInt64(JS_CONTEXT_TYPE context, const long long &value)
{
	if (!context) return nullptr;
	NumberData data{};
	data.int64 = value;
	return new JsObject(context, nullptr, data, JsTypes::TYPE_NUMBER, JsNumberTypes::TYPE_NUMBER_INT64);
}

/*static*/ JsObject *JsObject::CreateUint64(JS_CONTEXT_TYPE context, const unsigned long long &value)
{
	if (!context) return nullptr;
	NumberData data{};
	data.uint64 = value;
	return new JsObject(context, nullptr, data, JsTypes::TYPE_NUMBER, JsNumberTypes::TYPE_NUMBER_UINT64);
}

/*static*/ JsObject *JsObject::CreateSingle(JS_CONTEXT_TYPE context, const float &value)
{
	if (!context) return nullptr;
	NumberData data{};
	data.float32 = value;
	return new JsObject(context, nullptr, data, JsTypes::TYPE_NUMBER, JsNumberTypes::TYPE_NUMBER_SINGLE);
}

/*static*/ JsObject *JsObject::CreateDouble(JS_CONTEXT_TYPE context, const double &value)
{
	if (!context) return nullptr;
	NumberData data{};
	data.float64 = value;
	return new JsObject(context, nullptr, data, JsTypes::TYPE_NUMBER, JsNumberTypes::TYPE_NUMBER_DOUBLE);
}

void JsObject::removeTarget()
{
	if (mTarget)
	{
		mTarget->dettachJsObject();
		mTarget = nullptr;
	}
}

bool JsObject::Equals(JsObject* other)
{
	if (mType != other->mType || mSubType != other->mSubType)
	{
		return false;
	}

	if (JsTypes::TYPE_BOOLEAN == mType || JsTypes::TYPE_NUMBER == mType)
	{
		return mNumber && !memcmp(&mNumber, &other->mNumber, sizeof(NumberData));
	}

	if (JsTypes::TYPE_STRING == mType)
	{
		return 0 == strcmp(mString, other->mString);
	}
#if USE_ENGINE_V8
	return other->Equals(mPersistent.Get(INTERNAL_JS_CONTEXT_NAME));
#else
	return other->Equals(mPersistent);
#endif
}

/*static*/ void* JsObject::ToHandle(JS_CONTEXT_TYPE context, const JS_VALUE_TYPE value)
{
    unsigned long long handle = JsObject::ToUint64(context, value);
    return reinterpret_cast<void*>(handle);
}

void* JsObject::GetInstanceField()
{
	return mStructure ? mStructure->data : nullptr;
}

JsObject* JsObject::CallFunction(const std::string &name, JsObject *arguments, const bool& needResult)
{
	std::vector<JS_VALUE_TYPE> parameters = this->deserializeParameters(arguments);
	return this->CallFunction(name, parameters, needResult);
}

JsObject* JsObject::CallFunction(const std::string& name, const std::vector<JsObject*>& arguments, const bool& needResult)
{
	size_t argumentCount = arguments.size();
	std::vector<JS_VALUE_TYPE> parameters(argumentCount);
	for (size_t i = 0; i < argumentCount; ++i)
	{
		parameters.data()[i] = arguments[i]->GetValue();
	}
	return this->CallFunction(name, parameters, needResult);
}

JsObject* JsObject::CallAsFunction(JsObject* arguments, const bool& needResult)
{
	std::vector<JS_VALUE_TYPE> parameters = this->deserializeParameters(arguments);
	return this->CallAsFunction(parameters, needResult);
}

JsObject* JsObject::CallAsFunction(const std::vector<JsObject*>& arguments, const bool& needResult)
{
	size_t argumentCount = arguments.size();
	std::vector<JS_VALUE_TYPE> parameters(argumentCount);
	for (size_t i = 0; i < argumentCount; ++i)
	{
		parameters.data()[i] = arguments[i]->GetValue();
	}
	return this->CallAsFunction(parameters, needResult);
}
