namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDataGraphPipelineConstantTensorSemiStructuredSparsityInfoARM.html">VkDataGraphPipelineConstantTensorSemiStructuredSparsityInfoARM</see> - Structure specifying semi-structured sparsity parameters of a tensor data graph pipeline constant
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkDataGraphPipelineConstantTensorSemiStructuredSparsityInfoARM
    ///     </para>
    ///     <para>
    ///         The <c>VkDataGraphPipelineConstantTensorSemiStructuredSparsityInfoARM</c>
    ///         structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ARM_data_graph with VK_ARM_tensors
    ///         typedef struct VkDataGraphPipelineConstantTensorSemiStructuredSparsityInfoARM {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             uint32_t           dimension;
    ///             uint32_t           zeroCount;
    ///             uint32_t           groupSize;
    ///         } VkDataGraphPipelineConstantTensorSemiStructuredSparsityInfoARM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkDataGraphPipelineConstantTensorSemiStructuredSparsityInfoARM()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType =
            VkStructureType.DataGraphPipelineConstantTensorSemiStructuredSparsityInfoARM;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Dimension</c> is the dimension of the tensor along which its data is sparse.
        /// </summary>
        [FieldOffset(16)]
        public int Dimension;

        /// <summary>
        ///     <c>ZeroCount</c> is the number of tensor elements that <i>must</i> be zero in every group of <c>groupSize</c> elements.
        /// </summary>
        [FieldOffset(20)]
        public int ZeroCount;

        /// <summary>
        ///     <c>GroupSize</c> is the number of tensor elements in a group.
        /// </summary>
        [FieldOffset(24)]
        public int GroupSize;
    }
}
