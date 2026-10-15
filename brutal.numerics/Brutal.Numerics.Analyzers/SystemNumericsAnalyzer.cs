using System;
using System.Collections.Immutable;
using Brutal.Numerics.Analyzers;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Diagnostics;
using Microsoft.CodeAnalysis.Operations;

namespace Brutal.Numerics.Analyzers;

/// <summary>
/// Analyzer that reports invalid usage of System.Numerics.
/// </summary>
[DiagnosticAnalyzer(LanguageNames.CSharp)]
public class SystemNumericsAnalyzer : DiagnosticAnalyzer
{
    // Keep in mind: you have to list your rules here.
    public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics { get; } =
        ImmutableArray.Create(Resources.SystemNumericsBrutalCore0005);

    public override void Initialize(AnalysisContext context)
    {
        // You must call this method to avoid analyzing generated code.
        context.ConfigureGeneratedCodeAnalysis(GeneratedCodeAnalysisFlags.None);

        // You must call this method to enable the Concurrent Execution.
        context.EnableConcurrentExecution();

        // Subscribe to semantic (compile time) action invocation, e.g. method invocation.
        context.RegisterOperationAction(AnalyzeOperation, OperationKind.ObjectCreation);
    }

    /// <summary>
    /// Executed on the completion of the semantic analysis associated with the Invocation operation.
    /// </summary>
    /// <param name="context">Operation context.</param>
    private void AnalyzeOperation(OperationAnalysisContext context)
    {
        // Check if the operation is an object creation (ie., 'new TypeName(...)'). Specifically targeting cases like
        // 'new Vector2(...)'.
        if (context.Operation is not IObjectCreationOperation objectCreation)
            return;

        // Retrieve the type being instantiated
        var containingType = objectCreation.Type;
        if (containingType == null)
            return;

        // Get the namespace of the type (e.g. "System.Numerics").
        var namespaceName = containingType.ContainingNamespace?.ToDisplayString();

        // Ensure the namespace is valid and starts with "System.Numerics". If null or empty, the type is not from a
        // relevant namespace. If the namespace doesn't match, ignore the operation.
        if (
            namespaceName != null
            && (
                string.IsNullOrEmpty(namespaceName)
                || !namespaceName.StartsWith("System.Numerics", StringComparison.Ordinal)
            )
        )
            return;

        // At this point, we've identified an instantiation of a System.Numerics type. Create and report a diagnostic
        // at the source location of the 'new' expression.git
        context.ReportDiagnostic(
            Diagnostic.Create(Resources.SystemNumericsBrutalCore0005, context.Operation.Syntax.GetLocation())
        );
    }
}
