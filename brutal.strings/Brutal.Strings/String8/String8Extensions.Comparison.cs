namespace Brutal.Strings;

public static partial class String8Extensions
{
    private static class Helpers
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int CompareOrdinalHelper(
            String8View strA,
            int indexA,
            int countA,
            String8View strB,
            int indexB,
            int countB
        )
        {
            Debug.Assert(!strA.IsEmpty);
            Debug.Assert(!strB.IsEmpty);
            Debug.Assert(indexA >= 0 && indexB >= 0);
            Debug.Assert(countA >= 0 && countB >= 0);
            Debug.Assert(indexA + countA <= strA.Length && indexB + countB <= strB.Length);

            return strA.Slice(indexA, countA).SequenceCompareTo(strB.Slice(indexB, countB));
        }

        public static int CompareOrdinalHelper(String8View strA, String8View strB)
        {
            return strA.SequenceCompareTo(strB);
        }
    }

    // Provides an ordinal string comparison. strA is compared to strB
    // to determine whether it is lexicographically less, equal, or greater, and then a
    // negative integer, 0, or a positive integer is returned; respectively.
    public static int Compare<TString8>(this TString8 strA, String8View strB)
        where TString8 : IString8, allows ref struct
    {
        // They can't both be null at this point.
        if (strA.IsEmpty)
        {
            return -1;
        }

        if (strB.IsEmpty)
        {
            return 1;
        }

        return Helpers.CompareOrdinalHelper(strA.Chars, strB);
    }

    // Compares strA and strB using an ordinal (code-point) comparison.
    public static int Compare<TString8>(this TString8 strA, int indexA, String8View strB, int indexB, int length)
        where TString8 : IString8, allows ref struct
    {
        if (strA.IsEmpty || strB.IsEmpty)
        {
            return strA.IsEmpty ? -1 : 1;
        }

        ArgumentOutOfRangeException.ThrowIfNegative(length);

        if (indexA < 0 || indexB < 0)
        {
            string paramName = indexA < 0 ? nameof(indexA) : nameof(indexB);
            throw new ArgumentOutOfRangeException(paramName, "Index cannot be negative.");
        }

        int lengthA = Math.Min(length, strA.Length - indexA);
        int lengthB = Math.Min(length, strB.Length - indexB);

        if (lengthA < 0 || lengthB < 0)
        {
            string paramName = lengthA < 0 ? nameof(indexA) : nameof(indexB);
            throw new ArgumentOutOfRangeException(
                paramName,
                "Index and length must refer to a location within the string."
            );
        }

        if (length == 0)
        {
            return 0;
        }

        return Helpers.CompareOrdinalHelper(strA.Chars, indexA, lengthA, strB, indexB, lengthB);
    }

    // Determines whether a specified string is a suffix of the current instance.
    public static bool EndsWith<TString8>(this TString8 str, String8View value)
        where TString8 : IString8, allows ref struct
    {
        int offset = str.Length - value.Length;
        return (uint)offset <= (uint)str.Length && str.Chars[offset..].SequenceEqual(value);
    }

    public static bool EndsWith<TString8>(this TString8 str, Char8 value)
        where TString8 : IString8, allows ref struct
    {
        int lastPos = str.Length - 1;
        return ((uint)lastPos < (uint)str.Length) && str[lastPos].Equals(value);
    }

    // Determines whether a specified string is a prefix of the current instance
    public static bool StartsWith<TString8>(this TString8 str, String8View value)
        where TString8 : IString8, allows ref struct
    {
        if (value.IsEmpty)
        {
            return true;
        }

        if (value.Length > str.Length)
        {
            return false;
        }

        return str.Chars[..value.Length].SequenceEqual(value);
    }

    public static bool StartsWith<TString8>(this TString8 str, Char8 value)
        where TString8 : IString8, allows ref struct
    {
        return str.Length != 0 && str[0].Equals(value);
    }
}
