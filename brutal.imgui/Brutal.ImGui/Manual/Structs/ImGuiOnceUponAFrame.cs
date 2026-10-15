namespace Brutal.ImGuiApi;

/// <summary>Helper: Execute a block of code at maximum once a frame. </summary>
/// <remarks>
/// Convenient if you want to quickly create a UI within deep-nested code that runs multiple times every frame.<br/>
/// Usage: static ImGuiOnceUponAFrame oaf = new(); if (oaf) ImGui.Text("This will be called only once per frame");
/// </remarks>
/// <source href="https://github.com/ocornut/imgui/blob/v1.92.2-docking/imgui.h#L194"><a href="https://github.com/ocornut/imgui/blob/v1.92.2-docking/imgui.h#L194">imgui.h:194</a></source>
/// <br/>
/// <declaration><c>struct ImGuiOnceUponAFrame</c></declaration>
// A class, not a struct, so the implicit bool operator mutates the shared instance's _refFrame.
public class ImGuiOnceUponAFrame
{
    private int _refFrame = -1;

    public static implicit operator bool(ImGuiOnceUponAFrame value)
    {
        var currentFrame = ImGui.GetFrameCount();

        if (value._refFrame == currentFrame)
            return false;

        value._refFrame = currentFrame;

        return true;
    }
}
