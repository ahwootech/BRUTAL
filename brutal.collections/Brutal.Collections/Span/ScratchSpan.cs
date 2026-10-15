using System.Buffers;
using System.Runtime.CompilerServices;

namespace Brutal.Collections.Experimental;

/// <summary>
/// Stackalloc-or-rent scratch buffer.
/// <see cref="Span"/> is backed by the stack buffer if it's big enough,
/// else by an array rented from <see cref="ArrayPool{T}"/>.
/// <see cref="Dispose"/> returns any rented array to the pool.
/// </summary>
/// <remarks>Usage:<code>
/// using (var scratch = new ScratchSpan&lt;T&gt;(requiredLength, stackalloc T[256]))
/// {
///     var buf = scratch.Span; // length == required, backed by stack or pool
///     // ...
/// }
/// </code></remarks>
public readonly ref struct ScratchSpan<T>
{
    private readonly T[]? _rented;

    /// <summary>The scratch span of exactly <c>requiredLength</c> elements.</summary>
    public Span<T> Span { get; }

    public static implicit operator Span<T>(ScratchSpan<T> scratch) => scratch.Span;

    /// <summary>Construct a ScratchSpan, get the result in <see cref="Span"/>.</summary>
    /// <param name="requiredLength">Number of elements the caller needs.</param>
    /// <param name="stackBuffer">Stack-allocated tentative buffer to use if large enough, otherwise an array is rented.</param>
    public ScratchSpan(int requiredLength, Span<T> stackBuffer)
    {
        Span = requiredLength <= stackBuffer.Length ? stackBuffer : _rented = ArrayPool<T>.Shared.Rent(requiredLength);
        Span = Span[..requiredLength];
    }

    /// <summary>Alternative form where <see cref="Span"/> is output directly to <paramref name="span"/>.</summary>
    /// <param name="requiredLength">Number of elements the caller needs.</param>
    /// <param name="stackBuffer">Stack-allocated tentative buffer to use if large enough, otherwise an array is rented.</param>
    /// <param name="span">Output span of exactly <paramref name="requiredLength"/> elements, backed by either <paramref name="stackBuffer"/> or a rented array.</param>
    public ScratchSpan(int requiredLength, Span<T> stackBuffer, out Span<T> span)
        : this(requiredLength, stackBuffer)
    {
        span = Span;
    }

    /// Returns any rented array to the pool. No-op if the stack buffer was used.
    public void Dispose()
    {
        if (_rented != null)
            ArrayPool<T>.Shared.Return(_rented, clearArray: RuntimeHelpers.IsReferenceOrContainsReferences<T>());
    }
}
