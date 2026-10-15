using System;
namespace Brutal.NotCursesApi
{
    [Flags]
    public enum NcBoxOption
    {
        GradBottom = 0x0040,
        GradLeft = 0x0080,
        GradRight = 0x0020,
        GradTop = 0x0010,
        MaskBottom = 0x0004,
        MaskLeft = 0x0008,
        MaskRight = 0x0002,
        MaskTop = 0x0001,
    }
}
