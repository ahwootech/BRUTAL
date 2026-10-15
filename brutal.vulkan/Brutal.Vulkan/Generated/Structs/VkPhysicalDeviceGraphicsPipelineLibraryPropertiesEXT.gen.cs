namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceGraphicsPipelineLibraryPropertiesEXT.html">VkPhysicalDeviceGraphicsPipelineLibraryPropertiesEXT</see> - Structure describing additional properties of graphics pipeline libraries
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceGraphicsPipelineLibraryPropertiesEXT</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_graphics_pipeline_library
    ///         typedef struct VkPhysicalDeviceGraphicsPipelineLibraryPropertiesEXT {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           graphicsPipelineLibraryFastLinking;
    ///             VkBool32           graphicsPipelineLibraryIndependentInterpolationDecoration;
    ///         } VkPhysicalDeviceGraphicsPipelineLibraryPropertiesEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceGraphicsPipelineLibraryPropertiesEXT()
    {
        /// <summary>
        ///     <c>sType</c>
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceGraphicsPipelineLibraryPropertiesEXT;

        /// <summary>
        ///     <c>Next</c>
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>GraphicsPipelineLibraryFastLinking</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 GraphicsPipelineLibraryFastLinking;

        /// <summary>
        ///     <c>GraphicsPipelineLibraryIndependentInterpolationDecoration</c>
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 GraphicsPipelineLibraryIndependentInterpolationDecoration;
    }
}
