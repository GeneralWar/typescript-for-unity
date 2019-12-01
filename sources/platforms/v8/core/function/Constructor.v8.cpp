#include "core/function/Constructor.h"
#include "delegates.h"
#include "defines.h"
#include "core/function/Parameters.h"
#include "../Object.v8.h"
#include "../../utils.h"

extern ConstructorCallback sConstructorCallback;

std::map<std::string, Persistent<Object>> sConstructors;

void CheckConstructors(Isolate* isolate, const Local<Value>& value)
{
	if (!value->IsObject()) return;

	Local<Object> object = value.As<Object>();
	Local<Array> properties = object->GetOwnPropertyNames(isolate->GetCurrentContext()).ToLocalChecked();
	for (int i = (int)properties->Length() - 1; i >= 0; --i)
	{
		Local<Object> property = object->Get(properties->Get(i)).As<Object>();
		if (property.IsEmpty())
		{
			continue;
		}
		//String::Utf8Value propertyString(isolate, property);
		if (property->IsConstructor())
		{
			std::string name = GetCustomType(property);
			if (name.empty() || sConstructors.end() != sConstructors.find(name)) continue;
			sConstructors[name].Reset(isolate, property);
		}
		else if (property->IsObject())
		{
			CheckConstructors(isolate, property);
		}
	}
}

void ReleaseConstructors(Isolate* isolate)
{
	for (std::map<std::string, Persistent<Object>>::iterator it = sConstructors.begin(); sConstructors.end() != it; ++it)
	{
		it->second.Reset();
	}
	sConstructors.clear();
}

Local<Object> InstantiateObject(Isolate* isolate, const std::string& name)
{
	auto finder = sConstructors.find(name);
	if (sConstructors.end() != finder)
	{
		Local<Object> constructor = finder->second.Get(isolate);
		auto result = constructor->CallAsConstructor(isolate->GetCurrentContext(), 0, nullptr);
		if (!result.IsEmpty())
		{
			Local<Context> context = isolate->GetCurrentContext();
			Local<Object> instance = result.ToLocalChecked().As<Object>()->Clone();

			Local<Object> prototype = constructor->Get(String::NewFromUtf8(isolate, "prototype")).As<Object>();
			instance->SetPrototype(context, prototype);

			if (0 == name.find(UNITY_INSTANCE_CUSTOM_TYPE))
			{
				Local<Value> awake = instance->Get(String::NewFromUtf8(isolate, "Awake"));
				if (!awake.IsEmpty() && awake->IsFunction())
				{
					awake.As<Function>()->Call(context, instance, 0, nullptr);
				}
			}

			return instance;
		}
	}
	return Local<Object>();
}
