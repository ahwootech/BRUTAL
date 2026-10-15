global using System.ComponentModel;
global using System.Diagnostics;
global using System.Runtime.CompilerServices;
global using System.Runtime.InteropServices;
global using Brutal.Memory;
global using Brutal.Pointers;
global using Brutal.Pointers.Extensions;
global using Brutal.Strings.Extensions;
global using CommunityToolkit.HighPerformance;
global using Char16 = char;
global using Char8 = byte;
global using String16 = string;
global using String16View = System.ReadOnlySpan<char>;
global using String8View = System.ReadOnlySpan<byte>;
global using StringBuilder16 = Brutal.Strings.StringBuilder<char>;
global using StringBuilder8 = Brutal.Strings.StringBuilder<byte>;
global using ValueStringBuilder16 = Brutal.Strings.ValueStringBuilder<char>;
global using ValueStringBuilder8 = Brutal.Strings.ValueStringBuilder<byte>;

[assembly: InternalsVisibleTo("Brutal.Strings.Tests")]
