using Brutal.Attributes;
using Brutal.Pointers.Extensions;

namespace Brutal.Pointers;

/// <summary>
/// A wrapper for a typed pointer.
/// </summary>
public readonly unsafe struct Ptr<TValueType>(TValueType* pointer) : INullable
    where TValueType : unmanaged
{
    /// <summary>
    /// The raw pointer of type <typeparamref name="TValueType"/>.
    /// </summary>
    public TValueType* Pointer => pointer;

    /// <summary>
    /// A reference to the first value at the pointer address.
    /// </summary>
    public ref TValueType Value => ref *Pointer;

    /// <summary>
    /// Returns a new <see cref="Ptr{T}"/>, offset by the given byte count.
    /// </summary>
    /// <param name="count"></param>
    /// <returns></returns>
    public Ptr<TValueType> Offset(ElementCount count)
    {
        return new Ptr<TValueType>(Pointer + count);
    }

    /// <summary>
    /// Converts the pointer to a <see cref="Span{T}"/> of the given length.
    /// </summary>
    [return: Fixed]
    public Span<TValueType> AsSpan(ElementCount length)
    {
        return new Span<TValueType>(Pointer, length);
    }

    /// <summary>
    /// Converts the pointer to an untyped <see cref="Ptr"/>.
    /// </summary>
    public Ptr AsPtr()
    {
        return new Ptr(Pointer);
    }

    /// <summary>
    /// Cast this pointer to a different type.
    /// </summary>
    /// <typeparam name="TCastType"></typeparam>
    /// <returns></returns>
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
    /// Gets a reference to the value at the given index.
    /// </summary>
    public ref TValueType this[int index] => ref Pointer[index];

    /// <summary>
    /// Implicit conversion from a <see cref="Ptr{T}"/> to an untyped <see cref="Ptr"/>.
    /// </summary>
    public static implicit operator Ptr(Ptr<TValueType> ptr)
    {
        return ptr.AsPtr();
    }

    /// <summary>
    /// Implicit conversion from a typed pointer to a <see cref="Ptr{T}"/>.
    /// </summary>
    public static implicit operator Ptr<TValueType>(TValueType* pointer)
    {
        return new Ptr<TValueType>(pointer);
    }

    /// <summary>
    /// Implicit conversion from a <see cref="Ptr{T}"/> to <typeparamref name="TValueType"/>*.
    /// </summary>
    /// <param name="ptr"></param>
    /// <returns></returns>
    public static implicit operator TValueType*(Ptr<TValueType> ptr)
    {
        return ptr.Pointer;
    }

    /// <summary>
    /// Implicit conversion from a <see cref="Ptr{T}"/> to void pointer.
    /// </summary>
    public static implicit operator void*(Ptr<TValueType> ptr)
    {
        return ptr.Pointer;
    }

    public static implicit operator Ptr<TValueType>([Fixed] ReadOnlySpan<TValueType> span)
    {
        return span.AsPtr();
    }

    public static implicit operator Ptr<TValueType>([Fixed] Span<TValueType> span)
    {
        return span.AsPtr();
    }

    /// <summary>
    /// Explicit cast from nint to Ptr.
    /// </summary>
    public static explicit operator Ptr<TValueType>(nint ptr)
    {
        return new Ptr<TValueType>((TValueType*)ptr);
    }

    /// <summary>
    /// Explicit cast to nint.
    /// </summary>
    public static explicit operator nint(Ptr<TValueType> ptr)
    {
        return (nint)ptr.Pointer;
    }
}
