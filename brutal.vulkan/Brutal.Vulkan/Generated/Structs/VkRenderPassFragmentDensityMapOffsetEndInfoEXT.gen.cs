namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkRenderPassFragmentDensityMapOffsetEndInfoEXT.html">VkRenderPassFragmentDensityMapOffsetEndInfoEXT</see> - Structure specifying fragment density map offset subpass end information
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         [[renderpass-fragmentdensitymapoffsets]]
    ///         If the <c>VkSubpassEndInfo::pNext</c> chain
    ///         includes a <c>VkRenderPassFragmentDensityMapOffsetEndInfoEXT</c> structure,
    ///         then that structure includes an array of fragment density map offsets per
    ///         layer for the render pass.
    ///     </para>
    ///     <para>
    ///         The <c>VkRenderPassFragmentDensityMapOffsetEndInfoEXT</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_fragment_density_map_offset
    ///         typedef struct VkRenderPassFragmentDensityMapOffsetEndInfoEXT {
    ///             VkStructureType      sType;
    ///             const void*          pNext;
    ///             uint32_t             fragmentDensityOffsetCount;
    ///             const VkOffset2D*    pFragmentDensityOffsets;
    ///         } VkRenderPassFragmentDensityMapOffsetEndInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkRenderPassFragmentDensityMapOffsetEndInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.RenderPassFragmentDensityMapOffsetEndInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>FragmentDensityOffsetCount</c> is the number of offsets being specified.
        /// </summary>
        [FieldOffset(16)]
        public int FragmentDensityOffsetCount;

        /// <summary>
        ///     <c>FragmentDensityOffsets</c> is a pointer to an array of <c>VkOffset2D</c> structs, each of which describes the offset per layer.
        /// </summary>
        [FieldOffset(24)]
        public VkOffset2D* FragmentDensityOffsets;
    }
}
