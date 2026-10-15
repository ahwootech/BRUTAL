namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPipelineRasterizationProvokingVertexStateCreateInfoEXT.html">VkPipelineRasterizationProvokingVertexStateCreateInfoEXT</see> - Structure specifying provoking vertex mode used by a graphics pipeline
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         For a given primitive topology, the pipeline&apos;s provoking vertex mode
    ///         determines which vertex is the provoking vertex.
    ///         To specify the provoking vertex mode, include a
    ///         <c>VkPipelineRasterizationProvokingVertexStateCreateInfoEXT</c> structure in
    ///         the <c>VkPipelineRasterizationStateCreateInfo::pNext</c> chain when
    ///         creating the pipeline.
    ///     </para>
    ///     <para>
    ///         The <c>VkPipelineRasterizationProvokingVertexStateCreateInfoEXT</c> structure
    ///         is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_provoking_vertex
    ///         typedef struct VkPipelineRasterizationProvokingVertexStateCreateInfoEXT {
    ///             VkStructureType             sType;
    ///             const void*                 pNext;
    ///             VkProvokingVertexModeEXT    provokingVertexMode;
    ///         } VkPipelineRasterizationProvokingVertexStateCreateInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPipelineRasterizationProvokingVertexStateCreateInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType =
            VkStructureType.PipelineRasterizationProvokingVertexStateCreateInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ProvokingVertexMode</c> is a <c>VkProvokingVertexModeEXT</c> value selecting the provoking vertex mode.
        /// </summary>
        [FieldOffset(16)]
        public VkProvokingVertexModeEXT ProvokingVertexMode;
    }
}
