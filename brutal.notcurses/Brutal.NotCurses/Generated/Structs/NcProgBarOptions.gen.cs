using System.Runtime.InteropServices.Marshalling;
using Brutal;
using Brutal.Interop;
using Brutal.Pointers;
namespace Brutal.NotCursesApi
{
    public unsafe partial struct NcProgBarOptions
    {
        public uint Ulchannel; // upper-left channel. in the context of a progress bar,
        public uint Urchannel; // "up" is the direction we are progressing towards, and
        public uint Blchannel; // "bottom" is the direction of origin. for monochromatic
        public uint Brchannel; // bar, all four channels ought be the same.
        public NcProgbarOption Flags;
    }
}
