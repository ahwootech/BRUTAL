namespace Brutal.ImGuiApi;

public ref partial struct ImString
{
    /*
     * This partial provides helpers to interface with APIs that take regular C# strings.
     * Ideally should be removed in a stricter implementation, to avoid accidental conversions.
     * Also, the StringPool dictionary is naive, leaks etc.
     */

    // TODO: I would like to make the string conversion operator explicit,
    // unfortunately it is necessary to support ImString inside DefaultInterpolatedStringHandler...
    public static implicit operator string(in ImString s) => s.ToString();

    private class StringPool
    {
        private readonly Dictionary<int, string> _utf8ToString = new();

        public string ToString(ReadOnlySpan<byte> bytes)
        {
            var hash = new HashCode();
            hash.AddBytes(bytes);
            var key = hash.ToHashCode();
            if (!_utf8ToString.TryGetValue(key, out var toString))
            {
                toString = Utf8.GetString(bytes);
                _utf8ToString.Add(key, toString);
            }
            return toString;
        }
    }

    private static readonly StringPool SharedStringPool = new();
    public static bool CacheToString = true;

    public override string ToString()
    {
        if (!CacheToString)
            return Utf8.GetString(_bytes);
        return SharedStringPool.ToString(_bytes);
    }
}
