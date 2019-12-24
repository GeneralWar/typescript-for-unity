#include "Environment.v8.h"
#include "extra/log/Log.h"
#include "../utils.h"
#include "core/namespace/Namespace.h"
#include "core/function/Function.h"
#include "core/class/Class.h"
#include "Reference.v8.h"
#include "Object.v8.h"
#include "core/function/Constructor.h"

extern StartupData *sSnapshotData;
static std::unique_ptr<Platform> sPlatform = nullptr;

void EnvironmentV8::release()
{
	Environment::release();
	if (mIsolate)
	{
		HandleScope scope(mIsolate);
		if (!mContext.IsEmpty())
		{
			mContext.Reset();
		}

		object_finalize(mIsolate);
		ReleaseConstructors(mIsolate);

		mIsolate->Exit();
		auto allocator = mIsolate->GetArrayBufferAllocator();
		delete allocator;
		mIsolate->Dispose();
		mIsolate = nullptr;
	}
}

EnvironmentV8::~EnvironmentV8()
{
	this->release();
}

bool EnvironmentV8::Initialize()
{
	//this->release();

	if (!sPlatform)
	{
		sPlatform = platform::NewDefaultPlatform();
		V8::InitializePlatform(sPlatform.get());
	}
	V8::SetDcheckErrorHandler([](const char* file, int line, const char* message)
	{
		//LogError("[V8 ERROR] : \"%s\" at %s:%d!", message, file, line);
		int n = 0;
	});
	if (V8::Initialize())
	{
		Isolate::CreateParams params;
		params.snapshot_blob = sSnapshotData;
		params.array_buffer_allocator = ArrayBuffer::Allocator::NewDefaultAllocator();

		Isolate* isolate = Isolate::New(params);
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
			LogError("[JS ERROR] : %s\n%s", *content, stackTrace.c_str());
		}, isolate->kMessageError);

		mIsolate = isolate;
		return true;
	}
	return false;
}

void EnvironmentV8::Bind()
{
	HandleScope handleScope(mIsolate);
	mGlobalTemplate = ObjectTemplate::New(mIsolate);

	this->bindExtra();
	object_initialize(mIsolate);
	//initialize_general_before_running(isolate, global);

	for (auto instance : mNamespaces)
	{
		instance->Bind();
	}
	for (auto instance : mClasses)
	{
		instance->Bind();
	}
	for (auto instance : mFunctions)
	{
		instance->Bind();
	}

	TypescriptClass::Derive();

	Local<Context> context = Context::New(mIsolate, nullptr, mGlobalTemplate);
	context->Enter();
	mContext.Reset(mIsolate, context);

	mIsRunning = true;

	CreateGlobalObject(mIsolate, "exports");

	this->ExecuteString("console.log = General_Console.log;");
	this->ExecuteString("console.warn = General_Console.warn;");
	this->ExecuteString("console.error = General_Console.error;");
}

std::string EnvironmentV8::ExecuteString(const char* sourceContent)
{
	return this->execute(sourceContent);
}

std::string EnvironmentV8::ExecuteScript(const char* sourceContent, const char* filename)
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

void* EnvironmentV8::Require(const char* sourceContent, const char* filename)
{
	throw std::logic_error("The method or operation is not implemented.");
}

std::string EnvironmentV8::execute(const char* content, ScriptOrigin* origin /*= nullptr*/)
{
	if (mIsolate)
	{
		HandleScope handleScope(mIsolate);
		Local<Context> context = mIsolate->GetCurrentContext();
		Context::Scope contextScope(context);

		Local<String> source = String::NewFromUtf8(mIsolate, content);
		MaybeLocal<Script> compiled = Script::Compile(context, source, origin);
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

