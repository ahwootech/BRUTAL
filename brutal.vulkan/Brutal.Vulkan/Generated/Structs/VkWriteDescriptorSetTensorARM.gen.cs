namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkWriteDescriptorSetTensorARM.html">VkWriteDescriptorSetTensorARM</see> - Structure specifying descriptor tensor info
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkWriteDescriptorSetTensorARM</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ARM_tensors
    ///         typedef struct VkWriteDescriptorSetTensorARM {
    ///             VkStructureType           sType;
    ///             const void*               pNext;
    ///             uint32_t                  tensorViewCount;
    ///             const VkTensorViewARM*    pTensorViews;
    ///         } VkWriteDescriptorSetTensorARM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkWriteDescriptorSetTensorARM()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.WriteDescriptorSetTensorARM;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>TensorViewCount</c> is the number of elements in <c>pTensorViews</c>.
        /// </summary>
        [FieldOffset(16)]
        public int TensorViewCount;

        /// <summary>
        ///     <c>TensorViews</c> are the tensor views that will be used to update the descriptor set.
        /// </summary>
        [FieldOffset(24)]
        public VkTensorViewARM* TensorViews;
    }
}
