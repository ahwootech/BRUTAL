using System.Runtime.InteropServices.Marshalling;
using Brutal;
using Brutal.Interop;
using Brutal.Numerics;
using Brutal.Pointers;
using Brutal.Strings;
namespace Brutal.NotCursesApi
{
    [InteropHandle]
    public unsafe readonly partial struct NcTabbedHandle
    {
    }
    public unsafe readonly partial struct NcTabbedHandle
    {
        public NcTabHandle Add(NcTabHandle after, NcTabHandle before, delegate* unmanaged[Cdecl]<NcTabHandle, NcPlaneHandle, Ptr, void> tcb, RefString8 name, Ptr opaque)
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.nctabbed_add(this, after, before, tcb, name, opaque);
        public void Channels(Ptr<ulong> hdrChan, Ptr<ulong> selChan, Ptr<ulong> sepChan)
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.nctabbed_channels(this, hdrChan, selChan, sepChan);
        public void Channels(out ulong hdrChan, out ulong selChan, out ulong sepChan)
        {
            hdrChan = default;
            selChan = default;
            sepChan = default;
            fixed (ulong* hdrChanPtr = &hdrChan)
            {
                fixed (ulong* selChanPtr = &selChan)
                {
                    fixed (ulong* sepChanPtr = &sepChan)
                    {
                        global::Brutal.NotCursesApi.NotCurses.PInvoke.nctabbed_channels(this, new Ptr<ulong>(hdrChanPtr), new Ptr<ulong>(selChanPtr), new Ptr<ulong>(sepChanPtr));
                    }
                }
            }
        }
        public NcPlaneHandle ContentPlane()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.nctabbed_content_plane(this);
        public void Del(NcTabHandle t)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.nctabbed_del(this, t);
            if (__r != 0) throw new NcResultException("nctabbed_del", __r);
        }
        public void Destroy()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.nctabbed_destroy(this);
        public void EnsureSelectedHeaderVisible()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.nctabbed_ensure_selected_header_visible(this);
        public ulong HdrChan()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.nctabbed_hdrchan(this);
        public NcTabHandle Leftmost()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.nctabbed_leftmost(this);
        public NcTabHandle Next()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.nctabbed_next(this);
        public NcPlaneHandle Plane()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.nctabbed_plane(this);
        public NcTabHandle Prev()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.nctabbed_prev(this);
        public void Redraw()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.nctabbed_redraw(this);
        public void Rotate(int amt)
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.nctabbed_rotate(this, amt);
        public ulong SelChan()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.nctabbed_selchan(this);
        public NcTabHandle Select(NcTabHandle t)
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.nctabbed_select(this, t);
        public NcTabHandle Selected()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.nctabbed_selected(this);
        public string Separator()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.nctabbed_separator(this);
        public void SeparatorWidth()
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.nctabbed_separator_width(this);
            if (__r != 0) throw new NcResultException("nctabbed_separator_width", __r);
        }
        public ulong SepChan()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.nctabbed_sepchan(this);
        public void SetHdrChan(ulong chan)
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.nctabbed_set_hdrchan(this, chan);
        public void SetSelChan(ulong chan)
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.nctabbed_set_selchan(this, chan);
        public void SetSeparator(RefString8 separator)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.nctabbed_set_separator(this, separator);
            if (__r != 0) throw new NcResultException("nctabbed_set_separator", __r);
        }
        public void SetSepChan(ulong chan)
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.nctabbed_set_sepchan(this, chan);
        public void TabCount()
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.nctabbed_tabcount(this);
            if (__r != 0) throw new NcResultException("nctabbed_tabcount", __r);
        }
    }
    public static unsafe partial class StringExtensions
    {
        public static NcTabHandle Add(this NcTabbedHandle self, NcTabHandle after, NcTabHandle before, delegate* unmanaged[Cdecl]<NcTabHandle, NcPlaneHandle, Ptr, void> tcb, string name, Ptr opaque)
        {
            using var nameBuf = new ScratchBuffer(name, stackalloc byte[256]);
            return self.Add(after, before, tcb, nameBuf.Bytes, opaque);
        }
        public static void SetSeparator(this NcTabbedHandle self, string separator)
        {
            using var separatorBuf = new ScratchBuffer(separator, stackalloc byte[256]);
            self.SetSeparator(separatorBuf.Bytes);
        }
    }
}
