LOCAL_PATH := $(call my-dir)

V8_PATH := $(LOCAL_PATH)/libs
#======================================
include $(CLEAR_VARS)
LOCAL_MODULE := v8_libbase
LOCAL_SRC_FILES := $(V8_PATH)/$(TARGET_ARCH_ABI)/libv8_libbase.a
LOCAL_EXPORT_LDLIBS := -llog -landroid
include $(PREBUILT_STATIC_LIBRARY)

#======================================
include $(CLEAR_VARS)
LOCAL_MODULE := v8_libplatform
LOCAL_SRC_FILES := $(V8_PATH)/$(TARGET_ARCH_ABI)/libv8_libplatform.a
include $(PREBUILT_STATIC_LIBRARY)

#======================================
include $(CLEAR_VARS)
LOCAL_MODULE := v8_libsampler
LOCAL_SRC_FILES := $(V8_PATH)/$(TARGET_ARCH_ABI)/libv8_libsampler.a
include $(PREBUILT_STATIC_LIBRARY)

#======================================
include $(CLEAR_VARS)
LOCAL_MODULE := v8_snapshot
LOCAL_SRC_FILES := $(V8_PATH)/$(TARGET_ARCH_ABI)/libv8_snapshot.a
include $(PREBUILT_STATIC_LIBRARY)

#======================================
include $(CLEAR_VARS)
LOCAL_MODULE := v8_inspector
LOCAL_SRC_FILES := $(V8_PATH)/$(TARGET_ARCH_ABI)/libinspector.a
include $(PREBUILT_STATIC_LIBRARY)

#======================================
include $(CLEAR_VARS)
LOCAL_MODULE := v8_compiler
LOCAL_SRC_FILES := $(V8_PATH)/$(TARGET_ARCH_ABI)/libv8_compiler.a
include $(PREBUILT_STATIC_LIBRARY)

#======================================
include $(CLEAR_VARS)

LOCAL_MODULE := v8_static
LOCAL_SRC_FILES := $(V8_PATH)/$(TARGET_ARCH_ABI)/libv8_base_without_compiler.a
LOCAL_EXPORT_C_INCLUDES := $(V8_PATH)/include
LOCAL_WHOLE_STATIC_LIBRARIES += v8_libbase v8_libplatform v8_libsampler v8_snapshot v8_compiler

include $(PREBUILT_STATIC_LIBRARY)

#======================================

include $(CLEAR_VARS)
LOCAL_MODULE := typescript
LOCAL_MODULE_FILENAME := libtypescript

ifeq ($(USE_ARM_MODE),1)
LOCAL_ARM_MODE := arm
endif

COMMON_SOURCE_PATH := /../common/
V8_SOURCE_PATH := /../v8/

LOCAL_SRC_FILES := ${LOCAL_PATH}/${COMMON_SOURCE_PATH}/core/Base.cpp \
                   ${LOCAL_PATH}/${COMMON_SOURCE_PATH}/core/class/Class.cpp \
                   ${LOCAL_PATH}/${COMMON_SOURCE_PATH}/core/class/Class.exp.cpp \
                   ${LOCAL_PATH}/${COMMON_SOURCE_PATH}/core/enum/Enum.cpp \
                   ${LOCAL_PATH}/${COMMON_SOURCE_PATH}/core/enum/Enum.exp.cpp \
                   ${LOCAL_PATH}/${COMMON_SOURCE_PATH}/core/Environment.cpp \
                   ${LOCAL_PATH}/${COMMON_SOURCE_PATH}/core/function/Function.cpp \
                   ${LOCAL_PATH}/${COMMON_SOURCE_PATH}/core/namespace/Namespace.cpp \
                   ${LOCAL_PATH}/${COMMON_SOURCE_PATH}/core/namespace/Namespace.exp.cpp \
                   ${LOCAL_PATH}/${COMMON_SOURCE_PATH}/core/property/Property.cpp \
                   ${LOCAL_PATH}/${COMMON_SOURCE_PATH}/core/Reference.cpp \
                   ${LOCAL_PATH}/${COMMON_SOURCE_PATH}/core/Typescript.exp.cpp \
                   ${LOCAL_PATH}/${COMMON_SOURCE_PATH}/export.cpp \
                   ${LOCAL_PATH}/${COMMON_SOURCE_PATH}/extension/files/FileUtility.cpp \
                   ${LOCAL_PATH}/${COMMON_SOURCE_PATH}/extension/files/FileUtility.exp.cpp \
                   ${LOCAL_PATH}/${COMMON_SOURCE_PATH}/extra/console/console.cpp \
                   ${LOCAL_PATH}/${COMMON_SOURCE_PATH}/extra/log/Log.cpp \
                   ${LOCAL_PATH}/${COMMON_SOURCE_PATH}/extra/require/require.cpp \
                   ${LOCAL_PATH}/${V8_SOURCE_PATH}/core/Base.v8.cpp \
                   ${LOCAL_PATH}/${V8_SOURCE_PATH}/core/class/Class.v8.cpp \
                   ${LOCAL_PATH}/${V8_SOURCE_PATH}/core/class/Class.v8.exp.cpp \
                   ${LOCAL_PATH}/${V8_SOURCE_PATH}/core/enum/Enum.v8.cpp \
                   ${LOCAL_PATH}/${V8_SOURCE_PATH}/core/Environment.v8.cpp \
                   ${LOCAL_PATH}/${V8_SOURCE_PATH}/core/function/Argument.v8.cpp \
                   ${LOCAL_PATH}/${V8_SOURCE_PATH}/core/function/Caller.v8.exp.cpp \
                   ${LOCAL_PATH}/${V8_SOURCE_PATH}/core/function/Constructor.v8.cpp \
                   ${LOCAL_PATH}/${V8_SOURCE_PATH}/core/function/Function.v8.cpp \
                   ${LOCAL_PATH}/${V8_SOURCE_PATH}/core/function/Parameters.v8.cpp \
                   ${LOCAL_PATH}/${V8_SOURCE_PATH}/core/function/Parameters.v8.exp.cpp \
                   ${LOCAL_PATH}/${V8_SOURCE_PATH}/core/function/Result.v8.exp.cpp \
                   ${LOCAL_PATH}/${V8_SOURCE_PATH}/core/function/Return.v8.exp.cpp \
                   ${LOCAL_PATH}/${V8_SOURCE_PATH}/core/Object.v8.cpp \
                   ${LOCAL_PATH}/${V8_SOURCE_PATH}/core/Object.v8.exp.cpp \
                   ${LOCAL_PATH}/${V8_SOURCE_PATH}/core/property/Property.v8.cpp \
                   ${LOCAL_PATH}/${V8_SOURCE_PATH}/core/Reference.v8.cpp \
                   ${LOCAL_PATH}/${V8_SOURCE_PATH}/extra/console/console.v8.cpp \
                   ${LOCAL_PATH}/${V8_SOURCE_PATH}/extra/require/require.v8.cpp \
                   ${LOCAL_PATH}/${V8_SOURCE_PATH}/main.cpp \
                   ${LOCAL_PATH}/${V8_SOURCE_PATH}/utils.cpp

LOCAL_C_INCLUDES := $(LOCAL_PATH)/../include/v8
LOCAL_C_INCLUDES += ${LOCAL_PATH}/libs/include ${LOCAL_PATH}/${COMMON_SOURCE_PATH} ${LOCAL_PATH}/${V8_SOURCE_PATH}
LOCAL_STATIC_LIBRARIES := v8_static
LOCAL_CPPFLAGS += -fexceptions -d__ANDROID__
LOCAL_SHORT_COMMANDS := true

include $(BUILD_SHARED_LIBRARY)
