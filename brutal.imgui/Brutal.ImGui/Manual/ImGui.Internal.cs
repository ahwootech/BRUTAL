namespace Brutal.ImGuiApi
{
    public abstract partial class ImGui
    {
        public abstract partial class Internal : Brutal.ImGuiApi.ImGui
        {
            public new abstract class PInvoke : Brutal.ImGuiApi.Internal.PInvoke;
        }
    }
}

namespace Brutal.ImGuiApi.Internal
{
    public abstract partial class PInvoke : Brutal.ImGuiApi.ImGui.PInvoke;
}
