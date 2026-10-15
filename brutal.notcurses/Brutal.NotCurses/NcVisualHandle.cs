using Brutal.Pointers;

namespace Brutal.NotCursesApi;

/// <summary>
/// Hand-written ergonomics for the notcurses visual handle. Most instance methods (incl.
/// <see cref="Destroy"/>) are auto-generated in <c>Generated/Wrappers.gen.cs</c>; this file adds
/// the static factory for raw RGBA pixel data and the <see cref="IDisposable"/> contract.
/// </summary>
public readonly unsafe partial struct NcVisualHandle : IDisposable
{
    /// <summary>
    /// Creates a visual from a flat row-major RGBA8888 pixel buffer. The buffer is copied internally,
    /// so the caller doesn't need to keep it alive.
    /// </summary>
    /// <param name="rgba">Pixel data, <paramref name="rows"/> × <paramref name="cols"/> × 4 bytes.</param>
    /// <param name="rows">Image height in pixels.</param>
    /// <param name="cols">Image width in pixels.</param>
    public static NcVisualHandle FromRgba(ReadOnlySpan<byte> rgba, int rows, int cols)
    {
        if (rgba.Length < rows * cols * 4)
            throw new ArgumentException(
                $"RGBA buffer is {rgba.Length} bytes but {rows * cols * 4} were expected.",
                nameof(rgba)
            );
        fixed (byte* p = rgba)
        {
            var v = NotCurses.PInvoke.ncvisual_from_rgba(new Ptr(p), rows, cols * 4, cols);
            if (v.IsNull())
                throw new InvalidOperationException("ncvisual_from_rgba failed.");
            return v;
        }
    }

    /// <summary>Releases the visual and any plane it owns. Calls <see cref="Destroy"/>.</summary>
    public void Dispose() => Destroy();
}
