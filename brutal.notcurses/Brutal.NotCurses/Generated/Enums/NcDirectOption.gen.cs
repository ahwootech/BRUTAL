using System;
namespace Brutal.NotCursesApi
{
    [Flags]
    public enum NcDirectOption : ulong
    {
        DrainInput = 0x0004UL,
        InhibitCBreak = 0x0002UL,
        InhibitSetLocale = 0x0001UL,
        NoQuitSigHandlers = 0x0008UL,
        Verbose = 0x0010UL,
        VeryVerbose = 0x0020UL,
    }
}
