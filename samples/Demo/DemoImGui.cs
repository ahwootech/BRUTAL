/*
 * DemoImGui
 *
 * Dear ImGui on GLFW + OpenGL: a button, a slider and an ImPlot line plot, with fonts
 * rasterised by FreeType. Press Escape to close it.
 *
 * Optionally pass a font:
 *
 *     dotnet run Demo/DemoImGui.cs -- path/to/font.ttf
 */

#:property AllowUnsafeBlocks=true
#:package Ahwoo.Brutal.ImGui@2026.10.3
#:package Ahwoo.Brutal.ImGui.Backends@2026.10.3
#:package Ahwoo.Brutal.ImGui.FreeType@2026.10.3
#:package Ahwoo.Brutal.ImPlot@2026.10.3
#:package Ahwoo.Brutal.Core@2026.10.4
#:package Ahwoo.Brutal.Glfw@2026.10.5
#:package Ahwoo.Brutal.Numerics@2026.10.2
#:package Ahwoo.Brutal.OpenGl@2026.10.2

using Brutal;
using Brutal.GlfwApi;
using Brutal.ImGuiApi;
using Brutal.ImGuiApi.Backends;
using Brutal.ImGuiApi.FreeType;
using Brutal.ImPlotApi;
using Brutal.Numerics;
using Brutal.OpenGlApi;

if (!Glfw.Init())
{
    var errorCode = Glfw.GetError(out var errorMessage);
    throw new InvalidOperationException($"Failed to initialize GLFW: {errorCode}, {errorMessage}");
}

var context = ImGui.CreateContext();
var plotContext = ImPlot.CreateContext();
ImPlot.SetImGuiContext(context);

try
{
    Run(args);
}
finally
{
    ImPlot.DestroyContext(plotContext);
    ImGui.DestroyContext(context);
    Glfw.Terminate();
}

static void Run(string[] args)
{
    Glfw.WindowHint(GlfwWindowHint.ContextVersionMajor, 4);
    Glfw.WindowHint(GlfwWindowHint.ContextVersionMinor, 1);
    Glfw.WindowHint(GlfwWindowHint.OpenGlProfile, Glfw.Constants.GLFW_OPENGL_CORE_PROFILE);

    if (Platform.IsMacOS)
        Glfw.WindowHint(GlfwWindowHint.OpenGlForwardCompat, 1);

    // Declared first so it's disposed last: the backends below need the window and its GL context.
    using var window = Glfw.CreateWindow(new GlfwWindow.CreateInfo { Title = "Demo ImGui", Size = new int2(800, 600) });

    window.MakeContextCurrent();
    Glfw.SwapInterval(1); // Wait for vsync instead of drawing as fast as possible.

    unsafe
    {
        if (!Glad.Initialize(Glfw.PInvoke.GetProcAddress))
            throw new InvalidOperationException("Failed to initialize OpenGL");
    }

    window.OnKey += (handle, key, _, _, _) =>
    {
        if (key == GlfwKey.Escape)
            handle.ShouldClose = true;
    };

    ImGui.GetIO().IniFilename = null; // Don't write imgui.ini.

    // Rasterize fonts with FreeType instead of the built-in stb_truetype.
    var fonts = ImGui.GetIO().Fonts;
    fonts.SetFontLoader(ImGuiFreeType.GetFontLoader());
    if (args.Length > 0)
        fonts.AddFontFromFileTTF(args[0], 24f); // Optional: dotnet run Demo/DemoImGui.cs -- path/to/font.ttf.

    using var glfwBackend = new GlfwBackend(window, GlfwBackend.ClientApi.OpenGL);
    using var openGlBackend = new OpenGlBackend();

    var clicks = 0;
    var frequency = 1f;
    var xs = new float[200];
    var ys = new float[200];

    OpenGl.ClearColor(float4.Rgb(0.2f, 0.3f, 0.3f));

    while (!window.ShouldClose)
    {
        Glfw.PollEvents();

        glfwBackend.NewFrame();
        openGlBackend.NewFrame();
        ImGui.NewFrame();
        // Recycle the scratch memory that interpolated ImGui strings ($"...") use, once per frame.
        ImString.SharedStorage.Reset();

        var time = (float)Glfw.Time;
        for (var i = 0; i < xs.Length; i++)
        {
            xs[i] = i * 0.05f;
            ys[i] = MathF.Sin(xs[i] * frequency + time);
        }

        ImGui.SetNextWindowSize(new float2(500, 400), ImGuiCond.FirstUseEver);
        if (ImGui.Begin("Demo ImGui"u8))
        {
            ImGui.Text("Hello from Dear ImGui!"u8);

            if (ImGui.Button("Click me"u8))
                clicks++;
            ImGui.SameLine();
            ImGui.Text($"Clicked {clicks} times");

            ImGui.SliderFloat("Frequency"u8, ref frequency, 0.1f, 5f);

            if (ImPlot.BeginPlot("Sine Wave"u8, new float2(-1, -1))) // Fill the rest of the window.
            {
                ImPlot.PlotLine("sin(x * f + t)"u8, xs, ys);
                ImPlot.EndPlot();
            }
        }
        ImGui.End();

        ImGui.Render();

        OpenGl.Clear(GlClearBit.Color);
        openGlBackend.RenderDrawData(ImGui.GetDrawData());
        window.SwapBuffers();
    }
}
