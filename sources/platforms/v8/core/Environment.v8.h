#include "core/Environment.h"
#include "header.h"
#pragma once

class EnvironmentWindows : public Environment
{
private:
	Isolate* mIsolate;
	Persistent<Context> mContext;
	Local<ObjectTemplate> mGlobalTemplate;
public:
	Isolate* GetIsolate() { return mIsolate; }
protected:
	virtual void release() override;
public:
	~EnvironmentWindows();

	virtual bool Initialize() override;

	virtual void Bind() override;

	virtual std::string ExecuteString(const char* sourceContent) override;

	virtual std::string ExecuteScript(const char* sourceContent, const char* filename) override;

	virtual void* Require(const char* sourceContent, const char* filename) override;

	Local<ObjectTemplate> GetGloalTemplate() { return mGlobalTemplate; }
private:
	std::string execute(const char* content, ScriptOrigin* origin = nullptr);
};