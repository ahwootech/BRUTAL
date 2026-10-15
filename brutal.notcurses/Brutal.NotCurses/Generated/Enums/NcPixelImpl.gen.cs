using System;
namespace Brutal.NotCursesApi
{
    /// pixel blitting implementations. informative only; don't special-case
    /// based off any of this information!
    public enum NcPixelImpl
    {
        None = 0,
        Sixel, // sixel
        LinuxFb, // linux framebuffer
        ITerm2, // iTerm2
        /// C=1 (disabling scrolling) was only introduced in 0.20.0, at the same
        /// time as animation. prior to this, graphics had to be entirely redrawn
        /// on any change, and it wasn't possible to use the bottom line.
        KittyStatic,
        /// until 0.22.0's introduction of 'a=c' for self-referential composition, we
        /// had to keep a complete copy of the RGBA data, in case a wiped cell needed
        /// to be rebuilt. we'd otherwise have to unpack the glyph and store it into
        /// the auxvec on the fly.
        KittyAnimated,
        /// with 0.22.0, we only ever write transparent cells after writing the
        /// original image (which we now deflate, since we needn't unpack it later).
        /// the only data we need keep is the auxvecs.
        KittySelfRef,
    }
}
