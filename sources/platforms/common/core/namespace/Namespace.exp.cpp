#include "Namespace.h"
#include "../class/Class.h"
#include "core/namespace/Namespace.exp.h"

void* General_Typescript_Namespace_DeclareNamespace(void* parent, const char* name)
{
    TypescriptNamespace* instance = reinterpret_cast<TypescriptNamespace*>(parent);
    return instance ? instance->DeclareNamespace(name).get() : nullptr;
}

void* General_Typescript_Namespace_DeclareClass(void* parent, const char* name, const char* base)
{
    TypescriptNamespace* instance = reinterpret_cast<TypescriptNamespace*>(parent);
    return instance ? instance->DeclareClass(name, base).get() : nullptr;
}

void* General_Typescript_Namespace_DeclareEnum(void* parent, const char* name)
{
    TypescriptNamespace* instance = reinterpret_cast<TypescriptNamespace*>(parent);
    return instance ? instance->DeclareEnum(name).get() : nullptr;
}
