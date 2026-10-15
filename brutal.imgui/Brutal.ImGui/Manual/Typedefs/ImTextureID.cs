namespace Brutal.ImGuiApi;

public record struct ImTextureID(nint Value)
{
    // Special 'invalid' default defined by ImGui
    public static readonly ImTextureID Invalid = new(0);

    public static implicit operator nint(ImTextureID value) => value.Value;

    public static explicit operator ImTextureID(nint value) => new(value);
}
