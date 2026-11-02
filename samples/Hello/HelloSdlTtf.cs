/*
 * HelloSdlTtf
 *
 * Opens a font with Sdl.Ttf, renders a line of text to an SDL surface, prints its pixel size and
 * saves it as a BMP. Runs headless (no window).
 *
 * Pass a font, or it tries a common system font for your OS:
 *
 *     dotnet run Hello/HelloSdlTtf.cs -- path/to/font.ttf
 */

#:property AllowUnsafeBlocks=true
#:package Ahwoo.Brutal.Sdl@2026.10.3
#:package Ahwoo.Brutal.Sdl.Ttf@2026.10.3

using Brutal.SdlApi;
using Brutal.SdlApi.Ttf;

// yuck, sorry
string[] systemFonts =
[
    "/System/Library/Fonts/Supplemental/Arial.ttf", // macOS
    @"C:\Windows\Fonts\arial.ttf", // Windows
    "/usr/share/fonts/truetype/dejavu/DejaVuSans.ttf", // Debian, Ubuntu
    "/usr/share/fonts/TTF/DejaVuSans.ttf", // Arch
    "/usr/share/fonts/dejavu-sans-fonts/DejaVuSans.ttf", // Fedora
];

var fontPath = args.Length > 0 ? args[0] : systemFonts.FirstOrDefault(File.Exists);
if (fontPath is null)
{
    Console.WriteLine("No system font found. Usage: dotnet run Hello/HelloSdlTtf.cs -- path/to/font.ttf");
    return;
}

SdlTtf.Init();
try
{
    Run(fontPath);
}
finally
{
    SdlTtf.Quit();
}

static void Run(string fontPath)
{
    // Closed when Run returns, before Sdl.Ttf quits.
    using var font = SdlTtf.OpenFont(fontPath, 32f);
    Console.WriteLine($"Font: {SdlTtf.GetFontFamilyName(font)} {SdlTtf.GetFontStyleName(font)} ({fontPath})");

    var bmpPath = Path.Combine(Path.GetTempPath(), "HelloSdlTtf.bmp");
    unsafe
    {
        // Blended renders anti-aliased text onto a transparent surface; length 0 means null-terminated.
        var surface = SdlTtf.RenderTextBlended(
            font,
            "Hello, Sdl.Ttf!",
            0,
            new SdlColor
            {
                r = 255,
                g = 255,
                b = 255,
                a = 255,
            }
        );

        Console.WriteLine($"Rendered text: {surface->w}x{surface->h} pixels");

        Sdl.PInvoke.SaveBMP(surface, bmpPath);
        Console.WriteLine($"Saved {bmpPath}");

        // The surface is a raw pointer rather than an IDisposable handle, so destroy it by hand.
        Sdl.PInvoke.DestroySurface(surface);
    }
}
