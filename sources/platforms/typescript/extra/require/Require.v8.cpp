#include "extra/require/Require.h"
#include "extension/files/FileUtility.h"
#include "core/function/Function.h"
#include "core/Environment.h"
#include "Utils.h"
#include "core/class/Class.h"

void Require::onRequireCall(const FunctionCallbackInfo<Value>& info)
{
	Isolate* isolate = info.GetIsolate();
	Local<Context> context = isolate->GetCurrentContext();

	std::string filename = *String::Utf8Value(isolate, info[0]);
	if (Require::GetRequireStackSize() > 0)
	{
		filename = FileUtility::CombinePath(FileUtility::GetDirectoryName(Require::RequirePeek()), filename);
	}

	if (std::string::npos == filename.find(".js"))
	{
		filename += ".js";
	}

	Local<Object> global = context->Global();
	Local<String> keyString = String::NewFromUtf8(isolate, filename.c_str(), NewStringType::kNormal).ToLocalChecked();
	Local<Value> existed = global->Get(keyString);
	if (!existed.IsEmpty() && !existed->IsNullOrUndefined())
	{
		info.GetReturnValue().Set(existed);
	}
	else
	{
		Require::RequirePush(filename);

		std::string content = FileUtility::ReadStringFromFile(filename);
		ScriptOrigin origin(String::NewFromUtf8(isolate, filename.c_str()));
		Local<String> source = String::NewFromUtf8(isolate, content.c_str());
		MaybeLocal<Script> compiled = Script::Compile(context, source, &origin);
		if (compiled.IsEmpty())
		{

		}
		else
		{
			Local<Script> script = compiled.ToLocalChecked();
			MaybeLocal<Value> maybe = script->Run(context);
			if (!maybe.IsEmpty())
			{
				Local<Value> result = maybe.ToLocalChecked();

#ifdef DEBUG
				//Local<Object> object = result.As<Object>();
				//std::vector<std::string> propertyNames = GetObjectPropertyNames(object);
				//Local<Value> prototype = object->Get(String::NewFromUtf8(isolate, PROTOTYPE));
				//std::vector<std::string> prototypeNames = GetObjectPropertyNames(prototype.As<Object>());
#endif

				TypescriptClass::CheckConstructors(isolate, result);
				global->Set(keyString, result);
				info.GetReturnValue().Set(result);
			}
		}

		Require::RequirePop();
	}
}
