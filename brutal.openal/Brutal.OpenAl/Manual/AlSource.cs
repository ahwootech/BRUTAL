// Like AlBuffer, an OpenAL source is an ALuint object *name*, not a pointer - a value type over a
// uint.
//
// Hand-written half: the queue span operations and the auxiliary send. Everything else is
// generated (identity, playback verbs, named properties) or lives elsewhere (keyed access in the
// opt-in Params namespace, the latency/clock getters in AlSource.Ext.cs).

namespace Brutal.OpenAlApi;

public readonly unsafe partial struct AlSource
{
    /// <summary>
    ///     Queues buffers onto the source, in playback order, for streaming playback
    ///     (<c>alSourceQueueBuffers</c>).
    /// </summary>
    public void QueueBuffers(ReadOnlySpan<AlBuffer> buffers)
    {
        if (buffers.IsEmpty)
            return;

        var names = MemoryMarshal.Cast<AlBuffer, uint>(buffers);
        fixed (uint* p = names)
            Al.PInvoke.SourceQueueBuffers(Name, names.Length, p);
    }

    /// <summary>
    ///     Removes processed buffers from the front of the source's queue
    ///     (<c>alSourceUnqueueBuffers</c>), filling <paramref name="buffers"/> with the removed
    ///     buffer names. The span's length determines how many are unqueued and must not exceed the
    ///     number of processed buffers on the source.
    /// </summary>
    public void UnqueueBuffers(Span<AlBuffer> buffers)
    {
        if (buffers.IsEmpty)
            return;

        var names = MemoryMarshal.Cast<AlBuffer, uint>(buffers);
        fixed (uint* p = names)
            Al.PInvoke.SourceUnqueueBuffers(Name, names.Length, p);
    }

    /// <summary>
    ///     Routes this source to an auxiliary effect slot (<c>AL_AUXILIARY_SEND_FILTER</c>,
    ///     <c>alSource3i</c>), optionally through a wet-path filter (<see cref="AlFilter.Null"/>,
    ///     the default, means unfiltered). Pass <see cref="AlAuxiliaryEffectSlot.Null"/> to disable
    ///     the send. Send indices run <c>0</c> to <see cref="Efx.MaxAuxiliarySends"/> - 1.
    /// </summary>
    public void SetAuxiliarySend(AlAuxiliaryEffectSlot slot, int send, AlFilter filter = default)
    {
        Al.PInvoke.Source3i(Name, Al.Constants.AL_AUXILIARY_SEND_FILTER, (int)slot.Name, send, (int)filter.Name);
    }
}
