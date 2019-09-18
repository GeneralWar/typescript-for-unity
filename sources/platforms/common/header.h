#ifndef header_h
#define header_h

#if defined(_WIN32) || defined(__ANDROID__)

#include <v8.h>
//#ifdef WIN32
//#include <v8-debug.h>
//#endif
#include <v8-inspector-protocol.h>
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

#ifndef SLOT_GLOBAL_TEMPLATE
#define SLOT_GLOBAL_TEMPLATE 1
#endif

using namespace v8;

#endif

#ifdef __APPLE__
#include <JavaScriptCore/JavaScriptCore.h>
#endif

#endif

#include <map>
#include <vector>
#include <string>
#include <memory>
