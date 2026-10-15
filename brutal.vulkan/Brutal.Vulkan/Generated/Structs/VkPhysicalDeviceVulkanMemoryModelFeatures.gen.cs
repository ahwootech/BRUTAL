namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceVulkanMemoryModelFeatures.html">VkPhysicalDeviceVulkanMemoryModelFeatures</see> - Structure describing features supported by the memory model
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceVulkanMemoryModelFeatures</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_2
    ///         typedef struct VkPhysicalDeviceVulkanMemoryModelFeatures {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           vulkanMemoryModel;
    ///             VkBool32           vulkanMemoryModelDeviceScope;
    ///             VkBool32           vulkanMemoryModelAvailabilityVisibilityChains;
    ///         } VkPhysicalDeviceVulkanMemoryModelFeatures;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkPhysicalDeviceVulkanMemoryModelFeatures()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceVulkanMemoryModelFeatures;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>VulkanMemoryModel</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 VulkanMemoryModel;

        /// <summary>
        ///     <c>VulkanMemoryModelDeviceScope</c>
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 VulkanMemoryModelDeviceScope;

        /// <summary>
        ///     <c>VulkanMemoryModelAvailabilityVisibilityChains</c>
        /// </summary>
        [FieldOffset(24)]
        public Brutal.Bool32 VulkanMemoryModelAvailabilityVisibilityChains;
    }
}
