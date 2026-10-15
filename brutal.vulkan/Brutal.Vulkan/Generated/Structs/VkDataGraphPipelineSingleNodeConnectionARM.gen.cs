namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDataGraphPipelineSingleNodeConnectionARM.html">VkDataGraphPipelineSingleNodeConnectionARM</see> - Structure describing a single connection between a data graph node and the pipeline layout of a graph pipeline
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkDataGraphPipelineSingleNodeConnectionARM</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ARM_data_graph_optical_flow
    ///         typedef struct VkDataGraphPipelineSingleNodeConnectionARM {
    ///             VkStructureType                             sType;
    ///             void*                                       pNext;
    ///             uint32_t                                    set;
    ///             uint32_t                                    binding;
    ///             VkDataGraphPipelineNodeConnectionTypeARM    connection;
    ///         } VkDataGraphPipelineSingleNodeConnectionARM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkDataGraphPipelineSingleNodeConnectionARM()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.DataGraphPipelineSingleNodeConnectionARM;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Set</c> is the descriptor set number of the graph pipeline layout resource to be connected to this connection point.
        /// </summary>
        [FieldOffset(16)]
        public int Set;

        /// <summary>
        ///     <c>Binding</c> is the binding number of the graph pipeline layout resource to be connected to this connection point.
        /// </summary>
        [FieldOffset(20)]
        public int Binding;

        /// <summary>
        ///     <c>Connection</c> is a <c>VkDataGraphPipelineNodeConnectionTypeARM</c> specifying the connection point to link to a graph pipeline layout resource.
        /// </summary>
        [FieldOffset(24)]
        public VkDataGraphPipelineNodeConnectionTypeARM Connection;
    }
}
