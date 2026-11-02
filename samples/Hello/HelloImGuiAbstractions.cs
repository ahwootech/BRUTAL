/*
 * HelloImGuiAbstractions
 *
 * The in-game ConsoleWindow and its TerminalInterface: registers [TerminalAction] commands, runs
 * a few command lines with typed arguments, then draws the console headless.
 * See Hello/HelloImGui.cs for Dear ImGui on screen.
 */

#:package Ahwoo.Brutal.ImGui.Abstractions@2026.10.3
#:package Ahwoo.Brutal.Core@2026.10.4
#:package Ahwoo.Brutal.ImGui@2026.10.3
#:package Ahwoo.Brutal.Numerics@2026.10.2

// RIAN: This sample primarly showcases the console interface that all RW projects use.

using Brutal.ImGuiApi;
using Brutal.ImGuiApi.Abstractions;
using Brutal.Numerics;

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

    // Disposed when Run returns, before the ImGui context is destroyed.
    using var console = new ConsoleWindow();
    console.DisableMessageFading();

    // Commands are plain methods; the terminal parses arguments into their parameter types.
    console.Terminal.RegisterCommand(Hello);
    console.Terminal.RegisterCommand(Add);
    console.Terminal.OnOutput += (message, type) => Say($"[{type}] {message}"); // Parse errors land here.

    // What a player would type into the console; ';' separates commands on one line.
    string[] lines = ["hello World", "add 2 3; add 40", "add two 3"];
    foreach (var line in lines)
    {
        Console.WriteLine($"> {line}");
        console.Submit(line);
    }

    // Draw the open console as a game would each frame; it sizes itself to its log, which takes a
    // frame to measure, so draw two.
    console.Show();
    for (var frame = 0; frame < 2; frame++)
    {
        ImGui.NewFrame();
        var viewport = ImGui.GetMainViewport();
        console.Draw(viewport.Pos, viewport.Size, io.DeltaTime);
        ImGui.Render();
    }

    var drawData = ImGui.GetDrawData();
    Console.WriteLine($"Console drawn: {drawData.TotalVtxCount} vertices, {drawData.TotalIdxCount} indices");

    // Print to the in-game console, and echo to stdout since there's no window to see it in.
    void Say(string message)
    {
        console.Print(message);
        Console.WriteLine(message);
    }

    [TerminalAction("hello", "Prints a greeting")]
    void Hello(string name) => Say($"Hello, {name}!");

    [TerminalAction("add", "Adds two integers")]
    void Add(int a, int b = 2) => Say($"{a} + {b} = {a + b}");
}
