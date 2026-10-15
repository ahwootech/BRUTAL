# Finds Zlib from the RocketWerkz.Brutal.Zlib NuGet package, for consumers building native
# code against zlib. Shipped inside the package (build/natives/cmake/); a consumer puts this dir
# on CMAKE_MODULE_PATH and calls find_package(ZLIB). ZLIB_NUGET_DIR is injected by the
# package's auto-imported .targets.

# Normalise path separators (MSBuild may produce backslashes on Windows).
file(TO_CMAKE_PATH "${ZLIB_NUGET_DIR}" ZLIB_NUGET_DIR)

# Point at the shared lib (and Windows import lib) inside the NuGet package.
if(WIN32)
    set(zlib_shared "${ZLIB_NUGET_DIR}/runtimes/win-x64/native/zlib.dll")
    set(zlib_implib "${ZLIB_NUGET_DIR}/build/natives/lib/win-x64/zlib.lib")
elseif(APPLE)
    set(zlib_shared "${ZLIB_NUGET_DIR}/runtimes/osx-arm64/native/libzlib.dylib")
else()
    set(zlib_shared "${ZLIB_NUGET_DIR}/runtimes/linux-x64/native/libzlib.so")
endif()

# Hand find_package the results it expects.
set(ZLIB_FOUND TRUE)
set(ZLIB_INCLUDE_DIRS "${ZLIB_NUGET_DIR}/build/natives/include")
set(ZLIB_LIBRARIES    "${zlib_shared}")

# Expose the standard ZLIB::ZLIB target so consumers (FreeType/libpng) can link it.
if(NOT TARGET ZLIB::ZLIB)
    add_library(ZLIB::ZLIB SHARED IMPORTED GLOBAL)
    set_target_properties(ZLIB::ZLIB PROPERTIES
        IMPORTED_LOCATION             "${zlib_shared}"
        INTERFACE_INCLUDE_DIRECTORIES "${ZLIB_NUGET_DIR}/build/natives/include"
    )
    # Match the soname/implib the linker expects per platform.
    if(WIN32)
        set_property(TARGET ZLIB::ZLIB PROPERTY IMPORTED_IMPLIB "${zlib_implib}")
    elseif(APPLE)
        set_property(TARGET ZLIB::ZLIB PROPERTY IMPORTED_SONAME "@rpath/libzlib.1.dylib")
    else()
        set_property(TARGET ZLIB::ZLIB PROPERTY IMPORTED_SONAME "libzlib.so.1")
    endif()
endif()

mark_as_advanced(ZLIB_FOUND ZLIB_INCLUDE_DIRS ZLIB_LIBRARIES)
