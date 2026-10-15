namespace Brutal.ImGuiApi;

public record struct ImFontAtlasRectId(int Value)
{
    public static readonly ImFontAtlasRectId Invalid = new(-1);
}
