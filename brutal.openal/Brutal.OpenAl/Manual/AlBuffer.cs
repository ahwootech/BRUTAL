// OpenAL buffers are ALuint object *names*, not pointers, so this is a value type over a uint.
// Hand-written half: data upload only; the identity half is generated.

namespace Brutal.OpenAlApi;

public readonly unsafe partial struct AlBuffer
{
    /// <summary>
    ///     Uploads PCM sample data to the buffer (<c>alBufferData</c>); the rate is in Hz. On a
    ///     callback buffer a successful upload also detaches the callback and releases its handler
    ///     (uploading data is the spec's own detach idiom - see <see cref="ClearCallback"/>).
    /// </summary>
    public void SetData(AlFormat format, ReadOnlySpan<byte> data, int sampleRate)
    {
        // Same protocol as ClearCallback: upstream clears the buffer's callback on a successful
        // upload, which reports failure only on the error latch - so the handler root is evicted
        // only once the buffer no longer holds its cookie. PeekCookie keeps this free for
        // non-callback consumers.
        var previous = PeekCookie(Name);
        fixed (byte* p = data)
            Al.PInvoke.BufferData(Name, (int)format, p, data.Length, sampleRate);
        if (previous != 0 && BoundCookie(Name) == 0)
            BufferCallbacks.TryRemove(previous, out _);
    }
}
