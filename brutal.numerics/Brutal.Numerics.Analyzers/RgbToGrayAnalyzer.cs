using System.Collections.Immutable;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Diagnostics;
using Microsoft.CodeAnalysis.Operations;

namespace Brutal.Numerics.Analyzers;

/// <summary>
/// Analyzer that flags usage of Brutal color types such as `float3.Rgb(...)` and suggests replacing it with
/// `float3.Grayscale()`.
/// </summary>
[DiagnosticAnalyzer(LanguageNames.CSharp)]
public class RgbToGrayAnalyzer : DiagnosticAnalyzer
{
    // Keep in mind: you have to list your rules here.
    public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics { get; } =
        ImmutableArray.Create(Resources.RgbToGreyBrutalCore0006);

    public override void Initialize(AnalysisContext context)
    {
        // You must call this method to avoid analyzing generated code.
        context.ConfigureGeneratedCodeAnalysis(GeneratedCodeAnalysisFlags.None);

        // You must call this method to enable the Concurrent Execution.
        context.EnableConcurrentExecution();

        // Only interested in invocation operations, like `float3.Rgb(...)`
        context.RegisterOperationAction(AnalyzeInvocation, OperationKind.Invocation);

        // Check other 'context.Register...' methods that might be helpful for your purposes.
    }

    /// <summary>
    /// Called for each invocation expression in the code.
    /// </summary>
    /// <param name="context">Operation context.</param>
    private void AnalyzeInvocation(OperationAnalysisContext context)
    {
        if (context.Operation is not IInvocationOperation invocation)
            return;

        var methodSymbol = invocation.TargetMethod;

        // Must be in Brutal namespace
        if (methodSymbol.ContainingNamespace.ToDisplayString() != "Brutal.Numerics")
            return;

        // Color type must match allowed set
        var typeName = methodSymbol.ContainingType.Name;
        switch (typeName)
        {
            case "float3":
            case "float4":
            case "byte3":
            case "byte4":
            case "ushort3":
            case "ushort4":
                break;
            default:
                return;
        }

        // Only check methods named Rgb or Rgba
        var methodName = methodSymbol.Name;
        if (methodName != "Rgb" && methodName != "Rgba")
            return;

        // Check argument count and argument equality
        var args = invocation.Arguments;
        if (methodName == "Rgb")
        {
            if (args.Length != 3)
                return;
            if (!ArgsAreEqual(args[0], args[1], args[2]))
                return;
        }
        else if (methodName == "Rgba")
        {
            if (args.Length != 4)
                return;
            if (!ArgsAreEqual(args[0], args[1], args[2]))
                return;

            var alphaLiteral = args[3].Syntax.ToString();

            switch (typeName)
            {
                case "float4":
                    if (alphaLiteral != "1")
                        return;
                    break;
                case "byte4":
                    if (alphaLiteral != "0xFF")
                        return;
                    break;
                case "ushort4":
                    if (alphaLiteral != "0xFFFF")
                        return;
                    break;
                default:
                    return;
            }
        }
        else
            return;

        var location = invocation.Syntax.GetLocation();

        if (invocation.Syntax is InvocationExpressionSyntax invocationExpression)
        {
            ExpressionSyntax expr = invocationExpression;

            // Get location of method name
            var methodNameToken = expr switch
            {
                IdentifierNameSyntax id => id.Identifier, // Simple method call like Foo()
                MemberAccessExpressionSyntax memberAccess => memberAccess.Name.Identifier, // Call like obj.Method()
                // Handle cases like Console.WriteLine(...)
                InvocationExpressionSyntax nestedInvocation => nestedInvocation.Expression switch
                {
                    MemberAccessExpressionSyntax nestedMemberAccess => nestedMemberAccess.Name.Identifier, // Nested like Console.WriteLine(...)
                    IdentifierNameSyntax nestedId => nestedId.Identifier, // Nested like Foo.Bar()
                    _ => default,
                },
                _ => default,
            };

            location = methodNameToken.GetLocation();
        }

        // Emit a diagnostic at the location of the entire invocation
        context.ReportDiagnostic(Diagnostic.Create(Resources.RgbToGreyBrutalCore0006, location));
    }

    private static bool ArgsAreEqual(IArgumentOperation a, IArgumentOperation b, IArgumentOperation c)
    {
        var t0 = a.Syntax.ToString();
        var t1 = b.Syntax.ToString();
        var t2 = c.Syntax.ToString();
        return t0 == t1 && t0 == t2;
    }
}
