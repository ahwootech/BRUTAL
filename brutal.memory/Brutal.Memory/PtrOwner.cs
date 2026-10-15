using Brutal.Attributes;
using Brutal.Pointers;
using Brutal.Pointers.Extensions;

namespace Brutal.Memory;

/// <summary>
/// A variant of Ptr that owns the memory and frees it automatically when disposed or finalized
/// </summary>
/// <typeparam name="TValueType">The struct type we want to create unmanaged memory pointing to</typeparam>
public class PtrOwner<TValueType> : IDisposable, INullable
    where TValueType : unmanaged
{
    /// <summary>
    /// The owned pointer.
    /// </summary>
    public Ptr<TValueType> Ptr { get; private set; }

    /// <summary>
    /// Get the value of the pointer as a reference
    /// </summary>
    public ref TValueType Value => ref Ptr.Value;

    public PtrOwner(TValueType value)
    {
        Ptr = Mem.AllocAndCopy(value);
    }

    public PtrOwner(Ptr<TValueType> ptr)
    {
        Ptr = ptr;
    }

    /// <summary>
    /// Dispose resources, freeing the memory and preventing further use.
    /// </summary>
    /// <remarks>
    /// ONLY call this if you are sure you don't need the PtrOwner anymore.
    /// </remarks>
    public void Dispose()
    {
        Mem.Free(Ptr);
        Ptr = null;
        GC.SuppressFinalize(this);
    }

    /// <summary>
    /// A finalizer that frees the memory, in case the object was not disposed.
    /// </summary>
    ~PtrOwner()
    {
        Mem.Free(Ptr);
    }

    /// <inheritdoc />
    public bool IsNull()
    {
        return Ptr.IsNull();
    }

    /// <summary>
    /// Returns a new <see cref="Ptr{TValueType}"/> that points to the same memory as this one, but with an offset in elements of <typeparamref name="TValueType"/>.
    /// </summary>
    public Ptr<TValueType> Offset(int count)
    {
        return Ptr.Offset(count);
    }

    /// <summary>
    /// Convert the pointer to a span of type TValueType with the given length.
    /// </summary>
    [return: Fixed]
    public Span<TValueType> AsSpan(int length)
    {
        return Ptr.AsSpan(length);
    }

    /// <summary>
    /// Gets a reference to the element at the specified index.
    /// </summary>
    public ref TValueType this[int index] => ref Ptr[index];

    /// <summary>
    /// Swap the pointer with another one.
    /// </summary>
    /// <param name="newPointer"></param>
    /// <returns></returns>
    public Ptr<TValueType> Swap(Ptr<TValueType> newPointer)
    {
        var oldPointer = Ptr;
        Ptr = newPointer;
        return oldPointer;
    }

    /// <summary>
    /// Release the pointer and return it to the caller.
    /// </summary>
    /// <remarks>
    /// If you don't need the PtrOwner anymore, call Dispose() instead.
    /// </remarks>
    public Ptr<TValueType> Release()
    {
        return Swap(null);
    }

    /// <summary>
    /// Frees any existing pointer and resets it to the given value.
    /// </summary>
    /// <remarks>
    /// This PtrOwner will now own the memory of the given value.
    /// </remarks>
    public void Reset(Ptr<TValueType> newValue = default)
    {
        Release();
        Swap(newValue);
    }

    /// <summary>
    /// Implicit cast to <see cref="Ptr{TValueType}"/>.
    /// </summary>
    public static implicit operator Ptr<TValueType>(PtrOwner<TValueType>? inPtrOwner)
    {
        return inPtrOwner?.Ptr ?? null;
    }

    /// <summary>
    /// Implicit cast to <typeparamref name="TValueType"/>*.
    /// </summary>
    public static unsafe implicit operator TValueType*(PtrOwner<TValueType>? inPtrOwner)
    {
        return inPtrOwner?.Ptr ?? null;
    }

    /// <summary>
    /// Explicit cast to nint.
    /// </summary>
    public static explicit operator nint(PtrOwner<TValueType> ptr)
    {
        return (nint)ptr.Ptr;
    }
}
