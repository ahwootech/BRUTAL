namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceDescriptorBufferTensorFeaturesARM.html">VkPhysicalDeviceDescriptorBufferTensorFeaturesARM</see> - Structure describing the descriptor buffer tensor features that can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceDescriptorBufferTensorFeaturesARM</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_descriptor_buffer with VK_ARM_tensors
    ///         typedef struct VkPhysicalDeviceDescriptorBufferTensorFeaturesARM {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           descriptorBufferTensorDescriptors;
    ///         } VkPhysicalDeviceDescriptorBufferTensorFeaturesARM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceDescriptorBufferTensorFeaturesARM()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceDescriptorBufferTensorFeaturesARM;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>DescriptorBufferTensorDescriptors</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 DescriptorBufferTensorDescriptors;
    }
}
