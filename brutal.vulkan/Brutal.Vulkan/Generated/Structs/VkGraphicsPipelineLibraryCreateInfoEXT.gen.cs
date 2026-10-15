namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkGraphicsPipelineLibraryCreateInfoEXT.html">VkGraphicsPipelineLibraryCreateInfoEXT</see> - Structure specifying the subsets of the graphics pipeline being compiled
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkGraphicsPipelineLibraryCreateInfoEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_graphics_pipeline_library
    ///         typedef struct VkGraphicsPipelineLibraryCreateInfoEXT {
    ///             VkStructureType                      sType;
    ///             const void*                          pNext;
    ///             VkGraphicsPipelineLibraryFlagsEXT    flags;
    ///         } VkGraphicsPipelineLibraryCreateInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkGraphicsPipelineLibraryCreateInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.GraphicsPipelineLibraryCreateInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is a bitmask of <c>VkGraphicsPipelineLibraryFlagsEXT</c> specifying the subsets of the graphics pipeline that are being compiled.
        /// </summary>
        [FieldOffset(16)]
        public VkGraphicsPipelineLibraryFlagsEXT Flags;
    }
}
