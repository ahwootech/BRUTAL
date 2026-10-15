namespace Brutal.ImGuiApi;

public record struct ImGuiID(uint Value)
{
    public static implicit operator ImGuiID(uint value) => new(value);

    public static implicit operator ImGuiID(int value) => new((uint)value);

    public static implicit operator uint(ImGuiID value) => value.Value;

    public static implicit operator int(ImGuiID value) => (int)value.Value;
}
