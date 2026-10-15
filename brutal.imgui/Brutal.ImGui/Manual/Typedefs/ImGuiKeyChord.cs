namespace Brutal.ImGuiApi;

// Just a wrapper for ImGuiKey values, in the expectation that it will be a combination of Mod flags and a key value.
public record struct ImGuiKeyChord(ImGuiKey Flags)
{
    public static implicit operator ImGuiKeyChord(ImGuiKey key) => new(key);
}
