using System.Runtime.InteropServices.Marshalling;
using Brutal;
using Brutal.Interop;
using Brutal.Pointers;
namespace Brutal.NotCursesApi
{
    /// Capabilities, derived from terminfo, environment variables, and queries
    public unsafe partial struct NcCapabilities
    {
        public uint Colors; // size of palette for indexed colors
        public Bool8 Utf8; // are we using utf-8 encoding? from nl_langinfo(3)
        public Bool8 Rgb; // 24bit color? COLORTERM/heuristics/terminfo 'rgb'
        public Bool8 CanChangeColors; // can we change the palette? terminfo 'ccc'
        public Bool8 Halfblocks; // we assume halfblocks, but some are known to lack them
        public Bool8 Quadrants; // do we have (good, vetted) Unicode 1 quadrant support?
        public Bool8 Sextants; // do we have (good, vetted) Unicode 13 sextant support?
        public Bool8 Octants; // do we have (good, vetted) Unicode 16 octant support?
        public Bool8 Braille; // do we have Braille support? (linux console does not)
    }
}
