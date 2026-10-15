using System.Collections.Immutable;
using System.Composition;
using Brutal.Core.Analyzers;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CodeActions;
using Microsoft.CodeAnalysis.CodeFixes;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Brutal.Core.Analyzers;

[ExportCodeFixProvider(LanguageNames.CSharp, Name = nameof(OperatingSystemFixProvider)), Shared]
public class OperatingSystemFixProvider : CodeFixProvider
{
    // Specify the diagnostic IDs of analyzers that are expected to be linked.
    public sealed override ImmutableArray<string> FixableDiagnosticIds { get; } = [Resources.BrutalCore0003.Id];

    // If you don't need the 'fix all' behaviour, return null.
    public override FixAllProvider? GetFixAllProvider() => null;

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

        // To get the required metadata, we should match the Node to the specific type: 'ClassDeclarationSyntax'.
        if (diagnosticNode is not InvocationExpressionSyntax declaration)
            return;

        // Register a code action that will invoke the fix.
        context.RegisterCodeFix(
            CodeAction.Create(
                title: Resources.BrutalCore0003Suggestion,
                createChangedSolution: c => FixToBrutalPlatformAsync(context.Document, declaration, c),
                equivalenceKey: nameof(Resources.BrutalCore0003.Id)
            ),
            diagnostic
        );
    }

    private static async Task<Solution> FixToBrutalPlatformAsync(
        Document document,
        InvocationExpressionSyntax invocationExpression,
        CancellationToken cancellationToken
    )
    {
        // Change from OperatingSystem.XYZ() to Platform.XYZ
        // Platform.XYZ is a property, not a method, so we just change the expression part.
        var memberAccess = invocationExpression.Expression as MemberAccessExpressionSyntax;
        if (memberAccess == null)
            return document.Project.Solution;

        var root = await document.GetSyntaxRootAsync(cancellationToken);
        if (root == null)
            return document.Project.Solution;

        var newMemberAccess = SyntaxFactory.MemberAccessExpression(
            SyntaxKind.SimpleMemberAccessExpression,
            SyntaxFactory.IdentifierName("Platform"),
            memberAccess.Name
        );

        var newRoot = root.ReplaceNode(invocationExpression, newMemberAccess);
        var newDocument = document.WithSyntaxRoot(newRoot);
        return newDocument.Project.Solution;
    }
}
