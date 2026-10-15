namespace Brutal.RenderDocApi;

/// API version changelog:
/// 1.0.0 - initial release
/// 1.0.1 - Bugfix: IsFrameCapturing() was returning false for captures that were triggered
/// by keypress or TriggerCapture, instead of Start/EndFrameCapture.
/// 1.0.2 - Refactor: Renamed eRENDERDOC_Option_DebugDeviceMode to eRENDERDOC_Option_APIValidation
/// 1.1.0 - Add feature: TriggerMultiFrameCapture(). Backwards compatible with 1.0.x since the new
/// function pointer is added to the end of the struct, the original layout is identical
/// 1.1.1 - Refactor: Renamed remote access to target control (to better disambiguate from remote
/// replay/remote server concept in replay UI)
/// 1.1.2 - Refactor: Renamed &quot;log file&quot; in function names to just capture, to clarify that these
/// are captures and not debug logging files. This is the first API version in the v1.0
/// branch.
/// 1.2.0 - Added feature: SetCaptureFileComments() to add comments to a capture file that will be
/// displayed in the UI program on load.
/// 1.3.0 - Added feature: New capture option eRENDERDOC_Option_AllowUnsupportedVendorExtensions
/// which allows users to opt-in to allowing unsupported vendor extensions to function.
/// Should be used at the user&apos;s own risk.
/// Refactor: Renamed eRENDERDOC_Option_VerifyMapWrites to
/// eRENDERDOC_Option_VerifyBufferAccess, which now also controls initialisation to
/// 0xdddddddd of uninitialised buffer contents.
/// 1.4.0 - Added feature: DiscardFrameCapture() to discard a frame capture in progress and stop
/// capturing without saving anything to disk.
/// 1.4.1 - Refactor: Renamed Shutdown to RemoveHooks to better clarify what is happening
/// 1.4.2 - Refactor: Renamed &apos;draws&apos; to &apos;actions&apos; in callstack capture option.
/// 1.5.0 - Added feature: ShowReplayUI() to request that the replay UI show itself if connected
/// 1.6.0 - Added feature: SetCaptureTitle() which can be used to set a title for a
/// capture made with StartFrameCapture() or EndFrameCapture()
[StructLayout(LayoutKind.Explicit, Size = 216)]
public unsafe partial struct RenderDocApi()
{
    ///
    [FieldOffset(0)]
    public delegate* unmanaged[Cdecl]<int*, int*, int*, void> GetAPIVersion;

    ///
    [FieldOffset(8)]
    public delegate* unmanaged[Cdecl]<CaptureOption, uint, int> SetCaptureOptionU32;

    ///
    [FieldOffset(16)]
    public delegate* unmanaged[Cdecl]<CaptureOption, float, int> SetCaptureOptionF32;

    ///
    [FieldOffset(24)]
    public delegate* unmanaged[Cdecl]<CaptureOption, uint> GetCaptureOptionU32;

    ///
    [FieldOffset(32)]
    public delegate* unmanaged[Cdecl]<CaptureOption, float> GetCaptureOptionF32;

    ///
    [FieldOffset(40)]
    public delegate* unmanaged[Cdecl]<InputButton*, int, void> SetFocusToggleKeys;

    ///
    [FieldOffset(48)]
    public delegate* unmanaged[Cdecl]<InputButton*, int, void> SetCaptureKeys;

    ///
    [FieldOffset(56)]
    public delegate* unmanaged[Cdecl]<OverlayBits> GetOverlayBits;

    ///
    [FieldOffset(64)]
    public delegate* unmanaged[Cdecl]<OverlayBits, OverlayBits, void> MaskOverlayBits;

    ///
    [FieldOffset(72)]
    public delegate* unmanaged[Cdecl]<void> RemoveHooks;

    ///
    [FieldOffset(80)]
    public delegate* unmanaged[Cdecl]<void> UnloadCrashHandler;

    /// current name
    [FieldOffset(88)]
    public delegate* unmanaged[Cdecl]<byte*, void> SetCaptureFilePathTemplate;

    /// current name
    [FieldOffset(96)]
    public delegate* unmanaged[Cdecl]<byte*> GetCaptureFilePathTemplate;

    ///
    [FieldOffset(104)]
    public delegate* unmanaged[Cdecl]<uint> GetNumCaptures;

    ///
    [FieldOffset(112)]
    public delegate* unmanaged[Cdecl]<uint, byte*, uint*, ulong*, Bool32> GetCapture;

    ///
    [FieldOffset(120)]
    public delegate* unmanaged[Cdecl]<void> TriggerCapture;

    /// current name
    [FieldOffset(128)]
    public delegate* unmanaged[Cdecl]<Bool32> IsTargetControlConnected;

    ///
    [FieldOffset(136)]
    public delegate* unmanaged[Cdecl]<Bool32, byte*, Bool32> LaunchReplayUI;

    ///
    [FieldOffset(144)]
    public delegate* unmanaged[Cdecl]<DevicePointer, WindowHandle, void> SetActiveWindow;

    ///
    [FieldOffset(152)]
    public delegate* unmanaged[Cdecl]<DevicePointer, WindowHandle, void> StartFrameCapture;

    ///
    [FieldOffset(160)]
    public delegate* unmanaged[Cdecl]<Bool32> IsFrameCapturing;

    ///
    [FieldOffset(168)]
    public delegate* unmanaged[Cdecl]<DevicePointer, WindowHandle, uint> EndFrameCapture;

    /// new function in 1.1.0
    [FieldOffset(176)]
    public delegate* unmanaged[Cdecl]<uint, void> TriggerMultiFrameCapture;

    /// new function in 1.2.0
    [FieldOffset(184)]
    public delegate* unmanaged[Cdecl]<byte*, byte*, void> SetCaptureFileComments;

    /// new function in 1.4.0
    [FieldOffset(192)]
    public delegate* unmanaged[Cdecl]<DevicePointer, WindowHandle, uint> DiscardFrameCapture;

    /// new function in 1.5.0
    [FieldOffset(200)]
    public delegate* unmanaged[Cdecl]<Bool32> ShowReplayUI;

    /// new function in 1.6.0
    [FieldOffset(208)]
    public delegate* unmanaged[Cdecl]<byte*, void> SetCaptureTitle;
}
