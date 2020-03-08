#include "core/function/Parameters.h"

Parameters::Parameters(const FunctionCallbackInfo<Value>& info) : mValues(info), mCount(info.Length()) { }
