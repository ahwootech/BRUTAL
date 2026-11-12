/*
 * HelloSdl
 *
 * Opens an SDL window with a renderer and draws a filled rectangle each frame.
 * Press Escape to close it.
 * See Demo/DemoSdl.cs for the Sdl.Image, Sdl.Mixer and Sdl.Ttf add-ons.
 */

#:property AllowUnsafeBlocks=true
#:package Ahwoo.Brutal.Sdl@2026.10.3

// RIAN: We don't use SDL in any of our projects today, but feedback is appreciated.

using Brutal.SdlApi;

Sdl.Init.Initialize(SdlInitFlags.Video);
try
{
    Run();
}
finally
{
    Sdl.Init.Quit();
}

static void Run()
{
    // Disposed in reverse when Run returns: the renderer, then its window, before SDL quits.
    using var window = Sdl.Video.CreateWindow("Hello Sdl", 640, 480, SdlWindowFlags.Resizable);
    using var renderer = Sdl.Render.CreateRenderer(window, null!); // null picks the best available driver.
    Sdl.Render.SetRenderVSync(renderer, 1);

    var running = true;
    while (running)
    {
        while (Sdl.Events.PollEvent(out var ev))
        {
            if (ev.type is SdlEventType.Quit or SdlEventType.WindowCloseRequested)
                running = false;
            else if (ev.type == SdlEventType.KeyDown && ev.key.scancode == SdlScancode.Escape)
                running = false;
        }

        Sdl.Render.SetRenderDrawColor(renderer, 51, 77, 77, 255);
        Sdl.Render.RenderClear(renderer);

        Sdl.Render.SetRenderDrawColor(renderer, 230, 128, 51, 255);
        unsafe
        {
            var rect = new SdlFRect
            {
                x = 220,
                y = 140,
                w = 200,
                h = 200,
            };
            Sdl.Render.RenderFillRect(renderer, &rect);
        }

        Sdl.Render.SetRenderDrawColor(renderer, 255, 255, 255, 255);
        Sdl.Render.RenderDebugText(renderer, 16, 16, "Hello Sdl");

        Sdl.Render.RenderPresent(renderer);
    }
}
