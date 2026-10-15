namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDataGraphPipelineSingleNodeCreateInfoARM.html">VkDataGraphPipelineSingleNodeCreateInfoARM</see> - Structure specifying parameters of a newly-created single fixed-function node graph pipeline
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkDataGraphPipelineSingleNodeCreateInfoARM
    ///     </para>
    ///     <para>
    ///         The <c>VkDataGraphPipelineSingleNodeCreateInfoARM</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ARM_data_graph_optical_flow
    ///         typedef struct VkDataGraphPipelineSingleNodeCreateInfoARM {
    ///             VkStructureType                                      sType;
    ///             void*                                                pNext;
    ///             VkDataGraphPipelineNodeTypeARM                       nodeType;
    ///             uint32_t                                             connectionCount;
    ///             const VkDataGraphPipelineSingleNodeConnectionARM*    pConnections;
    ///         } VkDataGraphPipelineSingleNodeCreateInfoARM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkDataGraphPipelineSingleNodeCreateInfoARM()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.DataGraphPipelineSingleNodeCreateInfoARM;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>NodeType</c> is a <c>VkDataGraphPipelineNodeTypeARM</c> describing the type of this node.
        /// </summary>
        [FieldOffset(16)]
        public VkDataGraphPipelineNodeTypeARM NodeType;

        /// <summary>
        ///     <c>ConnectionCount</c> is the length of the <c>pConnections</c> array.
        /// </summary>
        [FieldOffset(20)]
        public int ConnectionCount;

        /// <summary>
        ///     <c>Connections</c> is a pointer to an array of <c>connectionCount</c> <c>VkDataGraphPipelineSingleNodeConnectionARM</c> structures.
        /// </summary>
        [FieldOffset(24)]
        public VkDataGraphPipelineSingleNodeConnectionARM* Connections;
    }
}
