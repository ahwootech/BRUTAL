namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDataGraphPipelineSessionBindPointRequirementARM.html">VkDataGraphPipelineSessionBindPointRequirementARM</see> - Structure specifying the requirements of a bind point of a data graph pipeline session
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkDataGraphPipelineSessionBindPointRequirementARM
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ARM_data_graph
    ///         typedef struct VkDataGraphPipelineSessionBindPointRequirementARM {
    ///             VkStructureType                               sType;
    ///             void*                                         pNext;
    ///             VkDataGraphPipelineSessionBindPointARM        bindPoint;
    ///             VkDataGraphPipelineSessionBindPointTypeARM    bindPointType;
    ///             uint32_t                                      numObjects;
    ///         } VkDataGraphPipelineSessionBindPointRequirementARM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkDataGraphPipelineSessionBindPointRequirementARM()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.DataGraphPipelineSessionBindPointRequirementARM;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>BindPoint</c> is a <c>VkDataGraphPipelineSessionBindPointARM</c> specifying the data graph pipeline session bind point being required.
        /// </summary>
        [FieldOffset(16)]
        public VkDataGraphPipelineSessionBindPointARM BindPoint;

        /// <summary>
        ///     <c>BindPointType</c> is a <c>VkDataGraphPipelineSessionBindPointTypeARM</c> specifying the type of object required for <c>bindPoint</c>.
        /// </summary>
        [FieldOffset(20)]
        public VkDataGraphPipelineSessionBindPointTypeARM BindPointType;

        /// <summary>
        ///     <c>NumObjects</c> is the number of objects required for <c>bindPoint</c>.
        /// </summary>
        [FieldOffset(24)]
        public int NumObjects;
    }
}
