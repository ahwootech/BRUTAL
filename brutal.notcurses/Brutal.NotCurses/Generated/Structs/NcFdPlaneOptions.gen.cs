using System.Runtime.InteropServices.Marshalling;
using Brutal;
using Brutal.Interop;
using Brutal.Pointers;
namespace Brutal.NotCursesApi
{
    /// read from an fd until EOF (or beyond, if follow is set), invoking the user's
    /// callback each time. runs in its own context. on EOF or error, the finalizer
    /// callback will be invoked, and the user ought destroy the ncfdplane. the
    /// data is *not* guaranteed to be nul-terminated, and may contain arbitrary
    /// zeroes.
    public unsafe partial struct NcFdPlaneOptions
    {
        public Ptr Curry; // parameter provided to callbacks
        public Bool8 Follow; // keep reading after hitting end? (think tail -f)
        public ulong Flags; // bitfield over NCOPTION_FDPLANE_*
    }
}
