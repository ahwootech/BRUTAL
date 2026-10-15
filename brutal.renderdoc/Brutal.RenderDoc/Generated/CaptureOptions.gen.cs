namespace Brutal.RenderDocApi;

public static partial class RenderDoc
{
    public static partial class CaptureOptions
    {
        public static bool AllowVSync
        {
            get => GetCaptureOptionBool(CaptureOption.AllowVSync);
            set => SetCaptureOption(CaptureOption.AllowVSync, value);
        }
        public static bool AllowFullscreen
        {
            get => GetCaptureOptionBool(CaptureOption.AllowFullscreen);
            set => SetCaptureOption(CaptureOption.AllowFullscreen, value);
        }
        public static bool APIValidation
        {
            get => GetCaptureOptionBool(CaptureOption.APIValidation);
            set => SetCaptureOption(CaptureOption.APIValidation, value);
        }
        public static bool CaptureCallstacks
        {
            get => GetCaptureOptionBool(CaptureOption.CaptureCallstacks);
            set => SetCaptureOption(CaptureOption.CaptureCallstacks, value);
        }
        public static bool CaptureCallstacksOnlyActions
        {
            get => GetCaptureOptionBool(CaptureOption.CaptureCallstacksOnlyActions);
            set => SetCaptureOption(CaptureOption.CaptureCallstacksOnlyActions, value);
        }
        public static float DelayForDebugger
        {
            get => GetCaptureOptionF32(CaptureOption.DelayForDebugger);
            set => SetCaptureOption(CaptureOption.DelayForDebugger, value);
        }
        public static bool VerifyBufferAccess
        {
            get => GetCaptureOptionBool(CaptureOption.VerifyBufferAccess);
            set => SetCaptureOption(CaptureOption.VerifyBufferAccess, value);
        }
        public static bool HookIntoChildren
        {
            get => GetCaptureOptionBool(CaptureOption.HookIntoChildren);
            set => SetCaptureOption(CaptureOption.HookIntoChildren, value);
        }
        public static bool RefAllResources
        {
            get => GetCaptureOptionBool(CaptureOption.RefAllResources);
            set => SetCaptureOption(CaptureOption.RefAllResources, value);
        }
        public static bool SaveAllInitials
        {
            get => GetCaptureOptionBool(CaptureOption.SaveAllInitials);
            set => SetCaptureOption(CaptureOption.SaveAllInitials, value);
        }
        public static bool CaptureAllCmdLists
        {
            get => GetCaptureOptionBool(CaptureOption.CaptureAllCmdLists);
            set => SetCaptureOption(CaptureOption.CaptureAllCmdLists, value);
        }
        public static bool DebugOutputMute
        {
            get => GetCaptureOptionBool(CaptureOption.DebugOutputMute);
            set => SetCaptureOption(CaptureOption.DebugOutputMute, value);
        }
        public static bool AllowUnsupportedVendorExtensions
        {
            get => GetCaptureOptionBool(CaptureOption.AllowUnsupportedVendorExtensions);
            set => SetCaptureOption(CaptureOption.AllowUnsupportedVendorExtensions, value);
        }
        public static uint SoftMemoryLimit
        {
            get => GetCaptureOptionU32(CaptureOption.SoftMemoryLimit);
            set => SetCaptureOption(CaptureOption.SoftMemoryLimit, value);
        }
    }
}
