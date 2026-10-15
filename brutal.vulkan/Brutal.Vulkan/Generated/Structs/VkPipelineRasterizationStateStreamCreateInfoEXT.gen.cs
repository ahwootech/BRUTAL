namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPipelineRasterizationStateStreamCreateInfoEXT.html">VkPipelineRasterizationStateStreamCreateInfoEXT</see> - Structure defining the geometry stream used for rasterization
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The vertex stream used for rasterization is specified by adding a
    ///         <c>VkPipelineRasterizationStateStreamCreateInfoEXT</c> structure to the
    ///         <c>pNext</c> chain of a <c>VkPipelineRasterizationStateCreateInfo</c>
    ///         structure.
    ///     </para>
    ///     <para>
    ///         The <c>VkPipelineRasterizationStateStreamCreateInfoEXT</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_transform_feedback
    ///         typedef struct VkPipelineRasterizationStateStreamCreateInfoEXT {
    ///             VkStructureType                                     sType;
    ///             const void*                                         pNext;
    ///             VkPipelineRasterizationStateStreamCreateFlagsEXT    flags;
    ///             uint32_t                                            rasterizationStream;
    ///         } VkPipelineRasterizationStateStreamCreateInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPipelineRasterizationStateStreamCreateInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PipelineRasterizationStateStreamCreateInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is reserved for future use.
        /// </summary>
        [FieldOffset(16)]
        public VkPipelineRasterizationStateStreamCreateFlagsEXT Flags;

        /// <summary>
        ///     <c>RasterizationStream</c> is the vertex stream selected for rasterization.
        /// </summary>
        [FieldOffset(20)]
        public int RasterizationStream;
    }
}
