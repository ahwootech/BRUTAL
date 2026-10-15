namespace Brutal.Pointers;

/// <summary>
/// Wrapper for a pointer to a pointer of type TValueType.
/// </summary>
public readonly unsafe struct PtrPtr<TValueType>(TValueType** address) : INullable
    where TValueType : unmanaged
{
    /// <summary>
    /// The pointer-pointer.
    /// </summary>
    public TValueType** Pointer => address;

    /// <summary>
    /// Convert the pointer to a span of pointers of type TValueType.
    /// </summary>
    public Span<Ptr<TValueType>> AsSpan(ElementCount length)
    {
        // Ptr<TValueType> is equivalent to TValueType*,
        // So we can cast TValueType** to Ptr<TValueType>*,
        // Or so we will hope
        return new Span<Ptr<TValueType>>((Ptr<TValueType>*)Pointer, length);
    }

    /// <inheritdoc />
    public bool IsNull()
    {
        return Pointer == null;
    }

    /// <summary>
    /// Get the value of the pointer as a reference.
    /// </summary>
    public ref TValueType* Value => ref *Pointer;

    /// <summary>
    /// Access the pointer at the given index.
    /// </summary>
    public Ptr<TValueType> this[int index]
    {
        get => Pointer[index];
        set => Pointer[index] = value.Pointer;
    }

    /// <summary>
    /// Implicit conversion from void** to PtrPtr.
    /// </summary>
    public static implicit operator PtrPtr<TValueType>(TValueType** address)
    {
        return new PtrPtr<TValueType>(address);
    }

    /// <summary>
    /// Implicit conversion from PtrPtr to void**.
    /// </summary>
    public static implicit operator void**(PtrPtr<TValueType> ptr)
    {
        return (void**)ptr.Pointer;
    }

    /// <summary>
    /// Implicit conversion from PtrPtr to TValueType**
    /// </summary>
    public static implicit operator TValueType**(PtrPtr<TValueType> ptr)
    {
        return ptr.Pointer;
    }

    /// <summary>
    /// Explicit conversion from nint to PtrPtr.
    /// </summary>
    public static explicit operator PtrPtr<TValueType>(nint ptr)
    {
        return new PtrPtr<TValueType>((TValueType**)ptr);
    }

    /// <summary>
    /// Explicit cast to nint.
    /// </summary>
    public static explicit operator nint(PtrPtr<TValueType> ptr)
    {
        return (nint)ptr.Pointer;
    }
}
