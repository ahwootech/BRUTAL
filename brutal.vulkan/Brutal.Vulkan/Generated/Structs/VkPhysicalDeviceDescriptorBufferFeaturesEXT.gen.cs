namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceDescriptorBufferFeaturesEXT.html">VkPhysicalDeviceDescriptorBufferFeaturesEXT</see> - Structure describing the descriptor buffer features that can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceDescriptorBufferFeaturesEXT</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_descriptor_buffer
    ///         typedef struct VkPhysicalDeviceDescriptorBufferFeaturesEXT {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           descriptorBuffer;
    ///             VkBool32           descriptorBufferCaptureReplay;
    ///             VkBool32           descriptorBufferImageLayoutIgnored;
    ///             VkBool32           descriptorBufferPushDescriptors;
    ///         } VkPhysicalDeviceDescriptorBufferFeaturesEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkPhysicalDeviceDescriptorBufferFeaturesEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceDescriptorBufferFeaturesEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>DescriptorBuffer</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 DescriptorBuffer;

        /// <summary>
        ///     <c>DescriptorBufferCaptureReplay</c>
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 DescriptorBufferCaptureReplay;

        /// <summary>
        ///     <c>DescriptorBufferImageLayoutIgnored</c>
        /// </summary>
        [FieldOffset(24)]
        public Brutal.Bool32 DescriptorBufferImageLayoutIgnored;

        /// <summary>
        ///     <c>DescriptorBufferPushDescriptors</c>
        /// </summary>
        [FieldOffset(28)]
        public Brutal.Bool32 DescriptorBufferPushDescriptors;
    }
}
