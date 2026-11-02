/*
 * HelloImGuiFreeType
 *
 * Rasterises Dear ImGui's font atlas with FreeType instead of stb_truetype, headless, and
 * prints the atlas size and glyph count. See Demo/DemoImGui.cs for FreeType fonts on screen.
 *
 * Optionally pass a font:
 *
 *     dotnet run Hello/HelloImGuiFreeType.cs -- path/to/font.ttf
 */

#:package Ahwoo.Brutal.ImGui@2026.10.3
#:package Ahwoo.Brutal.ImGui.FreeType@2026.10.3
#:package Ahwoo.Brutal.Core@2026.10.4
#:package Ahwoo.Brutal.Numerics@2026.10.2
#:package Ahwoo.Brutal.Strings@2026.10.2

using Brutal.ImGuiApi;
using Brutal.ImGuiApi.FreeType;
using Brutal.Numerics;
using Brutal.Strings;

var context = ImGui.CreateContext();

try
{
    Run(args);
}
finally
{
    ImGui.DestroyContext(context);
}

static void Run(string[] args)
{
    var io = ImGui.GetIO();
    io.IniFilename = null; // Don't write imgui.ini.
    io.DisplaySize = new float2(800, 600); // No window, so tell ImGui how big the screen is.
    io.DeltaTime = 1f / 60f;
    io.BackendFlags |= ImGuiBackendFlags.RendererHasTextures; // We "upload" the atlas ourselves below.

    // ImGui.FreeType: swap the font loader before adding any fonts.
    var fonts = io.Fonts;
    fonts.SetFontLoader(ImGuiFreeType.GetFontLoader());
    var font = args.Length > 0 ? fonts.AddFontFromFileTTF(args[0], 24f) : fonts.AddFontDefault();

    // Glyphs are rasterised lazily, so draw some text to bake them into the atlas.
    ImGui.NewFrame();
    ImGui.PushFont(font, 24f);
    ImGui.Begin("Hello ImGui FreeType"u8);
    ImGui.Text("The quick brown fox jumps over the lazy dog 0123456789"u8);
    ImGui.End();
    ImGui.PopFont();
    ImGui.Render();

    // A real renderer would create a GPU texture here; just mark each one as uploaded.
    var drawData = ImGui.GetDrawData();
    for (var i = 0; i < drawData.Textures.Value.Count; i++)
    {
        var texture = drawData.Textures.Value[i];
        if (texture.Status is ImTextureStatus.WantCreate or ImTextureStatus.WantUpdates)
        {
            texture.SetTexID(new ImTextureID(i + 1));
            texture.SetStatus(ImTextureStatus.OK);
        }
    }

    ImString loaderName = fonts.FontLoaderName; // A null-terminated UTF-8 name, owned by the atlas.
    Console.WriteLine($"Font loader: {Utf8.GetString(loaderName)}");
    Console.WriteLine($"Atlas: {fonts.TexData.Width}x{fonts.TexData.Height}, {fonts.TexData.Format}");
    Console.WriteLine($"Glyphs baked at 24px: {font.GetFontBaked(24f).Glyphs.Count}");
}
