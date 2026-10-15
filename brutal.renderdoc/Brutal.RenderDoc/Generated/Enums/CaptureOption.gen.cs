namespace Brutal.RenderDocApi;

/// ///////////////////////////////////////////////////////////////////////////////////////////////
/// RenderDoc capture options
public enum CaptureOption : int
{
    /// eRENDERDOC_Option_AllowVSync
    AllowVSync = 0,

    /// eRENDERDOC_Option_AllowFullscreen
    AllowFullscreen = 1,

    /// eRENDERDOC_Option_APIValidation
    APIValidation = 2,

    /// eRENDERDOC_Option_CaptureCallstacks
    CaptureCallstacks = 3,

    /// eRENDERDOC_Option_CaptureCallstacksOnlyActions
    CaptureCallstacksOnlyActions = 4,

    /// eRENDERDOC_Option_DelayForDebugger
    DelayForDebugger = 5,

    /// eRENDERDOC_Option_VerifyBufferAccess
    VerifyBufferAccess = 6,

    /// eRENDERDOC_Option_HookIntoChildren
    HookIntoChildren = 7,

    /// eRENDERDOC_Option_RefAllResources
    RefAllResources = 8,

    /// eRENDERDOC_Option_SaveAllInitials
    SaveAllInitials = 9,

    /// eRENDERDOC_Option_CaptureAllCmdLists
    CaptureAllCmdLists = 10,

    /// eRENDERDOC_Option_DebugOutputMute
    DebugOutputMute = 11,

    /// eRENDERDOC_Option_AllowUnsupportedVendorExtensions
    AllowUnsupportedVendorExtensions = 12,

    /// eRENDERDOC_Option_SoftMemoryLimit
    SoftMemoryLimit = 13,
}
