using System;
namespace Brutal.NotCursesApi
{
    [Flags]
    public enum NcPlaneOption : ulong
    {
        Autogrow = 0x0010UL,
        Fixed = 0x0008UL,
        HorAligned = 0x0001UL,
        Marginalized = 0x0004UL,
        VerAligned = 0x0002UL,
        Vscroll = 0x0020UL,
    }
}
