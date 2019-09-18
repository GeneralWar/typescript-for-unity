#include "../Base.h"
#include "defines.h"
#pragma once

void CheckConstructors(JS_CONTEXT_TYPE isolate, const JS_VALUE_REFERENCE_TYPE value);
void ReleaseConstructors(JS_CONTEXT_TYPE isolate);

JS_OBJECT_TYPE InstantiateObject(JS_CONTEXT_TYPE isolate, const std::string& name);
