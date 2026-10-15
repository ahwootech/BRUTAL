using System.ComponentModel;
using System.Numerics;
using System.Runtime.InteropServices;
using Brutal.Numerics;

namespace Brutal;

public interface IByteSize
{
    public nuint Bytes { get; }
    public nuint Kilobytes { get; }
    public nuint Megabytes { get; }
    public nuint Gigabytes { get; }
}

public interface IByteSize<TSelf, TBackend> : IByteSize, IArithmeticOperators<TSelf, TSelf, TSelf>
    where TSelf : IByteSize<TSelf, TBackend>
    where TBackend : unmanaged, IUnsignedNumber<TBackend>
{
    public TBackend Value { get; }

    static abstract implicit operator TSelf(ByteSize value);

    static abstract explicit operator TSelf(TBackend value);

    static abstract explicit operator TSelf(int value);

    static abstract TSelf operator *(TSelf left, ElementCount right);

    static abstract TSelf operator *(ElementCount right, TSelf left);

    // IAssociativeArithmeticOperators<TBackend, TSelf, TSelf>
    static abstract TSelf operator +(TSelf left, TBackend right);

    static abstract TSelf operator -(TSelf left, TBackend right);

    static abstract TSelf operator *(TSelf left, TBackend right);

    static abstract TSelf operator /(TSelf left, TBackend right);

    static abstract TSelf operator +(TBackend left, TSelf right);

    static abstract TSelf operator -(TBackend left, TSelf right);

    static abstract TSelf operator *(TBackend left, TSelf right);

    static abstract TSelf operator /(TBackend left, TSelf right);

    // IAssociativeArithmeticOperators<int, TSelf, TSelf>
    static abstract TSelf operator +(TSelf left, int right);

    static abstract TSelf operator -(TSelf left, int right);

    static abstract TSelf operator *(TSelf left, int right);

    static abstract TSelf operator /(TSelf left, int right);

    static abstract TSelf operator +(int left, TSelf right);

    static abstract TSelf operator -(int left, TSelf right);

    static abstract TSelf operator *(int left, TSelf right);

    static abstract TSelf operator /(int left, TSelf right);
}

/// <summary>
/// A specialized 32-bit version of <see cref="ByteSize"/>, to ensure consistency across platforms.
/// Prefer <see cref="ByteSize"/> in client code where possible.
/// TODO: ByteSize32 should be demoted to a .Interop namespace to make is less discoverable.
/// </summary>
public readonly record struct ByteSize32(uint Value)
    : IByteSize<ByteSize32, uint>,
        IAssociativeArithmeticOperators<ByteSize32, uint, ByteSize32>,
        IAssociativeArithmeticOperators<ByteSize32, int, ByteSize32>
{
    #region converters

    public static implicit operator ByteSize(ByteSize32 value) => new(value.Value);

    public static implicit operator ByteSize32(ByteSize value) => new(checked((uint)value.Value));

    public static implicit operator int(ByteSize32 value) => (int)value.Value;

    public static explicit operator ByteSize32(int value) => new(checked((uint)value));

    public static explicit operator ByteSize32(uint value) => new(value);

    #endregion

    #region arithmetic operators

    public static unsafe byte* operator +(byte* left, ByteSize32 right) => left + right.Value;

    public static ByteSize32 operator +(ByteSize32 left, ByteSize32 right) => left.Value + right;

    public static ByteSize32 operator -(ByteSize32 left, ByteSize32 right) => left.Value - right;

    public static ByteSize32 operator *(ByteSize32 left, ByteSize32 right) => left.Value * right;

    public static ByteSize32 operator /(ByteSize32 left, ByteSize32 right) => left.Value / right;

    public static ByteSize32 operator +(ByteSize32 left, uint right) => (ByteSize32)(left.Value + right);

    public static ByteSize32 operator -(ByteSize32 left, uint right) => (ByteSize32)(left.Value - right);

    public static ByteSize32 operator *(ByteSize32 left, uint right) => (ByteSize32)(left.Value * right);

    public static ByteSize32 operator /(ByteSize32 left, uint right) => (ByteSize32)(left.Value / right);

    public static ByteSize32 operator +(uint left, ByteSize32 right) => (ByteSize32)(left + right.Value);

    public static ByteSize32 operator -(uint left, ByteSize32 right) => (ByteSize32)(left - right.Value);

    public static ByteSize32 operator *(uint left, ByteSize32 right) => (ByteSize32)(left * right.Value);

    public static ByteSize32 operator /(uint left, ByteSize32 right) => (ByteSize32)(left / right.Value);

    public static ByteSize32 operator *(ByteSize32 left, ElementCount right) => left * (uint)right;

    public static ByteSize32 operator *(ElementCount left, ByteSize32 right) => (uint)left * right;

    public static ByteSize32 operator +(ByteSize32 left, int right) => left + (uint)right;

    public static ByteSize32 operator -(ByteSize32 left, int right) => left - (uint)right;

    public static ByteSize32 operator *(ByteSize32 left, int right) => left * (uint)right;

    public static ByteSize32 operator /(ByteSize32 left, int right) => left / (uint)right;

    public static ByteSize32 operator +(int left, ByteSize32 right) => (uint)left + right;

    public static ByteSize32 operator -(int left, ByteSize32 right) => (uint)left - right;

    public static ByteSize32 operator *(int left, ByteSize32 right) => (uint)left * right;

    public static ByteSize32 operator /(int left, ByteSize32 right) => (uint)left / right;

    #endregion

    [EditorBrowsable(EditorBrowsableState.Never)]
    public override string ToString() => ((ByteSize)this).ToString();

    public nuint Bytes => Value;
    public nuint Kilobytes => Bytes / ByteSize.KILOBYTES_TO_BYTES;
    public nuint Megabytes => Bytes / ByteSize.MEGABYTES_TO_BYTES;
    public nuint Gigabytes => Bytes / ByteSize.GIGABYTES_TO_BYTES;
}

/// <summary>
/// A specialized 64-bit version of <see cref="ByteSize"/>, to ensure consistency across platforms.
/// Prefer <see cref="ByteSize"/> in client code where possible.
/// TODO: ByteSize64 should be demoted to a .Interop namespace to make is less discoverable.
/// </summary>
public readonly record struct ByteSize64(ulong Value)
    : IByteSize<ByteSize64, ulong>,
        IAssociativeArithmeticOperators<ByteSize64, ulong, ByteSize64>,
        IAssociativeArithmeticOperators<ByteSize64, int, ByteSize64>
{
    #region converters

    public static implicit operator ByteSize(ByteSize64 value) => new(value.Bytes);

    public static implicit operator ByteSize64(ByteSize value) => new(value.Value);

    public static implicit operator int(ByteSize64 value) => (int)value.Value;

    public static explicit operator ByteSize64(int value) => new((ulong)value);

    public static explicit operator ByteSize64(ulong value) => new(value);

    #endregion

    #region arithmetic operators

    public static unsafe byte* operator +(byte* left, ByteSize64 right) => left + right.Value;

    public static ByteSize64 operator +(ByteSize64 left, ByteSize64 right) => left.Value + right;

    public static ByteSize64 operator -(ByteSize64 left, ByteSize64 right) => left.Value - right;

    public static ByteSize64 operator *(ByteSize64 left, ByteSize64 right) => left.Value * right;

    public static ByteSize64 operator /(ByteSize64 left, ByteSize64 right) => left.Value / right;

    public static ByteSize64 operator +(ByteSize64 left, ulong right) => (ByteSize64)(left.Value + right);

    public static ByteSize64 operator -(ByteSize64 left, ulong right) => (ByteSize64)(left.Value - right);

    public static ByteSize64 operator *(ByteSize64 left, ulong right) => (ByteSize64)(left.Value * right);

    public static ByteSize64 operator /(ByteSize64 left, ulong right) => (ByteSize64)(left.Value / right);

    public static ByteSize64 operator +(ulong left, ByteSize64 right) => (ByteSize64)(left + right.Value);

    public static ByteSize64 operator -(ulong left, ByteSize64 right) => (ByteSize64)(left - right.Value);

    public static ByteSize64 operator *(ulong left, ByteSize64 right) => (ByteSize64)(left * right.Value);

    public static ByteSize64 operator /(ulong left, ByteSize64 right) => (ByteSize64)(left / right.Value);

    public static ByteSize64 operator *(ByteSize64 left, ElementCount right) => left * (ulong)right;

    public static ByteSize64 operator *(ElementCount left, ByteSize64 right) => (ulong)left * right;

    public static ByteSize64 operator +(ByteSize64 left, int right) => left + (ulong)right;

    public static ByteSize64 operator -(ByteSize64 left, int right) => left - (ulong)right;

    public static ByteSize64 operator *(ByteSize64 left, int right) => left * (ulong)right;

    public static ByteSize64 operator /(ByteSize64 left, int right) => left / (ulong)right;

    public static ByteSize64 operator +(int left, ByteSize64 right) => (ulong)left + right;

    public static ByteSize64 operator -(int left, ByteSize64 right) => (ulong)left - right;

    public static ByteSize64 operator *(int left, ByteSize64 right) => (ulong)left * right;

    public static ByteSize64 operator /(int left, ByteSize64 right) => (ulong)left / right;

    #endregion

    [EditorBrowsable(EditorBrowsableState.Never)]
    public override string ToString() => ((ByteSize)this).ToString();

    public nuint Bytes => (nuint)Value;
    public nuint Kilobytes => Bytes / ByteSize.KILOBYTES_TO_BYTES;
    public nuint Megabytes => Bytes / ByteSize.MEGABYTES_TO_BYTES;
    public nuint Gigabytes => Bytes / ByteSize.GIGABYTES_TO_BYTES;
}

/// <summary>
/// <see cref="ByteSize"/> adapts to the target platform's natural pointer size,
/// using <see cref="nuint" href="https://learn.microsoft.com/en-us/dotnet/api/system.nuint"/> as a storage,
/// like <c>size_t</c> in C++.
/// </summary>
/// <remarks>
/// Prefer using this over <see cref="ByteSize64"/> and <see cref="ByteSize32"/>,
/// which are only meant for interoping with APIs that require fixed sizes of one or the other;
/// <see cref="ByteSize"/> will marshall to the correct size.
/// </remarks>
public readonly record struct ByteSize(nuint Value)
    : IByteSize,
        IAssociativeArithmeticOperators<ByteSize, nuint, ByteSize>,
        IAssociativeArithmeticOperators<ByteSize, int, ByteSize>
{
    public const nuint KILOBYTES_TO_BYTES = 1024;
    public const nuint MEGABYTES_TO_BYTES = 1024 * KILOBYTES_TO_BYTES;
    public const nuint GIGABYTES_TO_BYTES = 1024 * MEGABYTES_TO_BYTES;

    public static ByteSize Zero => new(0);
    public static ByteSize One => new(1);

    #region converters

    public static explicit operator ByteSize(int bytes) => new((nuint)bytes);

    public static explicit operator ByteSize(uint bytes) => new(bytes);

    public static explicit operator ByteSize(ulong bytes) => new((nuint)bytes);

    public static explicit operator ByteSize(long bytes) => new((nuint)bytes);

    public static explicit operator ByteSize(nuint bytes) => new(bytes);

    public static explicit operator ByteSize(nint bytes) => new((nuint)bytes);

    public static explicit operator ByteSize(double bytes) => new((nuint)bytes);

    public static explicit operator ByteSize(float bytes) => new((nuint)bytes);

    public static explicit operator int(ByteSize byteSize) => (int)byteSize.Bytes;

    public static explicit operator uint(ByteSize byteSize) => (uint)byteSize.Bytes;

    public static explicit operator long(ByteSize byteSize) => (long)byteSize.Bytes;

    public static implicit operator ulong(ByteSize byteSize) => byteSize.Bytes;

    public static explicit operator nint(ByteSize byteSize) => (nint)byteSize.Bytes;

    public static explicit operator nuint(ByteSize byteSize) => byteSize.Bytes;

    public static explicit operator float(ByteSize byteSize) => byteSize.Bytes;

    public static explicit operator double(ByteSize byteSize) => byteSize.Bytes;

    #endregion

    #region arithmetic operators

    public static unsafe byte* operator +(byte* left, ByteSize right) => left + right.Bytes;

    public static ByteSize operator +(ByteSize left, ByteSize right) => left.Bytes + right;

    public static ByteSize operator -(ByteSize left, ByteSize right) => left.Bytes - right;

    public static ByteSize operator *(ByteSize left, ByteSize right) => left.Bytes * right;

    public static ByteSize operator /(ByteSize left, ByteSize right) => left.Bytes / right;

    public static ByteSize operator +(ByteSize left, nuint right) => (ByteSize)(left.Bytes + right);

    public static ByteSize operator -(ByteSize left, nuint right) => (ByteSize)(left.Bytes - right);

    public static ByteSize operator *(ByteSize left, nuint right) => (ByteSize)(left.Bytes * right);

    public static ByteSize operator /(ByteSize left, nuint right) => (ByteSize)(left.Bytes / right);

    public static ByteSize operator +(nuint left, ByteSize right) => (ByteSize)(left + right.Bytes);

    public static ByteSize operator -(nuint left, ByteSize right) => (ByteSize)(left - right.Bytes);

    public static ByteSize operator *(nuint left, ByteSize right) => (ByteSize)(left * right.Bytes);

    public static ByteSize operator /(nuint left, ByteSize right) => (ByteSize)(left / right.Bytes);

    public static ByteSize operator *(ByteSize left, ElementCount right) => left * (nuint)right;

    public static ByteSize operator *(ElementCount left, ByteSize right) => (nuint)left * right;

    public static ByteSize operator +(ByteSize left, int right) => left + (nuint)right;

    public static ByteSize operator -(ByteSize left, int right) => left - (nuint)right;

    public static ByteSize operator *(ByteSize left, int right) => left * (nuint)right;

    public static ByteSize operator /(ByteSize left, int right) => left / (nuint)right;

    public static ByteSize operator +(int left, ByteSize right) => (nuint)left + right;

    public static ByteSize operator -(int left, ByteSize right) => (nuint)left - right;

    public static ByteSize operator *(int left, ByteSize right) => (nuint)left * right;

    public static ByteSize operator /(int left, ByteSize right) => (nuint)left / right;

    #endregion

    public nuint Bytes => Value;
    public nuint Kilobytes => Bytes / KILOBYTES_TO_BYTES;
    public nuint Megabytes => Bytes / MEGABYTES_TO_BYTES;
    public nuint Gigabytes => Bytes / GIGABYTES_TO_BYTES;

    private static readonly string[] Suffixes = ["B", "KB", "MB", "GB", "TB", "PB", "EB"];

    public override string ToString()
    {
        if (Bytes == 0)
            return "0 B";

        var order = (int)Math.Floor(Math.Log(Bytes, 1024));
        order = Math.Min(order, Suffixes.Length - 1);

        var value = Bytes / Math.Pow(1024, order);

        return $"{value:0.##} {Suffixes[order]}";
    }

    /// <summary>
    /// Returns the maximum number of elements that can fit in a span of the given size
    /// </summary>
    public ElementCount ToElementCount(ByteSize stride)
    {
        return new ElementCount((int)(Bytes / stride.Bytes));
    }

    /// <summary>
    /// Returns the maximum number of elements that can fit in a span of the given size
    /// </summary>
    public ElementCount ToElementCount<T>()
        where T : unmanaged
    {
        return ToElementCount(Of(Unsafe.SizeOf<T>()));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ByteSize Of(byte value) => (ByteSize)(int)value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ByteSize Of(int value) => (ByteSize)value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ByteSize Of(uint value) => (ByteSize)value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ByteSize Of(long value) => (ByteSize)value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ByteSize Of(ulong value) => (ByteSize)value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ByteSize OffsetOf<T>(string fieldName)
        where T : struct => (ByteSize)Marshal.OffsetOf<T>(fieldName);

    /// <summary>Returns the alignment requirement of T, as applied by the runtime's struct layout.</summary>
    public static ByteSize AlignmentOf<T>()
        where T : unmanaged
    {
        /* C# has no alignof; measure where the CLR places T after a single byte - sequential
           layout pads exactly to T's alignment, so the offset IS the alignment. This is the
           runtime truth (what C/C++ interop parity depends on), unlike Marshal.OffsetOf which
           reports the marshalled layout. */
        var probe = default(AlignmentProbe<T>);
        return (ByteSize)Unsafe.ByteOffset(ref probe.Padding, ref Unsafe.As<T, byte>(ref probe.Value));
    }

#pragma warning disable CS0649 // fields never assigned - only refs into the default layout are taken
    private struct AlignmentProbe<T>
        where T : unmanaged
    {
        public byte Padding;
        public T Value;
    }
#pragma warning restore CS0649

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ByteSize FromKilobytes(byte value) => (ByteSize)(value * KILOBYTES_TO_BYTES);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ByteSize FromKilobytes(int value) => (ByteSize)((nuint)value * KILOBYTES_TO_BYTES);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ByteSize FromKilobytes(uint value) => (ByteSize)(value * KILOBYTES_TO_BYTES);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ByteSize FromKilobytes(long value) => (ByteSize)((nuint)value * KILOBYTES_TO_BYTES);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ByteSize FromKilobytes(ulong value) => (ByteSize)((nuint)value * KILOBYTES_TO_BYTES);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ByteSize FromMegabytes(byte value) => (ByteSize)(value * MEGABYTES_TO_BYTES);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ByteSize FromMegabytes(int value) => (ByteSize)((nuint)value * MEGABYTES_TO_BYTES);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ByteSize FromMegabytes(uint value) => (ByteSize)(value * MEGABYTES_TO_BYTES);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ByteSize FromMegabytes(long value) => (ByteSize)((nuint)value * MEGABYTES_TO_BYTES);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ByteSize FromMegabytes(ulong value) => (ByteSize)((nuint)value * MEGABYTES_TO_BYTES);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ByteSize FromGigabytes(byte value) => (ByteSize)(value * GIGABYTES_TO_BYTES);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ByteSize FromGigabytes(int value) => (ByteSize)((nuint)value * GIGABYTES_TO_BYTES);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ByteSize FromGigabytes(uint value) => (ByteSize)(value * GIGABYTES_TO_BYTES);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ByteSize FromGigabytes(long value) => (ByteSize)((nuint)value * GIGABYTES_TO_BYTES);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ByteSize FromGigabytes(ulong value) => (ByteSize)((nuint)value * GIGABYTES_TO_BYTES);

    /// <summary>
    /// Returns the size in bytes of the type <c>T</c>
    /// </summary>
    public static ByteSize Of<T>()
        where T : unmanaged
    {
        return Of<T>(ElementCount.One);
    }

    /// <summary>
    /// Returns the size in bytes of <c>count</c> elements of type <c>T</c>
    /// </summary>
    public static ByteSize Of<T>(ElementCount count)
        where T : unmanaged
    {
        return Of(Unsafe.SizeOf<T>() * count.Value);
    }

    /// <summary>
    /// Returns the size in bytes of the array
    /// </summary>
    public static ByteSize Of<T>(T[] span)
        where T : unmanaged
    {
        return Of<T>(span.Length);
    }

    /// <summary>
    /// Returns the size in bytes of the list
    /// </summary>
    public static ByteSize Of<T>(List<T> span)
        where T : unmanaged
    {
        return Of<T>(span.Count);
    }

    /// <summary>
    /// Returns the size in bytes of the span
    /// </summary>
    public static ByteSize Of<T>(ReadOnlySpan<T> span)
        where T : unmanaged
    {
        return Of<T>(span.Length);
    }

    /// <summary>
    /// Returns the size in bytes of the span
    /// </summary>
    public static ByteSize Of<T>(Span<T> span)
        where T : unmanaged
    {
        return Of<T>(span.Length);
    }

    /// <summary>
    /// Returns the size in bytes of the span
    /// </summary>
    public static ByteSize Of<T>(T span)
        where T : ISpanLike, allows ref struct
    {
        return span.Length * span.Stride;
    }

    /// <summary>
    /// Returns the size in bytes of the span
    /// </summary>
    public static ByteSize Of<T1, T2>(T1 span)
        where T1 : ISpanLike<T2>
        where T2 : unmanaged
    {
        return Of<T2>(span.Length);
    }

    public static ByteSize Max(ByteSize a, ByteSize b) => (ByteSize)nuint.Max(a.Bytes, b.Bytes);

    public static ByteSize Min(ByteSize a, ByteSize b) => (ByteSize)nuint.Min(a.Bytes, b.Bytes);
}

public static class ByteSizeExtensions
{
    public static ByteSize AlignTo<T1, T2>(this T1 value, T2 alignment)
        where T1 : IByteSize
        where T2 : IByteSize
    {
        var a = alignment.Bytes;
        return (ByteSize)((value.Bytes + a - 1) & ~(a - 1));
    }
}
