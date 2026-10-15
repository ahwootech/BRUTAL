using System.Runtime.InteropServices.Marshalling;
using Brutal;
using Brutal.Interop;
using Brutal.Pointers;
namespace Brutal.NotCursesApi
{
    public unsafe partial struct NcMenuSection
    {
        public Ptr<byte> Name; // utf-8 c string
        public int Itemcount;
        public Ptr<NcMenuItem> Items;
        public NcInput Shortcut; // shortcut, will be underlined if present in name
    }
}
