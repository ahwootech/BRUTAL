namespace System.Text.Unicode;

public static class Utf8Ex
{
    extension(Utf8)
    {
        /// <inheritdoc cref="Utf8.TryWrite(Span{byte}, ref Utf8.TryWriteInterpolatedStringHandler, out int)" />
        public static bool TryFormat<T>(
            T value,
            Span<byte> destination,
            out int bytesWritten,
            string? format = null,
            IFormatProvider? provider = null
        )
        {
            // Hijack TryWriteInterpolatedStringHandler, which handles all cases,
            // including some enum internals we don't have access to.
            var handler = new Utf8.TryWriteInterpolatedStringHandler(0, 1, destination, provider, out _);
            if (format == null)
                handler.AppendFormatted(value);
            else
                handler.AppendFormatted(value, format);

            // handler.AppendFormatted() already returns a success bool;
            // we only call TryWrite() to access bytesWritten, which is internal
            return Utf8.TryWrite([], ref handler, out bytesWritten);
        }
    }
}
