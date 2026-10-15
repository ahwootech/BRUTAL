namespace Brutal.Strings;

/// <summary>
/// Represents a string backed by an array of bytes.
/// </summary>
/// <remarks>
/// Typically, but not necessarily, the bytes are UTF-8 encoded. Note that this type doesn't provide any special UTF-8 functionality.
/// </remarks>
[DebuggerDisplay("{ToString16()}")]
public class String8 : IString8, IEquatable<String8?>, IComparable, IComparable<String8?>, ICloneable
{
    /// the default array backing any empty-initialized String8
    private static readonly Char8[] EmptyChars = [0];

    /// <summary>
    /// An empty string8.
    /// </summary>
    public static readonly String8 Empty = new();

    /// WARNING: This array contains a trailing null byte.
    private readonly Char8[] _bytes;

    public String8View Chars => _bytes.AsSpan()[..^1];

    /// <summary>
    /// Construct an empty string.
    /// </summary>
    public String8()
    {
        _bytes = EmptyChars;
    }

    /// <summary>
    /// Construct a string from a list of characters (converting to UTF-8 in the process).
    /// </summary>
    public String8(String16View characters)
    {
        if (characters.IsEmpty)
        {
            _bytes = EmptyChars;
        }
        else
        {
            _bytes = new Char8[Utf8.GetByteCount(characters) + 1];
            Utf8.GetBytes(characters, _bytes);
        }
    }

    /// <summary>
    /// Construct a string from a list of bytes (no conversion, but copies).
    /// </summary>
    /// <param name="bytes"></param>
    public String8(String8View bytes)
    {
        if (bytes.IsEmpty)
        {
            _bytes = EmptyChars;
        }
        else
        {
            _bytes = new Char8[bytes.Length + 1];
            bytes.CopyTo(_bytes);
        }
    }

    /// <summary>
    /// Construct a string from an existing array of bytes.
    /// </summary>
    /// <remarks>
    /// Private because this behavior is dangerous if the array can be modified after construction.
    /// </remarks>
    private String8(Char8[] bytes)
    {
        if (bytes[^1] != 0)
            throw new ArgumentException("'bytes' must be null-terminated!", nameof(bytes));

        _bytes = bytes.Length != 0 ? bytes : EmptyChars;
    }

    /// <summary>
    /// The length of the string in bytes.
    /// </summary>
    public int Length => _bytes.Length - 1;

    public bool IsEmpty => Length == 0;

    /// <summary>
    /// Create a new String8 from a slice of the current string.
    /// </summary>
    public String8 Slice(int startIndex)
    {
        return new String8(Chars[startIndex..]);
    }

    /// <summary>
    /// Create a new String8 from a slice of the current string.
    /// </summary>
    public String8 Slice(int startIndex, int count)
    {
        return new String8(Chars[startIndex..(startIndex + count)]);
    }

    public Char8 this[int index] => Chars[index];
    public String8 this[Range range] => new String8(Chars[range]);

    public object Clone()
    {
        // do not call the byte[] constructor here!
        return new String8(AsSpan());
    }

    #region Operators

    public static implicit operator String8View(String8 str)
    {
        return str.Chars;
    }

    public static implicit operator String8(String8View str)
    {
        return new String8(str);
    }

    #endregion

    public String8View AsSpan()
    {
        return Chars;
    }

    public string ToString16()
    {
        return Utf8.GetString(Chars);
    }

    // Equality and comparison implementations
    public bool Equals(String8? other)
    {
        if (ReferenceEquals(this, other))
            return true;
        if (other is null || Length != other.Length)
            return false;
        return Chars.SequenceEqual(other.Chars);
    }

    public override bool Equals(object? obj)
    {
        return obj is String8 other && Equals(other);
    }

    public override int GetHashCode()
    {
        return Chars.GetDjb2HashCode();
    }

    public int CompareTo(object? obj)
    {
        if (obj is null)
            return 1;
        if (obj is not String8 other)
            throw new ArgumentException("Object must be of type String8.", nameof(obj));
        return CompareTo(other);
    }

    public int CompareTo(String8? other)
    {
        if (other is null)
            return 1;
        return Chars.AsBytes().SequenceCompareTo(other.Chars);
    }

    public static bool operator ==(String8? a, String8? b)
    {
        if (ReferenceEquals(a, b))
            return true;
        if (a is null || b is null)
            return false;
        return a.Equals(b);
    }

    public static bool operator !=(String8? a, String8? b)
    {
        return !(a == b);
    }

    /// <summary>
    /// Create a new string from existing memory without copying.
    /// </summary>
    /// <remarks>
    /// WARNING: Do not retain the provided bytes after constructing the String8. The String8 instance will take ownership of the memory.
    /// </remarks>
    public static String8 Move(Char8[] bytes)
    {
        if (bytes.Length != 0 && bytes[^1] != 0)
            return new String8(bytes.AsSpan());

        return new String8(bytes);
    }

    public ref Char8 GetPinnableReference()
    {
        return ref _bytes[0];
    }
}
