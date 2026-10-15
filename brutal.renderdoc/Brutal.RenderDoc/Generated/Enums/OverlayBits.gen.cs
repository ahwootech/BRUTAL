namespace Brutal.RenderDocApi;

///
[Flags]
public enum OverlayBits : int
{
    /// eRENDERDOC_Overlay_Enabled
    Enabled = 0x1,

    /// eRENDERDOC_Overlay_FrameRate
    FrameRate = 0x2,

    /// eRENDERDOC_Overlay_FrameNumber
    FrameNumber = 0x4,

    /// eRENDERDOC_Overlay_CaptureList
    CaptureList = 0x8,

    /// eRENDERDOC_Overlay_Default
    Default = (Enabled | FrameRate | FrameNumber | CaptureList),

    /// eRENDERDOC_Overlay_All
    All = 0x7ffffff,

    /// eRENDERDOC_Overlay_None
    None = 0,
}
