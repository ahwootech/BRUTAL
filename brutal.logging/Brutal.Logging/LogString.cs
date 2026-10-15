using System.ComponentModel;
using System.Runtime.CompilerServices;
using Brutal.Strings;
using Microsoft.Extensions.Logging;

namespace Brutal.Logging.Internal;

// NOTE: purposely not using static abstract here for potential .NET Standard compatibility.
[EditorBrowsable(EditorBrowsableState.Never)]
public interface ILogLevel
{
    LogLevel Level { get; }
}

[EditorBrowsable(EditorBrowsableState.Never)]
public readonly struct Trace : ILogLevel
{
    public LogLevel Level => LogLevel.Trace;
}

[EditorBrowsable(EditorBrowsableState.Never)]
public readonly struct Debug : ILogLevel
{
    public LogLevel Level => LogLevel.Debug;
}

[EditorBrowsable(EditorBrowsableState.Never)]
public readonly struct Information : ILogLevel
{
    public LogLevel Level => LogLevel.Information;
}

[EditorBrowsable(EditorBrowsableState.Never)]
public readonly struct Warning : ILogLevel
{
    public LogLevel Level => LogLevel.Warning;
}

[EditorBrowsable(EditorBrowsableState.Never)]
public readonly struct Error : ILogLevel
{
    public LogLevel Level => LogLevel.Error;
}

[EditorBrowsable(EditorBrowsableState.Never)]
public readonly struct Critical : ILogLevel
{
    public LogLevel Level => LogLevel.Critical;
}

[EditorBrowsable(EditorBrowsableState.Never)]
public readonly struct Dynamic : ILogLevel
{
    public LogLevel Level =>
        throw new InvalidOperationException(
            "LogString<Dynamic> must receive its LogLevel via the 5-param ctor; never call default(Dynamic).Level."
        );
}

/// Conditionally suppresses interpolation when the category is disabled. Compiler-only - not for manual construction.
[InterpolatedStringHandler, EditorBrowsable(EditorBrowsableState.Never)]
public readonly ref struct LogString<TLevel>
    where TLevel : unmanaged, ILogLevel
{
    private readonly StringBuilder<char>? _sb;

    public LogString(
        int literalLength,
        int formattedCount,
        LogCategory category,
        LogLevel logLevel,
        out bool shouldAppend
    )
    {
        shouldAppend = category.IsEnabled(logLevel);
        _sb = shouldAppend ? StringBuilderPool<char>.Shared.Get() : null;
    }

    public LogString(int literalLength, int formattedCount, LogCategory category, out bool shouldAppend)
        : this(literalLength, formattedCount, category, default(TLevel).Level, out shouldAppend) { }

    public void AppendLiteral(string value) => _sb?.Append(value);

    public void AppendFormatted<T>(T value, int alignment = 0, string? format = null) =>
        _sb?.Append(value, alignment, format);

    // ref-struct holes can't flow through AppendFormatted<T> (no `allows ref struct`).
    public void AppendFormatted(ReadOnlySpan<byte> value, int alignment = 0, string? format = null) =>
        _sb?.Append(value, alignment);

    public void AppendFormatted(ReadOnlySpan<char> value, int alignment = 0, string? format = null) =>
        _sb?.Append(value, alignment);

    public void AppendFormatted(string? value, int alignment = 0, string? format = null) =>
        _sb?.Append(value, alignment);

    #region string pass-through

    private readonly string? _message;

    private LogString(string message) => _message = message;

    public static implicit operator LogString<TLevel>(string message) => new(message);

    #endregion

    #region span pass-through

    private readonly ReadOnlySpan<char> _span;

    private LogString(ReadOnlySpan<char> message) => _span = message;

    public static implicit operator LogString<TLevel>(ReadOnlySpan<char> message) => new(message);

    /* Exposed as a raw span, not a "SpanToString"-style method: unlike ToStringAndClear, which
       LogCategory.Log must call unconditionally before the enabled guards (pool-return paranoia),
       a span holds no pooled resource, so its .ToString() can - and must - wait until after the
       guards, or every suppressed log pays for a string it never uses. */
    internal ReadOnlySpan<char> Span => _span;

    #endregion

    /// Don't call this twice as the StringBuilder will be returned to the pool.
    internal string? ToStringAndClear()
    {
        if (_message != null)
            return _message;

        if (_sb is null)
            return null;

        var result = _sb.WrittenSpan.ToString();
        StringBuilderPool<char>.Shared.Return(_sb);
        return result;
    }
}
