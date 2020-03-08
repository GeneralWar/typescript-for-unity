#include "header.h"
#include "defines.h"
#pragma once

class Parameters
{
private:
	int mCount;
	JS_PARAMETER_TYPE mValues;
public:
	Parameters(JS_PARAMETERS); 
	virtual ~Parameters() { }

	int count() { return mCount; }

	void* address() { return (void*)this; }

	JS_VALUE_TYPE Get(const int& index) { return mValues[index]; }
};
