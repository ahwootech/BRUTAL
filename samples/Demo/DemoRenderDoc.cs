/*
 * DemoRenderDoc
 *
 * Draws the coloured triangle from Hello/HelloOpenGl.cs and captures a frame with RenderDoc when
 * you press F12. Captures work when the app is launched from RenderDoc (Windows or Linux), or on
 * Windows when RenderDoc is installed in its default folder; otherwise (always on macOS) it still
 * draws and F12 just prints a hint. Press Escape to close it.
 */

#:property AllowUnsafeBlocks=true
#:package Ahwoo.Brutal.Glfw@2026.10.5
#:package Ahwoo.Brutal.OpenGl@2026.10.2
#:package Ahwoo.Brutal.RenderDoc@2026.10.3
#:package Ahwoo.Brutal.Core@2026.10.4
#:package Ahwoo.Brutal.Numerics@2026.10.2
#:package Ahwoo.Brutal.Strings@2026.10.2

using Brutal;
using Brutal.GlfwApi;
using Brutal.Numerics;
using Brutal.OpenGlApi;
using Brutal.RenderDocApi;
using Brutal.Strings;

const string HINT = "RenderDoc isn't loaded: launch this app from RenderDoc (Windows or Linux) to capture frames.";

// Load the in-app API before any graphics API is initialized, so RenderDoc sees every GL call.
RenderDoc.Initialize();

if (RenderDoc.IsAvailable)
{
    // F12 is handled below with TriggerCapture, so turn off RenderDoc's own capture keys.
    RenderDoc.SetCaptureKeys([]);
    Console.WriteLine($"RenderDoc {RenderDoc.Version} loaded, press F12 to capture a frame.");
    Console.WriteLine($"Captures are written to {Utf8.GetString(RenderDoc.CaptureFilePathTemplate)}*.rdc");
}
else
{
    Console.WriteLine(HINT);
}

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
    // Window, shaders and triangle, as in Hello/HelloOpenGl.cs.
    Glfw.WindowHint(GlfwWindowHint.ContextVersionMajor, 4);
    Glfw.WindowHint(GlfwWindowHint.ContextVersionMinor, 1);
    Glfw.WindowHint(GlfwWindowHint.OpenGlProfile, Glfw.Constants.GLFW_OPENGL_CORE_PROFILE);

    if (Platform.IsMacOS)
        Glfw.WindowHint(GlfwWindowHint.OpenGlForwardCompat, 1);

    // A fixed size keeps the viewport and aspect ratio valid.
    Glfw.WindowHint(GlfwWindowHint.Resizable, Glfw.Constants.GLFW_FALSE);

    // Declared first so it's disposed last, after the GL objects that need its context.
    using var window = Glfw.CreateWindow(
        new GlfwWindow.CreateInfo { Title = "Demo RenderDoc", Size = new int2(640, 480) }
    );

    window.MakeContextCurrent();
    Glfw.SwapInterval(1);

    unsafe
    {
        if (!Glad.Initialize(Glfw.PInvoke.GetProcAddress))
            throw new InvalidOperationException("Failed to initialize OpenGL");
    }

    window.OnKey += (handle, key, _, action, _) =>
    {
        if (key == GlfwKey.Escape)
            handle.ShouldClose = true;

        if (key != GlfwKey.F12 || action != GlfwKeyAction.Press)
            return;

        if (!RenderDoc.IsAvailable)
        {
            Console.WriteLine(HINT);
            return;
        }

        // Captures the next frame that is presented with SwapBuffers.
        RenderDoc.TriggerCapture();
    };

    // Declared after the window, so the program is deleted while the GL context still exists.
    using var program = LinkProgram();

    // The vertex array and buffer aren't IDisposable, so they're deleted at the end, while the window's
    // GL context still exists.
    var vertexArray = OpenGl.GenVertexArray().Bind();
    var vertexBuffer = OpenGl.GenBuffer();
    vertexBuffer.Bind(GlBindTarget.ArrayBuffer);
    OpenGl.BufferData(
        GlBindTarget.ArrayBuffer,
        new Vertex[]
        {
            new(new float2(0.0f, 0.5f), new float3(1.0f, 0.0f, 0.0f)),
            new(new float2(0.5f, -0.5f), new float3(0.0f, 1.0f, 0.0f)),
            new(new float2(-0.5f, -0.5f), new float3(0.0f, 0.0f, 1.0f)),
        },
        GlBufferUsage.StaticDraw
    );

    OpenGl.VertexAttribute(new GlAttribute(0, 2, OpenGl.GL_FLOAT, GlScaling.Float, 5 * sizeof(float), 0));
    OpenGl.VertexAttribute(
        new GlAttribute(1, 3, OpenGl.GL_FLOAT, GlScaling.Float, 5 * sizeof(float), 2 * sizeof(float))
    );
    OpenGl.EnableVertexAttribArray(0);
    OpenGl.EnableVertexAttribArray(1);

    OpenGl.ClearColor(float4.Rgb(0.2f, 0.3f, 0.3f));

    var captureCount = 0u;
    while (!window.ShouldClose)
    {
        Glfw.PollEvents();
        OpenGl.Clear(GlClearBit.Color);
        program.Use();
        vertexArray.Bind();
        OpenGl.Draw(GlTopology.Triangles, 3, 1, 0, 0);
        window.SwapBuffers();

        // A finished capture (from F12 or the RenderDoc UI) is added to RenderDoc's capture list.
        if (RenderDoc.IsAvailable && RenderDoc.NumCaptures > captureCount)
        {
            captureCount = RenderDoc.NumCaptures;
            if (RenderDoc.TryGetCapture((int)captureCount - 1, out var path, out _))
                Console.WriteLine($"Captured {path}");
        }
    }

    OpenGl.DeleteVertexArrays([vertexArray]);
    OpenGl.DeleteBuffers([vertexBuffer]);
}

// The shaders are only needed until the program is linked, so they are disposed on return.
static GlProgram LinkProgram()
{
    using var vertexShader = OpenGl
        .CreateShader(GlShaderType.Vertex)
        .SetSource(
            """
            #version 410 core
            layout (location = 0) in vec2 aPos;
            layout (location = 1) in vec3 aColor;
            out vec3 color;
            void main()
            {
                color = aColor;
                gl_Position = vec4(aPos, 0.0, 1.0);
            }
            """u8
        )
        .Compile();

    using var fragmentShader = OpenGl
        .CreateShader(GlShaderType.Fragment)
        .SetSource(
            """
            #version 410 core
            in vec3 color;
            out vec4 FragColor;
            void main()
            {
                FragColor = vec4(color, 1.0);
            }
            """u8
        )
        .Compile();

    return OpenGl.CreateProgram().Attach(vertexShader, fragmentShader).Link();
}

record struct Vertex(float2 Position, float3 Color);
