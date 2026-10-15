namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDataGraphPipelineConstantARM.html">VkDataGraphPipelineConstantARM</see> - Structure specifying parameters of a data graph pipeline constant
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkDataGraphPipelineConstantARM
    ///     </para>
    ///     <para>
    ///         The <c>VkDataGraphPipelineConstantARM</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ARM_data_graph
    ///         typedef struct VkDataGraphPipelineConstantARM {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             uint32_t           id;
    ///             const void*        pConstantData;
    ///         } VkDataGraphPipelineConstantARM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkDataGraphPipelineConstantARM()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.DataGraphPipelineConstantARM;

        /// <summary>
        ///     <c>Next</c> is a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Id</c> is the unique identifier of the graph constant this structure describes.
        /// </summary>
        [FieldOffset(16)]
        public int Id;

        /// <summary>
        ///     <c>ConstantData</c> is a pointer to the data for this graph constant.
        /// </summary>
        [FieldOffset(24)]
        public void* ConstantData;
    }
}
