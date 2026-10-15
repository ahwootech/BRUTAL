using Microsoft.CodeAnalysis;

namespace Brutal.Strings.Analyzers;

public static class Resources
{
    public static readonly DiagnosticDescriptor BrutalCore0001 = new(
        "BRUTALCORE0001",
        "Avoid calling ToString on (ReadOnly)Span<byte>",
        "ToString() on a span does not convert the contents to a string, did you mean to use ToString16?",
        "Intent",
        DiagnosticSeverity.Warning,
        isEnabledByDefault: true,
        description: "Span<byte>.ToString() does not decode the bytes to a string."
    );
    public const string BrutalCore0001Suggestion = "Use .ToString16()";

    public static readonly DiagnosticDescriptor BrutalCore0002 = new(
        "BRUTALCORE0002",
        "Avoid calling ToString on (ReadOnly)Span<T> where T is not string or byte",
        "ToString() on a span does not convert the contents to a string, did you mean to use a different method?",
        "Intent",
        DiagnosticSeverity.Warning,
        isEnabledByDefault: true,
        description: "Span<T>.ToString() does not decode the content to a string."
    );

    public static readonly DiagnosticDescriptor PreferU8OverloadBrutalCore0011 = new(
        "BRUTALCORE0011",
        "Prefer using a UTF8 string",
        "Prefer using a UTF8 string: {0}",
        "Usage",
        DiagnosticSeverity.Warning,
        isEnabledByDefault: true
    );
    public const string PreferU8OverloadBrutalCore0011Suggestion = "Append u8 to the string literal";
}
