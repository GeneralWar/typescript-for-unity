cmake_minimum_required(VERSION 3.4.1)

message(WARNING "aaa")

#if (ANDROID_ABI MATCHES "arm64")
#    set(ARCH_INCLUDE_DIR "aarch64-linux-android")
#else ()
#    set(ARCH_INCLUDE_DIR "arm-linux-androideabi")
#endif ()

set(SOURCE_ROOT  ${PROJECT_SOURCE_DIR}/sources)

add_library(libv8 SHARED IMPORTED)
set_target_properties(libv8 PROPERTIES IMPORTED_LOCATION ${PROJECT_SOURCE_DIR}/libs/${ANDROID_ABI}/libv8.so)
#target_link_libraries(typescript ${LIBRARY_PATH}/${ANDROID_ABI}/libv8.so)
message(WARNING "libv8 : ${v8}")

include_directories(${PROJECT_SOURCE_DIR}/libs/include)
#include_directories(${PROJECT_SOURCE_DIR}/libs/src)
include_directories(${PROJECT_SOURCE_DIR}/../common)
include_directories(${PROJECT_SOURCE_DIR}/../windows/typescript)

add_library(typescript SHARED
            ${PROJECT_SOURCE_DIR}/../common/core/Base.cpp
            ${PROJECT_SOURCE_DIR}/../common/core/class/Class.cpp
            ${PROJECT_SOURCE_DIR}/../common/core/class/Class.exp.cpp
            ${PROJECT_SOURCE_DIR}/../common/core/enum/Enum.cpp
            ${PROJECT_SOURCE_DIR}/../common/core/enum/Enum.exp.cpp
            ${PROJECT_SOURCE_DIR}/../common/core/Environment.cpp
            ${PROJECT_SOURCE_DIR}/../common/core/function/Function.cpp
            ${PROJECT_SOURCE_DIR}/../common/core/namespace/Namespace.cpp
            ${PROJECT_SOURCE_DIR}/../common/core/namespace/Namespace.exp.cpp
            ${PROJECT_SOURCE_DIR}/../common/core/property/Property.cpp
            ${PROJECT_SOURCE_DIR}/../common/core/Reference.cpp
            ${PROJECT_SOURCE_DIR}/../common/core/Typescript.exp.cpp
            ${PROJECT_SOURCE_DIR}/../common/export.cpp
            ${PROJECT_SOURCE_DIR}/../common/extension/files/FileUtility.cpp
            ${PROJECT_SOURCE_DIR}/../common/extension/files/FileUtility.exp.cpp
            ${PROJECT_SOURCE_DIR}/../common/extra/console/console.cpp
            ${PROJECT_SOURCE_DIR}/../common/extra/log/Log.cpp
            ${PROJECT_SOURCE_DIR}/../common/extra/require/require.cpp
            ${PROJECT_SOURCE_DIR}/../windows/typescript/core/Base.win.cpp
            ${PROJECT_SOURCE_DIR}/../windows/typescript/core/class/Class.win.cpp
            ${PROJECT_SOURCE_DIR}/../windows/typescript/core/class/Class.win.exp.cpp
            ${PROJECT_SOURCE_DIR}/../windows/typescript/core/enum/Enum.win.cpp
            ${PROJECT_SOURCE_DIR}/../windows/typescript/core/Environment.win.cpp
            ${PROJECT_SOURCE_DIR}/../windows/typescript/core/function/Argument.cpp
            ${PROJECT_SOURCE_DIR}/../windows/typescript/core/function/Caller.win.exp.cpp
            ${PROJECT_SOURCE_DIR}/../windows/typescript/core/function/Constructor.win.cpp
            ${PROJECT_SOURCE_DIR}/../windows/typescript/core/function/Function.win.cpp
            ${PROJECT_SOURCE_DIR}/../windows/typescript/core/function/Parameters.win.cpp
            ${PROJECT_SOURCE_DIR}/../windows/typescript/core/function/Parameters.win.exp.cpp
            ${PROJECT_SOURCE_DIR}/../windows/typescript/core/function/Result.win.exp.cpp
            ${PROJECT_SOURCE_DIR}/../windows/typescript/core/function/Return.win.exp.cpp
            ${PROJECT_SOURCE_DIR}/../windows/typescript/core/Object.win.cpp
            ${PROJECT_SOURCE_DIR}/../windows/typescript/core/Object.win.exp.cpp
            ${PROJECT_SOURCE_DIR}/../windows/typescript/core/property/Property.win.cpp
            ${PROJECT_SOURCE_DIR}/../windows/typescript/core/Reference.win.cpp
            ${PROJECT_SOURCE_DIR}/../windows/typescript/extra/console/console.win.cpp
            ${PROJECT_SOURCE_DIR}/../windows/typescript/extra/require/require.win.cpp
            ${PROJECT_SOURCE_DIR}/../windows/typescript/main.cpp
            ${PROJECT_SOURCE_DIR}/../windows/typescript/utils.cpp)
                    ${PROJECT_SOURCE_DIR}/../windows/typescript/native-lib.cpp)

set(LIBRARY_PATH ${PROJECT_SOURCE_DIR}/libs)
#target_link_libraries(typescript ${LIBRARY_PATH}/${ANDROID_ABI}/libv8_libbase.a)
#target_link_libraries(typescript ${LIBRARY_PATH}/${ANDROID_ABI}/libv8_libplatform.a)
#target_link_libraries(typescript ${LIBRARY_PATH}/${ANDROID_ABI}/libv8_libsampler.a)
#target_link_libraries(typescript ${LIBRARY_PATH}/${ANDROID_ABI}/libv8_snapshot.a)
#target_link_libraries(typescript ${LIBRARY_PATH}/${ANDROID_ABI}/libinspector.a)
#target_link_libraries(typescript ${LIBRARY_PATH}/${ANDROID_ABI}/libv8_compiler.a)
#target_link_libraries(typescript ${LIBRARY_PATH}/${ANDROID_ABI}/libv8_base_without_compiler.a)

# find_library(Sets the name of the path variable, Specifies the name of the NDK library that you want CMake to locate.)
find_library(liblog log)
target_link_libraries(typescript ${liblog} ${libv8})
