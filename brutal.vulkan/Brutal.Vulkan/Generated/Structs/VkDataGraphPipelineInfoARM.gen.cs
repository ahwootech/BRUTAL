namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDataGraphPipelineInfoARM.html">VkDataGraphPipelineInfoARM</see> - Structure describing a data graph pipeline
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkDataGraphPipelineInfoARM
    ///     </para>
    ///     <para>
    ///         The <c>VkDataGraphPipelineInfoARM</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ARM_data_graph
    ///         typedef struct VkDataGraphPipelineInfoARM {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             VkPipeline         dataGraphPipeline;
    ///         } VkDataGraphPipelineInfoARM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkDataGraphPipelineInfoARM()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.DataGraphPipelineInfoARM;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>DataGraphPipeline</c> is a <c>VkPipeline</c> handle.
        /// </summary>
        [FieldOffset(16)]
        public VkPipeline DataGraphPipeline;
    }
}
