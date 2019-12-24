#include "header.h"
#include "core/Reference.h"
#pragma once

class ReferenceWindows : public Reference
{
private:
	Local<Template> mTemplate;
	//Persistent<Object> mPersistent;
public:
	ReferenceWindows(Local<Template> reference) : mTemplate(reference) { }

	Local<Template> GetTemplate() { return mTemplate; }
	//Local<Object> GetPersistent();
};