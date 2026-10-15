using System;
namespace Brutal.NotCursesApi
{
    [Flags]
    public enum NcReaderOption : ulong
    {
        Cursor = 0x0008UL,
        Horscroll = 0x0001UL,
        Nocmdkeys = 0x0004UL,
        Verscroll = 0x0002UL,
    }
}
