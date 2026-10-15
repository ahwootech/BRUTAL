namespace Brutal.Localization.FixedBuffers;

/// <summary>
/// Interface for types that provide fixed writable buffers.
/// A fixed buffer must not be movable by the GC. For example a stackalloc'd buffer
/// or an array you have manually fixed.
/// </summary>
/// <typeparam name="T">The type of the elements stored in the buffer.</typeparam>
public interface IFixedBufferWriter<T>
{
    /// <summary>
    /// Tells the buffer writer that a number of elements have been written and the buffer writer
    /// should advance its write position.
    /// </summary>
    /// <param name="count">The number of elements that were written.</param>
    /// <exception cref="ArgumentOutOfRangeException">Thrown if count moves the write position past the end of the writer's maximum position, or
    /// if count is negative. </exception>
    public void Advance(ElementCount count);

    /// <summary>
    /// Get a Span that can hold at least a specified number of elements.
    /// </summary>
    /// <param name="lengthHint">One of either:
    /// <list>
    /// <item>LengthHint.NonZeroLengthHint: Request a non-empty Span of unspecified length.</item>
    /// <item>LengthHint.MaxLengthHint: Request the largest Span possible.</item>
    /// <item>Otherwise, a specific Span length to return.</item>
    /// </list></param>
    /// <returns>A Span of the requested length or greater. Must never return an empty Span but can throw if the request cannot be fulfilled.</returns>
    public Span<T> GetSpan(ElementCount lengthHint);

    /// <summary>
    /// Try to get a Span that can hold at least a specified number of elements, returning whether it succeeded or not.
    /// </summary>
    /// <param name="lengthHint"> <inheritdoc cref="IFixedBufferWriter{T}.GetSpan(ElementCount)" /></param>
    /// <param name="spanOut">When this method returns, if successful, contains a Span of the requested length or greater . If not successful will contain the largest Span that could have been returned.</param>
    /// <returns>true if a Span of the requested length or greater is returned. Otherwise, false.</returns>
    public bool TryGetSpan(ElementCount lengthHint, out Span<T> spanOut);
}
