namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPipelineViewportCoarseSampleOrderStateCreateInfoNV.html">VkPipelineViewportCoarseSampleOrderStateCreateInfoNV</see> - Structure specifying parameters controlling sample order in coarse fragments
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         If the <c>pNext</c> chain of <c>VkPipelineViewportStateCreateInfo</c> includes
    ///         a <c>VkPipelineViewportCoarseSampleOrderStateCreateInfoNV</c> structure, then
    ///         that structure includes parameters controlling the order of coverage samples
    ///         in fragments larger than one pixel.
    ///     </para>
    ///     <para>
    ///         The <c>VkPipelineViewportCoarseSampleOrderStateCreateInfoNV</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_shading_rate_image
    ///         typedef struct VkPipelineViewportCoarseSampleOrderStateCreateInfoNV {
    ///             VkStructureType                       sType;
    ///             const void*                           pNext;
    ///             VkCoarseSampleOrderTypeNV             sampleOrderType;
    ///             uint32_t                              customSampleOrderCount;
    ///             const VkCoarseSampleOrderCustomNV*    pCustomSampleOrders;
    ///         } VkPipelineViewportCoarseSampleOrderStateCreateInfoNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkPipelineViewportCoarseSampleOrderStateCreateInfoNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PipelineViewportCoarseSampleOrderStateCreateInfoNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>SampleOrderType</c> specifies the mechanism used to order coverage samples in fragments larger than one pixel.
        /// </summary>
        [FieldOffset(16)]
        public VkCoarseSampleOrderTypeNV SampleOrderType;

        /// <summary>
        ///     <c>CustomSampleOrderCount</c> specifies the number of custom sample orderings to use when ordering coverage samples.
        /// </summary>
        [FieldOffset(20)]
        public int CustomSampleOrderCount;

        /// <summary>
        ///     <c>CustomSampleOrders</c> is a pointer to an array of <c>customSampleOrderCount</c> <c>VkCoarseSampleOrderCustomNV</c> structures, each structure specifying the coverage sample order for a single combination of fragment area and coverage sample count.
        /// </summary>
        [FieldOffset(24)]
        public VkCoarseSampleOrderCustomNV* CustomSampleOrders;
    }
}
