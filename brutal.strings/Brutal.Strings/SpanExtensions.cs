namespace Brutal.Strings.Extensions;

public static class SpanExtensions
{
    public static String16 ToString16(this Span<Char8> span)
    {
        return Utf8.GetString(span);
    }

    public static String16 ToString16(this String8View span)
    {
        return Utf8.GetString(span);
    }
}
