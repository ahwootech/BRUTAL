namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDescriptorGetTensorInfoARM.html">VkDescriptorGetTensorInfoARM</see> - Structure specifying parameters to get descriptor data for tensor views
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkDescriptorGetTensorInfoARM</c> is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_descriptor_buffer with VK_ARM_tensors
    ///         typedef struct VkDescriptorGetTensorInfoARM {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             VkTensorViewARM    tensorView;
    ///         } VkDescriptorGetTensorInfoARM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkDescriptorGetTensorInfoARM()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.DescriptorGetTensorInfoARM;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>TensorView</c> is a <c>VkTensorViewARM</c> handle specifying the parameters of a <c>VK_DESCRIPTOR_TYPE_TENSOR_ARM</c> descriptor.
        /// </summary>
        [FieldOffset(16)]
        public VkTensorViewARM TensorView;
    }
}
