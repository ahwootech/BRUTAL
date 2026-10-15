using Brutal.Attributes;

namespace Brutal.Pointers;

/// <summary>
/// Wraps a pointer to a pointer.
/// </summary>
public readonly unsafe struct PtrPtr(void** pointerPointer) : INullable
{
    /// <summary>
    /// The pointer-pointer.
    /// </summary>
    public void** Pointer => pointerPointer;

    /// <summary>
    /// Convert the pointer to a span of pointers.
    /// </summary>
    [return: Fixed]
    public Span<Ptr> AsSpan(ElementCount length)
    {
        // Ptr is equivalent to void*,
        // So we can cast void** to Ptr*,
        // Or so we will hope
        return new Span<Ptr>((Ptr*)Pointer, length);
    }

    /// <summary>
    /// Convert the pointer to a span of pointers.
    /// </summary>
    public Span<Ptr<T>> AsSpan<T>(ElementCount length)
        where T : unmanaged
    {
        // Ptr<T> is equivalent to T*,
        // So we can cast void** to Ptr<T>,
        // Or so we will hope
        return new Span<Ptr<T>>((Ptr<T>*)Pointer, length);
    }

    /// <inheritdoc />
    public bool IsNull()
    {
        return Pointer == null;
    }

    /// <summary>
    /// Get the value of the pointer as a reference.
    /// </summary>
    public ref void* Value => ref *Pointer;

    /// <summary>
    /// Access the pointer at the given index.
    /// </summary>
    public Ptr this[int index]
    {
        get => Pointer[index];
        set => Pointer[index] = value.Pointer;
    }

    /// <summary>
    /// Implicit conversion from void** to PtrPtr.
    /// </summary>
    public static implicit operator PtrPtr(void** address)
    {
        return new PtrPtr(address);
    }

    /// <summary>
    /// Implicit conversion from PtrPtr to void**
    /// </summary>
    public static implicit operator void**(PtrPtr ptr)
    {
        return ptr.Pointer;
    }

    /// <summary>
    /// Explicit conversion from nint to PtrPtr.
    /// </summary>
    public static explicit operator PtrPtr(nint ptr)
    {
        return new PtrPtr((void**)ptr);
    }

    /// <summary>
    /// Explicit cast to nint.
    /// </summary>
    public static explicit operator nint(PtrPtr ptr)
    {
        return (nint)ptr.Pointer;
    }
}
