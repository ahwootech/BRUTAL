using System;
namespace Brutal.NotCursesApi
{
    [Flags]
    public enum NcKeyModifier
    {
        Alt = 2,
        Capslock = 64,
        Ctrl = 4,
        Hyper = 16,
        Meta = 32,
        Numlock = 128,
        Shift = 1,
        Super = 8,
    }
}
