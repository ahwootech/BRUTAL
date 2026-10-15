namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkTensorViewCaptureDescriptorDataInfoARM.html">VkTensorViewCaptureDescriptorDataInfoARM</see> - Structure specifying a tensor view for descriptor capture
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Information about the tensor view to get descriptor buffer capture data for
    ///         is passed in a <c>VkTensorViewCaptureDescriptorDataInfoARM</c> structure:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_descriptor_buffer with VK_ARM_tensors
    ///         typedef struct VkTensorViewCaptureDescriptorDataInfoARM {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             VkTensorViewARM    tensorView;
    ///         } VkTensorViewCaptureDescriptorDataInfoARM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkTensorViewCaptureDescriptorDataInfoARM()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.TensorViewCaptureDescriptorDataInfoARM;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>TensorView</c> is the <c>VkTensorViewARM</c> handle of the tensor view to get opaque capture data for.
        /// </summary>
        [FieldOffset(16)]
        public VkTensorViewARM TensorView;
    }
}
