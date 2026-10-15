using System.Runtime.InteropServices.Marshalling;
using Brutal;
using Brutal.Interop;
using Brutal.Pointers;
namespace Brutal.NotCursesApi
{
    /// Menus. Horizontal menu bars are supported, on the top and/or bottom rows.
    /// If the menu bar is longer than the screen, it will be only partially
    /// visible. Menus may be either visible or invisible by default. In the event of
    /// a plane resize, menus will be automatically moved/resized. Elements can be
    /// dynamically enabled or disabled at all levels (menu, section, and item),
    public unsafe partial struct NcMenuItem
    {
        public Ptr<byte> Desc; // utf-8 menu item, NULL for horizontal separator
        public NcInput Shortcut; // shortcut, all should be distinct
    }
}
