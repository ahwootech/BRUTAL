/*
 * HelloImPlot
 *
 * Plots a sine wave with ImPlot for one headless Dear ImGui frame and prints how much geometry
 * it produced. See Demo/DemoImGui.cs for an ImPlot plot on screen.
 */

#:package Ahwoo.Brutal.ImGui@2026.10.3
#:package Ahwoo.Brutal.ImPlot@2026.10.3
#:package Ahwoo.Brutal.Core@2026.10.4
#:package Ahwoo.Brutal.Numerics@2026.10.2

using Brutal.ImGuiApi;
using Brutal.ImPlotApi;
using Brutal.Numerics;

var context = ImGui.CreateContext();

// ImPlot keeps its own context alongside ImGui's.
var plotContext = ImPlot.CreateContext();
ImPlot.SetImGuiContext(context);

try
{
    Run();
}
finally
{
    ImPlot.DestroyContext(plotContext);
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

    var xs = new float[200];
    var ys = new float[200];
    for (var i = 0; i < xs.Length; i++)
    {
        xs[i] = i * 0.05f;
        ys[i] = MathF.Sin(xs[i]);
    }

    ImGui.NewFrame();

    ImGui.SetNextWindowSize(new float2(500, 400));
    ImGui.Begin("Hello ImPlot"u8);
    if (ImPlot.BeginPlot("Sine Wave"u8, new float2(-1, -1))) // Fill the window.
    {
        // Auto-fit only kicks in on the next frame, so give this single frame its limits up front.
        ImPlot.SetupAxesLimits(0, 10, -1.1, 1.1);
        ImPlot.PlotLine("sin(x)"u8, xs, ys);
        ImPlot.EndPlot();
    }
    ImGui.End();

    ImGui.Render();

    // A renderer would draw these; here we just count them.
    var drawData = ImGui.GetDrawData();
    var commands = 0;
    for (var i = 0; i < drawData.CmdListsCount; i++)
        commands += drawData.CmdLists[i].CmdBuffer.Count;

    Console.WriteLine($"Plotted {xs.Length} points");
    Console.WriteLine(
        $"Draw data: {drawData.CmdListsCount} lists, {drawData.TotalVtxCount} vertices, {drawData.TotalIdxCount} indices, {commands} commands"
    );
}
