namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDataGraphPipelineSessionBindPointRequirementsInfoARM.html">VkDataGraphPipelineSessionBindPointRequirementsInfoARM</see> - Structure specifying info to query the bind point requirements of a data graph pipeline session
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkDataGraphPipelineSessionBindPointRequirementsInfoARM
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ARM_data_graph
    ///         typedef struct VkDataGraphPipelineSessionBindPointRequirementsInfoARM {
    ///             VkStructureType                  sType;
    ///             const void*                      pNext;
    ///             VkDataGraphPipelineSessionARM    session;
    ///         } VkDataGraphPipelineSessionBindPointRequirementsInfoARM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkDataGraphPipelineSessionBindPointRequirementsInfoARM()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.DataGraphPipelineSessionBindPointRequirementsInfoARM;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Session</c> is a <c>VkDataGraphPipelineSessionARM</c> specifying the data graph pipeline session whose bind point requirements are being queried.
        /// </summary>
        [FieldOffset(16)]
        public VkDataGraphPipelineSessionARM Session;
    }
}
