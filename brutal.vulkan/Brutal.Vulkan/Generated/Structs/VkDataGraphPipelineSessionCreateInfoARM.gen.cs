namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDataGraphPipelineSessionCreateInfoARM.html">VkDataGraphPipelineSessionCreateInfoARM</see> - Structure specifying parameters of a newly created data graph pipeline session
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkDataGraphPipelineSessionCreateInfoARM
    ///     </para>
    ///     <para>
    ///         The <c>VkDataGraphPipelineSessionCreateInfoARM</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ARM_data_graph
    ///         typedef struct VkDataGraphPipelineSessionCreateInfoARM {
    ///             VkStructureType                             sType;
    ///             const void*                                 pNext;
    ///             VkDataGraphPipelineSessionCreateFlagsARM    flags;
    ///             VkPipeline                                  dataGraphPipeline;
    ///         } VkDataGraphPipelineSessionCreateInfoARM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkDataGraphPipelineSessionCreateInfoARM()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.DataGraphPipelineSessionCreateInfoARM;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is a bitmask of <c>VkDataGraphPipelineSessionCreateFlagsARM</c> describing additional parameters of the session.
        /// </summary>
        [FieldOffset(16)]
        public VkDataGraphPipelineSessionCreateFlagsARM Flags;

        /// <summary>
        ///     <c>DataGraphPipeline</c> is the <c>VkPipeline</c> handle of the data graph pipeline for which a session is being created.
        /// </summary>
        [FieldOffset(24)]
        public VkPipeline DataGraphPipeline;
    }
}
