using System.Collections.Immutable;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Diagnostics;
using Microsoft.CodeAnalysis.Operations;

namespace Brutal.Strings.Analyzers;

[DiagnosticAnalyzer(LanguageNames.CSharp)]
public class SpanToStringAnalyzer : DiagnosticAnalyzer
{
    // Keep in mind: you have to list your rules here.
    public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics { get; } =
    [Resources.BrutalCore0001, Resources.BrutalCore0002];

    public override void Initialize(AnalysisContext context)
    {
        // You must call this method to avoid analyzing generated code.
        context.ConfigureGeneratedCodeAnalysis(GeneratedCodeAnalysisFlags.None);

        // You must call this method to enable the Concurrent Execution.
        context.EnableConcurrentExecution();

        // Monitor (method) invocations
        context.RegisterOperationAction(AnalyzeInvocation, OperationKind.Invocation);
    }

    private static void AnalyzeInvocation(OperationAnalysisContext context)
    {
        var invocation = (IInvocationOperation)context.Operation;
        var method = invocation.TargetMethod;

        if (method.Name != "ToString")
            return;

        var type = method.ContainingType;
        if (type.TypeArguments.Length != 1)
            return;

        var compilation = context.Compilation;
        var spanType = compilation.GetTypeByMetadataName("System.Span`1");
        var readOnlySpanType = compilation.GetTypeByMetadataName("System.ReadOnlySpan`1");

        // no need for IncludeNullability as all types we're testing are value types, and spans can't be nullable
        var comparer = SymbolEqualityComparer.Default;

        if (
            !comparer.Equals(type.OriginalDefinition, spanType)
            && !comparer.Equals(type.OriginalDefinition, readOnlySpanType)
        )
            return;

        var typeArg = type.TypeArguments[0];
        var charType = compilation.GetTypeByMetadataName("System.Char");
        var byteType = compilation.GetTypeByMetadataName("System.Byte");

        // Span<char>.ToString() is ok
        if (comparer.Equals(typeArg, charType))
            return;

        var rule = comparer.Equals(typeArg, byteType) ? Resources.BrutalCore0001 : Resources.BrutalCore0002;

        var invocationSyntax = (InvocationExpressionSyntax)invocation.Syntax;
        var memberAccess = (MemberAccessExpressionSyntax)invocationSyntax.Expression;
        var methodSyntax = memberAccess.Name;

        var diagnostic = Diagnostic.Create(rule, methodSyntax.GetLocation());
        context.ReportDiagnostic(diagnostic);
    }
}
