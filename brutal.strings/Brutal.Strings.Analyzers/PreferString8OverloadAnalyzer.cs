using System.Collections.Immutable;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Diagnostics;
using Microsoft.CodeAnalysis.Operations;

namespace Brutal.Strings.Analyzers;

[DiagnosticAnalyzer(LanguageNames.CSharp)]
public class PreferString8OverloadAnalyzer : DiagnosticAnalyzer
{
    public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics { get; } =
    [Resources.PreferU8OverloadBrutalCore0011];

    public override void Initialize(AnalysisContext context)
    {
        context.EnableConcurrentExecution();
        context.ConfigureGeneratedCodeAnalysis(GeneratedCodeAnalysisFlags.None);

        context.RegisterCompilationStartAction(startContext =>
        {
            // Early-exit if ReadOnlySpan<T> is unavailable (e.g. netstandard2.0 without System.Memory)
            var readOnlySpan = startContext.Compilation.GetTypeByMetadataName("System.ReadOnlySpan`1");
            if (readOnlySpan is null)
                return;

            var analyzer = new PreferString8OverloadCompilationAnalyzer(startContext.Compilation, readOnlySpan);
            startContext.RegisterOperationAction(analyzer.Analyze, OperationKind.Argument, OperationKind.Conversion);
        });
    }
}

/*
 * Follow the guidelines frmo RS1008 (https://dotnetrules.com):
 *  Avoid storing per-compilation data into the fields of a diagnostic analyzer
 *    Instance of a diagnostic analyzer might outlive the lifetime of compilation.
 *    Hence, storing per-compilation data, such as symbols, into the fields of a diagnostic analyzer might cause stale compilations to stay alive and cause memory leaks.
 *    Instead, you should store this data on a separate type instantiated in a compilation start action, registered using 'AnalysisContext.RegisterCompilationStartAction' API.
 *    An instance of this type will be created per-compilation and it won't outlive compilation's lifetime, hence avoiding memory leaks.
 */
class PreferString8OverloadCompilationAnalyzer(Compilation compilation, INamedTypeSymbol readOnlySpan)
{
    private readonly INamedTypeSymbol _readOnlySpanByte = readOnlySpan.Construct(
        compilation.GetSpecialType(SpecialType.System_Byte)
    );

    private bool IsString8(ITypeSymbol type) => compilation.HasImplicitConversion(_readOnlySpanByte, type);

    private static bool IsString16(ITypeSymbol type) => type.SpecialType == SpecialType.System_String;

    /// Is method <paramref name="overload"/> a compatible replacement for <paramref name="method"/>?
    private bool IsCompatible(OperationAnalysisContext context, IMethodSymbol method, IMethodSymbol overload)
    {
        /*
         * We want to err on the side of caution: only suggest using an overload if it is _strictly_ identical:
         * - same kind/generic-ness etc.
         *   - same type parameters (same constraints etc.)
         * - same parameters (except for string/String8 of course)
         *
         * We won't suggest overloads with (type) parameters that _could_ be compatible through conversion, type constraints etc.
         */

        if (method.MethodKind != overload.MethodKind)
            return false;

        var isGeneric = method.IsGenericMethod;
        if (isGeneric != overload.IsGenericMethod)
            return false;

        // ignore self
        if (SymbolEqualityComparer.IncludeNullability.Equals(isGeneric ? method.OriginalDefinition : method, overload))
            return false;

        // is the overload accessible from the call site?
        if (!compilation.IsSymbolAccessibleWithin(overload, context.ContainingSymbol.ContainingType))
            return false;

        if (isGeneric)
        {
            // compare type parameters
            if (!method.TypeParameters.SequenceEqual(overload.TypeParameters, IsCompatible))
                return false;
        }

        // compare parameters
        if (!method.Parameters.SequenceEqual(overload.Parameters, (a, b) => IsCompatible(a.Type, b.Type)))
            return false;

        return true;
    }

    /// Is type <paramref name="overloadParamType"/> a compatible replacement for <paramref name="methodParamType"/>?
    private bool IsCompatible(ITypeSymbol methodParamType, ITypeSymbol overloadParamType)
    {
        if (SymbolEqualityComparer.IncludeNullability.Equals(methodParamType, overloadParamType))
            return true;

        if (IsString16(methodParamType) && IsString8(overloadParamType))
            return true;

        return false;
    }

    /// Are type parameters a and b compatible?
    private static bool IsCompatible(ITypeParameterSymbol a, ITypeParameterSymbol b)
    {
        return a.AllowsRefLikeType == b.AllowsRefLikeType
            && a.HasConstructorConstraint == b.HasConstructorConstraint
            && a.HasNotNullConstraint == b.HasNotNullConstraint
            && a.HasReferenceTypeConstraint == b.HasReferenceTypeConstraint
            && a.HasUnmanagedTypeConstraint == b.HasUnmanagedTypeConstraint
            && a.HasValueTypeConstraint == b.HasValueTypeConstraint
            && a.Variance == b.Variance
            && Utility.SequenceEqual(a.ConstraintTypes, b.ConstraintTypes, SymbolEqualityComparer.IncludeNullability);
    }

    public void Analyze(OperationAnalysisContext context)
    {
        switch (context.Operation)
        {
            case IArgumentOperation argumentOp:
            {
                var parameter = argumentOp.Parameter;
                if (parameter == null)
                    break;

                // is the current argument a string literal?
                if (!IsString16(parameter.Type) || argumentOp.Value.Syntax is not LiteralExpressionSyntax)
                    break;

                if (argumentOp.Parent is not IInvocationOperation parent)
                    break;

                // does the method have an overload that takes a UTF8 string instead?
                var method = parent.TargetMethod;
                var overloads = method.ContainingType.GetMembers(method.Name).OfType<IMethodSymbol>();
                var overload = overloads.FirstOrDefault(o => IsCompatible(context, method, o));

                if (overload == null)
                    break;

                // suggest using a UTF8 literal instead of a string
                var message = overload.ToDisplayString(SymbolDisplayFormat.MinimallyQualifiedFormat);
                ReportDiagnostic(message);
                break;
            }

            case IConversionOperation conversionOp:
            {
                if (conversionOp.OperatorMethod == null)
                    break;

                // are we converting from a string literal?
                if (conversionOp.Operand is not ILiteralOperation { Type.SpecialType: SpecialType.System_String })
                    break;

                // is the target type assignable from UTF8?
                var targetType = conversionOp.Type;
                if (targetType == null || !IsString8(targetType))
                    break;

                // find the actual conversion method - only for displaying to the user / debugging
                var conversions = targetType
                    .GetMembers()
                    .OfType<IMethodSymbol>()
                    .Where(m => m.MethodKind == MethodKind.Conversion);
                var overload = conversions.FirstOrDefault(m => IsString8(m.Parameters[0].Type));
                var message =
                    overload?.ToDisplayString(SymbolDisplayFormat.MinimallyQualifiedFormat)
                    ?? $"{targetType.ToDisplayString(SymbolDisplayFormat.MinimallyQualifiedFormat)} implicit conversion from UTF8";

                // suggest using a UTF8 literal instead of a string
                ReportDiagnostic(message);
                break;
            }
        }

        void ReportDiagnostic(string message)
        {
            var diagnostic = Diagnostic.Create(
                Resources.PreferU8OverloadBrutalCore0011,
                context.Operation.Syntax.GetLocation(),
                message
            );
            context.ReportDiagnostic(diagnostic);
        }
    }
}
