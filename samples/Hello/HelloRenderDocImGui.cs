/*
 * HelloRenderDocImGui
 *
 * Draws the RenderDoc ImGui window headlessly and prints how much geometry it produced. The window
 * adds View > RenderDoc to the main menu bar. When the app was launched from RenderDoc (Windows or
 * Linux) the window shows the overlay, capture options, a TriggerCapture button and the list of
 * captures; otherwise (always on macOS) its title reads "RenderDoc (loading failed)" and it only
 * has a Help link and a load/unload button. See Demo/DemoRenderDoc.cs for capturing frames.
 */

#:package Ahwoo.Brutal.ImGui@2026.10.3
#:package Ahwoo.Brutal.RenderDoc@2026.10.3
#:package Ahwoo.Brutal.RenderDoc.ImGui@2026.10.3
#:package Ahwoo.Brutal.Core@2026.10.4
#:package Ahwoo.Brutal.Numerics@2026.10.2

using Brutal.ImGuiApi;
using Brutal.Numerics;
using Brutal.RenderDocApi;

// Call as early as possible, before any graphics API is initialized.
RenderDoc.Initialize();

var context = ImGui.CreateContext();
try
{
    Run();
}
finally
{
    ImGui.DestroyContext(context);
}

static void Run()
{
    var io = ImGui.GetIO();
    io.IniFilename = null; // Don't write imgui.ini.
    io.DisplaySize = new float2(800, 600); // No window, so tell ImGui how big the screen is.
    io.DeltaTime = 1f / 60f;

    // Claim a renderer that handles texture requests so ImGui builds the font atlas during the frame.
    // Nothing uploads it here, which is fine for a headless frame.
    io.BackendFlags |= ImGuiBackendFlags.RendererHasTextures;

    // The window starts hidden; View > RenderDoc toggles it. Show it straight away.
    RenderDocWindow.Instance.Visible = true;

    // The window sizes itself to fit, and ImGui hides auto-sized windows on their first frame while
    // it measures them, so run two frames to see it drawn.
    for (var frame = 0; frame < 2; frame++)
    {
        ImGui.NewFrame();
        RenderDocWindow.Instance.OnImGui(); // Call once per frame, between NewFrame and Render.
        ImGui.Render();
    }

    // A renderer would draw these; here we just count them.
    var drawData = ImGui.GetDrawData();
    var commands = 0;
    for (var i = 0; i < drawData.CmdListsCount; i++)
        commands += drawData.CmdLists[i].CmdBuffer.Count;

    Console.WriteLine($"RenderDoc available: {RenderDoc.IsAvailable}, state: {RenderDoc.State}");
    Console.WriteLine(
        $"Draw data: {drawData.CmdListsCount} lists, {drawData.TotalVtxCount} vertices, {drawData.TotalIdxCount} indices, {commands} commands"
    );
}
