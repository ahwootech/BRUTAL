namespace Brutal.RenderDocApi;

public static unsafe partial class RenderDoc
{
    [ApiVersion(1, 0)]
    public static void GetApiVersion(out int major, out int minor, out int patch)
    {
        fixed (int* major_fixed = &major)
        fixed (int* minor_fixed = &minor)
        fixed (int* patch_fixed = &patch)
            Api->GetAPIVersion(major_fixed, minor_fixed, patch_fixed);
    }

    [ApiVersion(1, 0)]
    public static int SetCaptureOption(CaptureOption opt, uint val) => Api->SetCaptureOptionU32(opt, val);

    [ApiVersion(1, 0)]
    public static int SetCaptureOption(CaptureOption opt, float val) => Api->SetCaptureOptionF32(opt, val);

    [ApiVersion(1, 0)]
    public static uint GetCaptureOptionU32(CaptureOption opt) => Api->GetCaptureOptionU32(opt);

    [ApiVersion(1, 0)]
    public static float GetCaptureOptionF32(CaptureOption opt) => Api->GetCaptureOptionF32(opt);

    [ApiVersion(1, 0)]
    public static void SetFocusToggleKeys(ReadOnlySpan<InputButton> keys)
    {
        fixed (InputButton* keys_fixed = keys)
            Api->SetFocusToggleKeys(keys_fixed, keys.Length);
    }

    [ApiVersion(1, 0)]
    public static void SetCaptureKeys(ReadOnlySpan<InputButton> keys)
    {
        fixed (InputButton* keys_fixed = keys)
            Api->SetCaptureKeys(keys_fixed, keys.Length);
    }

    [ApiVersion(1, 0)]
    public static OverlayBits OverlayBits
    {
        get => Api->GetOverlayBits();
        set => Api->MaskOverlayBits(0, value);
    }

    [ApiVersion(1, 0)]
    public static void MaskOverlayBits(OverlayBits And, OverlayBits Or) => Api->MaskOverlayBits(And, Or);

    [ApiVersion(1, 0)]
    public static partial void RemoveHooks();

    [ApiVersion(1, 0)]
    public static void UnloadCrashHandler() => Api->UnloadCrashHandler();

    [ApiVersion(1, 0)]
    public static void SetCaptureFilePathTemplate(String8In pathtemplate)
    {
        fixed (byte* pathtemplate_fixed = pathtemplate)
            Api->SetCaptureFilePathTemplate(pathtemplate_fixed);
    }

    [ApiVersion(1, 0)]
    public static String8Return CaptureFilePathTemplate
    {
        get => Utf8.GetNullTerminatedSpan(Api->GetCaptureFilePathTemplate());
        set => SetCaptureFilePathTemplate(value);
    }

    [ApiVersion(1, 0)]
    public static uint NumCaptures => Api->GetNumCaptures();

    [ApiVersion(1, 0)]
    public static bool GetCapture(uint idx, String8Out filename, out uint pathlength, out ulong timestamp)
    {
        fixed (byte* filename_fixed = filename)
        fixed (uint* pathlength_fixed = &pathlength)
        fixed (ulong* timestamp_fixed = &timestamp)
            return Api->GetCapture(idx, filename_fixed, pathlength_fixed, timestamp_fixed);
    }

    [ApiVersion(1, 0)]
    public static void TriggerCapture() => Api->TriggerCapture();

    [ApiVersion(1, 0)]
    public static bool IsTargetControlConnected => Api->IsTargetControlConnected();

    [ApiVersion(1, 0)]
    public static bool LaunchReplayUI(bool connectTargetControl, String8In cmdline)
    {
        fixed (byte* cmdline_fixed = cmdline)
            return Api->LaunchReplayUI(connectTargetControl, cmdline_fixed);
    }

    [ApiVersion(1, 0)]
    public static void SetActiveWindow(DevicePointer device, WindowHandle wndHandle) =>
        Api->SetActiveWindow(device, wndHandle);

    [ApiVersion(1, 0)]
    public static void StartFrameCapture(DevicePointer device, WindowHandle wndHandle) =>
        Api->StartFrameCapture(device, wndHandle);

    [ApiVersion(1, 0)]
    public static bool IsFrameCapturing => Api->IsFrameCapturing();

    [ApiVersion(1, 0)]
    public static uint EndFrameCapture(DevicePointer device, WindowHandle wndHandle) =>
        Api->EndFrameCapture(device, wndHandle);

    [ApiVersion(1, 1)]
    public static void TriggerMultiFrameCapture(uint numFrames)
    {
        EnsureApiVersion(1, 1);
        Api->TriggerMultiFrameCapture(numFrames);
    }

    [ApiVersion(1, 2)]
    public static void SetCaptureFileComments(String8In filePath, String8In comments)
    {
        EnsureApiVersion(1, 2);
        fixed (byte* filePath_fixed = filePath)
        fixed (byte* comments_fixed = comments)
            Api->SetCaptureFileComments(filePath_fixed, comments_fixed);
    }

    [ApiVersion(1, 4)]
    public static uint DiscardFrameCapture(DevicePointer device, WindowHandle wndHandle)
    {
        EnsureApiVersion(1, 4);
        return Api->DiscardFrameCapture(device, wndHandle);
    }

    [ApiVersion(1, 5)]
    public static bool ShowReplayUI()
    {
        EnsureApiVersion(1, 5);
        return Api->ShowReplayUI();
    }

    [ApiVersion(1, 6)]
    public static void SetCaptureTitle(String8In title)
    {
        EnsureApiVersion(1, 6);
        fixed (byte* title_fixed = title)
            Api->SetCaptureTitle(title_fixed);
    }
}
