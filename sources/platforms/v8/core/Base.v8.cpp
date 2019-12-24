#include "core/Base.h"
#include "Reference.v8.h"
#include "Environment.v8.h"
#include "header.h"
#include "../utils.h"
#include "extra/log/Log.h"

Base::~Base()
{
	if (!mJsObject.IsEmpty())
	{
		mJsObject.Reset();
	}
}

void Base::Bind()
{
	Isolate* isolate = GetIsolate(this);
	Local<ObjectTemplate> self = ObjectTemplate::New(isolate);
	Local<String> localName = String::NewFromUtf8(isolate, mName.c_str());
	self->Set(String::NewFromUtf8(isolate, NAME), localName);
	self->Set(String::NewFromUtf8(isolate, FULLNAME, NewStringType::kNormal).ToLocalChecked(), String::NewFromUtf8(isolate, mFullname.c_str()));
	mReference = new ReferenceWindows(self);
	this->BindToParent();
}


void Base::BindToParent(Base* parent)
{
	Isolate* isolate = GetIsolate(this);
	if (!isolate) return;

	if (mEnvironment->IsRunning())
	{
		Local<Object> parentObject = parent->GetJsObject();
		parentObject->Set(String::NewFromUtf8(isolate, mName.c_str()), mJsObject.Get(isolate));
	}
	else
	{
		Local<Template> parentTemplate = parent ? GetTemplate(parent) : GetParentTemplate(this);
		Local<Template> selfTemplate = GetTemplate(this);
		if (parentTemplate.IsEmpty() || selfTemplate.IsEmpty()) return;

		parentTemplate.As<ObjectTemplate>()->Set(String::NewFromUtf8(isolate, mName.c_str()), selfTemplate);
	}
}

Local<Object> Base::GetJsObject()
{
	Isolate* isolate = GetIsolate(this);
	if (mJsObject.IsEmpty())
	{
		Local<Context> context = isolate->GetCurrentContext();
		Local<Object> parent = nullptr == mParent ? context->Global() : mParent->GetJsObject();
		Local<Object> self = parent->Get(String::NewFromUtf8(isolate, mName.c_str())).As<Object>();
		if (self.IsEmpty())
		{
			DEBUG_LOG("There is no object called %s in %s!", mName.c_str(), nullptr == mParent ? "global" : mParent->GetName().c_str());
			LogError("There is no object called %s in %s!", mName.c_str(), nullptr == mParent ? "global" : mParent->GetName().c_str());
			return self;
		}
		mJsObject.Reset(isolate, self);
	}
	return mJsObject.Get(isolate);
}