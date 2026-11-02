/*
 * HelloSdlImage
 *
 * Paints a gradient into an SDL surface, saves it as a PNG with Sdl.Image, loads it back and
 * prints its size and pixel format. Runs headless (no window).
 */

#:property AllowUnsafeBlocks=true
#:package Ahwoo.Brutal.Sdl@2026.10.3
#:package Ahwoo.Brutal.Sdl.Image@2026.10.3

using Brutal.SdlApi;
using Brutal.SdlApi.Image;

Run();

static void Run()
{
    // Versions are packed as major * 1_000_000 + minor * 1000 + patch.
    var version = SdlImage.Version();
    Console.WriteLine($"SDL_image {version / 1_000_000}.{version / 1000 % 1000}.{version % 1000}");

    var path = Path.Combine(Path.GetTempPath(), "HelloSdlImage.png");

    // Surfaces are raw pointers rather than IDisposable handles, so each is destroyed by hand.
    unsafe
    {
        // Surfaces are plain CPU-side pixel buffers, so no video subsystem is needed.
        var surface = Sdl.PInvoke.CreateSurface(128, 64, SdlPixelFormat.Rgba8888);
        for (var y = 0; y < surface->h; y++)
        for (var x = 0; x < surface->w; x++)
            Sdl.PInvoke.WriteSurfacePixel(surface, x, y, (byte)(x * 2), (byte)(y * 4), 128, 255);

        SdlImage.SavePNG(surface, path);
        Sdl.PInvoke.DestroySurface(surface);
        Console.WriteLine($"Saved {path} ({new FileInfo(path).Length} bytes)");

        // Load picks the decoder from the file contents; the loaded format need not match what was saved.
        var loaded = SdlImage.Load(path);
        Console.WriteLine(
            $"Loaded {loaded->w}x{loaded->h}, format {Sdl.PInvoke.GetPixelFormatName(loaded->format)}, pitch {loaded->pitch}"
        );
        Sdl.PInvoke.DestroySurface(loaded);
    }
}
