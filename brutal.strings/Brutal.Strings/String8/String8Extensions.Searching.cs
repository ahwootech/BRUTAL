namespace Brutal.Strings;

public static partial class String8Extensions
{
    public static bool Contains<TString8>(this TString8 str, String8View value)
        where TString8 : IString8, allows ref struct
    {
        return str.IndexOf(value) >= 0;
    }

    public static bool Contains<TString8>(this TString8 str, Char8 value)
        where TString8 : IString8, allows ref struct
    {
        return str.Chars.Contains(value);
    }

    // Returns the index of the first occurrence of a specified character in the current instance.
    // The search starts at startIndex and runs thorough the next count characters.
    public static int IndexOf<TString8>(this TString8 str, Char8 value)
        where TString8 : IString8, allows ref struct => str.Chars.IndexOf(value);

    public static int IndexOf<TString8>(this TString8 str, Char8 value, int startIndex)
        where TString8 : IString8, allows ref struct
    {
        return IndexOf(str, value, startIndex, str.Length - startIndex);
    }

    public static int IndexOf<TString8>(this TString8 str, Char8 value, int startIndex, int count)
        where TString8 : IString8, allows ref struct
    {
        var result = str.Chars.Slice(startIndex, count).IndexOf(value);
        return result < 0 ? result : result + startIndex;
    }

    // Returns the index of the first occurrence of any specified character in the current instance.
    // The search starts at startIndex and runs to startIndex + count - 1.
    //
    public static int IndexOfAny<TString8>(this TString8 str, String8View anyOf)
        where TString8 : IString8, allows ref struct
    {
        return str.Chars.IndexOfAny(anyOf);
    }

    public static int IndexOfAny<TString8>(this TString8 str, String8View anyOf, int startIndex)
        where TString8 : IString8, allows ref struct
    {
        return IndexOfAny(str, anyOf, startIndex, str.Length - startIndex);
    }

    public static int IndexOfAny<TString8>(this TString8 str, String8View anyOf, int startIndex, int count)
        where TString8 : IString8, allows ref struct
    {
        var result = str.Chars.Slice(startIndex, count).IndexOfAny(anyOf);
        return result < 0 ? result : result + startIndex;
    }

    public static int IndexOf<TString8>(this TString8 str, String8View value)
        where TString8 : IString8, allows ref struct
    {
        return str.Chars.IndexOf(value);
    }

    public static int IndexOf<TString8>(this TString8 str, String8View value, int startIndex)
        where TString8 : IString8, allows ref struct
    {
        var result = str.Chars[startIndex..].IndexOf(value);
        return result < 0 ? result : result + startIndex;
    }

    public static int IndexOf<TString8>(this TString8 str, String8View value, int startIndex, int count)
        where TString8 : IString8, allows ref struct
    {
        var result = str.Chars.Slice(startIndex, count).IndexOf(value);
        return result < 0 ? result : result + startIndex;
    }

    // Returns the index of the last occurrence of a specified character in the current instance.
    // The search starts at startIndex and runs backwards to startIndex - count + 1.
    // The character at position startIndex is included in the search.  startIndex is the larger
    // index within the string.
    public static int LastIndexOf<TString8>(this TString8 str, Char8 value)
        where TString8 : IString8, allows ref struct => str.Chars.LastIndexOf(value);

    public static int LastIndexOf<TString8>(this TString8 str, Char8 value, int startIndex)
        where TString8 : IString8, allows ref struct
    {
        return LastIndexOf(str, value, startIndex, startIndex + 1);
    }

    public static int LastIndexOf<TString8>(this TString8 str, Char8 value, int startIndex, int count)
        where TString8 : IString8, allows ref struct
    {
        var result = str.Chars.Slice(startIndex, count).LastIndexOf(value);
        return result < 0 ? result : result + startIndex;
    }

    // Returns the index of the last occurrence of any specified character in the current instance.
    // The search starts at startIndex and runs backwards to startIndex - count + 1.
    // The character at position startIndex is included in the search.  startIndex is the larger
    // index within the string.
    //
    public static int LastIndexOfAny<TString8>(this TString8 str, String8View anyOf)
        where TString8 : IString8, allows ref struct
    {
        return str.Chars.LastIndexOfAny(anyOf);
    }

    public static int LastIndexOfAny<TString8>(this TString8 str, String8View anyOf, int startIndex)
        where TString8 : IString8, allows ref struct
    {
        return LastIndexOfAny(str, anyOf, startIndex, startIndex + 1);
    }

    public static int LastIndexOfAny<TString8>(this TString8 str, String8View anyOf, int startIndex, int count)
        where TString8 : IString8, allows ref struct
    {
        var actualStartIndex = startIndex - count + 1;
        var result = str.Chars.Slice(actualStartIndex, count).LastIndexOfAny(anyOf);
        return result < 0 ? result : result + actualStartIndex;
    }

    // Returns the index of the last occurrence of any character in value in the current instance.
    // The search starts at startIndex and runs backwards to startIndex - count + 1.
    // The character at position startIndex is included in the search.  startIndex is the larger
    // index within the string.
    //
    public static int LastIndexOf<TString8>(this TString8 str, String8View value)
        where TString8 : IString8, allows ref struct
    {
        return LastIndexOf(str, value, str.Length - 1, str.Length);
    }

    public static int LastIndexOf<TString8>(this TString8 str, String8View value, int startIndex)
        where TString8 : IString8, allows ref struct
    {
        return LastIndexOf(str, value, startIndex, startIndex + 1);
    }

    public static int LastIndexOf<TString8>(this TString8 str, String8View value, int startIndex, int count)
        where TString8 : IString8, allows ref struct
    {
        var actualStartIndex = startIndex - count + 1;
        var result = str.Chars.Slice(actualStartIndex, count).LastIndexOf(value);
        return result < 0 ? result : result + actualStartIndex;
    }
}
