namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPipelineRasterizationStateRasterizationOrderAMD.html">VkPipelineRasterizationStateRasterizationOrderAMD</see> - Structure defining rasterization order for a graphics pipeline
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The rasterization order to use for a graphics pipeline is specified by
    ///         adding a <c>VkPipelineRasterizationStateRasterizationOrderAMD</c> structure
    ///         to the <c>pNext</c> chain of a <c>VkPipelineRasterizationStateCreateInfo</c>
    ///         structure.
    ///     </para>
    ///     <para>
    ///         The <c>VkPipelineRasterizationStateRasterizationOrderAMD</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_AMD_rasterization_order
    ///         typedef struct VkPipelineRasterizationStateRasterizationOrderAMD {
    ///             VkStructureType            sType;
    ///             const void*                pNext;
    ///             VkRasterizationOrderAMD    rasterizationOrder;
    ///         } VkPipelineRasterizationStateRasterizationOrderAMD;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPipelineRasterizationStateRasterizationOrderAMD()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PipelineRasterizationStateRasterizationOrderAMD;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>RasterizationOrder</c> is a <c>VkRasterizationOrderAMD</c> value specifying the primitive rasterization order to use.
        /// </summary>
        [FieldOffset(16)]
        public VkRasterizationOrderAMD RasterizationOrder;
    }
}
