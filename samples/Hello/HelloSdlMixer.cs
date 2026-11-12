/*
 * HelloSdlMixer
 *
 * Opens the default audio device with Sdl.Mixer, plays a half-second 440 Hz tone and waits for it
 * to finish. Runs headless (no window).
 */

#:property AllowUnsafeBlocks=true
#:package Ahwoo.Brutal.Sdl@2026.10.3
#:package Ahwoo.Brutal.Sdl.Mixer@2026.10.3

using Brutal.SdlApi;
using Brutal.SdlApi.Mixer;

const uint DEFAULT_PLAYBACK_DEVICE = 0xFFFFFFFFu; // SDL_AUDIO_DEVICE_DEFAULT_PLAYBACK

Sdl.Init.Initialize(SdlInitFlags.Audio);
SdlMixer.Init();
try
{
    Run();
}
finally
{
    SdlMixer.Quit();
    Sdl.Init.Quit();
}

// Unsafe for the null and &spec pointer arguments.
static unsafe void Run()
{
    // Disposed in reverse when Run returns: the track, the tone, then the mixer.
    using var mixer = SdlMixer.CreateMixerDevice(DEFAULT_PLAYBACK_DEVICE, null); // null accepts the device's format.
    SdlAudioSpec spec;
    mixer.GetFormat(&spec);
    Console.WriteLine(
        $"Mixer: {spec.freq} Hz, {spec.channels} channel(s), {Sdl.PInvoke.GetAudioFormatName(spec.format)}"
    );

    // A generated sine wave, so there is no audio file to ship.
    using var tone = mixer.CreateSineWaveAudio(440, 0.25f, 500);
    using var track = mixer.CreateTrack();
    track.SetAudio(tone);
    track.Play(0);
    Console.WriteLine($"Playing a 440 Hz sine wave for {tone.FramesToMS(tone.GetDuration())} ms");

    // Playback happens on SDL's audio thread; poll until the track runs out, with a safety timeout.
    var deadline = DateTime.UtcNow + TimeSpan.FromSeconds(3);
    while (track.Playing() && DateTime.UtcNow < deadline)
        Thread.Sleep(10);
    Console.WriteLine("Done");
}
