namespace Brutal.Strings;

public interface IString8 : IString<Char8>
{
    public String16 ToString16();
}

public static class IString8Extensions
{
    public static void CopyTo<T>(this T source, Span<Char8> destination)
        where T : IString8, allows ref struct
    {
        source.Chars.CopyTo(destination);
    }
}
