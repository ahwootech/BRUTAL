using System.Collections.Immutable;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Diagnostics;

namespace Brutal.Core.Analyzers;

[DiagnosticAnalyzer(LanguageNames.CSharp)]
public class OperatingSystemAnalyzer : DiagnosticAnalyzer
{
    // Keep in mind: you have to list your rules here.
    public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics { get; } =
        ImmutableArray.Create(Resources.BrutalCore0003);

    public override void Initialize(AnalysisContext context)
    {
        // You must call this method to avoid analyzing generated code.
        context.ConfigureGeneratedCodeAnalysis(GeneratedCodeAnalysisFlags.None);

        // You must call this method to enable the Concurrent Execution.
        context.EnableConcurrentExecution();

        // Subscribe to the Syntax Node with the appropriate 'SyntaxKind' (ClassDeclaration) action.
        // To figure out which Syntax Nodes you should choose, consider installing the Roslyn syntax tree viewer plugin Rossynt: https://plugins.jetbrains.com/plugin/16902-rossynt/
        context.RegisterSyntaxNodeAction(AnalyzeSyntax, SyntaxKind.InvocationExpression);
    }

    private static void AnalyzeSyntax(SyntaxNodeAnalysisContext context)
    {
        if (context.Node is not InvocationExpressionSyntax invocation)
            return;

        var memberAccess = invocation.Expression as MemberAccessExpressionSyntax;
        if (memberAccess == null)
            return;

        var symbolInfo = context.SemanticModel.GetSymbolInfo(memberAccess.Expression);
        if (symbolInfo.Symbol == null)
            return;

        var systemOperatingSystem = context.SemanticModel.Compilation.GetTypeByMetadataName("System.OperatingSystem");

        if (!SymbolEqualityComparer.Default.Equals(symbolInfo.Symbol, systemOperatingSystem))
            return;

        // check if member name is "IsWindows", "IsLinux", "IsMacOS"
        if (memberAccess.Name.Identifier.Text is not ("IsWindows" or "IsLinux" or "IsMacOS"))
            return;

        var diagnostic = Diagnostic.Create(Resources.BrutalCore0003, invocation.GetLocation());
        context.ReportDiagnostic(diagnostic);
    }
}
