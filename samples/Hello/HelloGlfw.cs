/*
 * HelloGlfw
 *
 * Opens an empty GLFW window with no graphics API. Press Escape to close it.
 */

#:package Ahwoo.Brutal.Glfw@2026.10.5
#:package Ahwoo.Brutal.Numerics@2026.10.2

using Brutal.GlfwApi;
using Brutal.Numerics;

if (!Glfw.Init())
{
    var errorCode = Glfw.GetError(out var errorMessage);
    throw new InvalidOperationException($"Failed to initialize GLFW: {errorCode}, {errorMessage}");
}

try
{
    Run();
}
finally
{
    Glfw.Terminate();
}

static void Run()
{
    // Destroyed when Run returns, before GLFW is terminated.
    using var window = Glfw.CreateWindow(
        new GlfwWindow.CreateInfo
        {
            Title = "Hello Glfw",
            Size = new int2(640, 480),
            Monitor = GlfwMonitor.Null, // Windowed mode.
            Share = null, // No shared context.
        }
    );

    window.OnKey += (handle, key, _, _, _) =>
    {
        if (key == GlfwKey.Escape)
            handle.ShouldClose = true;
    };

    while (!window.ShouldClose)
        Glfw.PollEvents();
}
