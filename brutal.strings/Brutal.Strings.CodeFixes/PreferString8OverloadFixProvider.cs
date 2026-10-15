using System.Collections.Immutable;
using System.Composition;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CodeActions;
using Microsoft.CodeAnalysis.CodeFixes;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Brutal.Strings.Analyzers;

[ExportCodeFixProvider(LanguageNames.CSharp, Name = nameof(PreferString8OverloadFixProvider)), Shared]
public class PreferString8OverloadFixProvider : CodeFixProvider
{
    private static readonly string DiagnosticId = Resources.PreferU8OverloadBrutalCore0011.Id;
    private const string Suggestion = Resources.PreferU8OverloadBrutalCore0011Suggestion;

    public sealed override ImmutableArray<string> FixableDiagnosticIds { get; } = [DiagnosticId];

    public override FixAllProvider GetFixAllProvider() => WellKnownFixAllProviders.BatchFixer;

    public sealed override async Task RegisterCodeFixesAsync(CodeFixContext context)
    {
        // We link only one diagnostic and assume there is only one diagnostic in the context.
        var diagnostic = context.Diagnostics.Single();

        // 'SourceSpan' of 'Location' is the highlighted area. We're going to use this area to find the 'SyntaxNode' to rename.
        var diagnosticSpan = diagnostic.Location.SourceSpan;

        // Get the root of Syntax Tree that contains the highlighted diagnostic.
        var root = await context.Document.GetSyntaxRootAsync(context.CancellationToken).ConfigureAwait(false);

        // Find SyntaxNode corresponding to the diagnostic.
        var diagnosticNode = root?.FindNode(diagnosticSpan);

        // We expect a string literal (argument or conversion)
        var literal = diagnosticNode switch
        {
            ArgumentSyntax { Expression: LiteralExpressionSyntax literalArg } => literalArg,
            LiteralExpressionSyntax literalConversion => literalConversion,
            _ => null,
        };
        if (literal == null)
            return;

        // Register a code action that will invoke the fix.
        context.RegisterCodeFix(
            CodeAction.Create(
                title: Suggestion,
                createChangedSolution: c => FixAsync(context.Document, literal, c),
                equivalenceKey: nameof(DiagnosticId)
            ),
            diagnostic
        );
    }

    private static async Task<Solution> FixAsync(
        Document document,
        LiteralExpressionSyntax stringLiteral,
        CancellationToken cancellationToken
    )
    {
        var root = await document.GetSyntaxRootAsync(cancellationToken);
        if (root == null)
            return document.Project.Solution;

        // change from "literal" to "literal"u8
        var token = stringLiteral.Token;
        var u8Token = SyntaxFactoryExtensions.Utf8Literal(token.Text + "u8", token.ValueText);
        var u8Literal = SyntaxFactory.LiteralExpression(SyntaxKind.Utf8StringLiteralExpression, u8Token);
        var newRoot = root.ReplaceNode(stringLiteral, u8Literal);
        var newDocument = document.WithSyntaxRoot(newRoot);
        return newDocument.Project.Solution;
    }
}
