using System.Runtime.InteropServices.Marshalling;
using Brutal;
using Brutal.Interop;
using Brutal.Numerics;
using Brutal.Pointers;
using Brutal.Strings;
namespace Brutal.NotCursesApi
{
    [InteropHandle]
    public unsafe readonly partial struct NcReelHandle
    {
    }
    public unsafe readonly partial struct NcReelHandle
    {
        public NcTabletHandle Add(NcTabletHandle after, NcTabletHandle before, delegate* unmanaged[Cdecl]<NcTabletHandle, Bool8, int> cb, Ptr opaque)
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncreel_add(this, after, before, cb, opaque);
        public void Del(NcTabletHandle t)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncreel_del(this, t);
            if (__r != 0) throw new NcResultException("ncreel_del", __r);
        }
        public void Destroy()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncreel_destroy(this);
        public NcTabletHandle Focused()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncreel_focused(this);
        public NcTabletHandle Next()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncreel_next(this);
        public Bool8 OfferInput(Ptr<NcInput> ni)
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncreel_offer_input(this, ni);
        public Bool8 OfferInput(out NcInput ni)
        {
            ni = default;
            fixed (NcInput* niPtr = &ni)
            {
                return global::Brutal.NotCursesApi.NotCurses.PInvoke.ncreel_offer_input(this, new Ptr<NcInput>(niPtr));
            }
        }
        public NcPlaneHandle Plane()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncreel_plane(this);
        public NcTabletHandle Prev()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncreel_prev(this);
        public void Redraw()
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncreel_redraw(this);
            if (__r != 0) throw new NcResultException("ncreel_redraw", __r);
        }
        public void TabletCount()
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncreel_tabletcount(this);
            if (__r != 0) throw new NcResultException("ncreel_tabletcount", __r);
        }
    }
}
