namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceTimelineSemaphoreFeatures.html">VkPhysicalDeviceTimelineSemaphoreFeatures</see> - Structure describing timeline semaphore features that can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceTimelineSemaphoreFeatures</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_2
    ///         typedef struct VkPhysicalDeviceTimelineSemaphoreFeatures {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           timelineSemaphore;
    ///         } VkPhysicalDeviceTimelineSemaphoreFeatures;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceTimelineSemaphoreFeatures()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceTimelineSemaphoreFeatures;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>TimelineSemaphore</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 TimelineSemaphore;
    }
}
