namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceDescriptorHeapTensorPropertiesARM.html">VkPhysicalDeviceDescriptorHeapTensorPropertiesARM</see> - Structure describing descriptor heap tensor properties supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceDescriptorHeapTensorPropertiesARM</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_descriptor_heap with VK_ARM_tensors
    ///         typedef struct VkPhysicalDeviceDescriptorHeapTensorPropertiesARM {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkDeviceSize       tensorDescriptorSize;
    ///             VkDeviceSize       tensorDescriptorAlignment;
    ///             size_t             tensorCaptureReplayOpaqueDataSize;
    ///         } VkPhysicalDeviceDescriptorHeapTensorPropertiesARM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct VkPhysicalDeviceDescriptorHeapTensorPropertiesARM()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceDescriptorHeapTensorPropertiesARM;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>TensorDescriptorSize</c>
        /// </summary>
        [FieldOffset(16)]
        public ByteSize64 TensorDescriptorSize;

        /// <summary>
        ///     <c>TensorDescriptorAlignment</c>
        /// </summary>
        [FieldOffset(24)]
        public ByteSize64 TensorDescriptorAlignment;

        /// <summary>
        ///     <c>TensorCaptureReplayOpaqueDataSize</c>
        /// </summary>
        [FieldOffset(32)]
        public nuint TensorCaptureReplayOpaqueDataSize;
    }
}
