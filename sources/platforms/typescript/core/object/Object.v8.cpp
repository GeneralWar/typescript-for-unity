#include "core/object/Object.h"
#include "extra/log/Log.h"
#include "core/Base.h"
#include "core/function/Argument.h"
#include "core/property/Property.h"

extern DEFINE_JS_FUNCTION_CALLBACK(onStaticPropertyGetterCall);
extern DEFINE_JS_FUNCTION_CALLBACK(onStaticPropertySetterCall);
extern DEFINE_JS_FUNCTION_CALLBACK(onInstancePropertyGetterCall);
extern DEFINE_JS_FUNCTION_CALLBACK(onInstancePropertySetterCall);

/*static*/ std::unordered_map<void*, JsObject*> JsObject::sJsToNativeMap;

/*static*/ GarbageCollectionCallback JsObject::sGarbageCollectionCallback = nullptr;

/*static*/ bool JsObject::Initialize(Isolate* isolate)
{
	return true;
}

/*static*/ JsObject* JsObject::Create(Isolate* isolate, Base *target)
{
	if (!isolate)
	{
		return nullptr;
	}

	return Create(isolate, target, Object::New(isolate));
}

/*static*/ JsObject* JsObject::Create(Isolate* isolate, Base* target, const Local<Value> value)
{
	if (!isolate || !JsObject::IsValid(isolate, value)) return nullptr;
	if (value->IsObject())
	{
		return Create(isolate, target, value.As<Object>());
	}
	else if (value->IsString())
	{
		return CreateString(isolate, JsObject::ToString(isolate, value));
	}
	else if (value->IsBoolean())
	{
		return CreateBoolean(isolate, JsObject::ToBoolean(isolate, value));
	}
	else if (value->IsBigInt())
	{
		return CreateInt64(isolate, value.As<BigInt>()->Int64Value());
	}
	else if (value->IsNumber())
	{
		return CreateDouble(isolate, JsObject::ToDouble(isolate, value));
	}
	else if (value->IsNull())
	{
		return new JsObject(isolate, target, { }, (int)JsTypes::TYPE_NULL);
	}
	else if (value->IsUndefined())
	{
		return new JsObject(isolate, target, { }, (int)JsTypes::TYPE_UNDEFINED);
	}
	assert(0);
	return nullptr;
}

/*static*/ JsObject* JsObject::Create(Isolate* isolate, Base *target, const JS_FUNCTION_CALLBACK_TYPE callback, const void *handle)
{
	if (!isolate) return nullptr;
	Local<Context> context = isolate->GetCurrentContext();
	MaybeLocal<Function> maybeObject = Function::New(context, callback, BigInt::NewFromUnsigned(isolate, (unsigned long long)handle));
	if (maybeObject.IsEmpty())
	{
		return nullptr;
	}
	return Create(isolate, target, maybeObject.ToLocalChecked().As<Object>());
}

/*static*/ JsObject* JsObject::Create(Isolate* isolate, Base *target, const JS_FUNCTION_CALLBACK_TYPE callback, const std::string &name)
{
	if (!isolate) return nullptr;
	Local<Context> context = isolate->GetCurrentContext();
	MaybeLocal<Function> maybeObject = Function::New(context, callback, String::NewFromUtf8(isolate, name.c_str()));
	if (maybeObject.IsEmpty())
	{
		return nullptr;
	}
	return Create(isolate, target, maybeObject.ToLocalChecked().As<Object>());
}

JsObject* JsObject::CreateArray(Isolate* isolate, const int& length)
{
	if (!isolate)
		return nullptr;
	Local<Array> array = Array::New(isolate, length);
	return Create(isolate, nullptr, array.As<Object>());
}

JsObject* JsObject::CreateArray(Isolate* isolate, JsObject** elements, const int& length)
{
	if (!isolate)
		return nullptr;
	std::vector<Local<Value>> elementVector((size_t)length);
	for (int i = 0; i < length; ++i)
	{
		JsObject* object = elements[i];
#if DEBUG
		assert(object);
#endif
		elementVector.data()[i] = object->GetValue();
	}
	Local<Array> array = Array::New(isolate, elementVector.data(), (size_t)length);
	return Create(isolate, nullptr, array.As<Object>());
}

/*static*/ JsObject* JsObject::Instantiate(Isolate* isolate, JsObject* prototype)
{
	if (!isolate) return nullptr;

	if (!prototype)
	{
		DEBUG_LOG("Try to instantiate but prototype is null, return a default js object!");
		return JsObject::Create(isolate, nullptr);
	}

	if (prototype->IsObject())
	{
		Local<Value> result = Object::New(isolate, prototype->GetObject(), nullptr, nullptr, 0);
		assert(!result.IsEmpty() && result->IsObject());
		Local<Object> instance = result.As<Object>();
		instance->Set(String::NewFromUtf8(isolate, JS_INSTANCE_HANDLE), Undefined(isolate));
		return JsObject::Create(isolate, prototype->GetTarget(), instance);
		//return result->IsObject() ? JsObject::Create(isolate, nullptr, result.As<Object>()) : JsObject::Create(isolate, nullptr, result);
	}
#if DEBUG
	assert(0);
#endif
	LogError("Failed to instantiate value!");
	return JsObject::Create(isolate, nullptr);
}

/*static*/ JsObject* JsObject::Convert(Isolate* isolate, Local<Object> object)
{
	// Only convert object.
	if (!isolate || object.IsEmpty() || !IsValid(isolate, object))
	{
		return nullptr;
	}

	JsObject* instance = Find((void*)JsObject::GetUint64(isolate, object, JS_INSTANCE_HANDLE));
	//assert(!instance || instance->GetObject()->Equals(isolate->GetCurrentContext(), object).FromMaybe(false));
	return instance;
}

/*static*/ JsObject* JsObject::Find(void *handle)
{
	auto finder = sJsToNativeMap.find(handle);
	return sJsToNativeMap.end() == finder ? nullptr : finder->second;
}

/*static*/ void JsObject::Clear()
{
	for (auto iterator : sJsToNativeMap)
	{
		JsObject* instance = iterator.second;
		instance->removeTarget();
		delete instance;
	}
	sJsToNativeMap.clear();
	//sPersistentCollection.Reset();
}

/*static*/ void JsObject::onFinalize(const WeakCallbackInfo<JsObject> &data)
{
	Isolate* isolate = data.GetIsolate();
	HandleScope scope(isolate);

	JsObject* instance = data.GetParameter();
	auto finder = sJsToNativeMap.find(instance);
	// 析构函数会被多次调用，从派生类向基类
	// assert(sJsToNativeMap.end() != finder);
	if (sJsToNativeMap.end() == finder)
	{
		return;
	}

	instance = finder->second;
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

JsObject::JsObject(Isolate* isolate, Base* target, const NumberData& data, const JsTypes& jsType, const int& subType) : mIsolate(isolate), mPersistent(), mTarget(target), mType(jsType), mSubType(subType), mNumber(), mString(), mStructure(), mReferenceCount(0)
{
#if DEBUG
	assert(jsType || mSubType);
#endif
	if (!isolate) return;

	mNumber = new NumberData;
	memcpy(mNumber, &data, sizeof(NumberData));
}

JsObject::JsObject(Isolate* isolate, Base* target, const std::string& value) : mIsolate(isolate), mPersistent(), mTarget(target), mType(JsTypes::TYPE_STRING), mSubType(), mNumber(), mString(), mStructure(), mReferenceCount(0)
{
	if (!isolate) return;

	mString = new char[value.length() + 1];
	strcpy(mString, value.c_str());
}

JsObject::JsObject(Isolate* isolate, Base* target, Local<Object> object, const size_t& size) : mIsolate(isolate), mPersistent(), mTarget(target), mType(), mSubType(), mNumber(), mString(), mStructure(), mReferenceCount(0)
{
	assert(isolate && JsObject::IsValid(isolate, object));

	if (object->IsArray())
	{
		mType = JsTypes::TYPE_ARRAY;
	}
	else if (object->IsConstructor())
	{
		mType = JsTypes::TYPE_CONSTRUCTOR;
	}
	else if (object->IsFunction())
	{
		mType = JsTypes::TYPE_FUNCTION;
	}
#if DEBUG
	else if (!object->IsObject())
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

	JsObject::Set(isolate, object, JS_INSTANCE_HANDLE, (unsigned long long)this);
	mPersistent.Reset(isolate, object);
	sJsToNativeMap[this] = this;
}

JsObject::~JsObject()
{
	if (!mPersistent.IsEmpty())
	{
		mPersistent.ClearWeak<JsObject>();
		mPersistent.Reset();
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
	if (mPersistent.IsEmpty()) return false;

	Local<Value> value = mPersistent.Get(mIsolate);
	if (value.IsEmpty()) return false;

	return value->IsObject();
}

bool JsObject::Equals(const Local<Value> other)
{
	if (mPersistent.IsEmpty())
	{
		return other.IsEmpty();
	}
	return mPersistent.Get(mIsolate)->Equals(mIsolate->GetCurrentContext(), other).FromMaybe(false);
}

bool JsObject::Equals(const Local<Object> other)
{
	return this->Equals(other.As<Value>());
}

void JsObject::SetTarget(Base* target)
{
	mTarget = target;
}

Local<Value> JsObject::GetValue()
{
	if (!mPersistent.IsEmpty())
	{
		return this->GetObject();
	}
	switch (mType)
	{
	case JsTypes::TYPE_BOOLEAN:
		return Boolean::New(mIsolate, mNumber ? mNumber->boolean : false);
	case JsTypes::TYPE_STRING:
	{
		assert(mString);
		return String::NewFromUtf8(mIsolate, mString);
	}
	case JsTypes::TYPE_NULL:
		return Null(mIsolate);
	case JsTypes::TYPE_UNDEFINED:
		return Undefined(mIsolate);
	case JsTypes::TYPE_NUMBER:
		switch (mSubType)
		{
		case JsNumberTypes::TYPE_NUMBER_SBYTE:
			return Integer::New(mIsolate, (int)(mNumber ? mNumber->int8 : 0));
		case JsNumberTypes::TYPE_NUMBER_BYTE:
			return Integer::NewFromUnsigned(mIsolate, (unsigned int)(mNumber ? mNumber->uint8 : 0));
		case JsNumberTypes::TYPE_NUMBER_INT16:
			return Integer::New(mIsolate, (int)(mNumber ? mNumber->int16 : 0));
		case JsNumberTypes::TYPE_NUMBER_UINT16:
			return Integer::NewFromUnsigned(mIsolate, (unsigned int)(mNumber ? mNumber->uint16 : 0));
		case JsNumberTypes::TYPE_NUMBER_INT32:
			return Integer::New(mIsolate, (int)(mNumber ? mNumber->int32 : 0));
		case JsNumberTypes::TYPE_NUMBER_UINT32:
			return Integer::NewFromUnsigned(mIsolate, (unsigned int)(mNumber ? mNumber->uint32 : 0));
		case JsNumberTypes::TYPE_NUMBER_INT64:
			return BigInt::New(mIsolate, (mNumber ? mNumber->int64 : 0));
		case JsNumberTypes::TYPE_NUMBER_UINT64:
			return BigInt::NewFromUnsigned(mIsolate, (mNumber ? mNumber->uint64 : 0));
		case JsNumberTypes::TYPE_NUMBER_SINGLE:
			return Number::New(mIsolate, (double)(mNumber ? mNumber->float32 : 0));
		case JsNumberTypes::TYPE_NUMBER_DOUBLE:
			return Number::New(mIsolate, mNumber ? mNumber->float64 : 0);
		}
	case JsTypes::TYPE_INSTANCE:
		assert(!mPersistent.IsEmpty());
		return this->GetObject();
	case JsTypes::TYPE_OBJECT:
	case JsTypes::TYPE_ARRAY:
	case JsTypes::TYPE_FUNCTION:
	case JsTypes::TYPE_CONSTRUCTOR:
	case JsTypes::TYPE_UNKNOWN:
		assert(0);
		break;
	}
	return Undefined(mIsolate);
}

Local<Object> JsObject::GetObject()
{
	return mPersistent.IsEmpty() ? EMPTY_JS_OBJECT : mPersistent.Get(mIsolate);
}

void JsObject::MakePersistent()
{
	Local<Value> value = this->GetValue();
	if (!mPersistent.IsEmpty())
	{
		++mReferenceCount;
		mPersistent.ClearWeak<Object>();
	}
}

void JsObject::MakeWeak()
{
	if (!mPersistent.IsEmpty())
	{
		if (0 == --mReferenceCount)
		{
			mPersistent.SetWeak<JsObject>(this, JsObject::onFinalize, WeakCallbackType::kFinalizer);
		}
	}
}

void JsObject::BindTo(const std::string &name, JsObject* target)
{
	Local<Object> parent = target ? target->GetObject() : mIsolate->GetCurrentContext()->Global();
	parent->Set(String::NewFromUtf8(mIsolate, name.c_str()), this->GetObject());
}

bool JsObject::Has(const std::string &name)
{
	Local<Value> local = mPersistent.Get(mIsolate);
	if (local.IsEmpty() || !local->IsObject()) return false;

	Local<Object> self = local.As<Object>();
	return JsObject::IsValid(mIsolate, self->Get(String::NewFromUtf8(mIsolate, name.c_str())));
}

bool JsObject::Set(const std::string &name, JsObject* value)
{
	Local<Object> self = mPersistent.Get(mIsolate);
	if (self.IsEmpty() || !self->IsObject()) return false;

	return self->Set(String::NewFromUtf8(mIsolate, name.c_str()), value->GetValue());
}

/*static*/ void JsObject::Set(Isolate* isolate, Local<Object> target, const std::string &name, Local<Object> value)
{
	JsObject::Set(isolate, target, name, value.As<Value>());
}

/*static*/ bool JsObject::Set(Isolate* isolate, const Local<Object> target, const std::string& name, const Local<Value> value)
{
	return target->Set(String::NewFromUtf8(target->GetIsolate(), name.c_str()), value);
}

JsObject* JsObject::GetJsObject(const std::string &name)
{
	Local<Object> self = mPersistent.Get(mIsolate);
	if (self.IsEmpty() || !self->IsObject()) return nullptr;

	Local<Value> localValue = self->Get(String::NewFromUtf8(mIsolate, name.c_str()));
	JsObject* value = localValue->IsObject() ? JsObject::Convert(mIsolate, localValue.As<Object>()) : nullptr;
	if (!value && JsObject::IsValid(mIsolate, localValue))
	{
		value = localValue->IsObject() ? JsObject::Create(mIsolate, nullptr, localValue) : JsObject::Create(mIsolate, nullptr, localValue);
	}
	return value;
}

/*static*/ Local<Value> JsObject::GetValue(Isolate* isolate, const Local<Object> target, const std::string& name)
{
	return JsObject::IsValid(isolate, target) ? target->Get(String::NewFromUtf8(isolate, name.c_str())) : EMPTY_JS_VALUE;
}

bool JsObject::Set(const std::string &name, const std::string &value)
{
	Local<Value> local = mPersistent.Get(mIsolate);
	if (local.IsEmpty() || !local->IsObject()) return false;

	return JsObject::Set(mIsolate, local.As<Object>(), name, value);
}

/*static*/ bool JsObject::Set(Isolate* isolate, const Local<Object> target, const std::string& name, const std::string& value)
{
	return target->Set(String::NewFromUtf8(isolate, name.c_str()), String::NewFromUtf8(isolate, value.c_str()));
}

std::string JsObject::GetString(const std::string &name)
{
	Local<Value> local = mPersistent.Get(mIsolate);
	if (local.IsEmpty() || !local->IsObject()) return "";

	return JsObject::GetString(mIsolate, local.As<Object>(), name);
}

/*static*/ std::string JsObject::GetString(Isolate* isolate, const Local<Object> target, const std::string& name)
{
	return JsObject::ToString(isolate, target->Get(String::NewFromUtf8(isolate, name.c_str())));
}

bool JsObject::Set(const unsigned long long &index, const std::string &value)
{
	Local<Value> local = mPersistent.Get(mIsolate);
	if (local.IsEmpty() || !local->IsObject()) return false;

	Local<Object> self = local.As<Object>();
	return self->Set(BigInt::NewFromUnsigned(mIsolate, index), String::NewFromUtf8(mIsolate, value.c_str()));
}

std::string JsObject::GetString(const unsigned long long &index)
{
	Local<Value> local = mPersistent.Get(mIsolate);
	if (local.IsEmpty() || !local->IsObject()) return "";

	Local<Object> self = local.As<Object>();
	return JsObject::ToString(mIsolate, self->Get(BigInt::NewFromUnsigned(mIsolate, index)));
}

bool JsObject::Set(const std::string &name, const unsigned long long &value)
{
	Local<Object> local = mPersistent.Get(mIsolate);
	if (local.IsEmpty() || !JsObject::IsValid(mIsolate, local)) return false;

	return JsObject::Set(mIsolate, local, name, value);
}

/*static*/ bool JsObject::Set(Isolate* isolate, const Local<Object> target, const std::string& name, const unsigned long long value)
{
	return target->Set(String::NewFromUtf8(isolate, name.c_str()), BigInt::NewFromUnsigned(isolate, value));
}

unsigned long long JsObject::GetUint64(const std::string &name)
{
	Local<Object> local = mPersistent.Get(mIsolate);
	if (local.IsEmpty() || !JsObject::IsValid(mIsolate, local)) return 0;

	return JsObject::GetUint64(mIsolate, local, name);
}

/*static*/ unsigned long long JsObject::GetUint64(Isolate* isolate, const Local<Object> target, const std::string& name)
{
	return JsObject::ToUint64(isolate, target->Get(String::NewFromUtf8(isolate, name.c_str())));
}

bool JsObject::DefineProperty(const std::string &name, const TypescriptProperty* property)
{
	Local<Value> local = mPersistent.Get(mIsolate);
	if (local.IsEmpty() || !local->IsObject()) return false;

	Local<Object> self = local.As<Object>();
	bool isStatic = property->CheckType(BaseChildTypes::BaseChildType_StaticProperty);
	Local<Context> context = mIsolate->GetCurrentContext();
	Local<BigInt> instance = BigInt::NewFromUnsigned(mIsolate, (unsigned long long)property);
	self->SetAccessorProperty(String::NewFromUtf8(mIsolate, name.c_str()), 
		property->HasGetter() ? Function::New(context, isStatic ? onStaticPropertyGetterCall : onInstancePropertyGetterCall, instance).ToLocalChecked() : Local<Function>(),
		property->HasSetter() ? Function::New(context, isStatic ? onStaticPropertySetterCall : onInstancePropertySetterCall, instance).ToLocalChecked() : Local<Function>());
	return true;
}

std::vector<Local<Value>> JsObject::deserializeParameters(JsObject* jsObject)
{
	std::vector<Local<Value>> parameters;
	if (jsObject)
	{
		Local<Value> value = jsObject->GetValue();
		if (value->IsArray())
		{
			Local<Array> array = value.As<Array>();
			uint32_t length = array->Length();
			if (length > 0)
			{
				parameters.resize((size_t)length);
				for (uint32_t i = 0; i < length; ++i)
				{
					parameters.data()[i] = array->Get(i);
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

//JSValueRef JsObject::CallAsConstructor()
//{
//	if (!mPersistent || !JSObjectIsConstructor(mContext, mPersistent))
//	{
//		return nullptr;
//	}
//
//	JSValueRef exception = nullptr;
//	JSValueRef result = JSObjectCallAsConstructor(mContext, mPersistent, 0, nullptr, &exception);
//	if (Environment::ClearException(&exception))
//	{
//		return nullptr;
//	}
//	return result;
//}

JsObject* JsObject::CallFunction(const std::string& name, const std::vector<Local<Value>>& parameters, const bool& needResult)
{
	Local<Object> object = this->GetObject();
	if (object.IsEmpty() || object->IsNullOrUndefined()) return nullptr;

	Local<Value> property = object->Get(String::NewFromUtf8(mIsolate, name.c_str()));
	if (!property.IsEmpty() && property->IsFunction())
	{
		Local<Function> function = property.As<Function>();
		MaybeLocal<Value> result = function->Call(mIsolate->GetCurrentContext(), object, (int)parameters.size(), const_cast<Local<Value>*>(parameters.data()));
		return needResult ? JsObject::Create(mIsolate, nullptr, result.FromMaybe(Local<Value>())) : nullptr;
	}
	return nullptr;
}

Local<Value> JsObject::CallAsConstructor()
{
	if (mPersistent.IsEmpty()) return EMPTY_JS_VALUE;
	Local<Object> local = mPersistent.Get(mIsolate);
	if (!local->IsConstructor()) return EMPTY_JS_VALUE;
	return local->CallAsConstructor(mIsolate->GetCurrentContext(), 0, nullptr).FromMaybe(EMPTY_JS_VALUE);
}

JsObject* JsObject::CallAsFunction(const std::vector<Local<Value>>& parameters, const bool& needResult)
{
	Local<Object> object = this->GetObject();
	if (object.IsEmpty() || !object->IsFunction()) return nullptr;

	Local<Function> function = object.As<Function>();
	MaybeLocal<Value> result = function->Call(mIsolate->GetCurrentContext(), Null(mIsolate), (int)parameters.size(), const_cast<Local<Value>*>(parameters.data()));
	return needResult ? JsObject::Create(mIsolate, nullptr, result.FromMaybe(Local<Value>())) : nullptr;
}

bool JsObject::ToBoolean()
{
	return ToBoolean(mIsolate, this->GetValue());
}

/*static*/ bool JsObject::ToBoolean(Isolate* isolate, const Local<Value> value)
{
	if (value.IsEmpty() || value->IsNullOrUndefined()) return false;
	return value->IsTrue() ? true : false;
}

std::string JsObject::ToString()
{
	return ToString(mIsolate, this->GetValue());
}

/*static*/ std::string JsObject::ToString(Isolate* isolate, const Local<Value> value)
{
	if (value.IsEmpty() || value->IsNullOrUndefined()) return "";
	return *String::Utf8Value(isolate, value);
}

int JsObject::ToInt32()
{
	return ToInt32(mIsolate, this->GetValue());
}

/*static*/ int JsObject::ToInt32(Isolate* isolate, const Local<Value> value)
{
	if (value.IsEmpty() || value->IsNullOrUndefined()) return 0;
	return value->Int32Value(isolate->GetCurrentContext()).FromMaybe(0);
}

unsigned int JsObject::ToUint32()
{
	return ToUint32(mIsolate, this->GetValue());
}

/*static*/ unsigned int JsObject::ToUint32(Isolate* isolate, const Local<Value> value)
{
	if (value.IsEmpty() || value->IsNullOrUndefined())
		return 0;
	return value->Uint32Value(isolate->GetCurrentContext()).FromMaybe(0);
}

long long JsObject::ToInt64()
{
	return ToInt64(mIsolate, this->GetValue());
}

/*static*/ long long JsObject::ToInt64(Isolate* isolate, const Local<Value> value)
{
	if (value.IsEmpty() || value->IsNullOrUndefined()) return 0;
	if (value->IsBigInt())
	{
		return value.As<BigInt>()->Int64Value();
	}
	return (long long)(value->IsNumber() ? value.As<Number>()->Value() : 0);
}

unsigned long long JsObject::ToUint64()
{
	return ToUint64(mIsolate, this->GetValue());
}

/*static*/ unsigned long long JsObject::ToUint64(Isolate* isolate, const Local<Value> value)
{
	if (value.IsEmpty() || value->IsNullOrUndefined()) return 0;
	if (value->IsBigInt())
	{
		return value.As<BigInt>()->Uint64Value();
	}
	return (unsigned long long)(value->IsNumber() ? value.As<Number>()->Value() : 0);
}

float JsObject::ToSingle()
{
	return ToSingle(mIsolate, this->GetValue());
}

/*static*/ float JsObject::ToSingle(Isolate* isolate, const Local<Value> value)
{
	return (float)ToDouble(isolate, value);
}

double JsObject::ToDouble()
{
	return ToDouble(mIsolate, this->GetValue());
}

/*static*/ double JsObject::ToDouble(Isolate* isolate, const Local<Value> value)
{
	if (value.IsEmpty() || value->IsNullOrUndefined())
		return 0;
	if (value->IsNumber())
	{
		return value.As<Number>()->Value();
	}
	return (double)(value->IsBigInt() ? value.As<BigInt>()->Int64Value() : 0);
}

//////////////////////////////////////////////////////////////////////////

/*static*/ bool JsObject::IsValid(Isolate* isolate, const Local<Object> object)
{
	if (!isolate || object.IsEmpty())
		return false;
	return IsValid(isolate, object.As<Value>());
}

/*static*/ bool JsObject::IsValid(Isolate* isolate, const Local<Value> value)
{
	if (!isolate) return false;

	if (value.IsEmpty())
	{
		return false;
	}
	if (value->IsNullOrUndefined())
	{
		return false;
	}
	if (!value->IsBoolean() && !value->BooleanValue(isolate))
	{
		return false;
	}
	return true;
}

/*static*/ Local<Object> JsObject::GetObject(Isolate* isolate, Local<Object> target, const std::string &name)
{
	return target->Get(String::NewFromUtf8(target->GetIsolate(), name.c_str())).As<Object>();
}