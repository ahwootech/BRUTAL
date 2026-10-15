using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;

namespace Brutal.Interop.SourceGenerators;

[Generator]
public class InteropHandleGenerator : IIncrementalGenerator
{
    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        var pipeline = context.SyntaxProvider.ForAttributeWithMetadataName(
            fullyQualifiedMetadataName: "Brutal.Interop.InteropHandleAttribute",
            predicate: static (node, _) => node is StructDeclarationSyntax,
            transform: static (ctx, _) => new Model(ctx)
        );

        context.RegisterSourceOutput(pipeline, static (ctx, model) => model.Generate(ctx));
    }

    private readonly record struct Model
    {
        private readonly string? _namespace;
        private readonly string _typeName;

        public Model(GeneratorAttributeSyntaxContext context)
        {
            var symbol = (INamedTypeSymbol)context.TargetSymbol;
            _namespace = symbol.ContainingNamespace is { IsGlobalNamespace: false } ns
                ? ns.ToDisplayString()
                : null;
            _typeName = symbol.Name;
        }

        public void Generate(SourceProductionContext context)
        {
            var nsDecl = _namespace is not null ? $"namespace {_namespace};\n\n" : "";

            var source = $$"""
                #nullable enable
                using System.Runtime.InteropServices.Marshalling;
                using Brutal.Interop;

                {{nsDecl}}[NativeMarshalling(typeof(InteropHandleMarshaller<{{_typeName}}, {{_typeName}}.Handle>))]
                public readonly unsafe partial struct {{_typeName}} : IInteropHandle<{{_typeName}}.Handle, {{_typeName}}>
                {
                    public record struct Handle(nint Value);
                    public required Handle Pointer { get; init; }
                    public bool IsNull() => Pointer.Value == 0;
                    public static implicit operator {{_typeName}}(void* ptr) => new() { Pointer = new Handle((nint)ptr) };
                }
                """;

            context.AddSource($"{_typeName}.g.cs", SourceText.From(source, Encoding.UTF8));
        }
    }
}
