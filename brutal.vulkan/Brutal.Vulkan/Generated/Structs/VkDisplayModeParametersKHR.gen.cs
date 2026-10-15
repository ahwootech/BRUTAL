namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDisplayModeParametersKHR.html">VkDisplayModeParametersKHR</see> - Structure describing display parameters associated with a display mode
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkDisplayModeParametersKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_display
    ///         typedef struct VkDisplayModeParametersKHR {
    ///             VkExtent2D    visibleRegion;
    ///             uint32_t      refreshRate;
    ///         } VkDisplayModeParametersKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial struct VkDisplayModeParametersKHR()
    {
        /// <summary>
        ///     <c>VisibleRegion</c> is the 2D extents of the visible region.
        /// </summary>
        [FieldOffset(0)]
        public VkExtent2D VisibleRegion;

        /// <summary>
        ///     <c>RefreshRate</c> is a <c>uint32_t</c> that is the number of times the display is refreshed each second multiplied by 1000.
        /// </summary>
        [FieldOffset(8)]
        public int RefreshRate;
    }
}
