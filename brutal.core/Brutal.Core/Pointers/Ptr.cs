using Brutal.Attributes;

namespace Brutal.Pointers;

/// <summary>
/// A wrapper for an untyped pointer.
/// </summary>
public readonly unsafe struct Ptr(void* pointer) : INullable, IEquatable<Ptr>
{
    /// <summary>
    /// The raw void pointer.
    /// </summary>
    public void* Pointer => pointer;

    /// <summary>
    /// Returns a new <see cref="Ptr"/>, offset by the given byte count.
    /// </summary>
    public Ptr Offset(ByteSize byteOffset)
    {
        return new Ptr((byte*)Pointer + byteOffset);
    }

    /// <summary>
    /// Converts the pointer to a Span of the given type and length.
    /// </summary>
    [return: Fixed]
    public Span<TValueType> AsSpan<TValueType>(ElementCount length)
    {
        return new Span<TValueType>(Pointer, length);
    }

    /// <summary>
    /// Casts the pointer to a typed pointer.
    /// </summary>
    public Ptr<TCastType> Cast<TCastType>()
        where TCastType : unmanaged
    {
        return new Ptr<TCastType>((TCastType*)Pointer);
    }

    /// <inheritdoc />
    public bool IsNull()
    {
        return Pointer == null;
    }

    /// <summary>
    /// Implicit conversion from void* to <see cref="Ptr"/>
    /// </summary>
    public static implicit operator Ptr(void* pointer)
    {
        return new Ptr(pointer);
    }

    /// <summary>
    /// Implicit conversion from <see cref="Ptr"/> to void*.
    /// </summary>
    public static implicit operator void*(Ptr ptr)
    {
        return ptr.Pointer;
    }

    /// <summary>
    /// Explicit conversion from nint to <see cref="Ptr"/>.
    /// </summary>
    public static explicit operator Ptr(nint ptr)
    {
        return new Ptr((void*)ptr);
    }

    /// <summary>
    /// Explicit cast to nint.
    /// </summary>
    public static explicit operator nint(Ptr ptr)
    {
        return (nint)ptr.Pointer;
    }

    public bool Equals(Ptr other)
    {
        return Pointer == other.Pointer;
    }

    public override bool Equals(object? obj)
    {
        return obj is Ptr other && Equals(other);
    }

    public override int GetHashCode()
    {
        return ((nint)Pointer).GetHashCode();
    }

    public static bool operator ==(Ptr left, Ptr right)
    {
        return left.Equals(right);
    }

    public static bool operator !=(Ptr left, Ptr right)
    {
        return !left.Equals(right);
    }
}
