// AL_SOFT_source_latency / ALC_SOFT_device_clock source-side queries, dispatched through the
// extension d/i64 entry points rather than the core f/i ones.
//
// Hand-written rather than generated because the registry can't supply the docs (al.xml has no
// prose for these enums) and misdescribes their shape (the *_OFFSET_CLOCK_SOFT params are declared
// scalar though openal-soft fills two slots).
//
// The pair types are record structs, not vectors: each native result is a 2-element array whose
// slots hold DIFFERENT quantities (an offset paired with a latency or clock reading), co-sampled
// in one call. A math vector would offer meaningless arithmetic across the two.

namespace Brutal.OpenAlApi;

/// <summary>A source's playback sample offset paired with its output latency. Provided by <c>AL_SOFT_source_latency</c>.</summary>
/// <param name="SampleOffset">32.32 fixed-point sample offset (high 32 bits: whole samples).</param>
/// <param name="Latency">Nanoseconds until the sample at the offset is audible.</param>
public readonly record struct AlSampleOffsetLatency(long SampleOffset, long Latency)
{
    /// <summary>The whole-sample part of <see cref="SampleOffset"/> (its high 32 bits).</summary>
    public int WholeSamples => (int)(SampleOffset >> 32);
}

/// <summary>A source's playback sample offset paired with the device clock. Provided by <c>ALC_SOFT_device_clock</c>.</summary>
/// <param name="SampleOffset">32.32 fixed-point sample offset (high 32 bits: whole samples).</param>
/// <param name="ClockTime">The device clock, in nanoseconds, at which the offset was sampled.</param>
public readonly record struct AlSampleOffsetClock(long SampleOffset, long ClockTime)
{
    /// <summary>The whole-sample part of <see cref="SampleOffset"/> (its high 32 bits).</summary>
    public int WholeSamples => (int)(SampleOffset >> 32);
}

/// <summary>A source's playback offset in seconds paired with its output latency. Provided by <c>AL_SOFT_source_latency</c>.</summary>
/// <param name="SecOffset">Playback offset, in seconds.</param>
/// <param name="Latency">Seconds until the sample at the offset is audible.</param>
public readonly record struct AlSecOffsetLatency(double SecOffset, double Latency);

/// <summary>A source's playback offset in seconds paired with the device clock. Provided by <c>ALC_SOFT_device_clock</c>.</summary>
/// <param name="SecOffset">Playback offset, in seconds.</param>
/// <param name="ClockTime">The device clock, in seconds, at which the offset was sampled.</param>
public readonly record struct AlSecOffsetClock(double SecOffset, double ClockTime);

public readonly partial struct AlSource
{
    /// <summary>
    ///     The playback offset and the output latency, in seconds, read atomically
    ///     (<c>AL_SEC_OFFSET_LATENCY_SOFT</c>). Provided by <c>AL_SOFT_source_latency</c>.
    /// </summary>
    public AlSecOffsetLatency SecOffsetLatency
    {
        get
        {
            var (offset, latency) = Al.GetSourcedv2SOFT(Name, Al.Constants.AL_SEC_OFFSET_LATENCY_SOFT);
            return new AlSecOffsetLatency(offset, latency);
        }
    }

    /// <summary>
    ///     The playback sample offset and output latency, read atomically
    ///     (<c>AL_SAMPLE_OFFSET_LATENCY_SOFT</c>). Provided by <c>AL_SOFT_source_latency</c>.
    /// </summary>
    public AlSampleOffsetLatency SampleOffsetLatency
    {
        get
        {
            var (offset, latency) = Al.GetSourcei64v2SOFT(Name, Al.Constants.AL_SAMPLE_OFFSET_LATENCY_SOFT);
            return new AlSampleOffsetLatency(offset, latency);
        }
    }

    /// <summary>
    ///     The playback offset and the device clock, in seconds, read atomically
    ///     (<c>AL_SEC_OFFSET_CLOCK_SOFT</c>). Provided by <c>ALC_SOFT_device_clock</c>.
    /// </summary>
    public AlSecOffsetClock SecOffsetClock
    {
        get
        {
            var (offset, clock) = Al.GetSourcedv2SOFT(Name, Al.Constants.AL_SEC_OFFSET_CLOCK_SOFT);
            return new AlSecOffsetClock(offset, clock);
        }
    }

    /// <summary>
    ///     The playback sample offset and the device clock, read atomically
    ///     (<c>AL_SAMPLE_OFFSET_CLOCK_SOFT</c>). Provided by <c>ALC_SOFT_device_clock</c>.
    /// </summary>
    public AlSampleOffsetClock SampleOffsetClock
    {
        get
        {
            var (offset, clock) = Al.GetSourcei64v2SOFT(Name, Al.Constants.AL_SAMPLE_OFFSET_CLOCK_SOFT);
            return new AlSampleOffsetClock(offset, clock);
        }
    }

    /// <summary>
    ///     Schedules playback to start at a device-clock time (<c>alSourcePlayAtTimeSOFT</c>). See
    ///     <see cref="OpenAlApi.Device.ClockTime"/> for the clock this is measured against. Provided by
    ///     <c>AL_SOFT_source_start_delay</c>.
    /// </summary>
    /// <param name="deviceClockTime">The device clock time, in nanoseconds, at which to start playback.</param>
    public void PlayAt(long deviceClockTime) => Al.PInvoke.SourcePlayAtTimeSOFT(Name, deviceClockTime);
}
