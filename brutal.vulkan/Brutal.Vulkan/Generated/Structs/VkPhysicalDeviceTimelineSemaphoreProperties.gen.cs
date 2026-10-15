namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceTimelineSemaphoreProperties.html">VkPhysicalDeviceTimelineSemaphoreProperties</see> - Structure describing timeline semaphore properties that can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceTimelineSemaphoreProperties</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_2
    ///         typedef struct VkPhysicalDeviceTimelineSemaphoreProperties {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             uint64_t           maxTimelineSemaphoreValueDifference;
    ///         } VkPhysicalDeviceTimelineSemaphoreProperties;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceTimelineSemaphoreProperties()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceTimelineSemaphoreProperties;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>MaxTimelineSemaphoreValueDifference</c>
        /// </summary>
        [FieldOffset(16)]
        public nint MaxTimelineSemaphoreValueDifference;
    }
}
