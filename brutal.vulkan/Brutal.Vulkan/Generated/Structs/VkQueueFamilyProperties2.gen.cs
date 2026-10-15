namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkQueueFamilyProperties2.html">VkQueueFamilyProperties2</see> - Structure providing information about a queue family
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkQueueFamilyProperties2</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_1
    ///         typedef struct VkQueueFamilyProperties2 {
    ///             VkStructureType            sType;
    ///             void*                      pNext;
    ///             VkQueueFamilyProperties    queueFamilyProperties;
    ///         } VkQueueFamilyProperties2;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct VkQueueFamilyProperties2()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.QueueFamilyProperties2;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>QueueFamilyProperties</c> is a <c>VkQueueFamilyProperties</c> structure which is populated with the same values as in <c>vkGetPhysicalDeviceQueueFamilyProperties</c>.
        /// </summary>
        [FieldOffset(16)]
        public VkQueueFamilyProperties QueueFamilyProperties;
    }
}
