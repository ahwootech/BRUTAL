/*
 * HelloNotCurses
 *
 * Draws coloured text with notcurses and waits for a key. Run it in a real terminal.
 */

#:package Ahwoo.Brutal.NotCurses@2026.10.1
#:package Ahwoo.Brutal.Numerics@2026.10.2

// RIAN: I'm the only one who uses this for tooling, please don't use it in your server applications.

using Brutal.NotCursesApi;
using Brutal.Numerics;

Run();

static void Run()
{
    using var nc = NotCursesHandle.Init(); // Takes over the terminal until disposed.

    var plane = nc.StdPlane();
    plane.SetFgRgb(0x66DD55);
    plane.PutStr(new int2(2, 1), $"Hello from notcurses {NotCurses.Version}!");
    plane.SetFgRgb(0xFFFFFF);
    plane.PutStr(new int2(2, 3), "Press any key to exit.");
    nc.Render();

    nc.GetBlocking(out _);
}
