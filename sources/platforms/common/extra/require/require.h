#pragma once
#include "header.h"
#include <stack>

class Environment;

class Require
{
private:
	static std::stack<std::string> sRequireStack;
public:
	static void Initialize(Environment* environment);

	static void Bind();

	static void Release();

	static int RequirePush(const std::string& filename);
	static int RequirePop();
	static std::string RequirePeek() { return sRequireStack.top(); }
	static int GetRequireStackSize() { return (int)sRequireStack.size(); }
};
