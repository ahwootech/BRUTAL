using System.Collections.Immutable;
using Microsoft.CodeAnalysis;

public static class Utility
{
    public static bool SequenceEqual<TSymbol>(
        ImmutableArray<TSymbol> a,
        ImmutableArray<TSymbol> b,
        SymbolEqualityComparer comparer
    )
        where TSymbol : class, ISymbol
    {
        var aUp = ImmutableArray<ISymbol>.CastUp(a);
        var bUp = ImmutableArray<ISymbol>.CastUp(b);
        return aUp.SequenceEqual(bUp, comparer);
    }
}
