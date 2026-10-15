using Brutal.Strings;

[assembly: DebuggerTypeProxy(typeof(ByteSpanDebugView), Target = typeof(ReadOnlySpan<byte>))]
[assembly: DebuggerDisplay(
    "{Brutal.Strings.ByteSpanDebugView.DebuggerDisplay(this)}",
    Target = typeof(ReadOnlySpan<byte>)
)]
[assembly: DebuggerTypeProxy(typeof(ByteSpanDebugView), Target = typeof(Span<byte>))]
[assembly: DebuggerDisplay("{Brutal.Strings.ByteSpanDebugView.DebuggerDisplay(this)}", Target = typeof(Span<byte>))]
[assembly: DebuggerTypeProxy(typeof(ByteSpanDebugView), Target = typeof(Ptr<byte>))]
[assembly: DebuggerDisplay("{Brutal.Strings.ByteSpanDebugView.DebuggerDisplay(this)}", Target = typeof(Ptr<byte>))]

namespace Brutal.Strings;

/// <summary>
/// Allows viewing byte spans as UTF8 strings in the IDE.
/// Does some guesswork (not-100% accurate) to figure out if a span looks like a string vs binary data.
///
/// Supports <see cref="ReadOnlySpan{T}">ReadOnlySpan&lt;byte&gt;</see>, <see cref="Span{T}">Span&lt;byte&gt;</see>, <see cref="Ptr{T}">Ptr&lt;byte&gt;</see>.
/// The containing assembly has to be loaded for the debug view to work.
///
/// Source: https://github.com/dotnet/dotnet/blob/main/src/runtime/src/libraries/System.Private.CoreLib/src/System/SpanDebugView.cs
/// </summary>
internal sealed class ByteSpanDebugView
{
    public record struct KindContainer(Kind Kind);

    [DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
    public readonly KindContainer AKind; // hack so that Kind appears first in the view (debugger sorts on field name, using ASCII sort: 'A', then '_', then 'a')

    public readonly string AsUtf8String;

    [DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
    public readonly byte[] Items;

    public ByteSpanDebugView(ReadOnlySpan<byte> value)
    {
        (var kind, AsUtf8String) = GetInfo(value);
        AKind = new KindContainer(kind);
        Items = value.ToArray();
    }

    public ByteSpanDebugView(Span<byte> span)
        : this((ReadOnlySpan<byte>)span) { }

    public ByteSpanDebugView(Ptr<byte> ptr)
        : this(Utf8.GetNullTerminatedSpan(ptr)) { }

    public enum Kind
    {
        NotEvaluated,
        Binary,
        BinaryMaybe,
        Ascii,
        Ansi,
        Unicode,
    }

    static Kind GuessKind(ReadOnlySpan<char> span)
    {
        var maxChar = 0;
        foreach (var c in span)
        {
            if (char.IsControl(c)) // non-displayable character
                return Kind.BinaryMaybe;
            maxChar = Math.Max(maxChar, c);
        }

        return maxChar < 256
            ? maxChar < 128
                ? Kind.Ascii
                : Kind.Ansi
            : Kind.Unicode;
    }

    static (Kind kind, string value) GetInfo(ReadOnlySpan<byte> value)
    {
        const int maxLength = 128;
        if (value.Length > maxLength)
            return (
                Kind.NotEvaluated,
                $"<Too big, string evaluation disabled (length {value.Length}, max {maxLength})>"
            );

        if (!Utf8.IsValid(value))
            return (Kind.Binary, "<Binary>");

        var str = Utf8.GetString(value);
        var kind = GuessKind(str);
        return (kind, str);
    }

    static string DebuggerDisplayInternal(ReadOnlySpan<byte> value)
    {
        var (kind, str) = GetInfo(value);
        return kind == Kind.BinaryMaybe ? $"<Binary?> {str}" : str;
    }

    static string DebuggerDisplay<T>(ReadOnlySpan<T> value)
    //where T : unmanaged  // don't add constraints, they break the [assembly: DebuggerDisplay] association...
    {
        Debug.Assert(
            typeof(T) == typeof(byte),
            "[DebuggerDisplay] requires a generic signature, but we expect only T=byte"
        );
        var bytes = Unsafe.As<ReadOnlySpan<T>, ReadOnlySpan<byte>>(ref value);
        return DebuggerDisplayInternal(bytes);
    }

    public static string DebuggerDisplay<T>(Ptr<T> value)
        where T : unmanaged
    {
        Debug.Assert(
            typeof(T) == typeof(byte),
            "[DebuggerDisplay] requires a generic signature, but we expect only T=byte"
        );
        var span = Utf8.GetNullTerminatedSpan(value.Cast<byte>());
        return DebuggerDisplay(span);
    }
}
