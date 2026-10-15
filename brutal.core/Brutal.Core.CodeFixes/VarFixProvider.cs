using System.Collections.Immutable;
using System.Composition;
using Brutal.Core.Analyzers;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CodeActions;
using Microsoft.CodeAnalysis.CodeFixes;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Brutal.Core.Analyzers;

/// <summary>
/// A code fix provider that replaces explicit types with 'var' and expands 'new()' to 'new TypeName()'.
/// All code fixes must be linked to specific analyzers.
/// </summary>
[ExportCodeFixProvider(LanguageNames.CSharp, Name = nameof(VarFixProvider)), Shared]
public class VarFixProvider : CodeFixProvider
{
    // Specify the diagnostic IDs of analyzers that are expected to be linked.
    public sealed override ImmutableArray<string> FixableDiagnosticIds { get; } =
    [Resources.VarBrutalCore0007.Id, Resources.VarDefaultBrutalCore0008.Id];

    // If you don't need the 'fix all' behavior, return null.
    public override FixAllProvider? GetFixAllProvider() => null; //WellKnownFixAllProviders.BatchFixer;

    public sealed override async Task RegisterCodeFixesAsync(CodeFixContext context)
    {
        // We link only one diagnostic and assume there is only one diagnostic in the context.
        if (context.Diagnostics.Length != 1)
        {
            return;
        }

        var diagnostic = context.Diagnostics[0];

        // 'SourceSpan' of 'Location' is the highlighted area.
        var diagnosticSpan = diagnostic.Location.SourceSpan;

        // Get the root of Syntax Tree that contains the highlighted diagnostic.
        var root = await context.Document.GetSyntaxRootAsync(context.CancellationToken).ConfigureAwait(false);

        // Find the TypeSyntax node to replace (eg., 'float' in 'float x = 1f')
        if (root?.FindNode(diagnosticSpan) is not TypeSyntax typeSyntax)
            return;

        var declaration = typeSyntax.FirstAncestorOrSelf<VariableDeclarationSyntax>();
        if (declaration is not null && TryRegisterDefault(declaration, context, diagnostic, root))
            return;

        // Register a code action that will invoke the fix.
        context.RegisterCodeFix(
            CodeAction.Create(
                title: string.Format(Resources.VarBrutalCore0007.Id),
                createChangedDocument: c => ReplaceWithVarAsync(context.Document, typeSyntax, c),
                equivalenceKey: nameof(Resources.VarBrutalCore0007.Id)
            ),
            diagnostic
        );
    }

    private bool TryRegisterDefault(
        VariableDeclarationSyntax declaration,
        CodeFixContext context,
        Diagnostic diagnostic,
        SyntaxNode root
    )
    {
        var variable = declaration.Variables.FirstOrDefault();
        if (variable?.Initializer is null)
        {
            return false;
        }

        // e.g. int bob = default. Here, default is a DefaultLiteralExpression
        // int bob = default(3). Here, default is a DefaultExpression
        if (!variable.Initializer.Value.IsKind(SyntaxKind.DefaultLiteralExpression))
            return false;

        context.RegisterCodeFix(
            CodeAction.Create(
                Resources.VarDefaultBrutalCore0008.Title.ToString(),
                c => UseVarAndExplicitDefaultAsync(context.Document, declaration, variable, c, root),
                nameof(VarFixProvider)
            ),
            diagnostic
        );
        return true;
    }

    private Task<Document> UseVarAndExplicitDefaultAsync(
        Document document,
        VariableDeclarationSyntax declaration,
        VariableDeclaratorSyntax variable,
        CancellationToken cancellationToken,
        SyntaxNode root
    )
    {
        var varType = SyntaxFactory
            .IdentifierName("var")
            .WithLeadingTrivia(declaration.Type.GetLeadingTrivia())
            .WithTrailingTrivia(declaration.Type.GetTrailingTrivia());

        var explicitDefault = SyntaxFactory.DefaultExpression(declaration.Type.WithoutTrivia());

        var newVariable = variable.WithInitializer(
            SyntaxFactory.EqualsValueClause(explicitDefault).WithEqualsToken(variable.Initializer!.EqualsToken)
        );

        var newDeclaration = declaration
            .WithType(varType)
            .WithVariables(SyntaxFactory.SingletonSeparatedList(newVariable));

        // var root = await document.GetSyntaxRootAsync(cancellationToken).ConfigureAwait(false);
        var newRoot = root.ReplaceNode(declaration, newDeclaration);

        return Task.FromResult(document.WithSyntaxRoot(newRoot));
    }

    /// <summary>
    /// Executed on the quick fix action raised by the user.
    /// </summary>
    /// <param name="document">Affected source file.</param>
    /// <param name="explicitType">The explicit type syntax node to replace.</param>
    /// <param name="cancellationToken">Any fix is cancellable by the user, so we should support the cancellation token.</param>
    /// <returns>A new document with the explicit type replaced by 'var'.</returns>
    private async Task<Document> ReplaceWithVarAsync(
        Document document,
        TypeSyntax explicitType,
        CancellationToken cancellationToken
    )
    {
        var root = await document.GetSyntaxRootAsync(cancellationToken).ConfigureAwait(false);
        if (root == null)
            return document;

        var semanticModel = await document.GetSemanticModelAsync(cancellationToken).ConfigureAwait(false);
        if (semanticModel == null)
            return document;

        // Get the VariableDeclarationSyntax node (e.g., 'myObject obj = new();')
        if (explicitType.Parent is not VariableDeclarationSyntax declaration || declaration.Variables.Count == 0)
            return document;

        var variable = declaration.Variables[0];

        // Create 'var' keyword with preserved trivia
        var varType = SyntaxFactory
            .IdentifierName("var")
            .WithLeadingTrivia(explicitType.GetLeadingTrivia())
            .WithTrailingTrivia(explicitType.GetTrailingTrivia());

        ExpressionSyntax? newInitializerExpr = variable.Initializer?.Value;

        // Replace 'new()' with 'new myObject()' if necessary
        if (variable.Initializer?.Value is ImplicitObjectCreationExpressionSyntax implicitNew)
        {
            newInitializerExpr = SyntaxFactory
                .ObjectCreationExpression(explicitType.WithoutTrivia())
                .WithArgumentList(implicitNew.ArgumentList ?? SyntaxFactory.ArgumentList())
                .WithTrailingTrivia(implicitNew.GetTrailingTrivia())
                .WithLeadingTrivia(implicitNew.GetLeadingTrivia());
        }

        if (variable.Initializer?.Value is DefaultExpressionSyntax defaultExpression)
        {
            newInitializerExpr = SyntaxFactory
                .DefaultExpression(explicitType.WithoutTrivia())
                .WithType(explicitType.NormalizeWhitespace());
        }

        // Reconstruct initializer
        var newInitializer = variable.Initializer?.WithValue(newInitializerExpr!);

        // Reconstruct the variable
        var newVariable = variable
            .WithInitializer(newInitializer)
            .WithLeadingTrivia(variable.GetLeadingTrivia())
            .WithTrailingTrivia(variable.GetTrailingTrivia());

        // Replace the declaration node
        var newDeclaration = declaration
            .WithType(varType)
            .WithVariables(SyntaxFactory.SingletonSeparatedList(newVariable))
            .WithLeadingTrivia(declaration.GetLeadingTrivia())
            .WithTrailingTrivia(declaration.GetTrailingTrivia());

        // Replace the old node with the new one in the tree
        var newRoot = root.ReplaceNode(declaration, newDeclaration);

        return document.WithSyntaxRoot(newRoot);
    }
}
