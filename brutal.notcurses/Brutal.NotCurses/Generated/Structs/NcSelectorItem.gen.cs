using System.Runtime.InteropServices.Marshalling;
using Brutal;
using Brutal.Interop;
using Brutal.Pointers;
namespace Brutal.NotCursesApi
{
    /// selection widget -- an ncplane with a title header and a body section. the
    /// body section supports infinite scrolling up and down.
    /// 
    /// At all times, exactly one item is selected.
    public unsafe partial struct NcSelectorItem
    {
        public Ptr<byte> Option;
        public Ptr<byte> Desc;
    }
}
