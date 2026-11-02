/*
 * DemoJolt
 *
 * Drops a pile of boxes onto the ground with Jolt Physics and draws them in 3D with OpenGL every
 * frame: the visual counterpart of the headless Hello/HelloJolt.cs. Press Escape to close it.
 */

#:property AllowUnsafeBlocks=true
#:package Ahwoo.Brutal.Jolt@2026.10.4
#:package Ahwoo.Brutal.Glfw@2026.10.5
#:package Ahwoo.Brutal.OpenGl@2026.10.2
#:package Ahwoo.Brutal.Core@2026.10.4
#:package Ahwoo.Brutal.Numerics@2026.10.2

using Brutal;
using Brutal.GlfwApi;
using Brutal.JoltApi;
using Brutal.Numerics;
using Brutal.OpenGlApi;

const ushort STATIC_LAYER = 0;
const ushort MOVING_LAYER = 1;

// Library-wide state, shut down in reverse even if Run throws: Jolt needs an allocator, a factory
// and its types registered before it can simulate anything, and GLFW provides the window.
Jolt.RegisterDefaultAllocator();
Factory.Instance = Factory.Create();
Jolt.RegisterTypes();
try
{
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
}
finally
{
    Jolt.UnregisterTypes();
    Factory.DestroyInstance();
}

// Everything else: its using declarations dispose in reverse, so the OpenGL objects and window go
// first, then the bodies' shapes and settings, then the physics system and what it was built from.
static void Run()
{
    // Physics: a job system and collision layers.
    using var tempAllocator = TempAllocatorImpl.Create(10 * 1024 * 1024);
    using var jobSystem = JobSystemThreadPool.Create(2048, 8, -1);

    using var broadPhaseLayers = BroadPhaseLayerInterfaceTable.Create(2, 2);
    broadPhaseLayers.MapObjectToBroadPhaseLayer(STATIC_LAYER, 0);
    broadPhaseLayers.MapObjectToBroadPhaseLayer(MOVING_LAYER, 1);

    using var pairFilter = ObjectLayerPairFilterTable.Create(2);
    pairFilter.EnableCollision(STATIC_LAYER, MOVING_LAYER);
    pairFilter.EnableCollision(MOVING_LAYER, MOVING_LAYER);

    using var broadPhaseFilter = ObjectVsBroadPhaseLayerFilterTable.Create(broadPhaseLayers, 2, pairFilter, 2);

    using var physicsSystem = PhysicsSystem.Create();
    physicsSystem.Init(1024, 0, 1024, 1024, broadPhaseLayers, broadPhaseFilter, pairFilter);
    var bodyInterface = physicsSystem.GetBodyInterface();

    var bodies = new List<(uint Body, float3 HalfSize, float3 Color)>();

    var groundHalfSize = new float3(8, 0.5f, 8);
    using var groundShape = BoxShapeSettings.Create(groundHalfSize, 0.05f, default);
    using var groundSettings = BodyCreationSettings.Create(
        groundShape,
        new float3(0, -0.5f, 0), // Top surface at y = 0.
        floatQuat.Identity,
        MotionType.Static,
        STATIC_LAYER
    );
    var boxHalfSize = new float3(0.5f);
    using var boxShape = BoxShapeSettings.Create(boxHalfSize, 0.05f, default);

    // Bodies are IDs, not disposable: they're removed and destroyed at the end, before their shapes
    // and the physics system are disposed.
    bodies.Add(
        (bodyInterface.CreateAndAddBody(groundSettings, Activation.DontActivate), groundHalfSize, new float3(0.6f))
    );

    for (var i = 0; i < 20; i++)
    {
        using var boxSettings = BodyCreationSettings.Create(
            boxShape,
            new float3(-1.5f + i % 3 * 1.5f, 3 + i * 1.2f, -1.5f + i % 2 * 1.5f),
            floatQuat.CreateFromYawPitchRoll(i * 0.5f, i * 0.3f, i * 0.7f),
            MotionType.Dynamic,
            MOVING_LAYER
        );
        var body = bodyInterface.CreateAndAddBody(boxSettings, Activation.Activate);
        bodies.Add((body, boxHalfSize, new float3(1.0f - i / 20f, 0.5f, i / 20f)));
    }

    // Window and OpenGL, as in Hello/HelloOpenGl.cs.
    Glfw.WindowHint(GlfwWindowHint.ContextVersionMajor, 4);
    Glfw.WindowHint(GlfwWindowHint.ContextVersionMinor, 1);
    Glfw.WindowHint(GlfwWindowHint.OpenGlProfile, Glfw.Constants.GLFW_OPENGL_CORE_PROFILE);

    if (Platform.IsMacOS)
        Glfw.WindowHint(GlfwWindowHint.OpenGlForwardCompat, 1);

    // A fixed size keeps the viewport and aspect ratio valid.
    Glfw.WindowHint(GlfwWindowHint.Resizable, Glfw.Constants.GLFW_FALSE);

    using var window = Glfw.CreateWindow(new GlfwWindow.CreateInfo { Title = "Demo Jolt", Size = new int2(640, 480) });

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
                layout (location = 0) in vec3 aPos;
                layout (location = 1) in vec3 aNormal;
                uniform mat4 model;
                uniform mat4 viewProjection;
                out vec3 normal;
                void main()
                {
                    normal = mat3(model) * aNormal;
                    gl_Position = viewProjection * model * vec4(aPos, 1.0);
                }
                """u8
        )
        .Compile();

    using var fragmentShader = OpenGl
        .CreateShader(GlShaderType.Fragment)
        .SetSource(
            """
                #version 410 core
                in vec3 normal;
                uniform vec3 color;
                out vec4 FragColor;
                void main()
                {
                    // Simple directional light plus a little ambient.
                    float light = max(dot(normalize(normal), normalize(vec3(0.4, 1.0, 0.6))), 0.0);
                    FragColor = vec4(color * (0.3 + 0.7 * light), 1.0);
                }
                """u8
        )
        .Compile();

    using var program = OpenGl.CreateProgram().Attach(vertexShader, fragmentShader).Link();

    // A cube from -1 to 1: two triangles per face, each vertex with a position and a face normal.
    var cube = new List<Vertex>();
    foreach (
        var normal in new[] { float3.UnitX, -float3.UnitX, float3.UnitY, -float3.UnitY, float3.UnitZ, -float3.UnitZ }
    )
    {
        var u = new float3(normal.Y, normal.Z, normal.X);
        var v = float3.Cross(normal, u);
        float2[] corners = [new(-1, -1), new(1, -1), new(1, 1), new(-1, -1), new(1, 1), new(-1, 1)];
        foreach (var corner in corners)
            cube.Add(new Vertex(normal + u * corner.X + v * corner.Y, normal));
    }

    // Vertex arrays and buffers aren't disposable, so they're deleted at the end, while the
    // window's context still exists.
    var vertexArray = OpenGl.GenVertexArray().Bind();
    var vertexBuffer = OpenGl.GenBuffer();
    vertexBuffer.Bind(GlBindTarget.ArrayBuffer);
    OpenGl.BufferData(GlBindTarget.ArrayBuffer, cube.ToArray(), GlBufferUsage.StaticDraw);

    OpenGl.VertexAttribute(new GlAttribute(0, 3, OpenGl.GL_FLOAT, GlScaling.Float, 6 * sizeof(float), 0));
    OpenGl.VertexAttribute(
        new GlAttribute(1, 3, OpenGl.GL_FLOAT, GlScaling.Float, 6 * sizeof(float), 3 * sizeof(float))
    );
    OpenGl.EnableVertexAttribArray(0);
    OpenGl.EnableVertexAttribArray(1);

    OpenGl.Enable(GlCapability.DepthTest);
    OpenGl.ClearColor(float4.Rgb(0.2f, 0.3f, 0.3f));

    var view = float4x4.CreateLookAt(new float3(8, 7, 12), new float3(0, 1.5f, 0), float3.UnitY);
    var projection = float4x4.CreatePerspectiveFieldOfView(float.DegreesToRadians(45), 640f / 480f, 0.1f, 100f);

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
            physicsSystem.Update(TIME_STEP, 1, tempAllocator, jobSystem);
            accumulator -= TIME_STEP;
        }

        OpenGl.Clear(GlClearBit.Color | GlClearBit.Depth);
        program.Use();
        program.Uniform("viewProjection"u8, view * projection);
        vertexArray.Bind();

        foreach (var (body, halfSize, color) in bodies)
        {
            bodyInterface.GetPositionAndRotation(body, out var position, out var rotation);
            var model =
                float4x4.CreateScale(halfSize)
                * float4x4.CreateFromQuaternion(rotation)
                * float4x4.CreateTranslation(position);

            program.Uniform("model"u8, model);
            program.Uniform("color"u8, color);
            OpenGl.Draw(GlTopology.Triangles, cube.Count, 1, 0, 0);
        }

        window.SwapBuffers();
    }

    OpenGl.DeleteVertexArrays([vertexArray]);
    OpenGl.DeleteBuffers([vertexBuffer]);

    foreach (var (body, _, _) in bodies)
    {
        bodyInterface.RemoveBody(body);
        bodyInterface.DestroyBody(body);
    }
}

record struct Vertex(float3 Position, float3 Normal);
