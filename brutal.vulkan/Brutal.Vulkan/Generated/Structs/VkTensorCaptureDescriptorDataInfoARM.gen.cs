namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkTensorCaptureDescriptorDataInfoARM.html">VkTensorCaptureDescriptorDataInfoARM</see> - Structure specifying a tensor for descriptor capture
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Information about the tensor to get descriptor buffer capture data for is
    ///         passed in a <c>VkTensorCaptureDescriptorDataInfoARM</c> structure:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_descriptor_buffer with VK_ARM_tensors
    ///         typedef struct VkTensorCaptureDescriptorDataInfoARM {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             VkTensorARM        tensor;
    ///         } VkTensorCaptureDescriptorDataInfoARM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkTensorCaptureDescriptorDataInfoARM()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.TensorCaptureDescriptorDataInfoARM;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Tensor</c> is the <c>VkTensorARM</c> handle of the tensor to get opaque capture data for.
        /// </summary>
        [FieldOffset(16)]
        public VkTensorARM Tensor;
    }
}
