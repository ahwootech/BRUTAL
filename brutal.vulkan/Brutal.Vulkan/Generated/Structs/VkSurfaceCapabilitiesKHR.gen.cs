namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSurfaceCapabilitiesKHR.html">VkSurfaceCapabilitiesKHR</see> - Structure describing capabilities of a surface
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkSurfaceCapabilitiesKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_surface
    ///         typedef struct VkSurfaceCapabilitiesKHR {
    ///             uint32_t                         minImageCount;
    ///             uint32_t                         maxImageCount;
    ///             VkExtent2D                       currentExtent;
    ///             VkExtent2D                       minImageExtent;
    ///             VkExtent2D                       maxImageExtent;
    ///             uint32_t                         maxImageArrayLayers;
    ///             VkSurfaceTransformFlagsKHR       supportedTransforms;
    ///             VkSurfaceTransformFlagBitsKHR    currentTransform;
    ///             VkCompositeAlphaFlagsKHR         supportedCompositeAlpha;
    ///             VkImageUsageFlags                supportedUsageFlags;
    ///         } VkSurfaceCapabilitiesKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 52)]
    public partial struct VkSurfaceCapabilitiesKHR()
    {
        /// <summary>
        ///     <c>MinImageCount</c>
        /// </summary>
        [FieldOffset(0)]
        public int MinImageCount;

        /// <summary>
        ///     <c>MaxImageCount</c>
        /// </summary>
        [FieldOffset(4)]
        public int MaxImageCount;

        /// <summary>
        ///     <c>CurrentExtent</c>
        /// </summary>
        [FieldOffset(8)]
        public VkExtent2D CurrentExtent;

        /// <summary>
        ///     <c>MinImageExtent</c>
        /// </summary>
        [FieldOffset(16)]
        public VkExtent2D MinImageExtent;

        /// <summary>
        ///     <c>MaxImageExtent</c>
        /// </summary>
        [FieldOffset(24)]
        public VkExtent2D MaxImageExtent;

        /// <summary>
        ///     <c>MaxImageArrayLayers</c>
        /// </summary>
        [FieldOffset(32)]
        public int MaxImageArrayLayers;

        /// <summary>
        ///     <c>SupportedTransforms</c>
        /// </summary>
        [FieldOffset(36)]
        public VkSurfaceTransformFlagsKHR SupportedTransforms;

        /// <summary>
        ///     <c>CurrentTransform</c>
        /// </summary>
        [FieldOffset(40)]
        public VkSurfaceTransformFlagsKHR CurrentTransform;

        /// <summary>
        ///     <c>SupportedCompositeAlpha</c>
        /// </summary>
        [FieldOffset(44)]
        public VkCompositeAlphaFlagsKHR SupportedCompositeAlpha;

        /// <summary>
        ///     <c>SupportedUsageFlags</c>
        /// </summary>
        [FieldOffset(48)]
        public VkImageUsageFlags SupportedUsageFlags;
    }
}
