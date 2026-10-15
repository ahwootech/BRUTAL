using System.Runtime.InteropServices.Marshalling;
using Brutal;
using Brutal.Interop;
using Brutal.Numerics;
using Brutal.Pointers;
using Brutal.Strings;
namespace Brutal.NotCursesApi
{
    [InteropHandle]
    public unsafe readonly partial struct NcFadectxHandle
    {
    }
    public unsafe readonly partial struct NcFadectxHandle
    {
        public void Free()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncfadectx_free(this);
        public void Iterations()
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncfadectx_iterations(this);
            if (__r != 0) throw new NcResultException("ncfadectx_iterations", __r);
        }
    }
}
