using System.Runtime.InteropServices;

namespace Brutal.ImGuiApi;

public partial struct ImGuiPlatformIO
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate byte* GetClipboardTextFnDelegate(ImGuiContextPtr ctx);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void SetClipboardTextFnDelegate(ImGuiContextPtr ctx, byte* text);
}
