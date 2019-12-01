#include "core/enum/Enum.h"
#include "../../utils.h"

void TypescriptEnum::Bind()
{
	Base::Bind();
	Isolate* isolate = GetIsolate(this);
	if (!isolate) return;

	HandleScope handleScope(isolate);
	Local<ObjectTemplate> self = GetTemplate(this).As<ObjectTemplate>();
	for (auto pair : mValues)
	{
		self->Set(String::NewFromUtf8(isolate, pair.first.c_str()), BigInt::New(isolate, pair.second));
	}
}
