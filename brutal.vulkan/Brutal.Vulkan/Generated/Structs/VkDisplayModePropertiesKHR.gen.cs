namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDisplayModePropertiesKHR.html">VkDisplayModePropertiesKHR</see> - Structure describing display mode properties
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkDisplayModePropertiesKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_display
    ///         typedef struct VkDisplayModePropertiesKHR {
    ///             VkDisplayModeKHR              displayMode;
    ///             VkDisplayModeParametersKHR    parameters;
    ///         } VkDisplayModePropertiesKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct VkDisplayModePropertiesKHR()
    {
        /// <summary>
        ///     <c>DisplayMode</c> is a handle to the display mode described in this structure. This handle will be valid for the lifetime of the Vulkan instance.
        /// </summary>
        [FieldOffset(0)]
        public VkDisplayModeKHR DisplayMode;

        /// <summary>
        ///     <c>Parameters</c> is a <c>VkDisplayModeParametersKHR</c> structure describing the display parameters associated with <c>displayMode</c>.
        /// </summary>
        [FieldOffset(8)]
        public VkDisplayModeParametersKHR Parameters;
    }
}
