namespace Brutal.Strings;

public interface IString<TChar>
    where TChar : unmanaged
{
    public ReadOnlySpan<TChar> Chars { get; }
    public int Length { get; }
    public bool IsEmpty { get; }

    public TChar this[int index] { get; }

    public ReadOnlySpan<TChar> AsSpan();
}
