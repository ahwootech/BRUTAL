namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceLayeredDriverPropertiesMSFT.html">VkPhysicalDeviceLayeredDriverPropertiesMSFT</see> - Structure containing information about driver layering for a physical device
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceLayeredDriverPropertiesMSFT</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_MSFT_layered_driver
    ///         typedef struct VkPhysicalDeviceLayeredDriverPropertiesMSFT {
    ///             VkStructureType                     sType;
    ///             void*                               pNext;
    ///             VkLayeredDriverUnderlyingApiMSFT    underlyingAPI;
    ///         } VkPhysicalDeviceLayeredDriverPropertiesMSFT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceLayeredDriverPropertiesMSFT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceLayeredDriverPropertiesMSFT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>UnderlyingAPI</c> is a <c>VkLayeredDriverUnderlyingApiMSFT</c> value indicating which underlying API is used to implement the layered driver, or <c>VK_LAYERED_DRIVER_UNDERLYING_API_NONE_MSFT</c> if the driver is not layered.
        /// </summary>
        [FieldOffset(16)]
        public VkLayeredDriverUnderlyingApiMSFT UnderlyingAPI;
    }
}
