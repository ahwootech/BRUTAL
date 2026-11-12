/*
 * HelloImGui
 *
 * Dear ImGui with its GLFW and OpenGL backends: some text, a button and a slider.
 * Press Escape to close it. See Demo/DemoImGui.cs for FreeType fonts and ImPlot.
 */

#:property AllowUnsafeBlocks=true
#:package Ahwoo.Brutal.ImGui@2026.10.3
#:package Ahwoo.Brutal.ImGui.Backends@2026.10.3
#:package Ahwoo.Brutal.Core@2026.10.4
#:package Ahwoo.Brutal.Glfw@2026.10.5
#:package Ahwoo.Brutal.Numerics@2026.10.2
#:package Ahwoo.Brutal.OpenGl@2026.10.2

// RIAN: Please look at this example carefully, especially how the SharedStorage is reset once per frame.
//       The shared storage (leveraged for allocation-free string interpolation) will OoM eventually if you don't.

using Brutal;
using Brutal.GlfwApi;
using Brutal.ImGuiApi;
using Brutal.ImGuiApi.Backends;
using Brutal.Numerics;
using Brutal.OpenGlApi;

// GLFW and OpenGL are just the host here: a window and a GL context for ImGui to draw into.
if (!Glfw.Init())
{
    var errorCode = Glfw.GetError(out var errorMessage);
    throw new InvalidOperationException($"Failed to initialize GLFW: {errorCode}, {errorMessage}");
}

var context = ImGui.CreateContext();

try
{
    Run();
}
finally
{
    ImGui.DestroyContext(context);
    Glfw.Terminate();
}

static void Run()
{
    Glfw.WindowHint(GlfwWindowHint.ContextVersionMajor, 4);
    Glfw.WindowHint(GlfwWindowHint.ContextVersionMinor, 1);
    Glfw.WindowHint(GlfwWindowHint.OpenGlProfile, Glfw.Constants.GLFW_OPENGL_CORE_PROFILE);

    if (Platform.IsMacOS)
        Glfw.WindowHint(GlfwWindowHint.OpenGlForwardCompat, 1);

    // Declared first so it's disposed last: the backends below need the window and its GL context.
    using var window = Glfw.CreateWindow(
        new GlfwWindow.CreateInfo { Title = "Hello ImGui", Size = new int2(800, 600) }
    );

    window.MakeContextCurrent();
    Glfw.SwapInterval(1); // Wait for vsync instead of drawing as fast as possible.

    unsafe
    {
        if (!Glad.Initialize(Glfw.PInvoke.GetProcAddress))
            throw new InvalidOperationException("Failed to load OpenGL functions with GLAD");
    }

    window.OnKey += (handle, key, _, _, _) =>
    {
        if (key == GlfwKey.Escape)
            handle.ShouldClose = true;
    };

    ImGui.GetIO().IniFilename = null; // Don't write imgui.ini.

    // ImGui.Backends: feed GLFW input to ImGui and render its draw lists with OpenGL.
    using var glfwBackend = new GlfwBackend(window, GlfwBackend.ClientApi.OpenGL);
    using var openGlBackend = new OpenGlBackend();

    var clicks = 0;
    var value = 0.5f;

    OpenGl.ClearColor(float4.Rgb(0.2f, 0.3f, 0.3f));

    while (!window.ShouldClose)
    {
        Glfw.PollEvents();

        glfwBackend.NewFrame();
        openGlBackend.NewFrame();
        ImGui.NewFrame();
        // Recycle the scratch memory that interpolated ImGui strings ($"...") use, once per frame.
        ImString.SharedStorage.Reset();

        ImGui.SetNextWindowSize(new float2(400, 200), ImGuiCond.FirstUseEver);
        if (ImGui.Begin("Hello ImGui"u8))
        {
            ImGui.Text("Hello from Dear ImGui!"u8);

            if (ImGui.Button("Click me"u8))
                clicks++;
            ImGui.SameLine();
            ImGui.Text($"Clicked {clicks} times");

            ImGui.SliderFloat("Value"u8, ref value, 0f, 1f);
        }
        ImGui.End();

        ImGui.Render();

        OpenGl.Clear(GlClearBit.Color);
        openGlBackend.RenderDrawData(ImGui.GetDrawData());
        window.SwapBuffers();
    }
}
