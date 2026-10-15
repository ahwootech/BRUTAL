using System.Collections.Immutable;
using Brutal.Numerics.Analyzers;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Diagnostics;
using Microsoft.CodeAnalysis.Operations;

namespace Brutal.Numerics.Analyzers;

/// <summary>
/// Analyzer that flags usage of System.Drawing.Color.
/// </summary>
[DiagnosticAnalyzer(LanguageNames.CSharp)]
public class SystemDrawingAnalyzer : DiagnosticAnalyzer
{
    // Keep in mind: you have to list your rules here.
    public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics { get; } =
        ImmutableArray.Create(Resources.SystemDrawingBrutalCore0004);

    public override void Initialize(AnalysisContext context)
    {
        // You must call this method to avoid analyzing generated code.
        context.ConfigureGeneratedCodeAnalysis(GeneratedCodeAnalysisFlags.None);

        // You must call this method to enable the Concurrent Execution.
        context.EnableConcurrentExecution();

        // Subscribe to semantic (compile time) action invocation, e.g. method invocation.
        context.RegisterOperationAction(
            AnalyzeOperation,
            OperationKind.FieldReference,
            OperationKind.PropertyReference
        );
    }

    /// <summary>
    /// Executed on the completion of the semantic analysis associated with the Invocation operation.
    /// </summary>
    /// <param name="context">Operation context.</param>
    private void AnalyzeOperation(OperationAnalysisContext context)
    {
        // Check if the current operation is a reference to a member (field or property), such as accessing Color.Red.
        // If not, exit early as this analyzer only targets member references.
        if (context.Operation is not IMemberReferenceOperation memberRef)
            return;

        // Get the type that contains the referenced member, e.g., System.Drawing.Color.
        var containingType = memberRef.Member.ContainingType;
        if (containingType == null)
            return;

        // Get the namespace of the containing type (e.g. "System.Drawing").
        var namespaceName = containingType.ContainingNamespace?.ToDisplayString();

        // Validate the namespace and type name. If the namespace is null or empty, ignore the operation. If the
        // namespace does not start with "System.Drawing" or if the type is not specifically "Color", ignore it.
        // Together, this ensures we only target usages like System.Drawing.Color.Red.
        if (
            namespaceName != null
            && (
                string.IsNullOrEmpty(namespaceName)
                || !namespaceName.StartsWith("System.Drawing", StringComparison.Ordinal)
                || containingType.Name != "Color"
            )
        )
            return;

        // At this point, we've confirmed a usage of System.Drawing.Color.<member>. Create and report a diagnostic at
        // the location where the member is used.
        context.ReportDiagnostic(
            Diagnostic.Create(Resources.SystemDrawingBrutalCore0004, memberRef.Syntax.GetLocation())
        );
    }
}
