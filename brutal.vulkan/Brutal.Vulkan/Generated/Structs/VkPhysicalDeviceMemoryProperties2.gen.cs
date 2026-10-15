namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceMemoryProperties2.html">VkPhysicalDeviceMemoryProperties2</see> - Structure specifying physical device memory properties
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceMemoryProperties2</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_1
    ///         typedef struct VkPhysicalDeviceMemoryProperties2 {
    ///             VkStructureType                     sType;
    ///             void*                               pNext;
    ///             VkPhysicalDeviceMemoryProperties    memoryProperties;
    ///         } VkPhysicalDeviceMemoryProperties2;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 536)]
    public unsafe partial struct VkPhysicalDeviceMemoryProperties2()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceMemoryProperties2;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>MemoryProperties</c> is a <c>VkPhysicalDeviceMemoryProperties</c> structure which is populated with the same values as in <c>vkGetPhysicalDeviceMemoryProperties</c>.
        /// </summary>
        [FieldOffset(16)]
        public VkPhysicalDeviceMemoryProperties MemoryProperties;
    }
}
