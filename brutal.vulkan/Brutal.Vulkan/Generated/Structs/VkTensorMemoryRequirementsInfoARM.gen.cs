namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkTensorMemoryRequirementsInfoARM.html">VkTensorMemoryRequirementsInfoARM</see> - Structure specifying memory requirements
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkTensorMemoryRequirementsInfoARM</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ARM_tensors
    ///         typedef struct VkTensorMemoryRequirementsInfoARM {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             VkTensorARM        tensor;
    ///         } VkTensorMemoryRequirementsInfoARM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkTensorMemoryRequirementsInfoARM()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.TensorMemoryRequirementsInfoARM;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Tensor</c> is the tensor to query.
        /// </summary>
        [FieldOffset(16)]
        public VkTensorARM Tensor;
    }
}
