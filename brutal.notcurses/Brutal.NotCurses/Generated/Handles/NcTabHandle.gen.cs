using System.Runtime.InteropServices.Marshalling;
using Brutal;
using Brutal.Interop;
using Brutal.Numerics;
using Brutal.Pointers;
using Brutal.Strings;
namespace Brutal.NotCursesApi
{
    [InteropHandle]
    public unsafe readonly partial struct NcTabHandle
    {
    }
    public unsafe readonly partial struct NcTabHandle
    {
        public delegate* unmanaged[Cdecl]<NcTabHandle, NcPlaneHandle, Ptr, void> Cb()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.nctab_cb(this);
        public string Name()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.nctab_name(this);
        public void NameWidth()
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.nctab_name_width(this);
            if (__r != 0) throw new NcResultException("nctab_name_width", __r);
        }
        public NcTabHandle Next()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.nctab_next(this);
        public NcTabHandle Prev()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.nctab_prev(this);
        public delegate* unmanaged[Cdecl]<NcTabHandle, NcPlaneHandle, Ptr, void> SetCb(delegate* unmanaged[Cdecl]<NcTabHandle, NcPlaneHandle, Ptr, void> newcb)
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.nctab_set_cb(this, newcb);
        public void SetName(RefString8 newname)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.nctab_set_name(this, newname);
            if (__r != 0) throw new NcResultException("nctab_set_name", __r);
        }
        public Ptr SetUserPtr(Ptr newopaque)
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.nctab_set_userptr(this, newopaque);
        public Ptr UserPtr()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.nctab_userptr(this);
    }
    public static unsafe partial class StringExtensions
    {
        public static void SetName(this NcTabHandle self, string newname)
        {
            using var newnameBuf = new ScratchBuffer(newname, stackalloc byte[256]);
            self.SetName(newnameBuf.Bytes);
        }
    }
}
