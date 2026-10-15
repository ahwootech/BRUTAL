using System;
namespace Brutal.NotCursesApi
{
    [Flags]
    public enum NcStyle : uint
    {
        Bold = 0x0002U,
        Italic = 0x0010U,
        Mask = 0xffffU,
        None = 0,
        Struck = 0x0001U,
        Undercurl = 0x0004U,
        Underline = 0x0008U,
    }
}
