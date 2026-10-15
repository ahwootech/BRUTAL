namespace Brutal.Localization;

/// <summary>
/// Global options used by LString.
/// </summary>
public static class LStringGlobalOptions
{
    /// <summary>
    /// The initial span length that any of the <see cref="LString.Format{TWriter}(TWriter)" /> methods will request from the <see cref="FixedBuffers.IFixedBufferWriter&lt;T&gt;" />.
    /// For more information on how this value is used see <see cref="LString.Format{TWriter}(TWriter)" />.
    /// </summary>
    ///
    public static ElementCount FormatInitialSpanLength { get; set; } =
        DefaultOptions.FormatInitialSpanLength;
}
