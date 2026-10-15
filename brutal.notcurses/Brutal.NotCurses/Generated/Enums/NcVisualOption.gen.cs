using System;
namespace Brutal.NotCursesApi
{
    [Flags]
    public enum NcVisualOption : ulong
    {
        AddAlpha = 0x0010UL,
        Blend = 0x0002UL,
        ChildPlane = 0x0020UL,
        HorAligned = 0x0004UL,
        NoDegrade = 0x0001UL,
        NoInterpolate = 0x0040UL,
        VerAligned = 0x0008UL,
    }
}
