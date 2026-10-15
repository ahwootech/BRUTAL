using System.Diagnostics;

namespace Brutal;

[DebuggerDisplay("{Value}")]
public readonly record struct ElementCount
{
    public ElementCount(int value) => Value = value;

    public int Value { get; init; }

    public void Deconstruct(out int value) => value = Value;

    public static ElementCount Zero => 0;
    public static ElementCount One => 1;

    public static implicit operator ElementCount(int elements) => new(elements);

    public static explicit operator ElementCount(uint elements) => new((int)elements);

    public static explicit operator ElementCount(ulong elements) => new((int)elements);

    public static explicit operator ElementCount(long elements) => new((int)elements);

    public static explicit operator ElementCount(nuint elements) => new((int)elements);

    public static explicit operator ElementCount(nint elements) => new((int)elements);

    public static explicit operator ElementCount(double elements) => new((int)elements);

    public static explicit operator ElementCount(float elements) => new((int)elements);

    public static implicit operator int(ElementCount elementCount) => elementCount.Value;

    public static explicit operator uint(ElementCount elementCount) => (uint)elementCount.Value;

    public static implicit operator long(ElementCount elementCount) => elementCount.Value;

    public static explicit operator ulong(ElementCount elementCount) => (nuint)elementCount.Value;

    public static implicit operator nint(ElementCount elementCount) => elementCount.Value;

    public static explicit operator nuint(ElementCount elementCount) => (nuint)elementCount.Value;

    public static implicit operator float(ElementCount elementCount) => elementCount.Value;

    public static implicit operator double(ElementCount elementCount) => elementCount.Value;

    public static ElementCount operator +(ElementCount left, ElementCount right) => left.Value + right.Value;

    public static ElementCount operator -(ElementCount left, ElementCount right) => left.Value - right.Value;

    public static ElementCount operator *(ElementCount left, ElementCount right) => left.Value * right.Value;

    public static ElementCount operator /(ElementCount left, ElementCount right) => left.Value / right.Value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ElementCount Of(ElementCount count) => count;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ElementCount Of(byte numElements) => numElements;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ElementCount Of(int numElements) => numElements;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ElementCount Of(uint numElements) => (int)numElements;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ElementCount Of(long numElements) => (ElementCount)numElements;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ElementCount Of(ulong numElements) => (int)numElements;
}
