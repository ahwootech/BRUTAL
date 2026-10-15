using System.Runtime.InteropServices.Marshalling;
using Brutal;
using Brutal.Interop;
using Brutal.Pointers;
namespace Brutal.NotCursesApi
{
    /// describes all geometries of an ncvisual: those which are inherent, and those
    /// dependent upon a given rendering regime. pixy and pixx are the true internal
    /// pixel geometry, taken directly from the load (and updated by
    /// ncvisual_resize()). cdimy/cdimx are the cell-pixel geometry *at the time
    /// of this call* (it can change with a font change, in which case all values
    /// other than pixy/pixx are invalidated). rpixy/rpixx are the pixel geometry as
    /// handed to the blitter, following any scaling. scaley/scalex are the number
    /// of input pixels drawn to a single cell; when using NCBLIT_PIXEL, they are
    /// equivalent to cdimy/cdimx. rcelly/rcellx are the cell geometry as written by
    /// the blitter, following any padding (there is padding whenever rpix{y, x} is
    /// not evenly divided by scale{y, x}, and also sometimes for Sixel).
    /// maxpixely/maxpixelx are defined only when NCBLIT_PIXEL is used, and specify
    /// the largest bitmap that the terminal is willing to accept. blitter is the
    /// blitter which will be used, a function of the requested blitter and the
    /// blitters actually supported by this environment. if no ncvisual was
    /// supplied, only cdimy/cdimx are filled in.
    public unsafe partial struct NcVGeom
    {
        public uint Pixy; // true pixel geometry of ncvisual data
        public uint Pixx; // true pixel geometry of ncvisual data
        public uint Cdimy; // terminal cell geometry when this was calculated
        public uint Cdimx; // terminal cell geometry when this was calculated
        public uint Rpixy; // rendered pixel geometry (per visual_options)
        public uint Rpixx; // rendered pixel geometry (per visual_options)
        public uint Rcelly; // rendered cell geometry (per visual_options)
        public uint Rcellx; // rendered cell geometry (per visual_options)
        public uint Scaley; // source pixels per filled cell
        public uint Scalex; // source pixels per filled cell
        public uint Begy; // upper-left corner of used region
        public uint Begx; // upper-left corner of used region
        public uint Leny; // geometry of used region
        public uint Lenx; // geometry of used region
        public uint Maxpixely; // only defined for NCBLIT_PIXEL
        public uint Maxpixelx; // only defined for NCBLIT_PIXEL
        public NcBlitter Blitter; // blitter that will be used
    }
}
