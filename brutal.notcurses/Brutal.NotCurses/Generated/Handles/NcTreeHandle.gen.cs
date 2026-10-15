using System.Runtime.InteropServices.Marshalling;
using Brutal;
using Brutal.Interop;
using Brutal.Numerics;
using Brutal.Pointers;
using Brutal.Strings;
namespace Brutal.NotCursesApi
{
    [InteropHandle]
    public unsafe readonly partial struct NcTreeHandle
    {
    }
    public unsafe readonly partial struct NcTreeHandle
    {
        public void Add(Ptr<uint> spec, Ptr<NcTreeItem> add)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.nctree_add(this, spec, add);
            if (__r != 0) throw new NcResultException("nctree_add", __r);
        }
        public void Add(out uint spec, out NcTreeItem add)
        {
            spec = default;
            add = default;
            fixed (uint* specPtr = &spec)
            {
                fixed (NcTreeItem* addPtr = &add)
                {
                    var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.nctree_add(this, new Ptr<uint>(specPtr), new Ptr<NcTreeItem>(addPtr));
                    if (__r != 0) throw new NcResultException("nctree_add", __r);
                }
            }
        }
        public uint Del()
        {
            uint spec = default;
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.nctree_del(this, new Ptr<uint>(&spec));
            if (__r != 0) throw new NcResultException("nctree_del", __r);
            return spec;
        }
        public void Destroy()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.nctree_destroy(this);
        public Ptr Focused()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.nctree_focused(this);
        public Ptr Goto(Ptr<uint> spec, Ptr<int> failSpec)
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.nctree_goto(this, spec, failSpec);
        public Ptr Goto(out uint spec, out int failSpec)
        {
            spec = default;
            failSpec = default;
            fixed (uint* specPtr = &spec)
            {
                fixed (int* failSpecPtr = &failSpec)
                {
                    return global::Brutal.NotCursesApi.NotCurses.PInvoke.nctree_goto(this, new Ptr<uint>(specPtr), new Ptr<int>(failSpecPtr));
                }
            }
        }
        public Ptr Next()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.nctree_next(this);
        public Bool8 OfferInput(Ptr<NcInput> ni)
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.nctree_offer_input(this, ni);
        public Bool8 OfferInput(out NcInput ni)
        {
            ni = default;
            fixed (NcInput* niPtr = &ni)
            {
                return global::Brutal.NotCursesApi.NotCurses.PInvoke.nctree_offer_input(this, new Ptr<NcInput>(niPtr));
            }
        }
        public NcPlaneHandle Plane()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.nctree_plane(this);
        public Ptr Prev()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.nctree_prev(this);
        public void Redraw()
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.nctree_redraw(this);
            if (__r != 0) throw new NcResultException("nctree_redraw", __r);
        }
    }
}
