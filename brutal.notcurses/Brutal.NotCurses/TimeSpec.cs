using System.Runtime.InteropServices;

namespace Brutal.NotCursesApi;

/// <summary>
/// Blittable mirror of POSIX <c>struct timespec</c>. notcurses uses it for input timeouts
/// (<see cref="NotCurses.PInvoke.notcurses_get"/>, <see cref="NotCurses.PInvoke.ncdirect_get"/>, fade durations).
/// </summary>
/// <remarks>
/// The layout (two <see cref="long"/>s, 16 bytes total) matches Linux/macOS exactly: there
/// <c>time_t</c> and <c>long tv_nsec</c> are both 8 bytes. On Windows-MinGW <c>tv_nsec</c> is
/// 4 bytes natively followed by 4 bytes of struct padding; input values whose nanoseconds fit
/// in 32 bits (true for every valid nanosecond) marshal correctly because the low 32 bits land
/// in the right slot. notcurses uses <c>const struct timespec*</c> exclusively (input-only),
/// so the high 32 bits of <see cref="Nsec"/> are ignored by the native side.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public struct TimeSpec
{
    /// <summary>Seconds (<c>time_t</c>).</summary>
    public long Sec;

    /// <summary>Nanoseconds (<c>long tv_nsec</c>; only the low 32 bits are read on Windows-MinGW).</summary>
    public long Nsec;
}
