namespace Brutal.ImGuiApi;

/// A UTF8 mutable string, for ImGui InputText() etc.
/// Heap-allocated.
public class ImInputString : IUtf8SpanFormattable, ISpanFormattable
{
    public readonly byte[] Buffer;
    public int Capacity => Buffer.Length;
    public int Length;

    public ImInputString(int capacity, ReadOnlySpan<byte> initialContent = default)
    {
        if (capacity < 1)
            throw new ArgumentOutOfRangeException(
                nameof(capacity),
                "Capacity must be at least 1 to accommodate null-terminator."
            );
        Buffer = new byte[capacity];
        SetValue(initialContent);
    }

    public ImInputString(int capacity, ImString initialContent)
        : this(capacity, initialContent.AsSpan()) { }

    public void SetValue(ReadOnlySpan<byte> content)
    {
        Length = Utf8.EvaluateLength(content);
        ValidateLength();
        if (Length > 0)
            content[..Length].CopyTo(Buffer);
        NullTerminate();
    }

    public void SetValue(ReadOnlySpan<char> content)
    {
        Utf8.FromUtf16(content, Buffer, out _, out Length);
        ValidateLength();
        NullTerminate();
    }

    public void Clear()
    {
        Length = 0;
        NullTerminate();
    }

    /// <inheritdoc cref="Utf8.EvaluateLength(ReadOnlySpan{byte})"/>
    public void EvaluateLength()
    {
        Length = Utf8.EvaluateLength(Buffer);
        ValidateLength();
    }

    private void ValidateLength()
    {
        if (Length >= Capacity)
            throw new Exception("Length must be less than Capacity to accommodate null-terminator.");
    }

    private void NullTerminate()
    {
        Buffer[Length] = 0;
    }

    public bool IsEmpty => Length == 0;

    /// for PInvoke
    public ref readonly byte GetPinnableReference() => ref MemoryMarshal.GetArrayDataReference(Buffer);

    public ReadOnlySpan<byte> ValueSpan => Buffer.AsSpan()[..Length];

    //public static implicit operator ReadOnlySpan<byte>(ImInputString input) => input.ValueSpan;
    public ImString Value => ValueSpan;
    public ReadOnlySpan<byte> Value8
    {
        set => SetValue(value);
    }
    public ReadOnlySpan<char> Value16
    {
        set => SetValue(value);
    }

    public static implicit operator ImString(ImInputString input) => input.ValueSpan;

    #region IUtf8SpanFormattable, ISpanFormattable, IFormattable

    /// IUtf8SpanFormattable implementation
    public bool TryFormat(
        Span<byte> utf8Destination,
        out int bytesWritten,
        ReadOnlySpan<char> format,
        IFormatProvider? provider
    ) => Value.TryFormat(utf8Destination, out bytesWritten, format, provider);

    /// ISpanFormattable implementation
    public bool TryFormat(
        Span<char> utf16Destination,
        out int charsWritten,
        ReadOnlySpan<char> format,
        IFormatProvider? provider
    ) => Value.TryFormat(utf16Destination, out charsWritten, format, provider);

    /// IFormattable implementation - useless but required for ISpanFormattable
    string IFormattable.ToString(string? format, IFormatProvider? formatProvider) => Value.ToString();

    public override string ToString() => Value.ToString();

    #endregion
}

public static class ImInputStringExtensions
{
    public static bool IsNullOrEmpty(this ImInputString? @this) => @this == null || @this.Length == 0;
}
