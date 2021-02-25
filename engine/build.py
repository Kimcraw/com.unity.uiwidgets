import subprocess

FLUTTER_ROOT = "/Users/siyao/temp/flutter/engine/src"
clang = FLUTTER_ROOT+"/buildtools/mac-x64/clang/bin/clang++"
codeFile = "src/assets/asset_manager.cc"
div = codeFile.rfind("/")+1
dir = codeFile[0:div-1]
fileName = codeFile[div::]
div = fileName.index(".")
name = fileName[0:div]
extention = fileName[div::]

FLUTTER_ROOT = "/Users/siyao/temp/flutter/engine/src"
clang = FLUTTER_ROOT + "/buildtools/mac-x64/clang/bin/clang++"
mkdirScript = ["mkdir", "-p", "obj/"+dir]
process = subprocess.Popen(mkdirScript, stdout=subprocess.PIPE, stderr=subprocess.PIPE)
stdout, stderr = process.communicate()
print(stdout, stderr)

buildScript = [
    clang,
    "-MD",
    "-MF",
    "obj/"+dir+"/"+name+".o.d",
    "-DUSE_OPENSSL=1",
    "-DUSE_OPENSSL_CERTS=1",
    "-DANDROID",
    "-DHAVE_SYS_UIO_H",
    "-D__STDC_CONSTANT_MACROS",
    "-D__STDC_FORMAT_MACROS",
    "-D_FORTIFY_SOURCE=2",
    "-D__compiler_offsetof=__builtin_offsetof",
    "-Dnan=__builtin_nan",
    "-D__GNU_SOURCE=1",
    "-D_LIBCPP_DISABLE_VISIBILITY_ANNOTATIONS",
    "-D_LIBCPP_ENABLE_THREAD_SAFETY_ANNOTATIONS",
    "-D_DEBUG",
    "-DU_USING_ICU_NAMESPACE=0",
    "-DU_ENABLE_DYLOAD=0",
    "-DUSE_CHROMIUM_ICU=1",
    "-DU_STATIC_IMPLEMENTATION",
    "-DICU_UTIL_DATA_IMPL=ICU_UTIL_DATA_FILE",
    "-DUCHAR_TYPE=uint16_t",
    "-DFLUTTER_RUNTIME_MODE_DEBUG=1",
    "-DFLUTTER_RUNTIME_MODE_PROFILE=2",
    "-DFLUTTER_RUNTIME_MODE_RELEASE=3",
    "-DFLUTTER_RUNTIME_MODE_JIT_RELEASE=4",
    "-DFLUTTER_RUNTIME_MODE=1",
    "-DFLUTTER_JIT_RUNTIME=1",
    "-I"+FLUTTER_ROOT+"",
    "-Igen",
    "-I"+FLUTTER_ROOT+"/third_party/libcxx/include",
    "-I"+FLUTTER_ROOT+"/third_party/libcxxabi/include",
    "-I"+FLUTTER_ROOT+"/third_party/icu/source/common",
    "-I"+FLUTTER_ROOT+"/third_party/icu/source/i18n",
    "-I"+FLUTTER_ROOT+"",
    "-I"+FLUTTER_ROOT+"/third_party/dart/runtime",
    "-I"+FLUTTER_ROOT+"/third_party/dart/runtime/include",
    "-fno-strict-aliasing",
    "-march=armv7-a",
    "-mfloat-abi=softfp",
    "-mtune=generic-armv7-a",
    "-mthumb",
    "-fPIC",
    "-pipe",
    "-fcolor-diagnostics",
    "-ffunction-sections",
    "-funwind-tables",
    "-fno-short-enums",
    "-nostdinc++",
    "--target=arm-linux-androideabi",
    "-mfpu=neon",
    "-Wall",
    "-Wextra",
    "-Wendif-labels",
    "-Werror",
    "-Wno-missing-field-initializers",
    "-Wno-unused-parameter",
    "-isystem"+FLUTTER_ROOT+"/third_party/android_tools/ndk/sources/android/support/include",
    "-isystem"+FLUTTER_ROOT +
    "/third_party/android_tools/ndk/sysroot/usr/include/arm-linux-androideabi",
    "-D__ANDROID_API__=16",
    "-fvisibility=hidden",
    "--sysroot=/Users/siyao/temp/flutter/engine/src/third_party/android_tools/ndk/sysroot",
    "-Wstring-conversion",
    "-Wnewline-eof",
    "-O0",
    "-g2",
    "-fvisibility-inlines-hidden",
    "-std=c++17",
    "-fno-rtti",
    "-fno-exceptions",
    "-c",
    dir+"/"+name+".cc",
    "-o",
    "obj/"+dir+"/"+name+".o"
]

process = subprocess.Popen(buildScript, stdout=subprocess.PIPE, stderr=subprocess.PIPE)
stdout, stderr = process.communicate()
print(stdout, stderr)
