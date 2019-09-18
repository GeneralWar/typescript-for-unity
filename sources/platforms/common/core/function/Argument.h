#include "header.h"
#include "defines.h"
#pragma once

class Argument
{
public:
	static JS_VALUE_TYPE Deserialize(JS_CONTEXT_TYPE context, unsigned char*& buffer); // depends platform
};