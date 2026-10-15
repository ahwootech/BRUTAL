namespace Brutal.ImGuiApi.Extensions;

public partial class ImGuiCompatibilityEx
{
    [Obsolete("use ImGui.Text() instead.", error: false)]
    public static void TextUnformatted(ImString text) => ImGui.Text(text);

    /// <inheritdoc cref="ImGui.Image"/>
    [Obsolete("use ImageWithBg(ImTextureRef, tintColor: color)", error: false)]
    public static void Image(ImTextureID user_texture_id, float2 image_size, float4? tint_col = default) =>
        ImGui.ImageWithBg(new ImTextureRef { _TexID = user_texture_id }, image_size, tintCol: tint_col);

    /// <inheritdoc cref="ImGui.Image"/>
    [Obsolete("use ImTextureRef overload", error: false)]
    public static void Image(ImTextureID user_texture_id, float2 image_size, float2 uv0, float2 uv1) =>
        ImGui.Image(new ImTextureRef { _TexID = user_texture_id }, image_size, uv0, uv1);

    /// <inheritdoc cref="ImGui.PushFont"/>
    [Obsolete(
        "PushFont() API now has a REQUIRED size parameter",
        error: false,
        UrlFormat = "https://github.com/ocornut/imgui/releases/tag/v1.92.0#:~:text=PushFont()%20API%20now%20has%20a%20REQUIRED%20size%20parameter"
    )]
    public static void PushFont(ImFontPtr font) => ImGui.PushFont(font, font.LegacySize);

    [Obsolete(
        "Prefer using PushFont(null, style.FontSizeBase * factor) or use style.FontScaleMain to scale all windows.",
        error: false,
        UrlFormat = "https://github.com/ocornut/imgui/blob/v1.92.2-docking/imgui.h#L4233"
    )]
    public static void SetWindowFontScale(float scale) => throw new NotImplementedException();
}
