namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPipelineFragmentDensityMapLayeredCreateInfoVALVE.html">VkPipelineFragmentDensityMapLayeredCreateInfoVALVE</see> - Structure specifying layered fragment density map info
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPipelineFragmentDensityMapLayeredCreateInfoVALVE</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VALVE_fragment_density_map_layered
    ///         typedef struct VkPipelineFragmentDensityMapLayeredCreateInfoVALVE {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             uint32_t           maxFragmentDensityMapLayers;
    ///         } VkPipelineFragmentDensityMapLayeredCreateInfoVALVE;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPipelineFragmentDensityMapLayeredCreateInfoVALVE()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PipelineFragmentDensityMapLayeredCreateInfoVALVE;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>MaxFragmentDensityMapLayers</c> is the maximum number of layers which can be used with a fragment density map.
        /// </summary>
        [FieldOffset(16)]
        public int MaxFragmentDensityMapLayers;
    }
}
