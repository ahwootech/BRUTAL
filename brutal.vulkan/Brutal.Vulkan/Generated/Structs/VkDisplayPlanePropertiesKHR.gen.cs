namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDisplayPlanePropertiesKHR.html">VkDisplayPlanePropertiesKHR</see> - Structure describing display plane properties
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkDisplayPlanePropertiesKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_display
    ///         typedef struct VkDisplayPlanePropertiesKHR {
    ///             VkDisplayKHR    currentDisplay;
    ///             uint32_t        currentStackIndex;
    ///         } VkDisplayPlanePropertiesKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct VkDisplayPlanePropertiesKHR()
    {
        /// <summary>
        ///     <c>CurrentDisplay</c> is the handle of the display the plane is currently associated with. If the plane is not currently attached to any displays, this will be <c>VK_NULL_HANDLE</c>.
        /// </summary>
        [FieldOffset(0)]
        public VkDisplayKHR CurrentDisplay;

        /// <summary>
        ///     <c>CurrentStackIndex</c> is the current z-order of the plane. This will be between 0 and the value returned by <c>vkGetPhysicalDeviceDisplayPlanePropertiesKHR</c> in <c>pPropertyCount</c>.
        /// </summary>
        [FieldOffset(8)]
        public int CurrentStackIndex;
    }
}
