using System.Runtime.InteropServices.Marshalling;
using Brutal;
using Brutal.Interop;
using Brutal.Pointers;
namespace Brutal.NotCursesApi
{
    public unsafe partial struct NcMSelectorItem
    {
        public Ptr<byte> Option;
        public Ptr<byte> Desc;
        public Bool8 Selected;
    }
}
