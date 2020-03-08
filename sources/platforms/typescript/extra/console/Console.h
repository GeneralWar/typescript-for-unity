#include <memory>
#pragma once

class Environment;
class TypescriptClass;

class Console
{
private:
	static TypescriptClass* sConsole;
public:
	static void Initialize(Environment* environment);

	static void Bind();

	static void Release();
};
