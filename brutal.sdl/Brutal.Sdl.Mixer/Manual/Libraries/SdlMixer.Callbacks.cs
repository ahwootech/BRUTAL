namespace Brutal.SdlApi.Mixer;

/// <summary>
/// A managed handler for <c>MIX_SetTrackStoppedCallback</c>: invoked when a track stops mixing (it
/// reached the end of its input, was stopped, or had its input removed).
/// </summary>
/// <remarks>
/// SDL_mixer fires this on its audio device thread. Any exception the handler throws is caught at the
/// native boundary, logged, and rethrown from managed code at the next mixer/track/group-touching
/// <see cref="SdlMixer"/> call or <see cref="SdlMixer.ThrowPendingCallbackExceptions"/> — it never
/// unwinds into native code.
/// </remarks>
/// <param name="track">The track that stopped.</param>
public delegate void MixTrackStoppedHandler(MixTrack track);

/// <summary>
/// A managed handler for <c>MIX_SetTrackRawCallback</c> / <c>MIX_SetTrackCookedCallback</c>: invoked
/// with a track's audio as it is mixed, so the handler can inspect or modify the PCM in place.
/// </summary>
/// <remarks>
/// Fired on SDL_mixer's audio device thread; exceptions are aggregated, never allowed to escape into
/// native code (see <see cref="MixTrackStoppedHandler"/>). The <paramref name="pcm"/> span aliases the
/// native buffer directly — writes to it modify the audio; do not retain it beyond the call.
/// </remarks>
/// <param name="track">The track being mixed.</param>
/// <param name="spec">The audio format of <paramref name="pcm"/>.</param>
/// <param name="pcm">The track's PCM sample buffer, writable in place.</param>
public delegate void MixTrackMixHandler(MixTrack track, in SdlAudioSpec spec, Span<float> pcm);

/// <summary>
/// A managed handler for <c>MIX_SetGroupPostMixCallback</c>: invoked with a group's combined audio
/// after its tracks are mixed together but before it is mixed into the final output.
/// </summary>
/// <remarks>Fired on SDL_mixer's audio device thread; exceptions are aggregated (see
/// <see cref="MixTrackStoppedHandler"/>). The <paramref name="pcm"/> span aliases the native buffer.</remarks>
/// <param name="group">The group being mixed.</param>
/// <param name="spec">The audio format of <paramref name="pcm"/>.</param>
/// <param name="pcm">The group's PCM sample buffer, writable in place.</param>
public delegate void MixGroupMixHandler(MixGroup group, in SdlAudioSpec spec, Span<float> pcm);

/// <summary>
/// A managed handler for <c>MIX_SetPostMixCallback</c>: invoked with the mixer's final audio, after
/// all tracks and groups are combined, just before it is sent to the audio device.
/// </summary>
/// <remarks>Fired on SDL_mixer's audio device thread; exceptions are aggregated (see
/// <see cref="MixTrackStoppedHandler"/>). The <paramref name="pcm"/> span aliases the native buffer.</remarks>
/// <param name="mixer">The mixer being mixed down.</param>
/// <param name="spec">The audio format of <paramref name="pcm"/>.</param>
/// <param name="pcm">The final PCM sample buffer, writable in place.</param>
public delegate void MixPostMixHandler(MixMixer mixer, in SdlAudioSpec spec, Span<float> pcm);

public static unsafe partial class SdlMixer
{
    // Which callback slot a registration occupies. SDL_mixer allows one callback of each kind per
    // object; a track can have all three of TrackStopped / TrackRaw / TrackCooked at once, so the kind
    // is part of the registry key (setting Raw must not disturb Cooked, and vice versa).
    private enum CallbackKind
    {
        TrackStopped,
        TrackRaw,
        TrackCooked,
        GroupPostMix,
        PostMix,
    }

    // Registered callback delegates, keyed by (native object pointer, kind). Each GCHandle roots the
    // managed delegate for as long as SDL_mixer holds the native trampoline pointer against that
    // object, and its IntPtr is the userdata SDL threads back to the trampoline so it can dispatch to
    // the right delegate. Guarded by a lock because SDL_mixer permits (un)registering from any thread,
    // and the audio thread reads the GCHandle target concurrently. Freed on replace, on clear (setting
    // a null handler), and wholesale on Quit.
    private static readonly Dictionary<(nint Object, CallbackKind Kind), GCHandle> Callbacks = new();
    private static readonly Lock CallbackLock = new();

    // ---- Race-safe callback (un)registration ---------------------------------------------------
    //
    // The order of "free the old GCHandle" vs "tell SDL_mixer to stop using its userdata" is a
    // memory-safety contract, not a nicety. SDL_mixer fires each callback from the audio device thread
    // (TrackGetCallback / MixerCallback in SDL_mixer.c) while holding the relevant SDL_AudioStream's
    // internal lock, and every MIX_Set*Callback setter takes that SAME lock (LockTrack/LockMixer ->
    // SDL_LockAudioStream) while it overwrites both the callback function pointer AND its userdata.
    // SDL_audio.h documents this explicitly: "this lock is held during callbacks ... locking the stream
    // guarantees that the callback is not running while the lock is held." Therefore, the instant a
    // MIX_Set*Callback call RETURNS, SDL guarantees the mixing thread can never again invoke the OLD
    // callback with the OLD userdata (to do so it would have to hold the stream lock, which the setter
    // held while atomically replacing both). So the old GCHandle is safe to free only AFTER the native
    // set returns — never before. The three helpers below split registration into that exact order:
    // PrepareCallback (alloc the new handle, touching nothing native yet) -> caller performs the native
    // MIX_Set*Callback -> CommitCallback on success (now race-safe to free the old handle) or
    // RollbackCallback on failure (native callback was NOT changed, so the old registration stays live
    // and only the speculative new handle is freed). Caller must hold CallbackLock for all three.

    // Phase 1: root the new delegate (if any) WITHOUT disturbing the existing registration, and return
    // the handle plus its IntPtr for use as native userdata. Returns (default, 0) for a null callback.
    private static (GCHandle NewHandle, nint Userdata) PrepareCallback(Delegate? callback)
    {
        if (callback is null)
            return (default, 0);

        var handle = GCHandle.Alloc(callback);
        return (handle, GCHandle.ToIntPtr(handle));
    }

    // Phase 2 (native set SUCCEEDED): SDL now points at the new callback/userdata and, per the stream
    // lock the setter took, will never invoke the old userdata again — so freeing the old GCHandle here
    // is race-safe. Records the new handle (or, for a clear, leaves the slot empty).
    private static void CommitCallback((nint, CallbackKind) key, GCHandle newHandle)
    {
        if (Callbacks.Remove(key, out var old))
            old.Free();

        if (newHandle.IsAllocated)
            Callbacks[key] = newHandle;
    }

    // Phase 2 (native set FAILED): MIX_Set*Callback failed before changing anything (it validates the
    // object and returns false without touching the callback), so the OLD registration is still live and
    // must be kept intact; free only the handle we speculatively allocated in PrepareCallback.
    private static void RollbackCallback(GCHandle newHandle)
    {
        if (newHandle.IsAllocated)
            newHandle.Free();
    }

    /// <summary>
    /// Sets (or, with a null <paramref name="callback"/>, clears) the handler invoked when
    /// <paramref name="track"/> stops mixing. Replaces any previously set track-stopped handler.
    /// </summary>
    /// <remarks>
    /// The handler is rooted by a <see cref="System.Runtime.InteropServices.GCHandle"/> for as long as it
    /// is registered. Replacing it (another call with a different handler) or clearing it (a call with
    /// <c>null</c>) frees the previous handle only AFTER SDL_mixer has stopped referencing it, and
    /// <see cref="SdlMixer.Quit"/> frees any still-registered handles after <c>MIX_Quit</c> returns — so a
    /// registered handler is retained until it is replaced, cleared, or the library is shut down (a bounded
    /// retention matching SDL_mixer's own model, not an unbounded leak). Prefer registering a callback
    /// before the object is driving audio rather than hot-swapping it under active playback.
    /// </remarks>
    /// <param name="track">The track to configure.</param>
    /// <param name="callback">The handler to invoke, or <c>null</c> to remove the current one.</param>
    /// <exception cref="SdlException">SDL_mixer failed to set the callback.</exception>
    /// <exception cref="SdlCallbackException">A previously parked callback exception surfaced.</exception>
    /// <exception cref="AggregateException">More than one parked callback exception surfaced.</exception>
    public static void SetTrackStoppedCallback(MixTrack track, MixTrackStoppedHandler? callback)
    {
        ExceptionAggregator.CheckExceptions();
        var key = (track.Pointer.Value, CallbackKind.TrackStopped);
        lock (CallbackLock)
        {
            var (newHandle, userdata) = PrepareCallback(callback);
            delegate* unmanaged[Cdecl]<void*, MixTrack, void> fn = callback is null ? null : &TrackStoppedTrampoline;
            if (PInvoke.SetTrackStoppedCallback(track, fn, (void*)userdata) == 0)
            {
                RollbackCallback(newHandle);
                throw SdlException.FromError("MIX_SetTrackStoppedCallback failed");
            }
            CommitCallback(key, newHandle);
        }
    }

    /// <summary>
    /// Sets (or, with a null <paramref name="callback"/>, clears) the raw (pre-processing) mix handler
    /// for <paramref name="track"/> — the track's audio before SDL_mixer applies gain, fades, etc.
    /// </summary>
    /// <remarks>
    /// The handler is rooted by a <see cref="System.Runtime.InteropServices.GCHandle"/> for as long as it
    /// is registered. Replacing it (another call with a different handler) or clearing it (a call with
    /// <c>null</c>) frees the previous handle only AFTER SDL_mixer has stopped referencing it, and
    /// <see cref="SdlMixer.Quit"/> frees any still-registered handles after <c>MIX_Quit</c> returns — so a
    /// registered handler is retained until it is replaced, cleared, or the library is shut down (a bounded
    /// retention matching SDL_mixer's own model, not an unbounded leak). Prefer registering a callback
    /// before the object is driving audio rather than hot-swapping it under active playback.
    /// </remarks>
    /// <param name="track">The track to configure.</param>
    /// <param name="callback">The handler to invoke, or <c>null</c> to remove the current one.</param>
    /// <exception cref="SdlException">SDL_mixer failed to set the callback.</exception>
    /// <exception cref="SdlCallbackException">A previously parked callback exception surfaced.</exception>
    /// <exception cref="AggregateException">More than one parked callback exception surfaced.</exception>
    public static void SetTrackRawCallback(MixTrack track, MixTrackMixHandler? callback)
    {
        ExceptionAggregator.CheckExceptions();
        var key = (track.Pointer.Value, CallbackKind.TrackRaw);
        lock (CallbackLock)
        {
            var (newHandle, userdata) = PrepareCallback(callback);
            delegate* unmanaged[Cdecl]<void*, MixTrack, SdlAudioSpec*, float*, int, void> fn = callback is null
                ? null
                : &TrackMixTrampoline;
            if (PInvoke.SetTrackRawCallback(track, fn, (void*)userdata) == 0)
            {
                RollbackCallback(newHandle);
                throw SdlException.FromError("MIX_SetTrackRawCallback failed");
            }
            CommitCallback(key, newHandle);
        }
    }

    /// <summary>
    /// Sets (or, with a null <paramref name="callback"/>, clears) the cooked (post-processing) mix
    /// handler for <paramref name="track"/> — the track's audio after SDL_mixer applies its transforms.
    /// </summary>
    /// <remarks>
    /// The handler is rooted by a <see cref="System.Runtime.InteropServices.GCHandle"/> for as long as it
    /// is registered. Replacing it (another call with a different handler) or clearing it (a call with
    /// <c>null</c>) frees the previous handle only AFTER SDL_mixer has stopped referencing it, and
    /// <see cref="SdlMixer.Quit"/> frees any still-registered handles after <c>MIX_Quit</c> returns — so a
    /// registered handler is retained until it is replaced, cleared, or the library is shut down (a bounded
    /// retention matching SDL_mixer's own model, not an unbounded leak). Prefer registering a callback
    /// before the object is driving audio rather than hot-swapping it under active playback.
    /// </remarks>
    /// <param name="track">The track to configure.</param>
    /// <param name="callback">The handler to invoke, or <c>null</c> to remove the current one.</param>
    /// <exception cref="SdlException">SDL_mixer failed to set the callback.</exception>
    /// <exception cref="SdlCallbackException">A previously parked callback exception surfaced.</exception>
    /// <exception cref="AggregateException">More than one parked callback exception surfaced.</exception>
    public static void SetTrackCookedCallback(MixTrack track, MixTrackMixHandler? callback)
    {
        ExceptionAggregator.CheckExceptions();
        var key = (track.Pointer.Value, CallbackKind.TrackCooked);
        lock (CallbackLock)
        {
            var (newHandle, userdata) = PrepareCallback(callback);
            delegate* unmanaged[Cdecl]<void*, MixTrack, SdlAudioSpec*, float*, int, void> fn = callback is null
                ? null
                : &TrackMixTrampoline;
            if (PInvoke.SetTrackCookedCallback(track, fn, (void*)userdata) == 0)
            {
                RollbackCallback(newHandle);
                throw SdlException.FromError("MIX_SetTrackCookedCallback failed");
            }
            CommitCallback(key, newHandle);
        }
    }

    /// <summary>
    /// Sets (or, with a null <paramref name="callback"/>, clears) the post-mix handler for
    /// <paramref name="group"/> — its tracks' combined audio, before it mixes into the final output.
    /// </summary>
    /// <remarks>
    /// The handler is rooted by a <see cref="System.Runtime.InteropServices.GCHandle"/> for as long as it
    /// is registered. Replacing it (another call with a different handler) or clearing it (a call with
    /// <c>null</c>) frees the previous handle only AFTER SDL_mixer has stopped referencing it, and
    /// <see cref="SdlMixer.Quit"/> frees any still-registered handles after <c>MIX_Quit</c> returns — so a
    /// registered handler is retained until it is replaced, cleared, or the library is shut down (a bounded
    /// retention matching SDL_mixer's own model, not an unbounded leak). Prefer registering a callback
    /// before the object is driving audio rather than hot-swapping it under active playback.
    /// </remarks>
    /// <param name="group">The group to configure.</param>
    /// <param name="callback">The handler to invoke, or <c>null</c> to remove the current one.</param>
    /// <exception cref="SdlException">SDL_mixer failed to set the callback.</exception>
    /// <exception cref="SdlCallbackException">A previously parked callback exception surfaced.</exception>
    /// <exception cref="AggregateException">More than one parked callback exception surfaced.</exception>
    public static void SetGroupPostMixCallback(MixGroup group, MixGroupMixHandler? callback)
    {
        ExceptionAggregator.CheckExceptions();
        var key = (group.Pointer.Value, CallbackKind.GroupPostMix);
        lock (CallbackLock)
        {
            var (newHandle, userdata) = PrepareCallback(callback);
            delegate* unmanaged[Cdecl]<void*, MixGroup, SdlAudioSpec*, float*, int, void> fn = callback is null
                ? null
                : &GroupMixTrampoline;
            if (PInvoke.SetGroupPostMixCallback(group, fn, (void*)userdata) == 0)
            {
                RollbackCallback(newHandle);
                throw SdlException.FromError("MIX_SetGroupPostMixCallback failed");
            }
            CommitCallback(key, newHandle);
        }
    }

    /// <summary>
    /// Sets (or, with a null <paramref name="callback"/>, clears) the post-mix handler for
    /// <paramref name="mixer"/> — its final combined audio, just before it is sent to the device.
    /// </summary>
    /// <remarks>
    /// The handler is rooted by a <see cref="System.Runtime.InteropServices.GCHandle"/> for as long as it
    /// is registered. Replacing it (another call with a different handler) or clearing it (a call with
    /// <c>null</c>) frees the previous handle only AFTER SDL_mixer has stopped referencing it, and
    /// <see cref="SdlMixer.Quit"/> frees any still-registered handles after <c>MIX_Quit</c> returns — so a
    /// registered handler is retained until it is replaced, cleared, or the library is shut down (a bounded
    /// retention matching SDL_mixer's own model, not an unbounded leak). Prefer registering a callback
    /// before the object is driving audio rather than hot-swapping it under active playback.
    /// </remarks>
    /// <param name="mixer">The mixer to configure.</param>
    /// <param name="callback">The handler to invoke, or <c>null</c> to remove the current one.</param>
    /// <exception cref="SdlException">SDL_mixer failed to set the callback.</exception>
    /// <exception cref="SdlCallbackException">A previously parked callback exception surfaced.</exception>
    /// <exception cref="AggregateException">More than one parked callback exception surfaced.</exception>
    public static void SetPostMixCallback(MixMixer mixer, MixPostMixHandler? callback)
    {
        ExceptionAggregator.CheckExceptions();
        var key = (mixer.Pointer.Value, CallbackKind.PostMix);
        lock (CallbackLock)
        {
            var (newHandle, userdata) = PrepareCallback(callback);
            delegate* unmanaged[Cdecl]<void*, MixMixer, SdlAudioSpec*, float*, int, void> fn = callback is null
                ? null
                : &PostMixTrampoline;
            if (PInvoke.SetPostMixCallback(mixer, fn, (void*)userdata) == 0)
            {
                RollbackCallback(newHandle);
                throw SdlException.FromError("MIX_SetPostMixCallback failed");
            }
            CommitCallback(key, newHandle);
        }
    }

    // Frees every GCHandle rooting a registered callback delegate and empties the registry. Called by
    // Quit AFTER MIX_Quit() has returned — by then the audio device thread is stopped and the native
    // callback registrations are gone, so no trampoline can fire against these handles and freeing them
    // is race-safe (see Quit for why the order matters). Without this the GCHandles would leak across a
    // MIX_Quit/MIX_Init cycle and a re-registration of the same object pointer could mis-resolve.
    // Mirrors core's Sdl.Events.ClearWatches.
    internal static void ClearCallbacks()
    {
        lock (CallbackLock)
        {
            foreach (var (_, handle) in Callbacks)
                handle.Free();
            Callbacks.Clear();
        }
    }

    // ---- Trampolines ---------------------------------------------------------------------------
    //
    // The single native entry point for each callback family. SDL_mixer passes the GCHandle IntPtr back
    // as userdata; we resolve it to the managed delegate and invoke it inside a try/catch so NO
    // exception ever escapes into the native audio thread. Failures (and a dead/foreign GCHandle) are
    // parked on the shared aggregator and rethrown from managed code at the next drain point.

    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl)])]
    private static void TrackStoppedTrampoline(void* userdata, MixTrack track)
    {
        try
        {
            if (GCHandle.FromIntPtr((nint)userdata).Target is MixTrackStoppedHandler handler)
                handler(track);
            else
                ExceptionAggregator.Push(DeadHandleMessage("track-stopped"));
        }
        catch (Exception ex)
        {
            ExceptionAggregator.Push("An exception occurred in an SDL_mixer track-stopped callback.", ex);
        }
    }

    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl)])]
    private static void TrackMixTrampoline(void* userdata, MixTrack track, SdlAudioSpec* spec, float* pcm, int samples)
    {
        try
        {
            if (GCHandle.FromIntPtr((nint)userdata).Target is MixTrackMixHandler handler)
                handler(track, in *spec, new Span<float>(pcm, samples));
            else
                ExceptionAggregator.Push(DeadHandleMessage("track mix"));
        }
        catch (Exception ex)
        {
            ExceptionAggregator.Push("An exception occurred in an SDL_mixer track mix callback.", ex);
        }
    }

    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl)])]
    private static void GroupMixTrampoline(void* userdata, MixGroup group, SdlAudioSpec* spec, float* pcm, int samples)
    {
        try
        {
            if (GCHandle.FromIntPtr((nint)userdata).Target is MixGroupMixHandler handler)
                handler(group, in *spec, new Span<float>(pcm, samples));
            else
                ExceptionAggregator.Push(DeadHandleMessage("group post-mix"));
        }
        catch (Exception ex)
        {
            ExceptionAggregator.Push("An exception occurred in an SDL_mixer group post-mix callback.", ex);
        }
    }

    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl)])]
    private static void PostMixTrampoline(void* userdata, MixMixer mixer, SdlAudioSpec* spec, float* pcm, int samples)
    {
        try
        {
            if (GCHandle.FromIntPtr((nint)userdata).Target is MixPostMixHandler handler)
                handler(mixer, in *spec, new Span<float>(pcm, samples));
            else
                ExceptionAggregator.Push(DeadHandleMessage("post-mix"));
        }
        catch (Exception ex)
        {
            ExceptionAggregator.Push("An exception occurred in an SDL_mixer post-mix callback.", ex);
        }
    }

    // The GCHandle resolved but its target is not the expected handler type: it was freed (dead) or
    // belongs to something else (foreign). Falling through silently would hide a real lifecycle bug, so
    // surface it through the aggregator rather than swallowing it.
    private static string DeadHandleMessage(string family) =>
        $"An SDL_mixer {family} callback fired with a dead or foreign GCHandle (its target was not the "
        + "expected handler); the callback was skipped.";
}
