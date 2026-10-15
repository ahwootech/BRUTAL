using System.Collections.Immutable;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Diagnostics;

namespace Brutal.Core.Analyzers;

/// <summary>
/// Analyzer that flags explicit type declarations that can be replaced with 'var'.
/// </summary>
[DiagnosticAnalyzer(LanguageNames.CSharp)]
public class VarAnalyzer : DiagnosticAnalyzer
{
    // Keep in mind: you have to list your rules here.
    public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics { get; } =
        ImmutableArray.Create(Resources.VarBrutalCore0007, Resources.VarDefaultBrutalCore0008);

    public override void Initialize(AnalysisContext context)
    {
        // You must call this method to avoid analyzing generated code.
        context.ConfigureGeneratedCodeAnalysis(GeneratedCodeAnalysisFlags.None);

        // You must call this method to enable the Concurrent Execution.
        context.EnableConcurrentExecution();

        // Analyze variable declarations like `float x = 1f` or `MyType obj = new()`
        context.RegisterSyntaxNodeAction(AnalyzeVariableDeclaration, SyntaxKind.VariableDeclaration);

        // Check other 'context.Register...' methods that might be helpful for your purposes.
    }

    /// <summary>
    /// Analyzes explicit variable declarations to suggest 'var' where applicable.
    /// </summary>
    /// <param name="context">Operation context.</param>
    private void AnalyzeVariableDeclaration(SyntaxNodeAnalysisContext context)
    {
        var variableDeclaration = (VariableDeclarationSyntax)context.Node;

        if (
            variableDeclaration.Type.IsVar
            || variableDeclaration.Parent is not LocalDeclarationStatementSyntax localDecl
            || IsConst(localDecl)
        )
            return;

        foreach (var variable in variableDeclaration.Variables)
        {
            if (variable.Initializer == null)
                continue;

            var declaredType = context.SemanticModel.GetTypeInfo(variableDeclaration.Type).Type;
            var initializerType = context.SemanticModel.GetTypeInfo(variable.Initializer.Value).Type;

            if (declaredType == null || initializerType == null)
                continue;

            // SomeType me = default -> var me default(SomeType);
            if (variable.Initializer.Value.IsKind(SyntaxKind.DefaultLiteralExpression))
            {
                ReportVarDefaultDiagnostic(context, variableDeclaration);
                continue;
            }

            if (!WouldVarDeclarationProduceSameType(variable, context.SemanticModel))
                continue;

            // Report diagnostic on the explicit type
            context.ReportDiagnostic(
                Diagnostic.Create(
                    Resources.VarBrutalCore0007,
                    variableDeclaration.Type.GetLocation(),
                    declaredType.ToDisplayString(SymbolDisplayFormat.MinimallyQualifiedFormat)
                )
            );
        }
    }

    private static void ReportVarDefaultDiagnostic(
        SyntaxNodeAnalysisContext context,
        VariableDeclarationSyntax variableDeclaration
    )
    {
        context.ReportDiagnostic(
            Diagnostic.Create(
                Resources.VarDefaultBrutalCore0008,
                variableDeclaration.Type.GetLocation(),
                variableDeclaration.Type.ToString()
            )
        );
    }

    /// <summary>
    /// This function returns whether, if the variable declaration was made into a 'var' declaration,
    /// that the same final type would be the same as what it originally was. e.g.
    ///
    /// Given:
    ///     Span &lt;byte&gt; data = stackalloc byte[1024];
    /// If we test
    ///     var data = stackalloc byte[1024];
    ///
    /// Is the resulting type of the symbol 'data' the same in both cases.
    /// </summary>
    /// <param name="declarator"></param>
    /// <param name="semanticModel"></param>
    /// <param name="ct"></param>
    /// <returns></returns>
    public static bool WouldVarDeclarationProduceSameType(
        VariableDeclaratorSyntax declarator,
        SemanticModel semanticModel,
        CancellationToken ct = default
    )
    {
        // Must have an initializer to use 'var'
        if (declarator.Initializer is null)
            return false;

        var declaration = (VariableDeclarationSyntax)declarator.Parent!;
        var originalLocal = (ILocalSymbol?)semanticModel.GetDeclaredSymbol(declarator, ct);
        if (originalLocal is null)
            return false;

        if (declaration.Parent is not LocalDeclarationStatementSyntax localStmt)
            return false;

        var synthesisedVarDeclaration = SynthesisedVarDeclaration(declarator, declaration);

        if (!TryGetSynthesisedSymbol(semanticModel, localStmt, synthesisedVarDeclaration, out var specLocal, ct))
            return false;

        return specLocal?.Type is not null
            && specLocal.Type.Kind != SymbolKind.ErrorType
            && SymbolEqualityComparer.Default.Equals(originalLocal.Type, specLocal.Type);
    }

    private static bool TryGetSynthesisedSymbol(
        SemanticModel semanticModel,
        LocalDeclarationStatementSyntax localStmt,
        VariableDeclarationSyntax synthesisedVarDeclaration,
        out ILocalSymbol? specLocal,
        CancellationToken ct
    )
    {
        var newLocalStmt = localStmt.WithDeclaration(synthesisedVarDeclaration);
        if (!semanticModel.TryGetSpeculativeSemanticModel(localStmt.SpanStart, newLocalStmt, out var specModel))
        {
            specLocal = null;
            return false;
        }

        var specRoot = specModel.SyntaxTree.GetRoot(ct);
        var specDeclarator = specRoot.FindNode(synthesisedVarDeclaration.Variables[0].Span); // <VariableDeclaratorSyntax>(node => node == varDeclaration.Variables[0]);

        specLocal = (ILocalSymbol?)specModel.GetDeclaredSymbol(specDeclarator, ct);
        return true;
    }

    private static VariableDeclarationSyntax SynthesisedVarDeclaration(
        VariableDeclaratorSyntax declarator,
        VariableDeclarationSyntax declaration
    )
    {
        var varType = SyntaxFactory.IdentifierName("var").WithTriviaFrom(declaration.Type);

        var varDecl = declaration.WithType(varType);
        return varDecl;
    }

    private static bool IsConst(LocalDeclarationStatementSyntax localDecl)
    {
        for (var i = 0; i < localDecl.Modifiers.Count; i++)
        {
            if (localDecl.Modifiers[i].IsKind(SyntaxKind.ConstKeyword))
                return true;
        }

        return false;
    }
}
