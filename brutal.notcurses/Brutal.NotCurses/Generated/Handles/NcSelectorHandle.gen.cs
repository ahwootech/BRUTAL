using System.Runtime.InteropServices.Marshalling;
using Brutal;
using Brutal.Interop;
using Brutal.Numerics;
using Brutal.Pointers;
using Brutal.Strings;
namespace Brutal.NotCursesApi
{
    [InteropHandle]
    public unsafe readonly partial struct NcSelectorHandle
    {
    }
    public unsafe readonly partial struct NcSelectorHandle
    {
        public NcSelectorItem AddItem()
        {
            NcSelectorItem item = default;
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncselector_additem(this, new Ptr<NcSelectorItem>(&item));
            if (__r != 0) throw new NcResultException("ncselector_additem", __r);
            return item;
        }
        public void DelItem(RefString8 item)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncselector_delitem(this, item);
            if (__r != 0) throw new NcResultException("ncselector_delitem", __r);
        }
        public void Destroy(Ptr<Ptr<byte>> item)
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncselector_destroy(this, item);
        public string NextItem()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncselector_nextitem(this);
        public Bool8 OfferInput(Ptr<NcInput> nc)
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncselector_offer_input(this, nc);
        public Bool8 OfferInput(out NcInput nc)
        {
            nc = default;
            fixed (NcInput* ncPtr = &nc)
            {
                return global::Brutal.NotCursesApi.NotCurses.PInvoke.ncselector_offer_input(this, new Ptr<NcInput>(ncPtr));
            }
        }
        public NcPlaneHandle Plane()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncselector_plane(this);
        public string PrevItem()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncselector_previtem(this);
        public string Selected()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncselector_selected(this);
    }
    public static unsafe partial class StringExtensions
    {
        public static void DelItem(this NcSelectorHandle self, string item)
        {
            using var itemBuf = new ScratchBuffer(item, stackalloc byte[256]);
            self.DelItem(itemBuf.Bytes);
        }
    }
}
