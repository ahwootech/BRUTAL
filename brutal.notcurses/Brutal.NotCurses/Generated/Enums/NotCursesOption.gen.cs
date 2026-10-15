using System;
namespace Brutal.NotCursesApi
{
    [Flags]
    public enum NotCursesOption : ulong
    {
        DrainInput = 0x0100UL,
        InhibitSetLocale = 0x0001UL,
        NoAlternateScreen = 0x0040UL,
        NoClearBitmaps = 0x0002UL,
        NoFontChanges = 0x0080UL,
        NoQuitSigHandlers = 0x0008UL,
        NoWinchSigHandler = 0x0004UL,
        PreserveCursor = 0x0010UL,
        Scrolling = 0x0200UL,
        SuppressBanners = 0x0020UL,
    }
}
