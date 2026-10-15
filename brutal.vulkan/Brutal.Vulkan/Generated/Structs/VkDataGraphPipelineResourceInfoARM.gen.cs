namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDataGraphPipelineResourceInfoARM.html">VkDataGraphPipelineResourceInfoARM</see> - Structure specifying parameters of a data graph pipeline resource
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkDataGraphPipelineResourceInfoARM
    ///     </para>
    ///     <para>
    ///         The <c>VkDataGraphPipelineResourceInfoARM</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ARM_data_graph
    ///         typedef struct VkDataGraphPipelineResourceInfoARM {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             uint32_t           descriptorSet;
    ///             uint32_t           binding;
    ///             uint32_t           arrayElement;
    ///         } VkDataGraphPipelineResourceInfoARM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkDataGraphPipelineResourceInfoARM()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.DataGraphPipelineResourceInfoARM;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>DescriptorSet</c> is the descriptor set number of the resource being described.
        /// </summary>
        [FieldOffset(16)]
        public int DescriptorSet;

        /// <summary>
        ///     <c>Binding</c> is the binding number of the resource being described.
        /// </summary>
        [FieldOffset(20)]
        public int Binding;

        /// <summary>
        ///     <c>ArrayElement</c> is the element in the resource array if <c>descriptorSet</c> and <c>binding</c> identifies an array of resources or <c>0</c> otherwise.
        /// </summary>
        [FieldOffset(24)]
        public int ArrayElement;
    }
}
