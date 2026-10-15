using Brutal.Pointers;

namespace Brutal;

public interface ISpanLike : INullable
{
    public Ptr Ptr { get; }
    public ElementCount Length { get; }
    public ByteSize Stride { get; }
    public bool IsEmpty { get; }

    public Span<T> AsSpan<T>()
        where T : unmanaged;
}

public interface ISpanLike<T> : ISpanLike
    where T : unmanaged
{
    public new Ptr<T> Ptr { get; }

    public Span<T> AsSpan();
}
