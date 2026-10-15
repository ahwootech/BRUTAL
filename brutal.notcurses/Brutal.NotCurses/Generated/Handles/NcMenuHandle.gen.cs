using System.Runtime.InteropServices.Marshalling;
using Brutal;
using Brutal.Interop;
using Brutal.Numerics;
using Brutal.Pointers;
using Brutal.Strings;
namespace Brutal.NotCursesApi
{
    [InteropHandle]
    public unsafe readonly partial struct NcMenuHandle
    {
    }
    public unsafe readonly partial struct NcMenuHandle
    {
        public void Destroy()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncmenu_destroy(this);
        public void ItemSetStatus(RefString8 section, RefString8 item, Bool8 enabled)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncmenu_item_set_status(this, section, item, enabled);
            if (__r != 0) throw new NcResultException("ncmenu_item_set_status", __r);
        }
        public string MouseSelected(Ptr<NcInput> click, Ptr<NcInput> ni)
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncmenu_mouse_selected(this, click, ni);
        public string MouseSelected(out NcInput click, out NcInput ni)
        {
            click = default;
            ni = default;
            fixed (NcInput* clickPtr = &click)
            {
                fixed (NcInput* niPtr = &ni)
                {
                    return global::Brutal.NotCursesApi.NotCurses.PInvoke.ncmenu_mouse_selected(this, new Ptr<NcInput>(clickPtr), new Ptr<NcInput>(niPtr));
                }
            }
        }
        public void NextItem()
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncmenu_nextitem(this);
            if (__r != 0) throw new NcResultException("ncmenu_nextitem", __r);
        }
        public void NextSection()
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncmenu_nextsection(this);
            if (__r != 0) throw new NcResultException("ncmenu_nextsection", __r);
        }
        public Bool8 OfferInput(Ptr<NcInput> nc)
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncmenu_offer_input(this, nc);
        public Bool8 OfferInput(out NcInput nc)
        {
            nc = default;
            fixed (NcInput* ncPtr = &nc)
            {
                return global::Brutal.NotCursesApi.NotCurses.PInvoke.ncmenu_offer_input(this, new Ptr<NcInput>(ncPtr));
            }
        }
        public NcPlaneHandle Plane()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncmenu_plane(this);
        public void PrevItem()
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncmenu_previtem(this);
            if (__r != 0) throw new NcResultException("ncmenu_previtem", __r);
        }
        public void PrevSection()
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncmenu_prevsection(this);
            if (__r != 0) throw new NcResultException("ncmenu_prevsection", __r);
        }
        public void RollUp()
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncmenu_rollup(this);
            if (__r != 0) throw new NcResultException("ncmenu_rollup", __r);
        }
        public string Selected(Ptr<NcInput> ni)
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncmenu_selected(this, ni);
        public string Selected(out NcInput ni)
        {
            ni = default;
            fixed (NcInput* niPtr = &ni)
            {
                return global::Brutal.NotCursesApi.NotCurses.PInvoke.ncmenu_selected(this, new Ptr<NcInput>(niPtr));
            }
        }
        public void Unroll(int sectionIdx)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncmenu_unroll(this, sectionIdx);
            if (__r != 0) throw new NcResultException("ncmenu_unroll", __r);
        }
    }
    public static unsafe partial class StringExtensions
    {
        public static void ItemSetStatus(this NcMenuHandle self, string section, string item, Bool8 enabled)
        {
            using var sectionBuf = new ScratchBuffer(section, stackalloc byte[256]);
            using var itemBuf = new ScratchBuffer(item, stackalloc byte[256]);
            self.ItemSetStatus(sectionBuf.Bytes, itemBuf.Bytes, enabled);
        }
    }
}
