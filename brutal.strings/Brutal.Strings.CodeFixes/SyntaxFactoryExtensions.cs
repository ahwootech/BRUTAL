using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

namespace Brutal.Strings.Analyzers;

using static SyntaxFactory;

// TODO: move this to a shared package...
public static class SyntaxFactoryExtensions
{
    /// <inheritdoc cref="Utf8Literal(string,string)" />
    public static SyntaxToken Utf8Literal(string value)
    {
        return Utf8Literal(SymbolDisplay.FormatLiteral(value, quote: true) + "u8", value);
    }

    /// <summary>
    /// Creates a token with kind Utf8StringLiteralToken from the text and corresponding string value.
    /// </summary>
    /// <param name="text">The raw text of the literal, including quotes and escape sequences.</param>
    /// <param name="value">The string value to be represented by the returned token.</param>
    public static SyntaxToken Utf8Literal(string text, string value)
    {
        return Token(SyntaxTriviaList.Empty, SyntaxKind.Utf8StringLiteralToken, text, value, SyntaxTriviaList.Empty);
    }
}
