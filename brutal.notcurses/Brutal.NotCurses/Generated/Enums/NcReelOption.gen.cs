using System;
namespace Brutal.NotCursesApi
{
    [Flags]
    public enum NcReelOption : ulong
    {
        Circular = 0x0002UL,
        Infinitescroll = 0x0001UL,
    }
}
