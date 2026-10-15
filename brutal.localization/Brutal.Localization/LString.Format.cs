using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Brutal.Localization;

public partial class LString
{
    /// <summary>
    /// Takes a single argument and formats it into the buffer of a DefaultInterpolatedStringHandler
    /// </summary>
    /// <param name="arg">The object to format.</param>
    /// <param name="replaceableIndex">The index of the replaceable the argument is for.</param>
    /// <param name="h">The interpolated string handler to use for formatting.</param>
    /// <typeparam name="T">The type of arg.</typeparam>
    /// <exception cref="InvalidOperationException">Thrown if the replacement type of the argument is not handled.</exception>
    private bool TryFormatReplacement<T>(
        T arg,
        int replaceableIndex,
        ref MemoryExtensions.TryWriteInterpolatedStringHandler h
    )
    {
        var localizedSpan = _localizedString.AsSpan();
        var replacementsSpan = CollectionsMarshal.AsSpan(_replacements);
        ref var replacement = ref replacementsSpan[replaceableIndex];

        var success = true;
        if (replacement.HasPrecedingLiteral)
            success &= h.AppendFormatted(
                localizedSpan[
                    replacement.LiteralRange.Start.Value..replacement.LiteralRange.End.Value
                ]
            );

        return success & h.AppendFormatted(arg);
    }

    /// <summary>
    /// Takes a single argument and formats it into the buffer of a DefaultInterpolatedStringHandler
    /// </summary>
    /// <param name="arg">The object to format.</param>
    /// <param name="replaceableIndex">The index of the replaceable the argument is for.</param>
    /// <param name="h">The interpolated string handler to use for formatting.</param>
    /// <typeparam name="T">The type of arg.</typeparam>
    /// <exception cref="InvalidOperationException">Thrown if the replacement type of the argument is not handled.</exception>
    private void FormatReplacement<T>(
        in T arg,
        int replaceableIndex,
        ref DefaultInterpolatedStringHandler h
    )
    {
        var localizedSpan = _localizedString.AsSpan();
        var replacementsSpan = CollectionsMarshal.AsSpan(_replacements);
        ref var replacement = ref replacementsSpan[replaceableIndex];

        if (replacement.HasPrecedingLiteral)
            h.AppendFormatted(
                localizedSpan[
                    replacement.LiteralRange.Start.Value..replacement.LiteralRange.End.Value
                ]
            );

        h.AppendFormatted(arg);
    }

    private void ValidateReplacementCount(int numberOfPassedArguments)
    {
        if (_replacements.Count != numberOfPassedArguments)
            throw new ArgumentException(
                $"Incorrect number of replacement values passed to LString {Id}. expected:{_replacements.Count} passed:{numberOfPassedArguments}"
            );
    }
}
