using System;
namespace Brutal.NotCursesApi
{
    /// How to scale an ncvisual during rendering. NCSCALE_NONE will apply no
    /// scaling. NCSCALE_SCALE scales a visual to the plane's size, maintaining
    /// aspect ratio. NCSCALE_STRETCH stretches and scales the image in an attempt
    /// to fill the entirety of the plane. NCSCALE_NONE_HIRES and
    /// NCSCALE_SCALE_HIRES behave like their counterparts, but admit blitters
    /// which don't preserve aspect ratio.
    public enum NcScale
    {
        None,
        Scale,
        Stretch,
        NoneHires,
        ScaleHires,
    }
}
