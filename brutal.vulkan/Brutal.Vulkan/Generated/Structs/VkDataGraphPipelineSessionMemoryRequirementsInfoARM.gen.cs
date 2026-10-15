namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDataGraphPipelineSessionMemoryRequirementsInfoARM.html">VkDataGraphPipelineSessionMemoryRequirementsInfoARM</see> - Structure specifying parameters to query the memory requirements of a data graph pipeline session
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkDataGraphPipelineSessionMemoryRequirementsInfoARM
    ///     </para>
    ///     <para>
    ///         The <c>VkDataGraphPipelineSessionMemoryRequirementsInfoARM</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ARM_data_graph
    ///         typedef struct VkDataGraphPipelineSessionMemoryRequirementsInfoARM {
    ///             VkStructureType                           sType;
    ///             const void*                               pNext;
    ///             VkDataGraphPipelineSessionARM             session;
    ///             VkDataGraphPipelineSessionBindPointARM    bindPoint;
    ///             uint32_t                                  objectIndex;
    ///         } VkDataGraphPipelineSessionMemoryRequirementsInfoARM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkDataGraphPipelineSessionMemoryRequirementsInfoARM()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.DataGraphPipelineSessionMemoryRequirementsInfoARM;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Session</c> is the data graph pipeline session to query.
        /// </summary>
        [FieldOffset(16)]
        public VkDataGraphPipelineSessionARM Session;

        /// <summary>
        ///     <c>BindPoint</c> is the bind point of a data graph pipeline session for which memory requirements are being queried.
        /// </summary>
        [FieldOffset(24)]
        public VkDataGraphPipelineSessionBindPointARM BindPoint;

        /// <summary>
        ///     <c>ObjectIndex</c> is the index of the object whose memory requirements are being queried.
        /// </summary>
        [FieldOffset(28)]
        public int ObjectIndex;
    }
}
