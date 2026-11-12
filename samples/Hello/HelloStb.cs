/*
 * HelloStb
 *
 * Writes a generated gradient to a PNG with stb_image_write, reads it back with stb_image and
 * prints a pixel.
 */

#:package Ahwoo.Brutal.Stb@2026.10.3
#:package Ahwoo.Brutal.Numerics@2026.10.2

// RIAN: Warning this library is handy for PNG, but it's pretty slow at runtime.

using System.Runtime.InteropServices;
using Brutal.Numerics;
using Brutal.StbApi;

const int WIDTH = 64;
const int HEIGHT = 64;

Run();

static void Run()
{
    // Generate an RGB gradient.
    var pixels = new byte3[WIDTH * HEIGHT];
    for (var y = 0; y < HEIGHT; y++)
    {
        for (var x = 0; x < WIDTH; x++)
            pixels[y * WIDTH + x] = new byte3((byte)(x * 4), (byte)(y * 4), 128);
    }

    var path = Path.Combine(Path.GetTempPath(), "HelloStb.png");
    Stb.WritePng(path, WIDTH, HEIGHT, 3, MemoryMarshal.AsBytes(pixels.AsSpan()));
    Console.WriteLine($"Wrote {path}");

    // Freed when Run returns.
    using var image = Stb.Load(path);
    Console.WriteLine($"Loaded {image.Width}x{image.Height}, {image.Channels} channels");
    Console.WriteLine($"Pixel (63, 0) = {image.AsSpan<byte3>()[63]}");
}
