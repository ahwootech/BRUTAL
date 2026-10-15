namespace Brutal.Strings;

public partial struct ValueStringBuilder<TChar>
{
    /// Appends an interpolated string.
    public void Append([InterpolatedStringHandlerArgument("")] ref Interpolator handler)
    {
        // Interpolated content appended in a copy, just catch-up with position
        _position = handler.Position;
    }

    /// Appends an interpolated string followed by <see cref="NewLine"/>.
    public void AppendLine([InterpolatedStringHandlerArgument("")] ref Interpolator handler)
    {
        // Interpolated content appended in a copy, just catch-up with position
        _position = handler.Position;
        AppendLine();
    }

    /// <summary>
    /// Interpolated-string handler for <see cref="ValueStringBuilder{TChar}"/>.
    /// Not intended for direct use.
    /// </summary>
    /// <inheritdoc cref="StringBuilder{TChar}.Interpolator" path="/remarks"/>
    [InterpolatedStringHandler, EditorBrowsable(EditorBrowsableState.Never)]
    public ref struct Interpolator
    {
        /*
         * A handler can't hold a ref-struct builder by ref (CS9050) or a ref into it (eg ref sb._position),
         * so it holds a by-value COPY and Append(ref handler) copies the cursor back.
         * The copy shares the same buffer (Span-by-value = same memory),
         * so only the cursor diverges - copying back _position suffices.
         * A growable builder would copy back the full state (buffer ref + cursor),
         * since a grow re-points the span; VSB is fixed, so it doesn't arise.
         */
        /// Caution, this is a copy!
        private ValueStringBuilder<TChar> _sb;
        public int Position => _sb.Length;

        public Interpolator(int literalLength, int formattedCount, ValueStringBuilder<TChar> sb)
        {
            _sb = sb;
        }

        public void AppendLiteral(String16 value) => _sb.Append((String16View)value);

        public void AppendFormatted<T>(T value, int alignment = 0, String16? format = null) =>
            _sb.Append(value, alignment, format);

        // ref-struct holes can't flow through AppendFormatted<T> (no `allows ref struct`).
        public void AppendFormatted(String8View value, int alignment = 0, String16? format = null) =>
            _sb.Append(value, alignment);

        public void AppendFormatted(String16View value, int alignment = 0, String16? format = null) =>
            _sb.Append(value, alignment);

        public void AppendFormatted(String16? value, int alignment = 0, String16? format = null) =>
            _sb.Append((String16View)value, alignment);

        #region nested interpolation

        /// Builder position captured at construction; only used for nested interpolation alignment.
        private readonly int _start;

        /// Nested interpolation ctor for <see cref="AppendFormatted(Interpolator, int, String16?)"/>
        public Interpolator(int literalLength, int formattedCount, Interpolator parent)
            : this(literalLength, formattedCount, parent._sb)
        {
            _start = parent._sb.Length;
        }

        // Nested interpolation overload
        public void AppendFormatted(
            [InterpolatedStringHandlerArgument("")] scoped Interpolator nested,
            int alignment = 0,
            String16? format = null
        )
        {
            // Interpolated content appended in a copy, just catch-up with position, and align
            // NOTE: if VSB ever supports growing, we'd need to copy-back the span as well.
            _sb._position = nested.Position;
            _sb.AlignFrom(nested._start, alignment);
        }

        #endregion
    }
}
