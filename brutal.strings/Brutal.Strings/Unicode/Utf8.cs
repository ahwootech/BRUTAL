using System.Buffers;
using System.Diagnostics.Contracts;
using System.Text;
using Brutal.Collections.Experimental;
using SystemUtf8 = System.Text.Unicode.Utf8;

namespace Brutal.Strings;

/// <summary>
/// Combination of <see cref="System.Text.Unicode.Utf8"/> and <see cref="System.Text.Encoding.UTF8"/> for common UTF-8 operations.
/// </summary>
public static partial class Utf8
{
    /// <summary>
    /// Count the number of bytes in a null-terminated byte array.
    /// </summary>
    [Pure]
    public static unsafe int GetByteCount(Ptr<Char8> bytes)
    {
        return MemoryMarshal.CreateReadOnlySpanFromNullTerminated(bytes).Length;
    }

    /// <summary>
    /// Convert a null-terminated byte array to a <see cref="Span{T}"/> containing the bytes up to the null terminator.
    /// </summary>
    [Pure]
    public static unsafe String8View GetNullTerminatedSpan(Ptr<Char8> bytes)
    {
        return MemoryMarshal.CreateReadOnlySpanFromNullTerminated(bytes);
    }

    /// Evaluate length from the null-terminator, if found - strlen() equivalent.
    [Pure]
    public static int EvaluateLength(String8View utf8Buffer)
    {
        var length = utf8Buffer.IndexOf((Char8)0);
        return length != -1 ? length : utf8Buffer.Length;
    }

    /// <inheritdoc cref="Encoding.GetChars(String8View, Span{Char16})"/>
    /// <remarks>Usage:<code>
    /// using (Utf8.GetChars(value, stackalloc Char16[256], out var chars))
    /// {
    ///     // ... use "chars" here
    /// }
    /// </code></remarks>
    /// <param name="value">The value to decode</param>
    /// <param name="stackBuffer">A temporary buffer, typically stack-allocated; if too small, will rent an array.</param>
    /// <param name="chars">The decoded UTF16 characters</param>
    /// <returns>Scratch handle; dispose to return any rented array to the pool.</returns>
    [Pure]
    public static ScratchSpan<Char16> GetChars(String8View value, Span<Char16> stackBuffer, out Span<Char16> chars)
    {
        var scratch = new ScratchSpan<Char16>(GetCharCount(value), stackBuffer, out chars);
        GetChars(value, chars);
        return scratch;
    }

    /// <inheritdoc cref="Encoding.GetBytes(String16View, Span{Char8})"/>
    /// <remarks>Usage:<code>
    /// using (Utf8.GetBytes(value, stackalloc Char8[256], out var bytes))
    /// {
    ///     // ... use "bytes" here
    /// }
    /// </code></remarks>
    /// <param name="value">The value to encode</param>
    /// <param name="stackBuffer">A temporary buffer, typically stack-allocated; if too small, will rent an array.</param>
    /// <param name="bytes">The encoded UTF8 bytes</param>
    /// <returns>Scratch handle; dispose to return any rented array to the pool.</returns>
    [Pure]
    public static ScratchSpan<Char8> GetBytes(String16View value, Span<Char8> stackBuffer, out Span<Char8> bytes)
    {
        var scratch = new ScratchSpan<Char8>(GetByteCount(value), stackBuffer, out bytes);
        GetBytes(value, bytes);
        return scratch;
    }
}

// System.Text.Unicode.Utf8
public static partial class Utf8
{
    /// <inheritdoc cref="SystemUtf8.FromUtf16(String16View, Span{Char8}, out int, out int, bool, bool)"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static System.Buffers.OperationStatus FromUtf16(
        String16View source,
        Span<Char8> destination,
        out int charsRead,
        out int bytesWritten,
        bool replaceInvalidSequences = true,
        bool isFinalBlock = true
    )
    {
        return SystemUtf8.FromUtf16(
            source,
            destination,
            out charsRead,
            out bytesWritten,
            replaceInvalidSequences,
            isFinalBlock
        );
    }

    /// <inheritdoc cref="SystemUtf8.ToUtf16(String8View, Span{Char16}, out int, out int, bool, bool)"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static System.Buffers.OperationStatus ToUtf16(
        String8View source,
        Span<Char16> destination,
        out int bytesRead,
        out int charsWritten,
        bool replaceInvalidSequences = true,
        bool isFinalBlock = true
    )
    {
        return SystemUtf8.ToUtf16(
            source,
            destination,
            out bytesRead,
            out charsWritten,
            replaceInvalidSequences,
            isFinalBlock
        );
    }

    /// <inheritdoc cref="SystemUtf8.TryWrite(Span{Char8}, ref System.Text.Unicode.Utf8.TryWriteInterpolatedStringHandler, out int)"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool TryWrite(
        Span<Char8> destination,
        [InterpolatedStringHandlerArgument(nameof(destination))]
            ref SystemUtf8.TryWriteInterpolatedStringHandler handler,
        out int bytesWritten
    )
    {
        return SystemUtf8.TryWrite(destination, ref handler, out bytesWritten);
    }

    /// <inheritdoc cref="SystemUtf8.TryWrite(Span{Char8}, IFormatProvider?, ref System.Text.Unicode.Utf8.TryWriteInterpolatedStringHandler, out int)"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool TryWrite(
        Span<Char8> destination,
        IFormatProvider? provider,
        [InterpolatedStringHandlerArgument(nameof(destination), nameof(provider))]
            ref SystemUtf8.TryWriteInterpolatedStringHandler handler,
        out int bytesWritten
    )
    {
        return SystemUtf8.TryWrite(destination, provider, ref handler, out bytesWritten);
    }

    /// <inheritdoc cref="SystemUtf8.IsValid(String8View)"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsValid(String8View value)
    {
        return SystemUtf8.IsValid(value);
    }
}

// System.Text.Encoding.UTF8
public static partial class Utf8
{
    /// <inheritdoc cref="Encoding.GetByteCount(Char16[])"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int GetByteCount(Char16[] chars)
    {
        return Encoding.UTF8.GetByteCount(chars, 0, chars.Length);
    }

    /// <inheritdoc cref="Encoding.GetByteCount(string)"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int GetByteCount(string str)
    {
        return Encoding.UTF8.GetByteCount(str);
    }

    /// <inheritdoc cref="Encoding.GetByteCount(Char16[], int, int)"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int GetByteCount(Char16[] chars, int index, int count)
    {
        return Encoding.UTF8.GetByteCount(chars, index, count);
    }

    /// <inheritdoc cref="Encoding.GetByteCount(string, int, int)"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int GetByteCount(string s, int index, int count)
    {
        return Encoding.UTF8.GetByteCount(s, index, count);
    }

    /// <inheritdoc cref="Encoding.GetByteCount(Char16*, int)"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe int GetByteCount(Ptr<Char16> chars, int count)
    {
        return Encoding.UTF8.GetByteCount(chars, count);
    }

    /// <inheritdoc cref="Encoding.GetByteCount(String16View)"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int GetByteCount(String16View chars)
    {
        return Encoding.UTF8.GetByteCount(chars);
    }

    /// <inheritdoc cref="Encoding.GetBytes(Char16[])"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Char8[] GetBytes(Char16[] chars)
    {
        return Encoding.UTF8.GetBytes(chars);
    }

    /// <inheritdoc cref="Encoding.GetBytes(Char16[], int, int)"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Char8[] GetBytes(Char16[] chars, int index, int count)
    {
        return Encoding.UTF8.GetBytes(chars, index, count);
    }

    /// <inheritdoc cref="Encoding.GetBytes(Char16[], int, int, Char8[], int)"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int GetBytes(Char16[] chars, int charIndex, int charCount, Char8[] bytes, int byteIndex)
    {
        return Encoding.UTF8.GetBytes(chars, charIndex, charCount, bytes, byteIndex);
    }

    /// <inheritdoc cref="Encoding.GetBytes(string)"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Char8[] GetBytes(string s)
    {
        return Encoding.UTF8.GetBytes(s);
    }

    /// <inheritdoc cref="Encoding.GetBytes(string, int, int)"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Char8[] GetBytes(string s, int index, int count)
    {
        return Encoding.UTF8.GetBytes(s, index, count);
    }

    /// <inheritdoc cref="Encoding.GetBytes(string, int, int, Char8[], int)"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int GetBytes(string s, int charIndex, int charCount, Char8[] bytes, int byteIndex)
    {
        return Encoding.UTF8.GetBytes(s, charIndex, charCount, bytes, byteIndex);
    }

    /// <inheritdoc cref="Encoding.GetBytes(Char16*, int, Char8*, int)"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe int GetBytes(Ptr<Char16> chars, int charCount, Ptr<Char8> bytes, int byteCount)
    {
        return Encoding.UTF8.GetBytes(chars, charCount, bytes, byteCount);
    }

    /// <inheritdoc cref="Encoding.GetBytes(String16View, Span{Char8})"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int GetBytes(String16View chars, Span<Char8> bytes)
    {
        return Encoding.UTF8.GetBytes(chars, bytes);
    }

    /// <inheritdoc cref="Encoding.TryGetBytes(String16View, Span{Char8}, out int)"/>
    /// <remarks>
    /// Routed through <see cref="FromUtf16"/>, which is single-pass and alloc-free.
    /// Avoid using <see cref="Encoding.TryGetBytes"/> which allocates (an EncoderFallbackBuffer)
    /// when <paramref name="bytes"/> is too small.
    /// </remarks>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool TryGetBytes(String16View chars, Span<Char8> bytes, out int bytesWritten)
    {
        if (FromUtf16(chars, bytes, out _, out bytesWritten) == OperationStatus.Done)
            return true;
        bytesWritten = 0; // return 0 on failure, matching Encoding.TryGetBytes (no partial count)
        return false;
    }

    /// <inheritdoc cref="Encoding.GetCharCount(Char8[])"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int GetCharCount(Char8[] bytes)
    {
        return Encoding.UTF8.GetCharCount(bytes, 0, bytes.Length);
    }

    /// <inheritdoc cref="Encoding.GetCharCount(Char8[], int, int)"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int GetCharCount(Char8[] bytes, int index, int count)
    {
        return Encoding.UTF8.GetCharCount(bytes, index, count);
    }

    /// <inheritdoc cref="Encoding.GetCharCount(Char8*, int)"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe int GetCharCount(Ptr<Char8> bytes, int count)
    {
        return Encoding.UTF8.GetCharCount(bytes, count);
    }

    /// <inheritdoc cref="Encoding.GetCharCount(String8View)"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int GetCharCount(String8View bytes)
    {
        return Encoding.UTF8.GetCharCount(bytes);
    }

    /// <inheritdoc cref="Encoding.GetChars(Char8[])"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Char16[] GetChars(Char8[] bytes)
    {
        return Encoding.UTF8.GetChars(bytes);
    }

    /// <inheritdoc cref="Encoding.GetChars(Char8[], int, int)"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Char16[] GetChars(Char8[] bytes, int index, int count)
    {
        return Encoding.UTF8.GetChars(bytes, index, count);
    }

    /// <inheritdoc cref="Encoding.GetChars(Char8[], int, int, Char16[], int)"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int GetChars(Char8[] bytes, int byteIndex, int byteCount, Char16[] chars, int charIndex)
    {
        return Encoding.UTF8.GetChars(bytes, byteIndex, byteCount, chars, charIndex);
    }

    /// <inheritdoc cref="Encoding.GetChars(Char8*, int, Char16*, int)"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe int GetChars(Ptr<Char8> bytes, int byteCount, Ptr<Char16> chars, int charCount)
    {
        return Encoding.UTF8.GetChars(bytes, byteCount, chars, charCount);
    }

    /// <inheritdoc cref="Encoding.GetChars(String8View, Span{Char16})"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int GetChars(String8View bytes, Span<Char16> chars)
    {
        return Encoding.UTF8.GetChars(bytes, chars);
    }

    /// <inheritdoc cref="Encoding.TryGetChars(String8View, Span{Char16}, out int)"/>
    /// <remarks><inheritdoc cref="TryGetBytes(String16View, Span{Char8}, out int)" path="/remarks"/></remarks>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool TryGetChars(String8View bytes, Span<Char16> chars, out int charsWritten)
    {
        if (ToUtf16(bytes, chars, out _, out charsWritten) == OperationStatus.Done)
            return true;
        charsWritten = 0; // return 0 on failure, matching Encoding.TryGetBytes (no partial count)
        return false;
    }

    /// <inheritdoc cref="Encoding.GetString(Char8*, int)"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe string GetString(Ptr<Char8> bytes, int byteCount)
    {
        return Encoding.UTF8.GetString(bytes, byteCount);
    }

    /// <inheritdoc cref="Encoding.GetString(Char8*, int)"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe string GetString(Ptr<Char8> bytes)
    {
        return Encoding.UTF8.GetString(bytes, GetByteCount(bytes));
    }

    /// <inheritdoc cref="Encoding.GetString(String8View)"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string GetString(String8View bytes)
    {
        return Encoding.UTF8.GetString(bytes);
    }

    /// <inheritdoc cref="Encoding.GetMaxByteCount(int)"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int GetMaxByteCount(int charCount)
    {
        return Encoding.UTF8.GetMaxByteCount(charCount);
    }

    /// <inheritdoc cref="Encoding.GetMaxCharCount(int)"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int GetMaxCharCount(int byteCount)
    {
        return Encoding.UTF8.GetMaxCharCount(byteCount);
    }

    /// <inheritdoc cref="Encoding.GetString(Char8[])"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string GetString(Char8[] bytes)
    {
        return Encoding.UTF8.GetString(bytes);
    }

    /// <inheritdoc cref="Encoding.GetString(Char8[], int, int)"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string GetString(Char8[] bytes, int index, int count)
    {
        return Encoding.UTF8.GetString(bytes, index, count);
    }
}
