using System.Runtime.InteropServices.Marshalling;
using Brutal;
using Brutal.Interop;
using Brutal.Pointers;
namespace Brutal.NotCursesApi
{
    public unsafe partial struct NcPlaneOptions
    {
        public int Y; // vertical placement relative to parent plane
        public int X; // horizontal placement relative to parent plane
        public uint Rows; // rows, must be >0 unless NCPLANE_OPTION_MARGINALIZED
        public uint Cols; // columns, must be >0 unless NCPLANE_OPTION_MARGINALIZED
        public Ptr UserPtr; // user curry, may be NULL
        public Ptr<byte> Name; // name (used only for debugging), may be NULL
        public delegate* unmanaged[Cdecl]<NcPlaneHandle, int> ResizeCb; // callback when parent is resized
        public NcPlaneOption Flags; // closure over NCPLANE_OPTION_*
        public uint MarginB; // margins (require NCPLANE_OPTION_MARGINALIZED)
        public uint MarginR; // margins (require NCPLANE_OPTION_MARGINALIZED)
    }
}
