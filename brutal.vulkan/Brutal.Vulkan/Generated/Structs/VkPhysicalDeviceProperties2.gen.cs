namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceProperties2.html">VkPhysicalDeviceProperties2</see> - Structure specifying physical device properties
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceProperties2</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_1
    ///         typedef struct VkPhysicalDeviceProperties2 {
    ///             VkStructureType               sType;
    ///             void*                         pNext;
    ///             VkPhysicalDeviceProperties    properties;
    ///         } VkPhysicalDeviceProperties2;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 840)]
    public unsafe partial struct VkPhysicalDeviceProperties2()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceProperties2;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Properties</c> is a <c>VkPhysicalDeviceProperties</c> structure describing properties of the physical device. This structure is written with the same values as if it were written by <c>vkGetPhysicalDeviceProperties</c>.
        /// </summary>
        [FieldOffset(16)]
        public VkPhysicalDeviceProperties Properties;
    }
}
