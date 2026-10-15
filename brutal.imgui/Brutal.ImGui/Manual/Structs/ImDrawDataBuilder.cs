namespace Brutal.ImGuiApi;

[InlineArray(2)]
public struct ImDrawDataBuilderLayers
{
    public Ptr<ImVector<ImDrawListPtr>> Value;
}

/// <summary>Helper to build a ImDrawData instance</summary>
/// <remarks>ImDrawList/ImFontAtlas</remarks>
/// <source href="https://github.com/ocornut/imgui/blob/v1.92.2-docking/imgui_internal.h#L142"><a href="https://github.com/ocornut/imgui/blob/v1.92.2-docking/imgui_internal.h#L142">imgui_internal.h:142</a></source>
/// <br/>
/// <declaration><c>struct ImDrawDataBuilder</c></declaration>
[StructLayout(LayoutKind.Explicit, Size = 32)]
public partial struct ImDrawDataBuilder()
{
    /// <summary>Pointers to global layers for: regular, tooltip. LayersP[0] is owned by DrawData.</summary>
    /// <source href="https://github.com/ocornut/imgui/blob/v1.92.2-docking/imgui_internal.h#L877"><a href="https://github.com/ocornut/imgui/blob/v1.92.2-docking/imgui_internal.h#L877">imgui_internal.h:877</a></source>
    /// <br/>
    /// <declaration><c>ImVector&lt;ImDrawList*&gt;*  Layers[2]</c></declaration>
    [FieldOffset(0)]
    public ImDrawDataBuilderLayers Layers;

    /// <summary/>
    /// <source href="https://github.com/ocornut/imgui/blob/v1.92.2-docking/imgui_internal.h#L878"><a href="https://github.com/ocornut/imgui/blob/v1.92.2-docking/imgui_internal.h#L878">imgui_internal.h:878</a></source>
    /// <br/>
    /// <declaration><c>ImVector&lt;ImDrawList*&gt;   LayerData1</c></declaration>
    [FieldOffset(16)]
    public ImVector<ImDrawListPtr> LayerData1;
}

/// <inheritdoc cref="ImDrawDataBuilder"/>
public unsafe partial struct ImDrawDataBuilderPtr(ImDrawDataBuilder* ptr) : INullable
{
    private ImDrawDataBuilder* _ptr = ptr;
    public ImDrawDataBuilder* Ptr => _ptr;

    public bool IsNull() => _ptr is null;

    public static implicit operator ImDrawDataBuilderPtr(ImDrawDataBuilder* ptr) => new(ptr);

    public static implicit operator ImDrawDataBuilder*(ImDrawDataBuilderPtr wrapper) => wrapper.Ptr;

    /// <inheritdoc cref="ImDrawDataBuilder.Layers"/>
    public ref ImDrawDataBuilderLayers Layers => ref Unsafe.AsRef<ImDrawDataBuilderLayers>(&_ptr->Layers);

    /// <inheritdoc cref="ImDrawDataBuilder.LayerData1"/>
    public ref ImVector<ImDrawListPtr> LayerData1 => ref Unsafe.AsRef<ImVector<ImDrawListPtr>>(&_ptr->LayerData1);
}
