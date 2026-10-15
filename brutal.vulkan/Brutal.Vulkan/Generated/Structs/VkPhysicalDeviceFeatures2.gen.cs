namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceFeatures2.html">VkPhysicalDeviceFeatures2</see> - Structure describing the fine-grained features that can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceFeatures2</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_1
    ///         typedef struct VkPhysicalDeviceFeatures2 {
    ///             VkStructureType             sType;
    ///             void*                       pNext;
    ///             VkPhysicalDeviceFeatures    features;
    ///         } VkPhysicalDeviceFeatures2;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 240)]
    public unsafe partial struct VkPhysicalDeviceFeatures2()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceFeatures2;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Features</c> is a <c>VkPhysicalDeviceFeatures</c> structure describing the fine-grained features of the Vulkan 1.0 API.
        /// </summary>
        [FieldOffset(16)]
        public VkPhysicalDeviceFeatures Features;
    }
}
