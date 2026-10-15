using System.Buffers;
using System.Buffers.Text;

namespace Brutal.Strings;

public static class Utf16Formatter
{
    /// <inheritdoc cref="Utf8Formatter.TryFormat(bool,System.Span{byte},out int,System.Buffers.StandardFormat)" />
    public static bool TryFormat(
        bool value,
        Span<Char16> destination,
        out int charsWritten,
        StandardFormat format = default
    )
    {
        var symbol = GetSymbolOrDefault(format, 'G');

        if (value)
        {
            if (symbol == 'G')
            {
                if (!"True".TryCopyTo(destination))
                {
                    goto BufferTooSmall;
                }
            }
            else if (symbol == 'l')
            {
                if (!"true".TryCopyTo(destination))
                {
                    goto BufferTooSmall;
                }
            }
            else
            {
                goto BadFormat;
            }

            charsWritten = 4;
            return true;
        }
        else
        {
            if (symbol == 'G')
            {
                if (!"False".TryCopyTo(destination))
                {
                    goto BufferTooSmall;
                }
            }
            else if (symbol == 'l')
            {
                if (!"false".TryCopyTo(destination))
                {
                    goto BufferTooSmall;
                }
            }
            else
            {
                goto BadFormat;
            }

            charsWritten = 5;
            return true;
        }

        BadFormat:
        throw new FormatException("BadFormatSpecifier");

        BufferTooSmall:
        charsWritten = 0;
        return false;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    static char GetSymbolOrDefault(in StandardFormat format, char defaultSymbol)
    {
        // This is equivalent to the line below, but it is written in such a way
        // that the JIT is able to perform more optimizations.
        //
        // return (format.IsDefault) ? defaultSymbol : format.Symbol;

        var symbol = format.Symbol;
        if (symbol == default && format.Precision == default)
        {
            symbol = defaultSymbol;
        }

        return symbol;
    }
}
