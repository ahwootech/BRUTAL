namespace Brutal.ImGuiApi.Extensions;

public abstract partial class ImGuiCompatibilityEx : ImGui
{
    #region overloads / permutations

    /// <inheritdoc cref="ImGui.PInvoke.InputText"/>
    [Obsolete("InputText(ref string) is obsolete, use the ImInputString overload instead.", error: false)]
    public static bool InputText(
        ImString label,
        ref string input,
        uint maxLength,
        ImGuiInputTextFlags flags = ImGuiInputTextFlags.None,
        ImGuiInputTextCallback? callback = null,
        IntPtr userData = 0
    )
    {
        // HACK: this allocates, remove when conversion is done
        var tmpInput = new ImInputString((int)maxLength, input);
        var changed = ImGui.InputText(label, tmpInput, flags, callback, userData);
        if (changed)
            input = tmpInput.ToString();
        return changed;
    }

    /// <inheritdoc cref="ImGui.PInvoke.MenuItem_0"/>
    [Obsolete("use the MenuItem(\"label\", selected: selected) syntax instead.", error: false)]
    public static bool MenuItem(ImString label, bool selected_obsolete) =>
        ImGui.MenuItem(label, selected: selected_obsolete);

    /// <inheritdoc cref="ImGui.PInvoke.MenuItem_0"/>
    [Obsolete("use the MenuItem(\"label\", selected: selected, enabled: enabled) syntax instead.", error: false)]
    public static bool MenuItem(ImString label, bool selected_obsolete, bool enabled_obsolete) =>
        ImGui.MenuItem(label, selected: selected_obsolete, enabled: enabled_obsolete);

    /// <inheritdoc cref="ImGui.PInvoke.BeginChild_0"/>
    [Obsolete("use the BeginChild(\"id\", childFlags: childFlags) syntax instead.", error: false)]
    public static bool BeginChild(ImString strId, ImGuiChildFlags childFlags_obsolete) =>
        ImGui.BeginChild(strId, childFlags: childFlags_obsolete);

    /// <inheritdoc cref="ImGui.PInvoke.BeginChild_0"/>
    [Obsolete("use the BeginChild(\"id\", windowFlags: windowFlags) syntax instead.", error: false)]
    public static bool BeginChild(ImString strId, float2? size, ImGuiWindowFlags windowFlags_obsolete) =>
        ImGui.BeginChild(strId, size, windowFlags: windowFlags_obsolete);

    #endregion
}
