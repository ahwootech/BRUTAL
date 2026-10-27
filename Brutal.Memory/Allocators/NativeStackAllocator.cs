using System;
using System.Runtime.InteropServices;

using Brutal;
using Brutal.Pointers;

namespace Brutal.Memory;

public unsafe class NativeStackAllocator
{
    private readonly Ptr _pointer;
    private readonly ByteSize _capacity;
    private ByteSize _reserved;

    public ByteSize Capacity => _capacity;
    public ByteSize Reserved => _reserved;
    public ByteSize Remaining => _capacity - _reserved;
    public Span<byte> Span => new(_pointer, ((int)_capacity));

    public NativeStackAllocator(Ptr pointer, ByteSize capacity)
    {
        if (pointer.IsNull())
        {
            throw new ArgumentNullException(nameof(pointer));
        }

        _pointer = pointer;
        _capacity = capacity;
        _reserved = ByteSize.Zero;
    }

    public unsafe Ptr Rent(ByteSize bytes)
    {
        if (_reserved + bytes > _capacity)
        {
            throw new OutOfMemoryException("Stack allocator is full");
        }

        Ptr result = _pointer.Offset(_reserved);
        _reserved += bytes;
        return result;
    }

    public Ptr<T> Rent<T>(ElementCount count) where T : unmanaged
    {
        int alignment = TypeAlign<T>.Value;

        nuint currentAddr = (nuint)_pointer.Offset(_reserved).Pointer;
        nuint alignedAddr = (currentAddr + (nuint)(alignment - 1)) & ~(nuint)(alignment - 1);
        ByteSize padding = ByteSize.Of((int)(alignedAddr - currentAddr));

        ByteSize dataBytes = ByteSize.Of<T>(count);
        ByteSize totalBytes = padding + dataBytes;

        if (_reserved + totalBytes > _capacity)
        {
            throw new OutOfMemoryException("Stack allocator is full");
        }

        Ptr alignedPtr = _pointer.Offset(_reserved + padding);
        _reserved += totalBytes;

        return alignedPtr.Cast<T>();
    }

    public Scope<T> RentScoped<T>(ElementCount count) where T : unmanaged
    {
        ByteSize marker = _reserved;
        Ptr<T> ptr = Rent<T>(count);
        return new Scope<T>(this, marker, ptr.AsSpan(count));
    }

    public void Reset() => _reserved = ByteSize.Zero;

    public void Rollback(ByteSize marker)
    {
        if (marker > _reserved)
        {
            throw new ArgumentOutOfRangeException(nameof(marker), "Cannot rollback to a future offset");
        }

        _reserved = marker;
    }

    public readonly ref struct Scope<T> : IDisposable where T : unmanaged
    {
        private readonly NativeStackAllocator _allocator;
        private readonly ByteSize _marker;

        public readonly Span<T> Span;

        public int Length => Span.Length;
        public ref T this[int index] => ref Span[index];

        internal Scope(NativeStackAllocator allocator, ByteSize marker, Span<T> span)
        {
            _allocator = allocator;
            _marker = marker;
            Span = span;
        }

        public void Dispose() => _allocator.Rollback(_marker);

        public Span<T>.Enumerator GetEnumerator() => Span.GetEnumerator();

        public static implicit operator Span<T>(Scope<T> scope) => scope.Span;
        public static implicit operator ReadOnlySpan<T>(Scope<T> scope) => scope.Span;
    }
}