namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDevicePushDescriptorProperties.html">VkPhysicalDevicePushDescriptorProperties</see> - Structure describing push descriptor limits that can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDevicePushDescriptorProperties</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_4
    ///         typedef struct VkPhysicalDevicePushDescriptorProperties {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             uint32_t           maxPushDescriptors;
    ///         } VkPhysicalDevicePushDescriptorProperties;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDevicePushDescriptorProperties()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDevicePushDescriptorProperties;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>MaxPushDescriptors</c>
        /// </summary>
        [FieldOffset(16)]
        public int MaxPushDescriptors;
    }
}
