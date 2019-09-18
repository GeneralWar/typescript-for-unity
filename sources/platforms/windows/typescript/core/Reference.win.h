#include "header.h"
#include "core/Reference.h"
#pragma once

class ReferenceWindows : public Reference
{
private:
	Local<Template> mReference;
public:
	ReferenceWindows(Local<Template> reference) : mReference(reference) { }

	Local<Template> GetReference() { return mReference; }
};