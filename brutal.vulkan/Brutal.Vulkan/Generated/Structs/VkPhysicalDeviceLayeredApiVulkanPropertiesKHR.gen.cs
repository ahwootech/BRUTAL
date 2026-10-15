namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceLayeredApiVulkanPropertiesKHR.html">VkPhysicalDeviceLayeredApiVulkanPropertiesKHR</see> - Structure describing physical device properties of a layered Vulkan implementation underneath the Vulkan physical device
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceLayeredApiVulkanPropertiesKHR</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_maintenance7
    ///         typedef struct VkPhysicalDeviceLayeredApiVulkanPropertiesKHR {
    ///             VkStructureType                sType;
    ///             void*                          pNext;
    ///             VkPhysicalDeviceProperties2    properties;
    ///         } VkPhysicalDeviceLayeredApiVulkanPropertiesKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 856)]
    public unsafe partial struct VkPhysicalDeviceLayeredApiVulkanPropertiesKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceLayeredApiVulkanPropertiesKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Properties</c> is a <c>VkPhysicalDeviceProperties2</c> in which properties of the underlying layered Vulkan implementation are returned.
        /// </summary>
        [FieldOffset(16)]
        public VkPhysicalDeviceProperties2 Properties;
    }
}
