namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceGraphicsPipelineLibraryFeaturesEXT.html">VkPhysicalDeviceGraphicsPipelineLibraryFeaturesEXT</see> - Structure describing support for graphics pipeline libraries
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceGraphicsPipelineLibraryFeaturesEXT</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_graphics_pipeline_library
    ///         typedef struct VkPhysicalDeviceGraphicsPipelineLibraryFeaturesEXT {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           graphicsPipelineLibrary;
    ///         } VkPhysicalDeviceGraphicsPipelineLibraryFeaturesEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceGraphicsPipelineLibraryFeaturesEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceGraphicsPipelineLibraryFeaturesEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>GraphicsPipelineLibrary</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 GraphicsPipelineLibrary;
    }
}
