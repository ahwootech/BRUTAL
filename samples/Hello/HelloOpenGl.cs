/*
 * HelloOpenGl
 *
 * Opens a GLFW window and draws a coloured triangle with OpenGL. Press Escape to close it.
 */

#:property AllowUnsafeBlocks=true
#:package Ahwoo.Brutal.Glfw@2026.10.5
#:package Ahwoo.Brutal.OpenGl@2026.10.2
#:package Ahwoo.Brutal.Core@2026.10.4
#:package Ahwoo.Brutal.Numerics@2026.10.2

// RIAN: Our OpenGL samples run on 4.1 for compatibility with macOS, but we should support up to 4.6 no problem.

using Brutal;
using Brutal.GlfwApi;
using Brutal.Numerics;
using Brutal.OpenGlApi;

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
    Glfw.WindowHint(GlfwWindowHint.ContextVersionMajor, 4);
    Glfw.WindowHint(GlfwWindowHint.ContextVersionMinor, 1);
    Glfw.WindowHint(GlfwWindowHint.OpenGlProfile, Glfw.Constants.GLFW_OPENGL_CORE_PROFILE);

    if (Platform.IsMacOS)
        Glfw.WindowHint(GlfwWindowHint.OpenGlForwardCompat, 1);

    // A fixed size keeps the viewport and aspect ratio valid.
    Glfw.WindowHint(GlfwWindowHint.Resizable, Glfw.Constants.GLFW_FALSE);

    using var window = Glfw.CreateWindow(
        new GlfwWindow.CreateInfo { Title = "Hello OpenGL", Size = new int2(640, 480) }
    );

    window.MakeContextCurrent();
    Glfw.SwapInterval(1); // Wait for vsync instead of drawing as fast as possible.

    unsafe
    {
        if (!Glad.Initialize(Glfw.PInvoke.GetProcAddress))
            throw new InvalidOperationException("Failed to load the OpenGL functions with GLAD");
    }

    window.OnKey += (handle, key, _, _, _) =>
    {
        if (key == GlfwKey.Escape)
            handle.ShouldClose = true;
    };

    // Declared after the window, so the program is deleted while the GL context still exists.
    using var program = LinkProgram();

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

    while (!window.ShouldClose)
    {
        Glfw.PollEvents();
        OpenGl.Clear(GlClearBit.Color);
        program.Use();
        vertexArray.Bind();
        OpenGl.Draw(GlTopology.Triangles, 3, 1, 0, 0);
        window.SwapBuffers();
    }

    // Vertex arrays and buffers aren't IDisposable, so delete them by hand while the GL context still exists.
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
