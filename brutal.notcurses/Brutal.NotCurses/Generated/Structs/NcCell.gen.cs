using System.Runtime.InteropServices.Marshalling;
using Brutal;
using Brutal.Interop;
using Brutal.Pointers;
namespace Brutal.NotCursesApi
{
    /// An nccell corresponds to a single character cell on some plane, which can be
    /// occupied by a single grapheme cluster (some root spacing glyph, along with
    /// possible combining characters, which might span multiple columns). At any
    /// cell, we can have a theoretically arbitrarily long UTF-8 EGC, a foreground
    /// color, a background color, and an attribute set. Valid grapheme cluster
    /// contents include:
    /// 
    ///  * A NUL terminator,
    ///  * A single control character, followed by a NUL terminator,
    ///  * At most one spacing character, followed by zero or more nonspacing
    ///    characters, followed by a NUL terminator.
    /// 
    /// Multi-column characters can only have a single style/color throughout.
    /// Existence is suffering, and thus wcwidth() is not reliable. It's just
    /// quoting whether or not the EGC contains a "Wide Asian" double-width
    /// character. This is set for some things, like most emoji, and not set for
    /// other things, like cuneiform. True display width is a *function of the
    /// font and terminal*. Among the longest Unicode codepoints is
    /// 
    ///    U+FDFD ARABIC LIGATURE BISMILLAH AR-RAHMAN AR-RAHEEM ﷽
    /// 
    /// wcwidth() rather optimistically claims this most exalted glyph to occupy
    /// a single column. BiDi text is too complicated for me to even get into here.
    /// Be assured there are no easy answers; ours is indeed a disturbing Universe.
    /// 
    /// Each nccell occupies 16 static bytes (128 bits). The surface is thus ~1.6MB
    /// for a (pretty large) 500x200 terminal. At 80x43, it's less than 64KB.
    /// Dynamic requirements (the egcpool) can add up to 16MB to an ncplane, but
    /// such large pools are unlikely in common use.
    /// 
    /// We implement some small alpha compositing. Foreground and background both
    /// have two bits of inverted alpha. The actual grapheme written to a cell is
    /// the topmost non-zero grapheme. If its alpha is 00, its foreground color is
    /// used unchanged. If its alpha is 10, its foreground color is derived entirely
    /// from cells underneath it. Otherwise, the result will be a composite.
    /// Likewise for the background. If the bottom of a coordinate's zbuffer is
    /// reached with a cumulative alpha of zero, the default is used. In this way,
    /// a terminal configured with transparent background can be supported through
    /// multiple occluding ncplanes. A foreground alpha of 11 requests high-contrast
    /// text (relative to the computed background). A background alpha of 11 is
    /// currently forbidden.
    /// 
    /// Default color takes precedence over palette or RGB, and cannot be used with
    /// transparency. Indexed palette takes precedence over RGB. It cannot
    /// meaningfully set transparency, but it can be mixed into a cascading color.
    /// RGB is used if neither default terminal colors nor palette indexing are in
    /// play, and fully supports all transparency options.
    /// 
    /// This structure is exposed only so that most functions can be inlined. Do not
    /// directly modify or access the fields of this structure; use the API.
    public unsafe partial struct NcCell
    {
        public uint Gcluster; // 4B → 4B little endian EGC
        public byte GclusterBackstop; // 1B → 5B (8 bits of zero)
        public byte Width; // 1B → 6B (8 bits of EGC column width)
        public ushort Stylemask; // 2B → 8B (16 bits of NCSTYLE_* attributes)
        public ulong Channels; // + 8B == 16B
    }
}
