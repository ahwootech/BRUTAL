# Finds FreeType from the RocketWerkz.Brutal.FreeType NuGet package, for consumers building native
# code against freetype. Shipped inside the package (build/natives/cmake/); a consumer puts this dir
# on CMAKE_MODULE_PATH and calls find_package(Freetype). FREETYPE_NUGET_DIR is injected by the
# package's auto-imported .targets.

# Normalise path separators (MSBuild may produce backslashes on Windows).
file(TO_CMAKE_PATH "${FREETYPE_NUGET_DIR}" FREETYPE_NUGET_DIR)

# Point at the shared lib (and Windows import lib) inside the NuGet package.
if(WIN32)
    set(freetype_shared "${FREETYPE_NUGET_DIR}/runtimes/win-x64/native/freetype.dll")
    set(freetype_implib "${FREETYPE_NUGET_DIR}/build/natives/lib/win-x64/freetype.lib")
elseif(APPLE)
    set(freetype_shared "${FREETYPE_NUGET_DIR}/runtimes/osx-arm64/native/libfreetype.dylib")
else()
    set(freetype_shared "${FREETYPE_NUGET_DIR}/runtimes/linux-x64/native/libfreetype.so")
endif()

# Hand find_package the results it expects.
set(FREETYPE_FOUND TRUE)
set(FREETYPE_INCLUDE_DIRS "${FREETYPE_NUGET_DIR}/build/natives/include")
set(FREETYPE_LIBRARIES    "${freetype_shared}")

# Expose the standard Freetype::Freetype target so consumers can link it.
if(NOT TARGET Freetype::Freetype)
    add_library(Freetype::Freetype SHARED IMPORTED GLOBAL)
    set_target_properties(Freetype::Freetype PROPERTIES
        IMPORTED_LOCATION             "${freetype_shared}"
        INTERFACE_INCLUDE_DIRECTORIES "${FREETYPE_NUGET_DIR}/build/natives/include"
    )
    # Match the soname/implib the linker expects per platform.
    if(WIN32)
        set_property(TARGET Freetype::Freetype PROPERTY IMPORTED_IMPLIB "${freetype_implib}")
    elseif(APPLE)
        set_property(TARGET Freetype::Freetype PROPERTY IMPORTED_SONAME "@rpath/libfreetype.6.dylib")
    else()
        set_property(TARGET Freetype::Freetype PROPERTY IMPORTED_SONAME "libfreetype.so.6")
    endif()
endif()

mark_as_advanced(FREETYPE_FOUND FREETYPE_INCLUDE_DIRS FREETYPE_LIBRARIES)
