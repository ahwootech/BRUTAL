using Brutal.ImGuiApi.Internal;

namespace Brutal.ImGuiApi.Extensions;

public partial class ImGuiCompatibilityEx
{
    [Obsolete("Use Brutal.ImGuiApi.Internal.ImGui.GetCurrentWindow()", error: false)]
    public static ImGuiWindowPtr GetCurrentWindow() => Internal.GetCurrentWindow();
}
