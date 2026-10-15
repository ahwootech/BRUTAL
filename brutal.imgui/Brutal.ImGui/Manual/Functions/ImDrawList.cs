namespace Brutal.ImGuiApi;

public static partial class ImDrawListExtensions
{
    /// <remarks><code>
    /// Image primitives
    /// - Read FAQ to understand what ImTextureID/ImTextureRef are.
    /// - &quot;p_min&quot; and &quot;p_max&quot; represent the upper-left and lower-right corners of the rectangle.
    /// - &quot;uv_min&quot; and &quot;uv_max&quot; represent the normalized texture coordinates to use for those corners. Using (0,0)-&gt;(1,1) texture coordinates will generally display the entire texture.
    /// </code></remarks>
    /// <source href="https://github.com/ocornut/imgui/blob/v1.92.2-docking/imgui.h#L3407"><a href="https://github.com/ocornut/imgui/blob/v1.92.2-docking/imgui.h#L3407">imgui.h:3407</a></source>
    /// <br/>
    /// <declaration><c>void  AddImage(ImTextureRef tex_ref, const ImVec2&amp; p_min, const ImVec2&amp; p_max, const ImVec2&amp; uv_min = ImVec2(0, 0), const ImVec2&amp; uv_max = ImVec2(1, 1), ImU32 col = IM_COL32_WHITE)</c></declaration>
    public static void AddImage(
        this ImDrawListPtr target,
        ImTextureRef texRef,
        in float2 pMin,
        in float2 pMax,
        in float2? uvMin = default,
        in float2? uvMax = default,
        ImColor8? col = default
    )
    {
        unsafe
        {
            var uvMin_default = uvMin ?? new float2(0f, 0f);
            var uvMax_default = uvMax ?? new float2(1f, 1f);
            var col_default = col ?? new byte4(255);
            fixed (float2* pMax_fixed = &pMax)
            fixed (float2* pMin_fixed = &pMin)
            {
                ImGui.PInvoke.ImDrawList_AddImage(
                    target,
                    texRef,
                    pMin_fixed,
                    pMax_fixed,
                    &uvMin_default,
                    &uvMax_default,
                    col_default
                );
            }
        }
    }

    /// <remarks><code>
    /// Image primitives
    /// - Read FAQ to understand what ImTextureID/ImTextureRef are.
    /// - &quot;p_min&quot; and &quot;p_max&quot; represent the upper-left and lower-right corners of the rectangle.
    /// - &quot;uv_min&quot; and &quot;uv_max&quot; represent the normalized texture coordinates to use for those corners. Using (0,0)-&gt;(1,1) texture coordinates will generally display the entire texture.
    /// </code></remarks>
    /// <source href="https://github.com/ocornut/imgui/blob/v1.92.2-docking/imgui.h#L3408"><a href="https://github.com/ocornut/imgui/blob/v1.92.2-docking/imgui.h#L3408">imgui.h:3408</a></source>
    /// <br/>
    /// <declaration><c>void  AddImageQuad(ImTextureRef tex_ref, const ImVec2&amp; p1, const ImVec2&amp; p2, const ImVec2&amp; p3, const ImVec2&amp; p4, const ImVec2&amp; uv1 = ImVec2(0, 0), const ImVec2&amp; uv2 = ImVec2(1, 0), const ImVec2&amp; uv3 = ImVec2(1, 1), const ImVec2&amp; uv4 = ImVec2(0, 1), ImU32 col = IM_COL32_WHITE)</c></declaration>
    public static void AddImageQuad(
        this ImDrawListPtr target,
        ImTextureRef texRef,
        in float2 p1,
        in float2 p2,
        in float2 p3,
        in float2 p4,
        in float2? uv1 = default,
        in float2? uv2 = default,
        in float2? uv3 = default,
        in float2? uv4 = default,
        ImColor8? col = default
    )
    {
        unsafe
        {
            var uv1_default = uv1 ?? new float2(0f, 0f);
            var uv2_default = uv2 ?? new float2(1f, 0f);
            var uv3_default = uv3 ?? new float2(1f, 1f);
            var uv4_default = uv4 ?? new float2(0f, 1f);
            var col_default = col ?? new byte4(255);
            fixed (float2* p4_fixed = &p4)
            fixed (float2* p3_fixed = &p3)
            fixed (float2* p2_fixed = &p2)
            fixed (float2* p1_fixed = &p1)
            {
                ImGui.PInvoke.ImDrawList_AddImageQuad(
                    target,
                    texRef,
                    p1_fixed,
                    p2_fixed,
                    p3_fixed,
                    p4_fixed,
                    &uv1_default,
                    &uv2_default,
                    &uv3_default,
                    &uv4_default,
                    col_default
                );
            }
        }
    }

    /// <remarks><code>
    /// Advanced: Draw Callbacks
    /// - May be used to alter render state (change sampler, blending, current shader).
    /// - May be used to emit custom rendering commands (difficult to do correctly, but possible).
    /// - Use special ImDrawCallback_ResetRenderState callback to instruct backend to reset its render state to the default.
    /// - Your rendering loop must check for 'UserCallback' in ImDrawCmd and call the function instead of rendering triangles. (All standard backends are honoring this.)
    /// </code></remarks>
    /// <summary>
    /// User data is copied to a backing buffer by ImGui internals, and the callback points to the copy for user data
    /// </summary>
    public static unsafe void AddCallback<T>(this ImDrawListPtr target, ImDrawCallback callback, in T userData)
        where T : unmanaged
    {
        fixed (void* ptr = &userData)
        {
            PInvoke.ImDrawList_AddCallback(
                target,
                Marshal.GetFunctionPointerForDelegate(callback),
                ptr,
                (UIntPtr)ByteSize.Of<T>()
            );
        }
    }
}
