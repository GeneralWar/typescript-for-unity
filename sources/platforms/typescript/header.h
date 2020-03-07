#ifndef header_h
#define header_h

#if defined(_WIN32) || defined(__ANDROID__)

#include <v8.h>
#include <v8-inspector.h>
#include <v8-platform.h>
#include <v8-profiler.h>
#include <v8-testing.h>
#include <v8-util.h>
#include <v8-value-serializer-version.h>
#include <v8-version-string.h>
#include <v8-version.h>
#include <v8config.h>
#include <libplatform/libplatform-export.h>
#include <libplatform/libplatform.h>
#include <libplatform/v8-tracing.h>

using namespace v8;

#ifndef SLOT_GLOBAL_TEMPLATE
#define SLOT_GLOBAL_TEMPLATE 1
#endif

#if __ANDROID__
#include <syslog.h>
#endif
#if _WIN32
#include <windows.h>
#include <debugapi.h>
#endif

#endif

#ifdef __APPLE__
#include <JavaScriptCore/JavaScriptCore.h>
#endif

#endif

#include <set>
#include <map>
#include <list>
#include <stack>
#include <vector>
#include <string>
#include <memory>
