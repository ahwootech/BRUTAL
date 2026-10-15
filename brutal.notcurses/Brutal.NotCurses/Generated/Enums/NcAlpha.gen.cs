using System;
namespace Brutal.NotCursesApi
{
    [Flags]
    public enum NcAlpha : ulong
    {
        Blend = 0x10000000UL,
        HighContrast = 0x30000000UL,
        Opaque = 0x00000000UL,
        Transparent = 0x20000000UL,
    }
}
