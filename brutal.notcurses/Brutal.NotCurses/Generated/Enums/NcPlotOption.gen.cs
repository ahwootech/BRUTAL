using System;
namespace Brutal.NotCursesApi
{
    [Flags]
    public enum NcPlotOption : uint
    {
        DetectMaxOnly = 0x0010U,
        ExponentialD = 0x0002U,
        LabelTicksD = 0x0001U,
        NoDegrade = 0x0008U,
        PrintSample = 0x0020U,
        VerticalI = 0x0004U,
    }
}
