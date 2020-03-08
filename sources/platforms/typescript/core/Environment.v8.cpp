#include "core/Environment.h"
#include "extra/log/Log.h"
#include "utils.h"
#include "core/namespace/Namespace.h"
#include "core/function/Function.h"
#include "core/class/Class.h"
#include "core/object/Object.h"

extern StartupData *sSnapshotData;
static std::unique_ptr<Platform> sPlatform = nullptr;
static Isolate* sIsolate = nullptr;;

/*static*/ void onDCheckError(const char* file, int line, const char* message)
{
	LogError("[Dcheck Failure](%s:%d): \"%s\"!", message, file, line);
}

bool Environment::initialize()
{
	//this->release();

	if (!sPlatform)
	{
		sPlatform = platform::NewDefaultPlatform();
		V8::InitializePlatform(sPlatform.get());

		const char* flags = "--expose_gc";
		V8::SetFlagsFromString(flags, (int)strlen(flags));
		
		V8::SetDcheckErrorHandler(onDCheckError);
	}
	if (V8::Initialize())
	{
		Isolate* isolate = sIsolate;
		if (!sIsolate)
		{
			Isolate::CreateParams params;
			params.snapshot_blob = sSnapshotData;
			params.array_buffer_allocator = ArrayBuffer::Allocator::NewDefaultAllocator();

			isolate = sIsolate = Isolate::New(params);
			isolate->Enter();

			isolate->SetFatalErrorHandler([](const char* location, const char* message)
			{
				LogError("[JS FATAL ERROR] : \"%s\" at %s!", message, location);
			});

			isolate->SetAbortOnUncaughtExceptionCallback([](Isolate* isolate)
			{
				assert(0);
				return true;
			});

			isolate->SetCaptureStackTraceForUncaughtExceptions(true);
			isolate->AddMessageListenerWithErrorLevel([](Local<Message> message, Local<Value> data)
			{
				Isolate* isolate = message->GetIsolate();
				auto level = message->ErrorLevel();

				char buffer[1024];
				std::string stackTrace = "";
				auto stacks = message->GetStackTrace();
				int frameCount = stacks->GetFrameCount();
				for (int i = 0; i < frameCount; ++i)
				{
					auto frame = stacks->GetFrame(isolate, i);
					sprintf(buffer, "%s(%d:%d) : %s", *String::Utf8Value(isolate, frame->GetScriptName()), frame->GetLineNumber(), frame->GetColumn(), *String::Utf8Value(isolate, frame->GetFunctionName()));
					stackTrace += stackTrace.empty() ? (std::string("\t") + buffer) : (std::string("\n\t") + buffer);
				}

				String::Utf8Value content(isolate, message->Get());
				LogError("%s\n%s", *content, stackTrace.c_str());
			}, isolate->kMessageError);
		}

		HandleScope handleScope(isolate);
		Local<ObjectTemplate> globalTemplate = ObjectTemplate::New(isolate);

		Local<Context> context = Context::New(isolate, nullptr, globalTemplate);
		context->Enter();

		mIsRunning = true;
		mIsolate = isolate;
		
		return true;
	}
	return false;
}

void Environment::bind()
{
	Local<Context> context = mIsolate->GetCurrentContext();
	mJsObject = JsObject::Create(mIsolate, this, context->Global());
	mJsObject->Set(NAME, "global");
	mJsObject->Set(FULLNAME, "global");
}

std::string Environment::ExecuteScript(const char* sourceContent, const char* filename)
{
	//  Local<Value> resource_name,
	//	Local<Integer> resource_line_offset = Local<Integer>(),
	//	Local<Integer> resource_column_offset = Local<Integer>(),
	//	Local<Boolean> resource_is_shared_cross_origin = Local<Boolean>(),
	//	Local<Integer> script_id = Local<Integer>(),
	//	Local<Value> source_map_url = Local<Value>(),
	//	Local<Boolean> resource_is_opaque = Local<Boolean>(),
	//	Local<Boolean> is_wasm = Local<Boolean>(),
	//	Local<Boolean> is_module = Local<Boolean>(),
	//	Local<PrimitiveArray> host_defined_options = Local<PrimitiveArray>();

	HandleScope handleScope(mIsolate);
	ScriptOrigin origin(String::NewFromUtf8(mIsolate, filename));
	return this->execute(sourceContent, &origin);
}

std::string Environment::execute(const char* content, void* origin /*= nullptr*/)
{
	if (mIsolate)
	{
		HandleScope handleScope(mIsolate);
		Local<Context> context = mIsolate->GetCurrentContext();
		Context::Scope contextScope(context);

		Local<String> source = String::NewFromUtf8(mIsolate, content);
		MaybeLocal<Script> compiled = Script::Compile(context, source, (ScriptOrigin*)origin);
		if (compiled.IsEmpty())
		{

		}
		else
		{
			Local<Script> script = compiled.ToLocalChecked();
			MaybeLocal<Value> result = script->Run(context);
			return result.IsEmpty() ? "" : *String::Utf8Value(mIsolate, result.ToLocalChecked());
		}
	}
	return "";
}

