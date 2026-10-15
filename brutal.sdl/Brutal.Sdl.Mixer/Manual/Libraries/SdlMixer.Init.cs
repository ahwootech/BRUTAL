namespace Brutal.SdlApi.Mixer;

public static unsafe partial class SdlMixer
{
    /// <summary>
    /// Shuts down SDL_mixer, releasing all mixers, tracks, audio and decoders it still owns.
    /// </summary>
    /// <remarks>
    /// Hand-written (rather than generated) so it also tears down this binding's managed callback
    /// state: it frees the <see cref="System.Runtime.InteropServices.GCHandle"/>s rooting any
    /// registered callback delegates and discards any parked callback exceptions (they refer to a
    /// session that is ending, so they are cleared rather than rethrown). Mirrors core's
    /// <c>Sdl.Init.Quit</c> teardown. Calling a mixer/track/group ergonomic method after this and
    /// before a fresh <c>MIX_Init</c> is undefined, exactly as in native SDL_mixer.
    /// </remarks>
    public static void Quit()
    {
        // Order is a memory-safety contract. MIX_Quit stops all audio output, closes the audio devices,
        // and destroys every mixer/track/group (see its header docs), so ONLY after it returns is the
        // audio device thread guaranteed to have stopped and no trampoline can fire again. The callback
        // GCHandles are the userdata those trampolines dereference, so they must be freed strictly AFTER
        // MIX_Quit — freeing them first (the previous order) left a window in which the still-running
        // audio thread could resolve a freed handle (undefined behaviour). Parked callback exceptions
        // refer to the session that is ending, so they are discarded (not rethrown) once no more can be
        // pushed.
        PInvoke.Quit();
        ClearCallbacks();
        ExceptionAggregator.Clear();
    }
}
