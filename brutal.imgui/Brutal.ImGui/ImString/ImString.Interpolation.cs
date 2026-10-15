using System.ComponentModel;

namespace Brutal.ImGuiApi;

[InterpolatedStringHandler]
public ref partial struct ImString
{
    /*
     * Interpolation handler for ImString. Each piece is appended to the shared arena builder,
     * which centralizes formatting, grapheme-aware alignment, and nested-interpolation write-through;
     * then `_bytes` is extended to span the chunk built so far.
     * The arena maintains a null terminator just past each chunk for native interop.
     */

    /// InterpolatedStringHandler constructor; not intended for general use.
    [EditorBrowsable(EditorBrowsableState.Never)]
    public ImString(int literalLength, int formattedCount)
    {
        if (literalLength + formattedCount == 0)
        {
            // special case for empty interpolation: $""
            this = Empty;
            return;
        }

        _bytes = SharedStorage.Begin(); // empty span anchored at the chunk start; grown by each Append below
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void AppendLiteral(scoped ReadOnlySpan<char> value)
    {
        SharedStorage.Append(ref _bytes, value);
    }

    #region AppendFormatted() for string types (UTF16 and UTF8)

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void AppendFormatted(String8 value, int alignment = 0, string? format = null) // no custom format, but we still declare the overload for compatibility
    {
        SharedStorage.Append(ref _bytes, value.AsSpan(), alignment);
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void AppendFormatted(String16 value, int alignment = 0, string? format = null) // no custom format, but we still declare the overload for compatibility
    {
        SharedStorage.Append(ref _bytes, value.AsSpan(), alignment);
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void AppendFormatted(scoped ReadOnlySpan<char> value, int alignment = 0, string? format = null) // no custom format, but we still declare the overload for compatibility
    {
        SharedStorage.Append(ref _bytes, value, alignment);
    }

    /// This assumes that value is a UTF8 string, rather than actual binary bytes...
    /// TODO: we could use a format string to disambiguate? Also see Utf8.IsValid(value)
    [EditorBrowsable(EditorBrowsableState.Never)]
    [OverloadResolutionPriority(1)] // disambiguates holes convertible to both ROS<byte> and ImString; both fold via Absorb
    public void AppendFormatted(scoped ReadOnlySpan<byte> value, int alignment = 0, string? format = null) // no custom format, but we still declare the overload for compatibility
    {
        SharedStorage.Absorb(ref _bytes, value, alignment);
    }

    #endregion

    /// Kitchen-sink formatting through <see cref="Utf8.TryFormat{T}"/> / <see cref="StringBuilder{TChar}.Append{T}"/>.
    [EditorBrowsable(EditorBrowsableState.Never)]
    public void AppendFormatted<T>(T value, int alignment = 0, string? format = null)
    {
        SharedStorage.Append(ref _bytes, value, alignment, format);
    }

    #region nested interpolation

    /// Nested interpolation ctor for <see cref="AppendFormatted(ImString, int, String16?)"/>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public ImString(int literalLength, int formattedCount, ImString parent)
    {
        _bytes = parent._bytes[^0..]; // continue the parent's chunk
    }

    /// Folds an ImString hole - a nested $"..." written through our chunk, or any other value - into this chunk.
    [EditorBrowsable(EditorBrowsableState.Never)]
    public void AppendFormatted(
        [InterpolatedStringHandlerArgument("")] scoped ImString value,
        int alignment = 0,
        string? format = null
    )
    {
        SharedStorage.Absorb(ref _bytes, value._bytes, alignment);
    }

    #endregion
}
