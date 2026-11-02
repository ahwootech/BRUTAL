/*
 * HelloImGuiExtensions
 *
 * ImGuiEx widgets that bind straight to C# enums, driven headless by simulated mouse clicks.
 * See Hello/HelloImGui.cs for Dear ImGui on screen.
 */

#:package Ahwoo.Brutal.ImGui.Extensions@2026.10.3
#:package Ahwoo.Brutal.Core@2026.10.4
#:package Ahwoo.Brutal.ImGui@2026.10.3
#:package Ahwoo.Brutal.Numerics@2026.10.2

// RIAN: This package contains small extras for ImGui that we like, but possibly needs a better name as it's very opinionated.

using Brutal.ImGuiApi;
using Brutal.ImGuiApi.Extensions;
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

    var shape = Shape.Circle;
    var layers = Layers.Ground;
    var triangleCenter = float2.Zero;
    var waterCenter = float2.Zero;

    Console.WriteLine($"Before: shape = {shape}, layers = {layers}");

    // No backend, so feed ImGui a click on "Triangle" then on "Water". A new window takes
    // a frame to settle its layout, so the clicks start on frame 2.
    for (var frame = 0; frame < 7; frame++)
    {
        switch (frame)
        {
            case 2:
                io.AddMousePosEvent(triangleCenter.X, triangleCenter.Y);
                io.AddMouseButtonEvent(0, true);
                break;
            case 4:
                io.AddMousePosEvent(waterCenter.X, waterCenter.Y);
                io.AddMouseButtonEvent(0, true);
                break;
            case 3:
            case 5:
                io.AddMouseButtonEvent(0, false);
                break;
        }

        ImGui.NewFrame();

        ImGui.Begin("Hello ImGui Extensions"u8);

        // ImGuiEx widgets take the enum by ref, no casting to and from int.
        ImGuiEx.RadioButton("Circle"u8, ref shape, Shape.Circle);
        ImGui.SameLine();
        ImGuiEx.RadioButton("Square"u8, ref shape, Shape.Square);
        ImGui.SameLine();
        ImGuiEx.RadioButton("Triangle"u8, ref shape, Shape.Triangle);
        triangleCenter = (ImGui.GetItemRectMin() + ImGui.GetItemRectMax()) * 0.5f;

        ImGuiEx.Combo("Shape"u8, ref shape, "Circle\0Square\0Triangle\0"u8);

        // Works for [Flags] enums too: each checkbox toggles one bit.
        ImGuiEx.CheckboxFlags("Ground"u8, ref layers, Layers.Ground);
        ImGuiEx.CheckboxFlags("Water"u8, ref layers, Layers.Water);
        waterCenter = (ImGui.GetItemRectMin() + ImGui.GetItemRectMax()) * 0.5f;
        ImGuiEx.CheckboxFlags("Sky"u8, ref layers, Layers.Sky);

        ImGui.End();

        ImGui.Render();
    }

    Console.WriteLine($"After:  shape = {shape}, layers = {layers}");

    // Plus a few non-widget helpers, e.g. colour conversion on a float4.
    var red = ImGuiEx.ColorConvertHSVtoRGB(new float4(0f, 1f, 1f, 1f));
    Console.WriteLine($"HSV(0, 1, 1) -> RGB({red.X}, {red.Y}, {red.Z})");
}

enum Shape
{
    Circle,
    Square,
    Triangle,
}

[Flags]
enum Layers
{
    None = 0,
    Ground = 1,
    Water = 2,
    Sky = 4,
}
