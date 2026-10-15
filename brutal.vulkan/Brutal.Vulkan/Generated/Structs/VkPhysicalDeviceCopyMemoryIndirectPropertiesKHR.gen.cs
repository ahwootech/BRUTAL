namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceCopyMemoryIndirectPropertiesKHR.html">VkPhysicalDeviceCopyMemoryIndirectPropertiesKHR</see> - Structure describing supported queues for indirect copy
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceCopyMemoryIndirectPropertiesNV</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_copy_memory_indirect
    ///         typedef struct VkPhysicalDeviceCopyMemoryIndirectPropertiesKHR {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkQueueFlags       supportedQueues;
    ///         } VkPhysicalDeviceCopyMemoryIndirectPropertiesKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceCopyMemoryIndirectPropertiesKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceCopyMemoryIndirectPropertiesKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>SupportedQueues</c> is a bitmask of <c>VkQueueFlags</c> indicating the types of queues on which <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#indirect-copies">indirect copy commands^</see> are supported. If a queue family supports any of the bits set in <c>supportedQueues</c>, then it <i>must</i> support at least one <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#indirect-copies">indirect copy command^</see>.
        /// </summary>
        [FieldOffset(16)]
        public VkQueueFlags SupportedQueues;
    }
}
