#include "core/Base.h"
#include "Reference.win.h"
#include "Environment.win.h"
#include "header.h"
#include "../utils.h"

void Base::Bind()
{
	Isolate* isolate = GetIsolate(this);
	Local<ObjectTemplate> self = ObjectTemplate::New(isolate);
	Local<String> localName = String::NewFromUtf8(isolate, mName.c_str());
	self->Set(String::NewFromUtf8(isolate, "name"), localName);
	self->Set(String::NewFromUtf8(isolate, "fullname", NewStringType::kNormal).ToLocalChecked(), String::NewFromUtf8(isolate, mFullname.c_str()));
	mReference = new ReferenceWindows(self);
	this->BindToParent();
}


void Base::BindToParent(Base* parent)
{
	Isolate* isolate = GetIsolate(this);
	if (!isolate) return;

	Local<Template> parentTemplate = parent ? GetTemplate(parent) : GetParentTemplate(this);
	Local<Template> selfTemplate = GetTemplate(this);
	if (parentTemplate.IsEmpty() || selfTemplate.IsEmpty()) return;

	parentTemplate.As<ObjectTemplate>()->Set(String::NewFromUtf8(isolate, mName.c_str()), selfTemplate);
}