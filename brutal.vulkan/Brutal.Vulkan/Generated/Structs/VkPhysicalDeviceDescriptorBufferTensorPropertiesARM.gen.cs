namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceDescriptorBufferTensorPropertiesARM.html">VkPhysicalDeviceDescriptorBufferTensorPropertiesARM</see> - Structure describing descriptor buffer tensor properties supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceDescriptorBufferTensorPropertiesARM</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_descriptor_buffer with VK_ARM_tensors
    ///         typedef struct VkPhysicalDeviceDescriptorBufferTensorPropertiesARM {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             size_t             tensorCaptureReplayDescriptorDataSize;
    ///             size_t             tensorViewCaptureReplayDescriptorDataSize;
    ///             size_t             tensorDescriptorSize;
    ///         } VkPhysicalDeviceDescriptorBufferTensorPropertiesARM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct VkPhysicalDeviceDescriptorBufferTensorPropertiesARM()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceDescriptorBufferTensorPropertiesARM;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>TensorCaptureReplayDescriptorDataSize</c> indicates the maximum size in bytes of the opaque data used for capture and replay with tensors.
        /// </summary>
        [FieldOffset(16)]
        public nuint TensorCaptureReplayDescriptorDataSize;

        /// <summary>
        ///     <c>TensorViewCaptureReplayDescriptorDataSize</c> indicates the maximum size in bytes of the opaque data used for capture and replay with tensor views.
        /// </summary>
        [FieldOffset(24)]
        public nuint TensorViewCaptureReplayDescriptorDataSize;

        /// <summary>
        ///     <c>TensorDescriptorSize</c> indicates the size in bytes of a <c>VK_DESCRIPTOR_TYPE_TENSOR_ARM</c> descriptor.
        /// </summary>
        [FieldOffset(32)]
        public nuint TensorDescriptorSize;
    }
}
