#include <string>
#include "delegates.h"
#pragma once

void Log(const char* content, ...);
void Log(const std::string content, ...);
void LogWarning(const char* content, ...);
void LogWarning(const std::string content, ...);
void LogError(const char* content, ...);
void LogError(const std::string content, ...);

void debug_log(const char* content, ...);