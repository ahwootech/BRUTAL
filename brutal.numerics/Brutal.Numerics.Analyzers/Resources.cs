using Microsoft.CodeAnalysis;

namespace Brutal.Numerics.Analyzers;

public static class Resources
{
    // From framework analyser BRUTAL3001 Usage of System.Drawing
    public static readonly DiagnosticDescriptor SystemDrawingBrutalCore0004 = new(
        "BRUTALCORE0004",
        "Prefer Brutal.Numerics instead of System.Drawing.Color",
        "Brutal.Numerics has colour constant types",
        "Obsolete",
        DiagnosticSeverity.Warning,
        isEnabledByDefault: true,
        description: "Use Brutal.Numerics instead of System.Drawing.Color."
    );

    // From framework analyser BRUTAL3002 Usage of System.Numerics
    public static readonly DiagnosticDescriptor SystemNumericsBrutalCore0005 = new(
        "BRUTALCORE0005",
        "Prefer Brutal.Numerics instead of System.Numerics",
        "Brutal.Numerics provides optimised numeric functions",
        "Obsolete",
        DiagnosticSeverity.Info,
        isEnabledByDefault: true,
        description: "Brutal.Numerics instead of System.Numerics."
    );

    // From framework analyser BRUTAL4002 Usage of float3.Rgb(...) to create grayscale colors
    public static readonly DiagnosticDescriptor RgbToGreyBrutalCore0006 = new(
        "BRUTALCORE0006",
        "Prefer Brutal.Numerics.Color.Gray instead of specifying explicit color channel values",
        "Brutal.Numerics provides a set of predefined colors",
        "Usage",
        DiagnosticSeverity.Info,
        isEnabledByDefault: true,
        description: "Brutal.Numerics instead of System.Numerics."
    );
}
