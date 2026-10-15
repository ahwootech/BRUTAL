using System;
namespace Brutal.NotCursesApi
{
    [Flags]
    public enum NcMiceEvent
    {
        AllEvents = 0x7,
        ButtonEvent = 0x2,
        DragEvent = 0x4,
        MoveEvent = 0x1,
        NoEvents = 0,
    }
}
