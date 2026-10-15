using System.Runtime.InteropServices.Marshalling;
using Brutal.Attributes;

namespace Brutal.Strings;

/// <summary>
/// A reference to a null-terminated string of bytes.
/// </summary>
[DebuggerDisplay("{ToString16()}")]
[NativeMarshalling(typeof(RefString8Marshaller))]
public readonly ref struct RefString8 : IString8
{
    private readonly ref Char8 _firstChar;

    public static RefString8 Empty => String8View.Empty;

    /// <summary>
    /// Create a safe reference to a null-terminated string of bytes.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RefString8(String8View cString)
    {
        _firstChar = ref MemoryMarshal.GetReference(cString);
    }

    /// <summary>
    /// Create an unsafe reference to a null-terminated string of bytes.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe RefString8([Fixed] Ptr<Char8> pointer)
    {
        _firstChar = ref Unsafe.AsRef<Char8>(pointer);
    }

    /// <summary>
    /// Get a reference to the first character of the string.
    /// </summary>
    public ref Char8 FirstChar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => ref _firstChar;
    }

    /// <summary>
    /// Implicit conversion from a null-terminated string of bytes to a RefString8.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator RefString8([Fixed] Ptr<Char8> cString)
    {
        return new RefString8(cString);
    }

    /// <summary>
    /// Implicit conversion from a String8View to a RefString8.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator RefString8(String8View bytes)
    {
        return new RefString8(bytes);
    }

    /// <summary>
    /// Implicit conversion from a Span&lt;Char8&gt; to a RefString8.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator RefString8(Span<Char8> bytes)
    {
        return new RefString8(bytes);
    }

    /// <summary>
    /// Implicit conversion from a byte array to a RefString8.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator RefString8(Char8[] bytes)
    {
        return new RefString8(bytes);
    }

    /// <summary>
    /// Implicit conversion from a String8 to a RefString8.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator RefString8(String8 cString)
    {
        return new RefString8(cString.AsSpan());
    }

    public static implicit operator String8View(RefString8 str)
    {
        return str.Chars;
    }

    /// <summary>
    /// Get a reference to the first character of the string.
    /// </summary>
    public ref Char8 GetPinnableReference()
    {
        return ref _firstChar;
    }

    public unsafe String8View Chars => Utf8.GetNullTerminatedSpan((Ptr<Char8>)Unsafe.AsPointer(ref _firstChar));
    public int Length => Chars.Length;
    public bool IsEmpty => Unsafe.IsNullRef(ref _firstChar) || _firstChar == 0;

    public Char8 this[int index] => Chars[index];
    public String8View this[Range range] => Chars[range];

    public String8View AsSpan()
    {
        return Chars;
    }

    public String16 ToString16()
    {
        return Utf8.GetString(Chars);
    }
}
