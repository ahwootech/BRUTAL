using System.Runtime.InteropServices.Marshalling;
using Brutal;
using Brutal.Interop;
using Brutal.Pointers;
namespace Brutal.NotCursesApi
{
    /// Palette API. Some terminals only support 256 colors, but allow the full
    /// palette to be specified with arbitrary RGB colors. In all cases, it's more
    /// performant to use indexed colors, since it's much less data to write to the
    /// terminal. If you can limit yourself to 256 colors, that's probably best.
    public unsafe partial struct NcPalette
    {
        public fixed uint Chans[256]; // RGB values as regular ol' channels
    }
}
