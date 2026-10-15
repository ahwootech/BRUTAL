using Microsoft.CodeAnalysis;

namespace Brutal.Core.Analyzers;

public static class Resources
{
    public static readonly DiagnosticDescriptor BrutalCore0003 = new(
        "BRUTALCORE0003",
        "Prefer Brutal.Platform instead of System.OperatingSystem",
        "Brutal.Platform provides a simpler API to check the current platform",
        "Obsolete",
        DiagnosticSeverity.Info,
        isEnabledByDefault: true,
        description: "Use Brutal.Platform instead of System.OperatingSystem."
    );
    public const string BrutalCore0003Suggestion = "Use Brutal.Platform";

    // From framework analyser BRUTAL4003 var fixes
    public static readonly DiagnosticDescriptor VarBrutalCore0007 = new(
        "BRUTALCORE0007",
        "Prefer var over explicit type",
        "Use var for terseness and ease of refactoring",
        "Usage",
        DiagnosticSeverity.Info,
        isEnabledByDefault: true,
        description: "Use var instead of explicit types."
    );

    // From framework analyser BRUTAL4003 var fixes for default initialisation
    public static readonly DiagnosticDescriptor VarDefaultBrutalCore0008 = new(
        "BRUTALCORE0008",
        "Prefer var default literal over explicit with default",
        "Use var with default(type) for terseness and consistency",
        "Usage",
        DiagnosticSeverity.Info,
        isEnabledByDefault: true,
        description: "Use var instead of explicit types."
    );

    public static readonly DiagnosticDescriptor ExpectsFixedBrutalCore0009 = new(
        "BRUTALCORE0009",
        "This should be a fixed value",
        "Potential unsafe call to {0}. Ensure the argument for '{1}' comes from a fixed source.",
        "Usage",
        DiagnosticSeverity.Error,
        isEnabledByDefault: true
    );

    public static readonly DiagnosticDescriptor ExpectsFixedBrutalCore0010 = new(
        "BRUTALCORE0010",
        "This should be a fixed value",
        "Potential unsafe implicit conversion from {0} to {1}. Ensure cast comes from a fixed source.",
        "Usage",
        DiagnosticSeverity.Error,
        isEnabledByDefault: true
    );

    public static readonly DiagnosticDescriptor LosesFixedBrutalCore0012 = new(
        "BRUTALCORE0012",
        "Delegate conversion loses [Fixed]",
        "Converting {0} to '{1}' erases the [Fixed] requirement on parameter '{2}'. Calls through the delegate are not checked; use a delegate type that marks the parameter [Fixed].",
        "Usage",
        DiagnosticSeverity.Warning,
        isEnabledByDefault: true
    );
}
