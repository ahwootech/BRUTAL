/*
 * DemoTexturedQuad
 *
 * Generates a checkerboard with four mip levels, each tinted a different colour, saves it as a
 * KTX2 file, loads it back with TextureLoader and draws it on a floor quad with OpenGL. The tints
 * show where the GPU switches mip level as the floor recedes. Press Escape to close it.
 */

#:property AllowUnsafeBlocks=true
#:package Ahwoo.Brutal.Glfw@2026.10.5
#:package Ahwoo.Brutal.Ktx@2026.10.2
#:package Ahwoo.Brutal.OpenGl@2026.10.2
#:package Ahwoo.Brutal.Texture@2026.10.3
#:package Ahwoo.Brutal.Core@2026.10.4
#:package Ahwoo.Brutal.Numerics@2026.10.2

using System.Runtime.InteropServices;
using Brutal;
using Brutal.GlfwApi;
using Brutal.KtxApi;
using Brutal.KtxApi.Abstractions;
using Brutal.Numerics;
using Brutal.OpenGlApi;
using Brutal.TextureApi;
using Brutal.TextureApi.Ktx;

const int SIZE = 256;
const int LEVELS = 4;

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

// Everything else: its using declarations dispose in reverse, the program and shaders, then the window.
static void Run()
{
    // Texture: a KTX2 texture with room for every mip level, as in Hello/HelloKtx.cs.
    var createInfo = new KtxTextureCreateInfo
    {
        VkFormat = (uint)VkFormat.R8G8B8A8UNorm,
        BaseWidth = SIZE,
        BaseHeight = SIZE,
        BaseDepth = 1,
        NumDimensions = 2,
        NumLevels = LEVELS,
        NumLayers = 1,
        NumFaces = 1,
    };

    var createResult = KtxTexture2.Create(
        ref createInfo,
        KtxTextureCreateStorageEnum.TextureCreateAllocStorage,
        out var ktxTexture
    );
    if (createResult != KtxErrorCode.Success)
        throw new KtxTextureException($"Failed to create KTX2 texture: {createResult}", createResult);

    // Only needed until it's written, so it's disposed at the end of this block.
    var path = Path.Combine(Path.GetTempPath(), "DemoTexturedQuad.ktx2");
    using (ktxTexture)
    {
        // Each level halves in size; the checker squares shrink with it so they line up across levels.
        byte4[] tints = [new(255, 255, 255, 255), new(255, 96, 96, 255), new(96, 255, 96, 255), new(96, 96, 255, 255)];
        for (var level = 0; level < LEVELS; level++)
        {
            var size = SIZE >> level;
            var square = 32 >> level;
            var texels = new byte4[size * size];
            for (var y = 0; y < size; y++)
            for (var x = 0; x < size; x++)
                texels[y * size + x] = (x / square + y / square) % 2 == 0 ? tints[level] : new byte4(40, 40, 40, 255);

            ktxTexture.SetImageFromMemory((uint)level, 0, 0, MemoryMarshal.AsBytes(texels.AsSpan()));
        }

        ktxTexture.WriteToNamedFile(path);
    }
    Console.WriteLine($"Wrote {path} ({new FileInfo(path).Length} bytes)");

    // TextureLoader picks the KTX backend from the file extension, as in Hello/HelloTexture.cs.
    var texture = TextureLoader.LoadFromFile(path);
    Console.WriteLine($"Loaded {texture.Format}, {texture.Extent.X}x{texture.Extent.Y}, {texture.LevelCount} levels");

    // Window and OpenGL, as in Hello/HelloOpenGl.cs.
    Glfw.WindowHint(GlfwWindowHint.ContextVersionMajor, 4);
    Glfw.WindowHint(GlfwWindowHint.ContextVersionMinor, 1);
    Glfw.WindowHint(GlfwWindowHint.OpenGlProfile, Glfw.Constants.GLFW_OPENGL_CORE_PROFILE);

    if (Platform.IsMacOS)
        Glfw.WindowHint(GlfwWindowHint.OpenGlForwardCompat, 1);

    // A fixed size keeps the viewport and aspect ratio valid.
    Glfw.WindowHint(GlfwWindowHint.Resizable, Glfw.Constants.GLFW_FALSE);

    using var window = Glfw.CreateWindow(
        new GlfwWindow.CreateInfo { Title = "Demo Textured Quad", Size = new int2(640, 480) }
    );

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

    // Upload every level we loaded instead of letting OpenGL generate its own mips.
    GlTexture[] glTextures = [default];
    OpenGl.GenTextures(glTextures);

    // OpenGL textures, vertex arrays and buffers aren't disposable, so they're deleted at the end,
    // while the window's context still exists.
    OpenGl.BindTexture(OpenGl.GL_TEXTURE_2D, glTextures[0].Id);
    for (var level = 0; level < texture.LevelCount; level++)
    {
        var size = texture.Extent.X >> level;
        unsafe
        {
            fixed (byte* data = texture.ImageData(level, 0, 0))
                OpenGl.TexImage2D(
                    OpenGl.GL_TEXTURE_2D,
                    level,
                    (int)OpenGl.GL_RGBA8,
                    size,
                    size,
                    0,
                    OpenGl.GL_RGBA,
                    OpenGl.GL_UNSIGNED_BYTE,
                    data
                );
        }
    }
    TextureLoader.Unload(texture);

    // TexParameterFloat with an int calls glTexParameteri; the name is a binding quirk (brutal.opengl#14).
    OpenGl.TexParameterFloat(OpenGl.GL_TEXTURE_2D, OpenGl.GL_TEXTURE_MAX_LEVEL, LEVELS - 1);
    OpenGl.TexParameterFloat(OpenGl.GL_TEXTURE_2D, OpenGl.GL_TEXTURE_MIN_FILTER, (int)OpenGl.GL_LINEAR_MIPMAP_LINEAR);
    OpenGl.TexParameterFloat(OpenGl.GL_TEXTURE_2D, OpenGl.GL_TEXTURE_MAG_FILTER, (int)OpenGl.GL_LINEAR);

    using var vertexShader = OpenGl
        .CreateShader(GlShaderType.Vertex)
        .SetSource(
            """
                #version 410 core
                layout (location = 0) in vec3 aPos;
                layout (location = 1) in vec2 aUv;
                uniform mat4 viewProjection;
                out vec2 uv;
                void main()
                {
                    uv = aUv;
                    gl_Position = viewProjection * vec4(aPos, 1.0);
                }
                """u8
        )
        .Compile();

    using var fragmentShader = OpenGl
        .CreateShader(GlShaderType.Fragment)
        .SetSource(
            """
                #version 410 core
                in vec2 uv;
                uniform sampler2D tex;
                out vec4 FragColor;
                void main()
                {
                    FragColor = texture(tex, uv);
                }
                """u8
        )
        .Compile();

    using var program = OpenGl.CreateProgram().Attach(vertexShader, fragmentShader).Link();

    // A floor quad (two triangles) on y = 0 that repeats the texture eight times along its length.
    var vertexArray = OpenGl.GenVertexArray().Bind();
    var vertexBuffer = OpenGl.GenBuffer();
    vertexBuffer.Bind(GlBindTarget.ArrayBuffer);
    OpenGl.BufferData(
        GlBindTarget.ArrayBuffer,
        new Vertex[]
        {
            new(new float3(-2, 0, 2), new float2(0, 0)),
            new(new float3(2, 0, 2), new float2(2, 0)),
            new(new float3(2, 0, -14), new float2(2, 8)),
            new(new float3(-2, 0, 2), new float2(0, 0)),
            new(new float3(2, 0, -14), new float2(2, 8)),
            new(new float3(-2, 0, -14), new float2(0, 8)),
        },
        GlBufferUsage.StaticDraw
    );

    OpenGl.VertexAttribute(new GlAttribute(0, 3, OpenGl.GL_FLOAT, GlScaling.Float, 5 * sizeof(float), 0));
    OpenGl.VertexAttribute(
        new GlAttribute(1, 2, OpenGl.GL_FLOAT, GlScaling.Float, 5 * sizeof(float), 3 * sizeof(float))
    );
    OpenGl.EnableVertexAttribArray(0);
    OpenGl.EnableVertexAttribArray(1);

    OpenGl.ClearColor(float4.Rgb(0.2f, 0.3f, 0.3f));

    var view = float4x4.CreateLookAt(new float3(0, 1, 3), new float3(0, 0, -4), float3.UnitY);
    var projection = float4x4.CreatePerspectiveFieldOfView(float.DegreesToRadians(60), 640f / 480f, 0.1f, 100f);

    while (!window.ShouldClose)
    {
        Glfw.PollEvents();
        OpenGl.Clear(GlClearBit.Color);
        program.Use();
        program.Uniform("viewProjection"u8, view * projection);
        vertexArray.Bind();
        OpenGl.Draw(GlTopology.Triangles, 6, 1, 0, 0);
        window.SwapBuffers();
    }

    OpenGl.DeleteVertexArrays([vertexArray]);
    OpenGl.DeleteBuffers([vertexBuffer]);
    OpenGl.DeleteTextures(glTextures);
}

record struct Vertex(float3 Position, float2 Uv);
