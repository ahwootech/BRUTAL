using System;
namespace Brutal.NotCursesApi
{
    [Flags]
    public enum NcMenuOption : ulong
    {
        Bottom = 0x0001UL,
        Hiding = 0x0002UL,
    }
}
