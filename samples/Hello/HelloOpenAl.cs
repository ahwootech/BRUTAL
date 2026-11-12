/*
 * HelloOpenAl
 *
 * Opens the default audio device with OpenAL and plays a generated one-second 440 Hz tone.
 */

#:package Ahwoo.Brutal.OpenAl@2026.10.3

using System.Runtime.InteropServices;
using Brutal.OpenAlApi;

using var device = Alc.OpenDevice(); // Default output device.
Run(device);

static void Run(Device device)
{
    using var context = device.CreateContext();
    context.MakeCurrent();

    Console.WriteLine($"Opened device: {device.Specifier}");

    // One second of a 440 Hz sine wave as 16-bit mono PCM.
    const int SAMPLE_RATE = 44_100;
    var pcm = new short[SAMPLE_RATE];
    for (var i = 0; i < pcm.Length; i++)
        pcm[i] = (short)(Math.Sin(2 * Math.PI * 440 * i / SAMPLE_RATE) * short.MaxValue * 0.5);

    var buffer = Al.GenBuffer();
    buffer.SetData(AlFormat.Mono16, MemoryMarshal.AsBytes<short>(pcm), SAMPLE_RATE);

    var source = Al.GenSource();
    source.Buffer = buffer;
    source.Play();

    Console.WriteLine("Playing a 440 Hz tone...");
    while (source.State == AlSourceState.Playing)
        Thread.Sleep(10);

    // Buffers and sources aren't IDisposable, so delete them by hand.
    Al.DeleteSources([source]);
    Al.DeleteBuffers([buffer]);
    Context.MakeCurrent(null); // Release the context before it is destroyed.
}
