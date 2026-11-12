/*
 * DemoGltfViewer
 *
 * Loads a glTF model, reorders it with meshoptimizer for the GPU's vertex cache and fetch, and
 * draws it lit and slowly rotating with OpenGL. Pass a .gltf or .glb path to view your own
 * model (`dotnet run Demo/DemoGltfViewer.cs -- model.glb`); without one it builds a torus knot,
 * writes it out as a .glb with Brutal.Gltf and views that.
 *
 * It walks the file's scene graph, placing every triangle primitive with its node's matrix or
 * translation, rotation and scale; other primitive modes, and quantized (non-float) positions,
 * aren't supported. Materials, textures, cameras, lights, skins, morph targets and animations
 * are ignored, so the model is drawn untextured in its rest pose. Press Escape to close it.
 */

// Brutal.Gltf uses reflection-based System.Text.Json, which Native AOT (the default for
// file-based apps) disables.
#:property PublishAot=false
#:property AllowUnsafeBlocks=true
#:package Ahwoo.Brutal.Gltf@2026.10.3
#:package Ahwoo.Brutal.MeshOptimizer@2026.10.2
#:package Ahwoo.Brutal.Glfw@2026.10.5
#:package Ahwoo.Brutal.OpenGl@2026.10.2
#:package Ahwoo.Brutal.Core@2026.10.4
#:package Ahwoo.Brutal.Numerics@2026.10.2

using System.Runtime.InteropServices;
using Brutal;
using Brutal.GlfwApi;
using Brutal.GltfApi;
using Brutal.MeshOptimizer;
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
    Run(args);
}
finally
{
    Glfw.Terminate();
}

// Everything else: its using declarations dispose in reverse, the program and shaders, then the
// window, then the glTF loader.
static void Run(string[] args)
{
    var path = args.Length > 0 ? args[0] : WriteTorusKnotGlb(Path.Combine(Path.GetTempPath(), "DemoGltfViewer.glb"));

    // Every primitive goes into one shared vertex and index list, each mesh loaded once however many
    // nodes use it; each draw is one of those primitives with the world transform of a node using it.
    using var loader = new GltfLoader(path);
    var gltf = loader.GltfJson;
    List<Vertex> vertices = [];
    List<int> indices = [];
    var meshPrimitives = new Dictionary<int, List<Primitive>>();
    var draws = new List<(Primitive Primitive, float4x4 World)>();
    var (transformsBefore, transformsAfter) = (0f, 0f);

    // Draw the file's chosen scene, else its first, else every mesh once where it stands.
    if ((gltf.Scene ?? (gltf.Scenes?.Length > 0 ? 0 : null)) is { } scene)
        foreach (var root in gltf.Scenes![scene].Nodes ?? [])
            AddNode(root, float4x4.Identity);
    else
        for (var mesh = 0; mesh < (gltf.Meshes?.Length ?? 0); mesh++)
            draws.AddRange(LoadMesh(mesh).Select(p => (p, float4x4.Identity)));

    if (draws.Count == 0)
        throw new NotSupportedException($"{Path.GetFileName(path)} has no triangle meshes to draw");

    var triangles = indices.Count / 3;
    Console.WriteLine(
        $"{Path.GetFileName(path)}: {draws.Count} draws, {triangles} triangles, {vertices.Count} vertices"
    );
    Console.WriteLine(
        $"ACMR (vertex transforms per triangle): {transformsBefore / triangles:F2} -> {transformsAfter / triangles:F2}"
    );

    // Fit the camera to the placed model: centre it on the origin and back off far enough to see all of it.
    float3[] points =
    [
        .. draws.SelectMany(d =>
            vertices
                .GetRange(d.Primitive.BaseVertex, d.Primitive.VertexCount)
                .Select(v => float3.Transform(v.Position, d.World))
        ),
    ];
    var min = points.Aggregate(float3.Min);
    var max = points.Aggregate(float3.Max);
    var centre = (min + max) / 2;
    var radius = MathF.Max((max - min).Length() / 2, 1e-3f);

    // Places a node and its children: a node has either a matrix or translation, rotation and scale,
    // whichever it lacks is identity, and a child's world transform is its local one times its parent's.
    void AddNode(int nodeIndex, float4x4 parentWorld)
    {
        var node = gltf.Nodes[nodeIndex];
        var trs =
            float4x4.CreateScale(node.Scale)
            * float4x4.CreateFromQuaternion(node.Rotation)
            * float4x4.CreateTranslation(node.Translation);
        var world = node.Matrix * trs * parentWorld;
        if (node.Mesh is { } mesh)
            draws.AddRange(LoadMesh(mesh).Select(p => (p, world)));
        foreach (var child in node.Children ?? [])
            AddNode(child, world);
    }

    // Reads a mesh's triangle primitives, filling in indices and normals where the file has none,
    // optimises each and appends it to the shared lists.
    List<Primitive> LoadMesh(int meshIndex)
    {
        if (meshPrimitives.TryGetValue(meshIndex, out var loaded))
            return loaded;
        meshPrimitives[meshIndex] = loaded = [];

        foreach (var primitive in gltf.Meshes![meshIndex].Primitives)
        {
            if (primitive.Mode != MeshPrimitive.ModeEnum.Triangles)
            {
                Console.WriteLine(
                    $"Skipping a {primitive.Mode} primitive in mesh {meshIndex}: only triangles are drawn"
                );
                continue;
            }

            var positions = ReadFloat3s(loader, primitive.Attributes["POSITION"]);
            int[] ids = primitive.Indices is { } i
                ? ReadIndices(loader, i)
                : [.. Enumerable.Range(0, positions.Length)];
            var normals = primitive.Attributes.TryGetValue("NORMAL", out var n)
                ? ReadFloat3s(loader, n)
                : SmoothNormals(positions, ids);
            var verts = positions.Zip(normals, (p, q) => new Vertex(p, q)).ToArray();

            // Reorder triangles so recently used vertices are reused, then vertices into first-use order.
            unsafe
            {
                fixed (int* p = ids)
                fixed (Vertex* v = verts)
                {
                    // AnalyzeVertexCache arguments: cache size 16, warp size 0, primitive group size 0.
                    transformsBefore +=
                        MeshOptimizer.AnalyzeVertexCache(p, ids.Length, verts.Length, 16, 0, 0).Acmr * ids.Length / 3;
                    MeshOptimizer.OptimizeVertexCache(p, p, ids.Length, verts.Length);
                    MeshOptimizer.OptimizeVertexFetch(v, p, ids.Length, v, verts.Length, ByteSize.Of<Vertex>());
                    transformsAfter +=
                        MeshOptimizer.AnalyzeVertexCache(p, ids.Length, verts.Length, 16, 0, 0).Acmr * ids.Length / 3;
                }
            }

            loaded.Add(new Primitive(indices.Count, ids.Length, vertices.Count, verts.Length));
            indices.AddRange(ids);
            vertices.AddRange(verts);
        }
        return loaded;
    }

    // Window and OpenGL, as in Hello/HelloOpenGl.cs.
    Glfw.WindowHint(GlfwWindowHint.ContextVersionMajor, 4);
    Glfw.WindowHint(GlfwWindowHint.ContextVersionMinor, 1);
    Glfw.WindowHint(GlfwWindowHint.OpenGlProfile, Glfw.Constants.GLFW_OPENGL_CORE_PROFILE);

    if (Platform.IsMacOS)
        Glfw.WindowHint(GlfwWindowHint.OpenGlForwardCompat, 1);

    // A fixed size, so the viewport and the projection's aspect ratio never need updating.
    Glfw.WindowHint(GlfwWindowHint.Resizable, Glfw.Constants.GLFW_FALSE);

    using var window = Glfw.CreateWindow(
        new GlfwWindow.CreateInfo { Title = "Demo glTF Viewer", Size = new int2(640, 480) }
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
            normal = transpose(inverse(mat3(model))) * aNormal;
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
        out vec4 FragColor;
        void main()
        {
            // A warm key light and a cool fill from below, plus a little ambient.
            vec3 n = normalize(normal);
            vec3 key = vec3(1.0, 0.9, 0.75) * max(dot(n, normalize(vec3(0.4, 1.0, 0.6))), 0.0);
            vec3 fill = vec3(0.25, 0.3, 0.45) * max(dot(n, normalize(vec3(-0.6, -0.4, -0.3))), 0.0);
            FragColor = vec4(vec3(0.8) * (0.15 + key + fill), 1.0);
        }
        """u8
        )
        .Compile();

    using var program = OpenGl.CreateProgram().Attach(vertexShader, fragmentShader).Link();

    // Vertex arrays and buffers aren't disposable, so they're deleted at the end, while the window's
    // context still exists.
    var vertexArray = OpenGl.GenVertexArray().Bind();
    var vertexBuffer = OpenGl.GenBuffer();
    var indexBuffer = OpenGl.GenBuffer();
    vertexBuffer.Bind(GlBindTarget.ArrayBuffer);
    OpenGl.BufferData(GlBindTarget.ArrayBuffer, vertices.ToArray(), GlBufferUsage.StaticDraw);
    indexBuffer.Bind(GlBindTarget.ElementArrayBuffer); // Recorded in the vertex array.
    OpenGl.BufferData(GlBindTarget.ElementArrayBuffer, indices.ToArray(), GlBufferUsage.StaticDraw);

    OpenGl.VertexAttribute(new GlAttribute(0, 3, OpenGl.GL_FLOAT, GlScaling.Float, 6 * sizeof(float), 0));
    OpenGl.VertexAttribute(
        new GlAttribute(1, 3, OpenGl.GL_FLOAT, GlScaling.Float, 6 * sizeof(float), 3 * sizeof(float))
    );
    OpenGl.EnableVertexAttribArray(0);
    OpenGl.EnableVertexAttribArray(1);

    OpenGl.Enable(GlCapability.DepthTest);
    OpenGl.ClearColor(float4.Rgb(0.2f, 0.3f, 0.3f));

    // 45 degree field of view: a sphere of this radius just fits at radius / sin(22.5 degrees).
    var view = float4x4.CreateLookAt(new float3(0, 0.4f, 1) * radius * 2.8f, float3.Zero, float3.UnitY);
    var projection = float4x4.CreatePerspectiveFieldOfView(MathF.PI / 4, 640f / 480f, radius / 10, radius * 10);

    while (!window.ShouldClose)
    {
        Glfw.PollEvents();

        OpenGl.Clear(GlClearBit.Color | GlClearBit.Depth);
        program.Use();
        program.Uniform("viewProjection"u8, view * projection);
        vertexArray.Bind();
        var spin = float4x4.CreateTranslation(-centre) * float4x4.CreateRotationY((float)Glfw.Time * 0.5f);
        foreach (var (primitive, world) in draws)
        {
            // The first index is passed as a byte offset into the index buffer.
            program.Uniform("model"u8, world * spin);
            OpenGl.DrawIndexed(
                GlTopology.Triangles,
                GlIndexType.UInt,
                primitive.IndexCount,
                1,
                primitive.FirstIndex * sizeof(int),
                primitive.BaseVertex,
                0
            );
        }

        window.SwapBuffers();
    }

    OpenGl.DeleteVertexArrays([vertexArray]);
    OpenGl.DeleteBuffers([vertexBuffer, indexBuffer]);
}

// Reads a float VEC3 accessor, such as positions or normals, which may be interleaved with other data.
static float3[] ReadFloat3s(GltfLoader loader, int accessorIndex)
{
    var accessor = loader.GltfJson.Accessors[accessorIndex];
    if (accessor.ComponentType != Accessor.ComponentTypeEnum.Float || accessor.Type != Accessor.TypeEnum.Vec3)
        throw new NotSupportedException($"Expected float VEC3 data, not {accessor.ComponentType} {accessor.Type}");

    var bytes = loader.GetBufferView(accessor.BufferView!.Value)[accessor.ByteOffset..];
    var stride = loader.GltfJson.BufferViews[accessor.BufferView.Value].ByteStride ?? 3 * sizeof(float);
    var result = new float3[accessor.Count];
    for (var i = 0; i < result.Length; i++)
        result[i] = MemoryMarshal.Read<float3>(bytes[(i * stride)..]);
    return result;
}

// Reads an index accessor of any of the three index sizes glTF allows, widening to 32-bit.
static int[] ReadIndices(GltfLoader loader, int accessorIndex)
{
    var accessor = loader.GltfJson.Accessors[accessorIndex];
    var bytes = loader.GetBufferView(accessor.BufferView!.Value)[accessor.ByteOffset..];
    return accessor.ComponentType switch
    {
        Accessor.ComponentTypeEnum.UnsignedByte => [.. bytes[..accessor.Count].ToArray().Select(b => (int)b)],
        Accessor.ComponentTypeEnum.UnsignedShort =>
        [
            .. MemoryMarshal.Cast<byte, ushort>(bytes)[..accessor.Count].ToArray().Select(s => (int)s),
        ],
        _ => MemoryMarshal.Cast<byte, int>(bytes)[..accessor.Count].ToArray(),
    };
}

// Sums each triangle's area-weighted face normal into its vertices; flat when no vertices are shared.
static float3[] SmoothNormals(float3[] positions, int[] indices)
{
    var normals = new float3[positions.Length];
    foreach (var t in indices.Chunk(3))
    {
        var normal = float3.Cross(positions[t[1]] - positions[t[0]], positions[t[2]] - positions[t[0]]);
        foreach (var index in t)
            normals[index] += normal;
    }
    return [.. normals.Select(float3.NormalizeOrZero)];
}

// Sweeps a circle along a (2, 3) torus knot and writes the result as a .glb with Brutal.Gltf,
// positions and indices only, so the viewer has to compute its normals.
static string WriteTorusKnotGlb(string path)
{
    const int SEGMENTS = 256;
    const int SIDES = 24;

    static float3 Knot(float u)
    {
        var r = 2 + MathF.Cos(3 * u);
        return new float3(r * MathF.Cos(2 * u), MathF.Sin(3 * u), r * MathF.Sin(2 * u));
    }

    // Vertex index of a point on the tube, wrapping around both the knot and the tube.
    static int At(int ring, int around) => ring % SEGMENTS * SIDES + around % SIDES;

    var positions = new List<float3>();
    var indices = new List<int>();
    for (var s = 0; s < SEGMENTS; s++)
    {
        // A frame around the curve: tangent from a step ahead, then two perpendicular axes.
        var u = s * MathF.Tau / SEGMENTS;
        var (here, ahead) = (Knot(u), Knot(u + 0.01f));
        var side = float3.Normalize(float3.Cross(ahead - here, ahead + here));
        var up = float3.Normalize(float3.Cross(side, ahead - here));
        for (var j = 0; j < SIDES; j++)
        {
            var v = j * MathF.Tau / SIDES;
            positions.Add(here + (up * MathF.Cos(v) + side * MathF.Sin(v)) * 0.4f);

            // Two triangles joining this point to the next ring, counter-clockwise seen from outside as glTF expects.
            indices.AddRange([At(s, j), At(s + 1, j + 1), At(s + 1, j)]);
            indices.AddRange([At(s, j), At(s, j + 1), At(s + 1, j + 1)]);
        }
    }

    var positionBytes = MemoryMarshal.AsBytes(positions.ToArray().AsSpan()).ToArray();
    var indexBytes = MemoryMarshal.AsBytes(indices.ToArray().AsSpan()).ToArray();
    var (min, max) = (positions.Aggregate(float3.Min), positions.Aggregate(float3.Max));

    // One binary buffer holding the positions then the indices, a view into each, and an
    // accessor saying how to read each view; glTF requires min and max on positions.
    var model = new Gltf
    {
        Asset = new Asset { Version = "2.0" },
        Buffers = [new Brutal.GltfApi.Buffer { ByteLength = positionBytes.Length + indexBytes.Length }],
        BufferViews =
        [
            new BufferView { Buffer = 0, ByteLength = positionBytes.Length },
            new BufferView
            {
                Buffer = 0,
                ByteOffset = positionBytes.Length,
                ByteLength = indexBytes.Length,
            },
        ],
        Accessors =
        [
            new Accessor
            {
                BufferView = 0,
                ComponentType = Accessor.ComponentTypeEnum.Float,
                Count = positions.Count,
                Type = Accessor.TypeEnum.Vec3,
                Min = [min.X, min.Y, min.Z],
                Max = [max.X, max.Y, max.Z],
            },
            new Accessor
            {
                BufferView = 1,
                ComponentType = Accessor.ComponentTypeEnum.UnsignedInt,
                Count = indices.Count,
                Type = Accessor.TypeEnum.Scalar,
            },
        ],
        Meshes =
        [
            new Mesh
            {
                Primitives =
                [
                    new MeshPrimitive
                    {
                        Attributes = new() { ["POSITION"] = 0 },
                        Indices = 1,
                    },
                ],
            },
        ],
    };
    model.SaveBinaryModel([.. positionBytes, .. indexBytes], path);
    return path;
}

record struct Vertex(float3 Position, float3 Normal);

// Where a primitive lives in the shared index and vertex lists.
record struct Primitive(int FirstIndex, int IndexCount, int BaseVertex, int VertexCount);
