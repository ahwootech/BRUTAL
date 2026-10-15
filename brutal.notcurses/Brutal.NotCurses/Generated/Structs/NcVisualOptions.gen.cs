using System.Runtime.InteropServices.Marshalling;
using Brutal;
using Brutal.Interop;
using Brutal.Pointers;
namespace Brutal.NotCursesApi
{
    public unsafe partial struct NcVisualOptions
    {
        /// if no ncplane is provided, one will be created using the exact size
        /// necessary to render the source with perfect fidelity (this might be
        /// smaller or larger than the rendering area). if NCVISUAL_OPTION_CHILDPLANE
        /// is provided, this must be non-NULL, and will be interpreted as the parent.
        public NcPlaneHandle N;
        /// the scaling is ignored if no ncplane is provided (it ought be NCSCALE_NONE
        /// in this case). otherwise, the source is stretched/scaled relative to the
        /// provided ncplane.
        public NcScale Scaling;
        /// if an ncplane is provided, y and x specify where the visual will be
        /// rendered on that plane. otherwise, they specify where the created ncplane
        /// will be placed relative to the standard plane's origin. x is an ncalign_e
        /// value if NCVISUAL_OPTION_HORALIGNED is provided. y is an ncalign_e if
        /// NCVISUAL_OPTION_VERALIGNED is provided.
        public int Y;
        /// if an ncplane is provided, y and x specify where the visual will be
        /// rendered on that plane. otherwise, they specify where the created ncplane
        /// will be placed relative to the standard plane's origin. x is an ncalign_e
        /// value if NCVISUAL_OPTION_HORALIGNED is provided. y is an ncalign_e if
        /// NCVISUAL_OPTION_VERALIGNED is provided.
        public int X;
        public uint Begy; // origin of rendered region in pixels
        public uint Begx; // origin of rendered region in pixels
        public uint Leny; // size of rendered region in pixels
        public uint Lenx; // size of rendered region in pixels
        public NcBlitter Blitter; // glyph set to use (maps input to output cells)
        public NcVisualOption Flags; // bitmask over NCVISUAL_OPTION_*
        public uint Transcolor; // treat this color as transparent under NCVISUAL_OPTION_ADDALPHA
        /// pixel offsets within the cell. if NCBLIT_PIXEL is used, the bitmap will
        /// be drawn offset from the upper-left cell's origin by these amounts. it is
        /// an error if either number exceeds the cell-pixel geometry in its
        /// dimension. if NCBLIT_PIXEL is not used, these fields are ignored.
        /// this functionality can be used for smooth bitmap movement.
        public uint Pxoffy;
        /// pixel offsets within the cell. if NCBLIT_PIXEL is used, the bitmap will
        /// be drawn offset from the upper-left cell's origin by these amounts. it is
        /// an error if either number exceeds the cell-pixel geometry in its
        /// dimension. if NCBLIT_PIXEL is not used, these fields are ignored.
        /// this functionality can be used for smooth bitmap movement.
        public uint Pxoffx;
    }
}
