using System.Collections.Immutable;
using System.Composition;
using Brutal.Numerics.Analyzers;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CodeActions;
using Microsoft.CodeAnalysis.CodeFixes;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Document = Microsoft.CodeAnalysis.Document;

namespace Brutal.Numerics.Analyzers;

/// <summary>
/// A code fix provider that replaces calls to float3.Rgb(...) with float3.Grayscale().
/// All code fixes must be linked to specific analyzers.
/// </summary>
[ExportCodeFixProvider(LanguageNames.CSharp, Name = nameof(RgbToGrayFixProvider)), Shared]
public class RgbToGrayFixProvider : CodeFixProvider
{
    public sealed override ImmutableArray<string> FixableDiagnosticIds { get; } =
    [Resources.RgbToGreyBrutalCore0006.Id];

    // If you don't need the 'fix all' behavior, return null.
    public override FixAllProvider? GetFixAllProvider() => null;

    public sealed override async Task RegisterCodeFixesAsync(CodeFixContext context)
    {
        // We link only one diagnostic and assume there is only one diagnostic in the context.
        if (context.Diagnostics.Length != 1)
        {
            return;
        }

        var diagnostic = context.Diagnostics[0];
        var diagnosticSpan = diagnostic.Location.SourceSpan;
        var root = await context.Document.GetSyntaxRootAsync(context.CancellationToken).ConfigureAwait(false);
        var diagnosticNode = root?.FindNode(diagnosticSpan);

        var invocation = diagnosticNode?.FirstAncestorOrSelf<InvocationExpressionSyntax>();
        if (invocation is null)
            return;

        context.RegisterCodeFix(
            CodeAction.Create(
                title: string.Format(Resources.RgbToGreyBrutalCore0006.Id),
                createChangedDocument: c => ReplaceWithGrayscaleAsync(context.Document, invocation, c),
                equivalenceKey: nameof(Resources.RgbToGreyBrutalCore0006.Id)
            ),
            diagnostic
        );
    }

    /// <summary>
    /// Executed on the quick fix action raised by the user.
    /// </summary>
    /// <param name="document">Affected source file.</param>
    /// <param name="invocation">The original method invocation node.</param>
    /// <param name="cancellationToken">Any fix is cancellable by the user, so we should support the cancellation token.</param>
    /// <returns>A modified version of the solution with the method call replaced.</returns>
    private async Task<Document> ReplaceWithGrayscaleAsync(
        Document document,
        InvocationExpressionSyntax invocation,
        CancellationToken cancellationToken
    )
    {
        if (invocation.Expression is not MemberAccessExpressionSyntax memberAccess)
            return document;

        var method = await TryGetReplaceableMethod(memberAccess, document, cancellationToken);
        if (
            method == null
            || !IsMethodOfReplaceableType(method, out var typeName)
            || !IsMethodParametersReplaceableByGrayscale(invocation, method.Name, typeName, out var replacementArgExpr)
        )
            return document;

        var newInvocation = CreateFunctionCallToGrayscale(invocation, memberAccess, replacementArgExpr!);
        var newRoot = await ReplaceNode(document, invocation, cancellationToken, newInvocation);

        return document.WithSyntaxRoot(newRoot);
    }

    private static bool IsMethodOfReplaceableType(IMethodSymbol methodSymbol, out string typeName)
    {
        typeName = methodSymbol.ContainingType.Name;
        switch (typeName)
        {
            case "float3" or "float4" or "byte3" or "byte4" or "ushort3" or "ushort4":
                var methodName = methodSymbol.Name;
                return methodName is "Rgb" or "Rgba";
            default:
                return false;
        }
    }

    private static async Task<IMethodSymbol?> TryGetReplaceableMethod(
        MemberAccessExpressionSyntax memberAccess,
        Document document,
        CancellationToken cancellationToken
    )
    {
        var semanticModel = await document.GetSemanticModelAsync(cancellationToken).ConfigureAwait(false);
        var symbolInfo = semanticModel.GetSymbolInfo(memberAccess, cancellationToken);
        if (
            symbolInfo.Symbol is not IMethodSymbol methodSymbol
            || methodSymbol.ContainingNamespace.ToDisplayString() != "Brutal.Numerics"
        )
            return null;

        return methodSymbol;
    }

    private static bool IsMethodParametersReplaceableByGrayscale(
        InvocationExpressionSyntax invocation,
        string methodName,
        string typeName,
        out ExpressionSyntax? replacementArgExpr
    )
    {
        var args = invocation.ArgumentList.Arguments;

        switch (methodName)
        {
            case "Rgb" when args.Count != 3 || !ArgsAreEqual(args[0], args[1], args[2]):
                replacementArgExpr = null;
                return false;
            case "Rgb":
                replacementArgExpr = args[0].Expression;
                break;
            case "Rgba" when args.Count != 4 || !ArgsAreEqual(args[0], args[1], args[2]):
                replacementArgExpr = null;
                return false;
            case "Rgba":
            {
                var alphaLiteral = args[3].Expression.ToString();

                switch (typeName)
                {
                    case "float4":
                        if (alphaLiteral != "1")
                        {
                            replacementArgExpr = null;
                            return false;
                        }

                        break;
                    case "byte4":
                        if (alphaLiteral != "0xFF")
                        {
                            replacementArgExpr = null;
                            return false;
                        }

                        break;
                    case "ushort4":
                        if (alphaLiteral != "0xFFFF")
                        {
                            replacementArgExpr = null;
                            return false;
                        }

                        break;
                    default:
                        replacementArgExpr = null;
                        return false;
                }

                replacementArgExpr = args[0].Expression;
                break;
            }
            default:
                replacementArgExpr = null;
                return false;
        }

        return true;
    }

    private static InvocationExpressionSyntax CreateFunctionCallToGrayscale(
        InvocationExpressionSyntax invocation,
        MemberAccessExpressionSyntax memberAccess,
        ExpressionSyntax replacementArgExpr
    )
    {
        var newMemberAccess = memberAccess.WithName(SyntaxFactory.IdentifierName("Grayscale"));
        var newInvocation = invocation
            .WithExpression(newMemberAccess)
            .WithArgumentList(
                SyntaxFactory.ArgumentList(
                    SyntaxFactory.SingletonSeparatedList(SyntaxFactory.Argument(replacementArgExpr))
                )
            );
        return newInvocation;
    }

    private static async Task<SyntaxNode> ReplaceNode(
        Document document,
        InvocationExpressionSyntax invocation,
        CancellationToken cancellationToken,
        InvocationExpressionSyntax newInvocation
    )
    {
        var root = await document.GetSyntaxRootAsync(cancellationToken).ConfigureAwait(false);
        var newRoot = root!.ReplaceNode(invocation, newInvocation);
        return newRoot;
    }

    private static bool ArgsAreEqual(ArgumentSyntax a, ArgumentSyntax b, ArgumentSyntax c)
    {
        var t0 = a.ToString();
        var t1 = b.ToString();
        var t2 = c.ToString();
        return t0 == t1 && t0 == t2;
    }
}
