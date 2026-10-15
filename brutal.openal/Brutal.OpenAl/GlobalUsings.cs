// Global usings for the generated P/Invoke and handle surface.
//
// - System.Runtime.InteropServices: the [LibraryImport] source-generated imports in Al.PInvoke /
//   Alc.PInvoke.
// - System.Runtime.CompilerServices: [ModuleInitializer] on the native loader.
//
// The generated enum files each carry their own per-file `using static ...Constants;` import, so no
// `global using static ...Constants;` is required here.
//
// Additions for the hand-written layer:
// - System.Text: Encoding.UTF8 in Utf8Buffer/StringUtils.
// - Brutal: INullable (implemented by the value handles) and Bool8.
// - Brutal.Numerics: float3, the vector type for 3-float AL/ALC parameters.
global using System.Runtime.CompilerServices;
global using System.Runtime.InteropServices;
global using System.Text;
global using Brutal;
global using Brutal.Numerics;
global using CommunityToolkit.HighPerformance;
