using System.Runtime.InteropServices.Marshalling;
using Brutal;
using Brutal.Interop;
using Brutal.Pointers;
namespace Brutal.NotCursesApi
{
    public unsafe partial struct NcSubProcOptions
    {
        public Ptr Curry;
        public ulong RestartPeriod; // restart this many seconds after an exit (watch)
        public ulong Flags; // bitfield over NCOPTION_SUBPROC_*
    }
}
