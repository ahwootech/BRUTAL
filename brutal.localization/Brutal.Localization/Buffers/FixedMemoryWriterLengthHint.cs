namespace Brutal.Localization.FixedBuffers;

public static class LengthHint
{
    /// <summary>
    /// Pass this to <see cref="IFixedBufferWriter&lt;T&gt;.GetSpan" /> or <see cref="IFixedBufferWriter&lt;T&gt;.TryGetSpan" />
    /// to request the largest available span size the writer can return.
    /// </summary>
    public static readonly ElementCount MaxLengthHint = int.MinValue + 1;

    /// <summary>
    /// Pass this to <see cref="IFixedBufferWriter&lt;T&gt;.GetSpan" /> or <see cref="IFixedBufferWriter&lt;T&gt;.TryGetSpan" />
    /// to request any span size greater than or equal to one.
    /// </summary>
    public static readonly ElementCount NonZeroLengthHint = int.MinValue;
}
