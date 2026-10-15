// Handle-less AL operations: listener and global state, and GetString/GetExtensions. Handle-first
// operations are members on AlSource/AlBuffer; the Gen*/Delete* span methods are generated.
// Nothing here checks the AL error state automatically (call Al.ThrowIfError() explicitly), and
// handle inputs are not pre-validated: a bad object name sets AL_INVALID_NAME natively.
//
// Public half of the partial class; the vector-shaped marshalling helpers live in
// Al.Wrapper.Internal.cs.

namespace Brutal.OpenAlApi;

public static unsafe partial class Al
{
    // --- Strings -----------------------------------------------------------------------------------------

    /// <summary>
    ///     Gets an AL string property (<c>alGetString</c>): vendor, version, renderer, or the
    ///     extension list. <see langword="null"/> when OpenAL returns its NULL sentinel.
    /// </summary>
    public static string? GetString(AlGetString param)
    {
        // Raw byte* return, copied to managed before anything can invalidate the library-owned
        // buffer. A null result is either the NULL sentinel or an error.
        return StringUtils.Utf8ToString(PInvoke.GetString((int)param));
    }

    /// <summary>Gets the space-separated AL extension list (<c>AL_EXTENSIONS</c>) as an array.</summary>
    public static string[] GetExtensions()
    {
        var s = GetString(AlGetString.Extensions);
        return string.IsNullOrEmpty(s) ? [] : s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    }

    // --- Global state ----------------------------------------------------------------------------------

    /// <summary>Gets/sets the distance attenuation model (<c>AL_DISTANCE_MODEL</c>).</summary>
    public static AlDistanceModel DistanceModel
    {
        get => (AlDistanceModel)PInvoke.GetInteger(Constants.AL_DISTANCE_MODEL);
        set => PInvoke.DistanceModel((int)value);
    }

    /// <summary>Gets/sets the Doppler factor (<c>AL_DOPPLER_FACTOR</c>, default 1).</summary>
    public static float DopplerFactor
    {
        get => PInvoke.GetFloat(Constants.AL_DOPPLER_FACTOR);
        set => PInvoke.DopplerFactor(value);
    }

    /// <summary>Gets/sets the speed of sound used for Doppler (<c>AL_SPEED_OF_SOUND</c>, default 343.3).</summary>
    public static float SpeedOfSound
    {
        get => PInvoke.GetFloat(Constants.AL_SPEED_OF_SOUND);
        set => PInvoke.SpeedOfSound(value);
    }

    // --- Deferred updates, resampler queries, gain limit, and start-delay --------------------------------

    /// <summary>
    ///     Defers applying source/effect-slot state changes until <see cref="ProcessUpdates"/>
    ///     (<c>alDeferUpdatesSOFT</c>), so a batch of changes takes effect atomically instead of one at a
    ///     time. Provided by <c>AL_SOFT_deferred_updates</c>.
    /// </summary>
    public static void DeferUpdates() => PInvoke.DeferUpdatesSOFT();

    /// <summary>
    ///     Applies state changes deferred since <see cref="DeferUpdates"/> (<c>alProcessUpdatesSOFT</c>).
    ///     Provided by <c>AL_SOFT_deferred_updates</c>.
    /// </summary>
    public static void ProcessUpdates() => PInvoke.ProcessUpdatesSOFT();

    /// <summary>
    ///     Defers updates for the returned scope's lifetime (pairs <see cref="DeferUpdates"/> with
    ///     <see cref="ProcessUpdates"/> for a <see langword="using"/> block). Provided by
    ///     <c>AL_SOFT_deferred_updates</c>.
    /// </summary>
    public static DeferredUpdatesScope DeferUpdatesScope()
    {
        DeferUpdates();
        return new DeferredUpdatesScope();
    }

    /// <summary>
    ///     The names of the available resamplers (<c>AL_RESAMPLER_NAME_SOFT</c>), indexed the same
    ///     as a source's resampler property value. Allocates a fresh array on every access -
    ///     startup-tier enumeration, not a per-frame query. Provided by
    ///     <c>AL_SOFT_source_resampler</c>.
    /// </summary>
    public static string[] ResamplerNames
    {
        get
        {
            var count = PInvoke.GetInteger(Constants.AL_NUM_RESAMPLERS_SOFT);
            var names = new string[count];
            for (var i = 0; i < count; i++)
            {
                names[i] =
                    StringUtils.Utf8ToString(PInvoke.GetStringiSOFT(Constants.AL_RESAMPLER_NAME_SOFT, i))
                    ?? string.Empty;
            }
            return names;
        }
    }

    /// <summary>
    ///     The index into <see cref="ResamplerNames"/> of the implementation's default resampler
    ///     (<c>AL_DEFAULT_RESAMPLER_SOFT</c>). Provided by <c>AL_SOFT_source_resampler</c>.
    /// </summary>
    public static int DefaultResampler => PInvoke.GetInteger(Constants.AL_DEFAULT_RESAMPLER_SOFT);

    /// <summary>
    ///     The implementation's maximum per-source gain multiplier (<c>AL_GAIN_LIMIT_SOFT</c>); a
    ///     source's <c>Gain</c> is silently clamped to this value. Provided by
    ///     <c>AL_SOFT_gain_clamp_ex</c>.
    /// </summary>
    public static float GainLimit => PInvoke.GetFloat(Constants.AL_GAIN_LIMIT_SOFT);

    /// <summary>
    ///     Schedules playback of several sources to start together at a device-clock time, in
    ///     nanoseconds (<c>alSourcePlayAtTimevSOFT</c>; the clock is
    ///     <see cref="OpenAlApi.Device.ClockTime"/>). Provided by <c>AL_SOFT_source_start_delay</c>.
    /// </summary>
    public static void PlaySourcesAt(ReadOnlySpan<AlSource> sources, long deviceClockTime)
    {
        if (sources.IsEmpty)
            return;

        var names = sources.Cast<AlSource, uint>();
        fixed (uint* p = names)
            PInvoke.SourcePlayAtTimevSOFT(names.Length, p, deviceClockTime);
    }
}

/// <summary>
///     A <see langword="using"/>-able scope pairing <see cref="Al.DeferUpdates"/> with
///     <see cref="Al.ProcessUpdates"/>: state changes made while the scope is open are applied
///     atomically when it is disposed. Provided by <c>AL_SOFT_deferred_updates</c>.
/// </summary>
public readonly ref struct DeferredUpdatesScope
{
    /// <summary>Applies the deferred updates (<c>alProcessUpdatesSOFT</c>).</summary>
    public void Dispose() => Al.ProcessUpdates();
}
