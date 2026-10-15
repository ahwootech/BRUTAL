namespace Brutal.Strings;

public partial class StringBuilder<TChar>
{
    /// Appends an interpolated string.
    public void Append([InterpolatedStringHandlerArgument("")] ref Interpolator handler)
    {
        // No-op: the handler writes directly into this builder as it is constructed,
        // so by the time this method runs, the content is already appended.
    }

    /// Appends an interpolated string followed by <see cref="NewLine"/>.
    public void AppendLine([InterpolatedStringHandlerArgument("")] ref Interpolator handler)
    {
        // Interpolated content already appended during handler construction; only add the newline.
        AppendLine();
    }

    /// <summary>
    /// Interpolated-string handler for <see cref="StringBuilder{TChar}"/>.
    /// Not intended for direct use.
    /// </summary>
    /// <remarks>
    /// Lean by design:
    /// - Value-type holes flow through the generic <c>AppendFormatted&lt;T&gt;</c> kitchen-sink via <see cref="Utf{TChar}.TryFormat"/>.
    /// - Char-span and byte-span holes need explicit overloads (ref structs can't flow through generic <c>T</c>).
    /// - String holes are fast-tracked to avoid the kitchen-sink
    /// - Nested holes (<c>$"outer {$"inner"}"</c>) write through into the same builder, zero-alloc - no temp string.
    /// </remarks>
    [InterpolatedStringHandler, EditorBrowsable(EditorBrowsableState.Never)]
    public readonly ref struct Interpolator
    {
        private readonly StringBuilder<TChar> _sb;

        public Interpolator(int literalLength, int formattedCount, StringBuilder<TChar> sb)
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
            _start = parent._sb._position;
        }

        // Nested interpolation overload
        public void AppendFormatted(
            [InterpolatedStringHandlerArgument("")] Interpolator nested,
            int alignment = 0,
            String16? format = null
        )
        {
            // Nested hole writes into our own _sb, so by the time control returns here, `nested` has already appended.
            // The only thing left to do is potentially aligning.
            _sb.AlignFrom(nested._start, alignment);
        }

        #endregion
    }
}
