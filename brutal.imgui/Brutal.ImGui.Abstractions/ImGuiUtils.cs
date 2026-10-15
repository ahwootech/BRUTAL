using Brutal.ImGuiApi;

namespace Brutal.ImGuiApi.Abstractions;

public static class ImGuiUtils
{
    public static void SetLastFocusOnAppearing(bool force = false)
    {
        if (
            force
            || ImGui.IsItemHovered()
            || (ImGui.IsAnyItemFocused() && !ImGui.IsAnyItemActive() && !ImGui.IsMouseClicked(0))
        )
            ImGui.SetKeyboardFocusHere(-1); // Auto focus
    }

    public static void TextShadow(ImString text, ImColor8 color)
    {
        if (text.IsEmpty)
            return;

        var cursorPos = ImGui.GetCursorPos();
        ImGui.SetCursorPos(cursorPos - new float2(-1, -1));
        ImGui.PushStyleColor(ImGuiCol.Text, 0);
        ImGui.Text(text);
        ImGui.PopStyleColor();
        ImGui.SetCursorPos(cursorPos);
        ImGui.PushStyleColor(ImGuiCol.Text, color);
        ImGui.Text(text);
        ImGui.PopStyleColor();
    }
}
