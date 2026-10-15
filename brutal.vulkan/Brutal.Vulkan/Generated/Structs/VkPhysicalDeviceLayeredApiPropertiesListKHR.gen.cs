namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceLayeredApiPropertiesListKHR.html">VkPhysicalDeviceLayeredApiPropertiesListKHR</see> - Structure describing layered implementations underneath the Vulkan physical device
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceLayeredApiPropertiesListKHR</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_maintenance7
    ///         typedef struct VkPhysicalDeviceLayeredApiPropertiesListKHR {
    ///             VkStructureType                             sType;
    ///             void*                                       pNext;
    ///             uint32_t                                    layeredApiCount;
    ///             VkPhysicalDeviceLayeredApiPropertiesKHR*    pLayeredApis;
    ///         } VkPhysicalDeviceLayeredApiPropertiesListKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkPhysicalDeviceLayeredApiPropertiesListKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceLayeredApiPropertiesListKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>LayeredApiCount</c> is an integer related to the number of layered implementations underneath the Vulkan physical device, as described below.
        /// </summary>
        [FieldOffset(16)]
        public int LayeredApiCount;

        /// <summary>
        ///     <c>LayeredApis</c> is a pointer to an array of <c>VkPhysicalDeviceLayeredApiPropertiesKHR</c> in which information regarding the layered implementations underneath the Vulkan physical device are returned.
        /// </summary>
        [FieldOffset(24)]
        public VkPhysicalDeviceLayeredApiPropertiesKHR* LayeredApis;
    }
}
