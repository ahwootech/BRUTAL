/*
 * HelloFmod
 *
 * Starts FMOD, prints its version and plays a 440 Hz tone from FMOD's built-in oscillator.
 *
 * FMOD natives are not bundled: put your licensed FMOD 2.03 Core library (fmod.dll, libfmod.so
 * or libfmod.dylib) on the library search path (PATH on Windows, LD_LIBRARY_PATH on Linux,
 * DYLD_LIBRARY_PATH on macOS), or this throws DllNotFoundException.
 */

#:package Ahwoo.Brutal.Fmod@2026.10.4
#:package Ahwoo.Brutal.Core@2026.10.4

// RIAN: It needs to be stressed that we do not provide FMOD binaries, and you must obtain them from the official FMOD website.

using Brutal.FmodApi;

// The FMOD system owns everything else; closing and releasing it frees anything left behind.
var system = Fmod.SystemCreate(Fmod.VERSION);
system.Init(32, InitFlags.Normal, 0);

try
{
    Run(system);
}
finally
{
    system.Close();
    system.Release();
}

static void Run(FmodSystem system)
{
    system.GetVersion(out var version, out _);
    Console.WriteLine($"FMOD version: {version >> 16:x}.{(version >> 8) & 0xff:x2}.{version & 0xff:x2}");

    var dsp = system.CreateDspByType(DspType.Oscillator); // Generates a sine wave by default.
    dsp.SetParameterFloat((int)DspOscillator.Rate, 440.0f);

    var channel = system.PlayDsp(dsp, default, false);
    channel.SetVolume(0.5f);

    Console.WriteLine("Playing a 440 Hz tone...");
    for (var i = 0; i < 100; i++)
    {
        system.Update();
        Thread.Sleep(10);
    }

    // Channels and DSPs aren't IDisposable, so stop and release them by hand.
    channel.Stop();
    dsp.Release();
}
