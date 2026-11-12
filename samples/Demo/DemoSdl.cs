/*
 * DemoSdl
 *
 * Opens an SDL window and uses its add-ons: Sdl.Image saves and loads a PNG, Sdl.Mixer beeps
 * when you press Space, and Sdl.Ttf draws text if you pass a font. Press Escape to close it.
 *
 * Optionally pass a font:
 *
 *     dotnet run Demo/DemoSdl.cs -- path/to/font.ttf
 */

#:property AllowUnsafeBlocks=true
#:package Ahwoo.Brutal.Sdl@2026.10.3
#:package Ahwoo.Brutal.Sdl.Image@2026.10.3
#:package Ahwoo.Brutal.Sdl.Mixer@2026.10.3
#:package Ahwoo.Brutal.Sdl.Ttf@2026.10.3

using Brutal.SdlApi;
using Brutal.SdlApi.Image;
using Brutal.SdlApi.Mixer;
using Brutal.SdlApi.Ttf;

const uint DEFAULT_PLAYBACK_DEVICE = 0xFFFFFFFFu; // SDL_AUDIO_DEVICE_DEFAULT_PLAYBACK

Sdl.Init.Initialize(SdlInitFlags.Video | SdlInitFlags.Audio);
SdlTtf.Init();
SdlMixer.Init();
try
{
    Run(args);
}
finally
{
    SdlMixer.Quit();
    SdlTtf.Quit();
    Sdl.Init.Quit();
}

// Unsafe for the surface and rectangle pointers and the mixer's null spec.
static unsafe void Run(string[] args)
{
    // Declared in dependency order, so the using declarations dispose them in reverse when Run returns: the
    // track, tone and mixer, then the text, font, image, renderer and window.
    using var window = Sdl.Video.CreateWindow("Demo Sdl", 640, 480, SdlWindowFlags.Resizable);
    using var renderer = Sdl.Render.CreateRenderer(window, null!); // null picks the best available driver.
    Sdl.Render.SetRenderVSync(renderer, 1);

    // Sdl.Image: paint a gradient, save it as a PNG, then load it back as a texture.
    var imagePath = Path.Combine(Path.GetTempPath(), "DemoSdl.png");
    var surface = Sdl.PInvoke.CreateSurface(256, 256, SdlPixelFormat.Rgba8888);
    for (var y = 0; y < 256; y++)
    for (var x = 0; x < 256; x++)
        Sdl.PInvoke.WriteSurfacePixel(surface, x, y, (byte)x, (byte)y, 128, 255);

    SdlImage.SavePNG(surface, imagePath);
    Sdl.PInvoke.DestroySurface(surface);
    using var image = SdlImage.LoadTexture(renderer, imagePath);

    // Sdl.Ttf: render text with a font, if one was given (dotnet run Demo/DemoSdl.cs -- path/to/font.ttf).
    // Without one, the font and text stay default handles, which Dispose skips.
    var hasFont = args.Length > 0;
    using var font = hasFont ? SdlTtf.OpenFont(args[0], 32f) : default;
    using var text = hasFont ? RenderText(renderer, font, "Demo Sdl Ttf") : default;
    var textSize = (w: 0f, h: 0f);
    if (hasFont)
        Sdl.Render.GetTextureSize(text, out textSize.w, out textSize.h);

    // Sdl.Mixer: a 440 Hz tone, played whenever Space is pressed (key auto-repeat is ignored).
    using var mixer = SdlMixer.CreateMixerDevice(DEFAULT_PLAYBACK_DEVICE, null);
    using var tone = mixer.CreateSineWaveAudio(440, 0.25f, 250);
    using var track = mixer.CreateTrack();
    track.SetAudio(tone);

    var running = true;
    while (running)
    {
        while (Sdl.Events.PollEvent(out var ev))
        {
            if (ev.type is SdlEventType.Quit or SdlEventType.WindowCloseRequested)
                running = false;
            else if (ev.type == SdlEventType.KeyDown && ev.key.scancode == SdlScancode.Escape)
                running = false;
            else if (ev.type == SdlEventType.KeyDown && ev.key.scancode == SdlScancode.Space && ev.key.repeat == 0)
                track.Play(0);
        }

        Sdl.Render.SetRenderDrawColor(renderer, 51, 77, 77, 255);
        Sdl.Render.RenderClear(renderer);
        Sdl.Render.SetRenderDrawColor(renderer, 255, 255, 255, 255);
        Sdl.Render.RenderDebugText(renderer, 16, 16, "Demo Sdl - press Space to beep");

        var imageRect = new SdlFRect
        {
            x = 16,
            y = 40,
            w = 256,
            h = 256,
        };
        Sdl.Render.RenderTexture(renderer, image, null, &imageRect);

        if (hasFont)
        {
            var textRect = new SdlFRect
            {
                x = 16,
                y = 312,
                w = textSize.w,
                h = textSize.h,
            };
            Sdl.Render.RenderTexture(renderer, text, null, &textRect);
        }

        Sdl.Render.RenderPresent(renderer);
    }

    static SdlTexture RenderText(SdlRenderer renderer, TtfFont font, string message)
    {
        var surface = SdlTtf.RenderTextBlended(
            font,
            message,
            0,
            new SdlColor
            {
                r = 255,
                g = 255,
                b = 255,
                a = 255,
            }
        );
        var texture = Sdl.Render.CreateTextureFromSurface(renderer, surface);
        Sdl.PInvoke.DestroySurface(surface);
        return texture;
    }
}
