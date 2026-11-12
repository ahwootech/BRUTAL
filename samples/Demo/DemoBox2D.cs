/*
 * DemoBox2D
 *
 * Drops a pile of boxes onto the ground with Box2D and draws them with OpenGL every frame: the
 * visual counterpart of the headless Hello/HelloBox2D.cs. Press Escape to close it.
 */

#:property AllowUnsafeBlocks=true
#:package Ahwoo.Brutal.Box2D@2026.10.2
#:package Ahwoo.Brutal.Glfw@2026.10.5
#:package Ahwoo.Brutal.OpenGl@2026.10.2
#:package Ahwoo.Brutal.Core@2026.10.4
#:package Ahwoo.Brutal.Numerics@2026.10.2

using Brutal;
using Brutal.Box2DApi;
using Brutal.GlfwApi;
using Brutal.Numerics;
using Brutal.OpenGlApi;

// GLFW is the only library-wide state, set up here and terminated even if Run throws.
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

// Everything else: its using declarations dispose in reverse, the program and shaders, then the
// window, then the physics world with all its bodies.
static void Run()
{
    // Physics: a static ground and a handful of boxes dropped from different heights.
    using var world = Box2D.CreateWorld(B2WorldDef.Default);

    var ground = world.CreateBody(new B2BodyDef { Position = new float2(0, -0.5f) });
    ground.CreatePolygonShape(B2ShapeDef.Default, Box2D.MakeBox(9, 0.5f)); // Top surface at y = 0.

    var bodies = new List<(B2Body Body, float2 HalfSize, float3 Color)>
    {
        (ground, new float2(9, 0.5f), new float3(0.6f, 0.6f, 0.6f)),
    };
    for (var i = 0; i < 12; i++)
    {
        var body = world.CreateBody(
            new B2BodyDef
            {
                Type = B2BodyType.Dynamic,
                Position = new float2(-3 + i % 4 * 2f, 4 + i * 1.2f),
                Rotation = new B2Rot(i * 0.4f),
            }
        );
        body.CreatePolygonShape(B2ShapeDef.Default, Box2D.MakeBox(0.5f, 0.5f));
        bodies.Add((body, new float2(0.5f, 0.5f), new float3(1.0f - i / 12f, 0.5f, i / 12f)));
    }

    // Window and OpenGL, as in Hello/HelloOpenGl.cs.
    Glfw.WindowHint(GlfwWindowHint.ContextVersionMajor, 4);
    Glfw.WindowHint(GlfwWindowHint.ContextVersionMinor, 1);
    Glfw.WindowHint(GlfwWindowHint.OpenGlProfile, Glfw.Constants.GLFW_OPENGL_CORE_PROFILE);

    if (Platform.IsMacOS)
        Glfw.WindowHint(GlfwWindowHint.OpenGlForwardCompat, 1);

    // A fixed size keeps the viewport and aspect ratio valid.
    Glfw.WindowHint(GlfwWindowHint.Resizable, Glfw.Constants.GLFW_FALSE);

    using var window = Glfw.CreateWindow(new GlfwWindow.CreateInfo { Title = "Demo Box2D", Size = new int2(640, 480) });

    window.MakeContextCurrent();
    Glfw.SwapInterval(1);

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
                // Show world x in [-10, 10] and y in [-1, 14].
                gl_Position = vec4(aPos.x / 10.0, (aPos.y - 6.5) / 7.5, 0.0, 1.0);
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

    using var program = OpenGl.CreateProgram().Attach(vertexShader, fragmentShader).Link();

    // Vertex arrays and buffers aren't disposable, so they're deleted at the end, while the window's
    // context still exists.
    var vertexArray = OpenGl.GenVertexArray().Bind();
    var vertexBuffer = OpenGl.GenBuffer();
    vertexBuffer.Bind(GlBindTarget.ArrayBuffer);

    OpenGl.VertexAttribute(new GlAttribute(0, 2, OpenGl.GL_FLOAT, GlScaling.Float, 5 * sizeof(float), 0));
    OpenGl.VertexAttribute(
        new GlAttribute(1, 3, OpenGl.GL_FLOAT, GlScaling.Float, 5 * sizeof(float), 2 * sizeof(float))
    );
    OpenGl.EnableVertexAttribArray(0);
    OpenGl.EnableVertexAttribArray(1);

    // Two triangles per box, five floats (x, y, r, g, b) per vertex.
    var vertices = new float[bodies.Count * 6 * 5];
    float2[] corners = [new(-1, -1), new(1, -1), new(1, 1), new(-1, -1), new(1, 1), new(-1, 1)];

    OpenGl.ClearColor(float4.Rgb(0.2f, 0.3f, 0.3f));

    const float TIME_STEP = 1.0f / 60.0f;
    var previousTime = Glfw.Time;
    var accumulator = 0.0;

    while (!window.ShouldClose)
    {
        Glfw.PollEvents();

        // Step physics at a fixed rate whatever the refresh rate, capping the catch-up after a stall.
        var now = Glfw.Time;
        accumulator += Math.Min(now - previousTime, 0.25);
        previousTime = now;
        while (accumulator >= TIME_STEP)
        {
            world.Step(TIME_STEP, 4);
            accumulator -= TIME_STEP;
        }

        var v = 0;
        foreach (var (body, halfSize, color) in bodies)
        {
            var transform = body.GetTransform();
            foreach (var corner in corners)
            {
                var local = corner * halfSize;
                var p =
                    transform.P
                    + new float2(
                        transform.Q.C * local.X - transform.Q.S * local.Y,
                        transform.Q.S * local.X + transform.Q.C * local.Y
                    );
                vertices[v++] = p.X;
                vertices[v++] = p.Y;
                vertices[v++] = color.X;
                vertices[v++] = color.Y;
                vertices[v++] = color.Z;
            }
        }

        OpenGl.Clear(GlClearBit.Color);
        program.Use();
        vertexArray.Bind();
        vertexBuffer.Bind(GlBindTarget.ArrayBuffer);
        OpenGl.BufferData(GlBindTarget.ArrayBuffer, vertices, GlBufferUsage.DynamicDraw);
        OpenGl.Draw(GlTopology.Triangles, bodies.Count * 6, 1, 0, 0);
        window.SwapBuffers();
    }

    OpenGl.DeleteVertexArrays([vertexArray]);
    OpenGl.DeleteBuffers([vertexBuffer]);
}
