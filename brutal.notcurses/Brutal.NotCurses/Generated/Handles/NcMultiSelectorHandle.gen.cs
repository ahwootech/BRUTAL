using System.Runtime.InteropServices.Marshalling;
using Brutal;
using Brutal.Interop;
using Brutal.Numerics;
using Brutal.Pointers;
using Brutal.Strings;
namespace Brutal.NotCursesApi
{
    [InteropHandle]
    public unsafe readonly partial struct NcMultiSelectorHandle
    {
    }
    public unsafe readonly partial struct NcMultiSelectorHandle
    {
        public void Destroy()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncmultiselector_destroy(this);
        public Bool8 OfferInput(Ptr<NcInput> nc)
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncmultiselector_offer_input(this, nc);
        public Bool8 OfferInput(out NcInput nc)
        {
            nc = default;
            fixed (NcInput* ncPtr = &nc)
            {
                return global::Brutal.NotCursesApi.NotCurses.PInvoke.ncmultiselector_offer_input(this, new Ptr<NcInput>(ncPtr));
            }
        }
        public NcPlaneHandle Plane()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncmultiselector_plane(this);
        public void Selected(Ptr<Bool8> selected, uint count)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncmultiselector_selected(this, selected, count);
            if (__r != 0) throw new NcResultException("ncmultiselector_selected", __r);
        }
    }
}
