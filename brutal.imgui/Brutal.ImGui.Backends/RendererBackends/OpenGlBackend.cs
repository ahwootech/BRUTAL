using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Brutal.Numerics;
using Brutal.OpenGlApi;
using Brutal.Pointers;
using Brutal.Strings;

namespace Brutal.ImGuiApi.Backends;

using static OpenGlBackend.Helpers;

/**
 * Brutal port based on the default imgui_impl_opengl3 C++ code
 * Key variations:
 * - Assumes version 4.1+
 * - Haven't added multi-context support, assumes we can just GetContext()
 * - Doesn't support forward compatibility using GL_CONTEXT_COMPATIBILITY_PROFILE_BIT
 */

public partial class OpenGlBackend : IRendererBackend
{
    private static readonly Ptr<byte> Name = "Brutal.ImGuiApi.OpenGlBackend"u8;

    public unsafe OpenGlBackend()
    {
        var io = ImGui.GetIO();

        io.BackendRendererUserData = (nint)GCHandle.Alloc(this);
        io.BackendRendererName = Name;

        io.BackendFlags |= ImGuiBackendFlags.RendererHasVtxOffset; // We can honor the ImDrawCmd::VtxOffset field, allowing for large meshes.
        io.BackendFlags |= ImGuiBackendFlags.RendererHasTextures; // We can honor ImGuiPlatformIO::Textures[] requests during render.
        io.BackendFlags |= ImGuiBackendFlags.RendererHasViewports; // We can create multi-viewports on the Renderer side (optional)

        var versionMaj = GetIntegerv(OpenGl.GL_MAJOR_VERSION);
        var versionMin = GetIntegerv(OpenGl.GL_MINOR_VERSION);
        _glVersion = versionMaj * 100 + versionMin;

        _hasClipOrigin = _glVersion >= 450;

        if (!_hasClipOrigin)
        {
            var numExtensions = GetIntegerv(OpenGl.GL_NUM_EXTENSIONS);

            for (uint i = 0; i < numExtensions; i++)
            {
                var extension = OpenGl.GetStringi(OpenGl.GL_EXTENSIONS, i);

                if (extension is not null)
                {
                    var utf8String = Utf8.GetNullTerminatedSpan(extension);
                    if (utf8String.SequenceEqual("GL_ARB_clip_control"u8))
                        _hasClipOrigin = true;
                }
            }
        }

        InitMultiViewportSupport();

        // Note: original C++ code does this on NewFrame if not already loaded, couldn't see a good reason to wait though
        CreateDeviceObjects(out _shader, out _vertexBuffer, out _indexBuffer);
    }

    public void NewFrame() { }

    public unsafe void RenderDrawData(ImDrawDataPtr drawData)
    {
        var width = (int)(drawData.DisplaySize.X * drawData.FramebufferScale.X);
        var height = (int)(drawData.DisplaySize.Y * drawData.FramebufferScale.Y);
        if (width <= 0 || height <= 0)
            return;

        if (drawData.Textures.IsNotNull())
        {
            for (var i = 0; i < drawData.Textures.Value.Count; i++)
            {
                var tex = drawData.Textures.Value[i];
                if (tex.Status != ImTextureStatus.OK)
                    UpdateTexture(tex);
            }
        }

        using var backupState = new GlStateBackup();

        var vertexArrayObject = OpenGl.GenVertexArray();
        SetupRenderState(drawData, width, height, vertexArrayObject);

        // Will project scissor/clipping rectangles into framebuffer space
        var clipOff = drawData.DisplayPos; // (0,0) unless using multi-viewports
        var clipScale = drawData.FramebufferScale; // (1,1) unless using retina display which are often (2,2)

        // Render command lists
        for (var n = 0; n < drawData.CmdListsCount; n++)
        {
            var drawList = drawData.CmdLists[n];

            OpenGl.BufferData(
                GlBindTarget.ArrayBuffer,
                new Span<ImDrawVert>(drawList.VtxBuffer.Data, drawList.VtxBuffer.Count),
                GlBufferUsage.StreamDraw
            );

            OpenGl.BufferData(
                GlBindTarget.ElementArrayBuffer,
                new Span<ushort>(drawList.IdxBuffer.Data, drawList.IdxBuffer.Count),
                GlBufferUsage.StreamDraw
            );

            for (var i = 0; i < drawList.CmdBuffer.Count; i++)
            {
                var command = drawList.CmdBuffer[i];

                // Project scissor/clipping rectangles into framebuffer space
                var clipMin = new float2(
                    (command.ClipRect.X - clipOff.X) * clipScale.X,
                    (command.ClipRect.Y - clipOff.Y) * clipScale.Y
                );
                var clipMax = new float2(
                    (command.ClipRect.Z - clipOff.X) * clipScale.X,
                    (command.ClipRect.W - clipOff.Y) * clipScale.Y
                );
                if (clipMax.X <= clipMin.X || clipMax.Y <= clipMin.Y)
                    continue;

                // Apply scissor/clipping rectangle (Y is inverted in OpenGL)
                OpenGl.Scissor(
                    (int)clipMin.X,
                    (int)(height - clipMax.Y),
                    (int)(clipMax.X - clipMin.X),
                    (int)(clipMax.Y - clipMin.Y)
                );

                // Bind texture, Draw
                OpenGl.BindTexture(OpenGl.GL_TEXTURE_2D, (uint)command.GetTexID().Value);
                OpenGl.DrawIndexed(
                    GlTopology.Triangles,
                    GlIndexType.UShort,
                    indexCount: (int)command.ElemCount,
                    instanceCount: 1,
                    firstIndex: (int)command.IdxOffset * sizeof(ushort),
                    vertexOffset: (int)command.VtxOffset,
                    firstInstance: 0
                );

                OpenGl.Scissor(0, 0, width, height); // Reset scissor to full viewport;
            }
        }

        OpenGl.DeleteVertexArrays([vertexArrayObject]);
    }

    private unsafe void SetupRenderState(ImDrawDataPtr drawData, int width, int height, GlVertexArray vertexArrayObject)
    {
        OpenGl.Enable(GlCapability.Blend);
        OpenGl.BlendEquation(OpenGl.GL_FUNC_ADD);
        OpenGl.BlendFuncSeparate(
            OpenGl.GL_SRC_ALPHA,
            OpenGl.GL_ONE_MINUS_SRC_ALPHA,
            OpenGl.GL_ONE,
            OpenGl.GL_ONE_MINUS_SRC_ALPHA
        );
        OpenGl.Disable(GlCapability.CullFace);
        OpenGl.Disable(GlCapability.DepthTest);
        OpenGl.Disable(GlCapability.StencilTest);
        OpenGl.Enable(GlCapability.ScissorTest);

        OpenGl.Disable(GlCapability.PrimitiveRestart);
        OpenGl.PolygonMode(GlFace.FrontAndBack, OpenGl.GL_FILL);

        var clipOriginLowerLeft = true;
        if (_hasClipOrigin)
        {
            if (GetIntegerv(OpenGl.GL_CLIP_ORIGIN) == OpenGl.GL_UPPER_LEFT)
                clipOriginLowerLeft = false;
        }

        // Setup viewport, orthographic projection matrix
        // Our visible imgui space lies from draw_data->DisplayPos (top left) to draw_data->DisplayPos+data_data->DisplaySize (bottom right).
        // DisplayPos is (0,0) for single viewport apps.
        OpenGl.Viewport(0, 0, width, height);

        var left = drawData.DisplayPos.X;
        var right = drawData.DisplayPos.X + drawData.DisplaySize.X;
        var top = drawData.DisplayPos.Y;
        var bottom = drawData.DisplayPos.Y + drawData.DisplaySize.Y;

        // Swap top and bottom if origin is upper left
        if (!clipOriginLowerLeft)
        {
            (top, bottom) = (bottom, top);
        }

        _shader.Use();
        OpenGl.Uniform(_shader.Locations.Tex, 0);
        OpenGl.Uniform(
            _shader.Locations.Projection,
            float4x4.CreateOrthographicOffCenter(left, right, bottom, top, 0.0f, 1.0f)
        );

        // We use combined texture/sampler state. Applications using GL 3.3 and GL ES 3.0 may set that otherwise.
        OpenGl.BindSampler(0, default);

        // Bind vertex/index buffers and setup attributes for ImDrawVert
        vertexArrayObject.Bind();
        _vertexBuffer.Bind(GlBindTarget.ArrayBuffer);
        _indexBuffer.Bind(GlBindTarget.ElementArrayBuffer);

        OpenGl.EnableVertexAttribArray((uint)_shader.Locations.Position);
        OpenGl.EnableVertexAttribArray((uint)_shader.Locations.Uv);
        OpenGl.EnableVertexAttribArray((uint)_shader.Locations.Color);

        OpenGl.VertexAttribute(
            new GlAttribute(
                (uint)_shader.Locations.Position,
                2,
                OpenGl.GL_FLOAT,
                OpenGl.GL_FALSE,
                sizeof(ImDrawVert),
                0 // Offset of pos
            )
        );
        OpenGl.VertexAttribute(
            new GlAttribute(
                (uint)_shader.Locations.Uv,
                2,
                OpenGl.GL_FLOAT,
                OpenGl.GL_FALSE,
                sizeof(ImDrawVert),
                8 // Offset of uv
            )
        );
        OpenGl.VertexAttribute(
            new GlAttribute(
                (uint)_shader.Locations.Color,
                4,
                OpenGl.GL_UNSIGNED_BYTE,
                GlScaling.Normalized, // TODO: This is supposed to be true but API seems wrong...
                sizeof(ImDrawVert),
                16 // Offset of color
            )
        );
    }

    public unsafe void Dispose()
    {
        var io = ImGui.GetIO();

        GCHandle.FromIntPtr(io.BackendRendererUserData).Free();
        io.BackendRendererUserData = IntPtr.Zero;
        io.BackendRendererName = null;
        io.BackendFlags &= ~(
            ImGuiBackendFlags.RendererHasVtxOffset
            | ImGuiBackendFlags.RendererHasTextures
            | ImGuiBackendFlags.RendererHasViewports
        );

        ShutdownMultiViewportSupport();
        DestroyDeviceObjects();
    }

    private static unsafe void UpdateTexture(ImTextureDataPtr tex)
    {
        if (tex.Status is ImTextureStatus.WantCreate or ImTextureStatus.WantUpdates)
        {
            OpenGl.PixelStorei(OpenGl.GL_UNPACK_ROW_LENGTH, 0);
            OpenGl.PixelStorei(OpenGl.GL_UNPACK_ALIGNMENT, 1);
        }

        if (tex.Status is ImTextureStatus.WantCreate)
        {
            // Create and upload new texture to graphics system
            ImGui.Assert(tex.TexID.Value == 0 && tex.BackendUserData is 0);
            ImGui.Assert(tex.Format is ImTextureFormat.RGBA32);
            var pixels = tex.GetPixels();

            // Upload texture to graphics system
            // (Bilinear sampling is required by default. Set 'io.Fonts->Flags |= ImFontAtlasFlags_NoBakedLines' or 'style.AntiAliasedLinesUseTex = false' to allow point/nearest sampling)
            GlTexture glTextureId = default;
            var lastGlTextureId = GetIntegerv(OpenGl.GL_TEXTURE_BINDING_2D);
            OpenGl.GenTextures(new ReadOnlySpan<GlTexture>(&glTextureId, 1));
            OpenGl.BindTexture(OpenGl.GL_TEXTURE_2D, glTextureId.Id);
            OpenGl.TexParameterInt(OpenGl.GL_TEXTURE_2D, OpenGl.GL_TEXTURE_MIN_FILTER, [(int)OpenGl.GL_LINEAR]);
            OpenGl.TexParameterInt(OpenGl.GL_TEXTURE_2D, OpenGl.GL_TEXTURE_MAG_FILTER, [(int)OpenGl.GL_LINEAR]);
            OpenGl.TexParameterInt(OpenGl.GL_TEXTURE_2D, OpenGl.GL_TEXTURE_WRAP_S, [(int)OpenGl.GL_CLAMP_TO_EDGE]);
            OpenGl.TexParameterInt(OpenGl.GL_TEXTURE_2D, OpenGl.GL_TEXTURE_WRAP_T, [(int)OpenGl.GL_CLAMP_TO_EDGE]);
            OpenGl.TexImage2D(
                OpenGl.GL_TEXTURE_2D,
                0,
                (int)OpenGl.GL_RGBA,
                tex.Width,
                tex.Height,
                0,
                OpenGl.GL_RGBA,
                OpenGl.GL_UNSIGNED_BYTE,
                (void*)pixels
            );

            // Store identifiers
            tex.SetTexID(new ImTextureID((nint)glTextureId.Id));
            tex.SetStatus(ImTextureStatus.OK);

            // Restore state
            OpenGl.BindTexture(OpenGl.GL_TEXTURE_2D, (uint)lastGlTextureId);
        }
        else if (tex.Status == ImTextureStatus.WantUpdates)
        {
            // Update selected blocks. We only ever write to textures regions which have never been used before!
            // This backend choose to use tex.Updates[] but you can use tex.UpdateRect to upload a single region.
            var lastGlTextureId = GetIntegerv(OpenGl.GL_TEXTURE_BINDING_2D);

            OpenGl.BindTexture(OpenGl.GL_TEXTURE_2D, (uint)tex.TexID.Value);
            OpenGl.PixelStorei(OpenGl.GL_UNPACK_ROW_LENGTH, tex.Width);
            for (var i = 0; i < tex.Updates.Count; i++)
            {
                var r = tex.Updates[i];
                OpenGl.TexSubImage2D(
                    OpenGl.GL_TEXTURE_2D,
                    0,
                    r.x,
                    r.y,
                    r.w,
                    r.h,
                    (int)OpenGl.GL_RGBA,
                    OpenGl.GL_UNSIGNED_BYTE,
                    (void*)tex.GetPixelsAt(r.x, r.y)
                );
            }
            OpenGl.PixelStorei(OpenGl.GL_UNPACK_ROW_LENGTH, 0);
            tex.SetStatus(ImTextureStatus.OK);

            OpenGl.BindTexture(OpenGl.GL_TEXTURE_2D, (uint)lastGlTextureId); // Restore state
        }
        else if (tex is { Status: ImTextureStatus.WantDestroy, UnusedFrames: > 0 })
            DestroyTexture(tex);
    }

    private void CreateDeviceObjects(out Shader shader, out GlBuffer vertexBuffer, out GlBuffer indexBuffer)
    {
        // Note: at this point the C++ backend does some gl state backup/restore.
        // It didn't appear that any of it was actually required, so skipped here...

        shader = new Shader();

        ReadOnlySpan<GlBuffer> buffers = stackalloc GlBuffer[2];
        OpenGl.GenBuffers(buffers);

        vertexBuffer = buffers[0];
        indexBuffer = buffers[1];
    }

    private void DestroyDeviceObjects()
    {
        _shader.Dispose();
        OpenGl.DeleteBuffers([_vertexBuffer, _indexBuffer]);

        // Destroy all textures
        var textures = ImGui.GetPlatformIO().Textures;
        foreach (var tex in textures)
        {
            if (tex.RefCount is 1)
                DestroyTexture(tex);
        }
    }

    private static void DestroyTexture(ImTextureDataPtr tex)
    {
        var glTextureId = new GlTexture { Id = (uint)tex.TexID.Value };
        OpenGl.DeleteTextures([glTextureId]);

        // Clear identifiers and mark as destroyed (in order to allow e.g. calling InvalidateDeviceObjects while running)
        tex.SetTexID(ImTextureID.Invalid);
        tex.SetStatus(ImTextureStatus.Destroyed);
    }

    private Shader _shader;
    private readonly GlBuffer _vertexBuffer;
    private readonly GlBuffer _indexBuffer;

    private int _glVersion;
    private bool _hasClipOrigin;

    private unsafe struct GlStateBackup : IDisposable
    {
        private readonly int _lastActiveTexture;
        private readonly uint _lastProgram;
        private readonly uint _lastTexture;
        private readonly uint _lastSampler;
        private readonly uint _lastArrayBuffer;
        private readonly uint _lastVertexArrayObject;
        private fixed int _lastPolygonMode[2];
        private fixed int _lastViewport[4];
        private fixed int _lastScissorBox[4];
        private readonly int _lastBlendSrcRgb;
        private readonly int _lastBlendDstRgb;
        private readonly int _lastBlendSrcAlpha;
        private readonly int _lastBlendDstAlpha;
        private readonly int _lastBlendEquationRgb;
        private readonly int _lastBlendEquationAlpha;
        private readonly bool _lastEnableBlend;
        private readonly bool _lastEnableCullFace;
        private readonly bool _lastEnableDepthTest;
        private readonly bool _lastEnableStencilTest;
        private readonly bool _lastEnableScissorTest;
        private readonly bool _lastEnablePrimitiveRestart;

        public GlStateBackup()
        {
            // Backup GL state
            _lastActiveTexture = GetIntegerv(OpenGl.GL_ACTIVE_TEXTURE);
            OpenGl.ActiveTexture(OpenGl.GL_TEXTURE0);
            _lastProgram = (uint)GetIntegerv(OpenGl.GL_CURRENT_PROGRAM);
            _lastTexture = (uint)GetIntegerv(OpenGl.GL_TEXTURE_BINDING_2D);
            _lastSampler = (uint)GetIntegerv(OpenGl.GL_SAMPLER_BINDING);
            _lastArrayBuffer = (uint)GetIntegerv(OpenGl.GL_ARRAY_BUFFER_BINDING);
            _lastVertexArrayObject = (uint)GetIntegerv(OpenGl.GL_VERTEX_ARRAY_BINDING);
            fixed (int* lastPolygonMode = _lastPolygonMode)
                OpenGl.GetIntegerv(OpenGl.GL_POLYGON_MODE, new ReadOnlySpan<int>(lastPolygonMode, 2));
            fixed (int* lastViewport = _lastViewport)
                OpenGl.GetIntegerv(OpenGl.GL_VIEWPORT, new ReadOnlySpan<int>(lastViewport, 4));
            fixed (int* lastScissorBox = _lastScissorBox)
                OpenGl.GetIntegerv(OpenGl.GL_SCISSOR_BOX, new ReadOnlySpan<int>(lastScissorBox, 4));
            _lastBlendSrcRgb = GetIntegerv(OpenGl.GL_BLEND_SRC_RGB);
            _lastBlendDstRgb = GetIntegerv(OpenGl.GL_BLEND_DST_RGB);
            _lastBlendSrcAlpha = GetIntegerv(OpenGl.GL_BLEND_SRC_ALPHA);
            _lastBlendDstAlpha = GetIntegerv(OpenGl.GL_BLEND_DST_ALPHA);
            _lastBlendEquationRgb = GetIntegerv(OpenGl.GL_BLEND_EQUATION_RGB);
            _lastBlendEquationAlpha = GetIntegerv(OpenGl.GL_BLEND_EQUATION_ALPHA);
            _lastEnableBlend = OpenGl.IsEnabled(OpenGl.GL_BLEND);
            _lastEnableCullFace = OpenGl.IsEnabled(OpenGl.GL_CULL_FACE);
            _lastEnableDepthTest = OpenGl.IsEnabled(OpenGl.GL_DEPTH_TEST);
            _lastEnableStencilTest = OpenGl.IsEnabled(OpenGl.GL_STENCIL_TEST);
            _lastEnableScissorTest = OpenGl.IsEnabled(OpenGl.GL_SCISSOR_TEST);
            _lastEnablePrimitiveRestart = OpenGl.IsEnabled(OpenGl.GL_PRIMITIVE_RESTART);
        }

        public void Dispose()
        {
            // Restore modified GL state
            // This "glIsProgram()" check is required because if the program is "pending deletion" at the time of binding backup, it will have been deleted by now and will cause an OpenGL error. See #6220.
            if (_lastProgram is 0 || OpenGl.IsProgram(new GlProgram(_lastProgram)))
                new GlProgram(_lastProgram).Use();
            OpenGl.BindTexture(OpenGl.GL_TEXTURE_2D, _lastTexture);
            OpenGl.BindSampler(0, new GlSampler(_lastSampler));
            OpenGl.ActiveTexture((uint)_lastActiveTexture);
            new GlVertexArray(_lastVertexArrayObject).Bind();
            new GlBuffer(_lastArrayBuffer).Bind(GlBindTarget.ArrayBuffer);
            OpenGl.BlendEquationSeparate((uint)_lastBlendEquationRgb, (uint)_lastBlendEquationAlpha);
            OpenGl.BlendFuncSeparate(
                (uint)_lastBlendSrcRgb,
                (uint)_lastBlendDstRgb,
                (uint)_lastBlendSrcAlpha,
                (uint)_lastBlendDstAlpha
            );
            if (_lastEnableBlend)
                OpenGl.Enable(GlCapability.Blend);
            else
                OpenGl.Disable(GlCapability.Blend);
            if (_lastEnableCullFace)
                OpenGl.Enable(GlCapability.CullFace);
            else
                OpenGl.Disable(GlCapability.CullFace);
            if (_lastEnableDepthTest)
                OpenGl.Enable(GlCapability.DepthTest);
            else
                OpenGl.Disable(GlCapability.DepthTest);
            if (_lastEnableStencilTest)
                OpenGl.Enable(GlCapability.StencilTest);
            else
                OpenGl.Disable(GlCapability.StencilTest);
            if (_lastEnableScissorTest)
                OpenGl.Enable(GlCapability.ScissorTest);
            else
                OpenGl.Disable(GlCapability.ScissorTest);
            if (_lastEnablePrimitiveRestart)
                OpenGl.Enable(GlCapability.PrimitiveRestart);
            else
                OpenGl.Disable(GlCapability.PrimitiveRestart);

            OpenGl.PolygonMode(GlFace.FrontAndBack, (uint)_lastPolygonMode[0]);

            OpenGl.Viewport(_lastViewport[0], _lastViewport[1], _lastViewport[2], _lastViewport[3]);
            OpenGl.Scissor(_lastScissorBox[0], _lastScissorBox[1], _lastScissorBox[2], _lastScissorBox[3]);
        }
    }

    private struct Shader : IDisposable
    {
        public Shader()
        {
            Program = BuildProgram();
            Locations.Tex = Program.GetUniformLocation("Texture"u8);
            Locations.Projection = Program.GetUniformLocation("Projection"u8);
            Locations.Position = OpenGl.GetAttribLocation(Program, "Position"u8);
            Locations.Uv = OpenGl.GetAttribLocation(Program, "UV"u8);
            Locations.Color = OpenGl.GetAttribLocation(Program, "Color"u8);
        }

        public void Use()
        {
            Program.Use();
        }

        public readonly GlProgram Program;
        public readonly AttributeLocations Locations;

        public struct AttributeLocations
        {
            public int Tex;
            public int Projection;
            public int Position;
            public int Uv;
            public int Color;
        }

        private static GlProgram BuildProgram()
        {
            using var vertShaderHandle = OpenGl
                .CreateShader(GlShaderType.Vertex)
                .SetSource(ShaderSource.Vert)
                .Compile();

            using var fragShaderHandle = OpenGl
                .CreateShader(GlShaderType.Fragment)
                .SetSource(ShaderSource.Frag)
                .Compile();

            var shaderHandle = OpenGl.CreateProgram().Attach(vertShaderHandle, fragShaderHandle).Link();

            OpenGl.DetachShader(shaderHandle, vertShaderHandle);
            OpenGl.DetachShader(shaderHandle, fragShaderHandle);

            return shaderHandle;
        }

        public void Dispose()
        {
            Program.Dispose();
        }
    }

    private static class ShaderSource
    {
        public const string Vert = """
            #version 410 core
            layout (location = 0) in vec2 Position;
            layout (location = 1) in vec2 UV;
            layout (location = 2) in vec4 Color;
            uniform mat4 Projection;
            out vec2 Frag_UV;
            out vec4 Frag_Color;
            void main()
            {
                Frag_UV = UV;
                Frag_Color = Color;
                gl_Position = Projection * vec4(Position.xy,0,1);
            }
            """;

        public const string Frag = """
            #version 410 core
            in vec2 Frag_UV;
            in vec4 Frag_Color;
            uniform sampler2D Texture;
            layout (location = 0) out vec4 Out_Color;
            void main()
            {
                Out_Color = Frag_Color * texture(Texture, Frag_UV.st);
            }
            """;
    }

    //--------------------------------------------------------------------------------------------------------
    // MULTI-VIEWPORT / PLATFORM INTERFACE SUPPORT
    // This is an _advanced_ and _optional_ feature, allowing the backend to create and handle multiple viewports simultaneously.
    // If you are new to dear imgui or creating a new binding for dear imgui, it is recommended that you completely ignore this section first..
    //--------------------------------------------------------------------------------------------------------

    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl)])]
    private static unsafe void RenderWindow(ImGuiViewport* viewport)
    {
        if (!viewport->Flags.HasFlag(ImGuiViewportFlags.NoRendererClear))
        {
            OpenGl.ClearColor(new float4(float3.Zero, 1.0f));
            OpenGl.Clear(GlClearBit.Color);
        }

        var handle = GCHandle.FromIntPtr(ImGui.GetIO().BackendRendererUserData);
        if (handle.Target is not OpenGlBackend backend)
            throw new Exception("Failed to retrieve OpenGL backend");

        backend.RenderDrawData(viewport->DrawData);
    }

    private static unsafe void InitMultiViewportSupport()
    {
        var platformIo = ImGui.GetPlatformIO();
        delegate* unmanaged[Cdecl]<ImGuiViewport*, void> renderWindowFunction = &RenderWindow;
        platformIo.Renderer_RenderWindow = (nint)renderWindowFunction;
    }

    private static void ShutdownMultiViewportSupport()
    {
        ImGui.DestroyPlatformWindows();
    }
}
