namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSurfaceCapabilities2EXT.html">VkSurfaceCapabilities2EXT</see> - Structure describing capabilities of a surface
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkSurfaceCapabilities2EXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_display_surface_counter
    ///         typedef struct VkSurfaceCapabilities2EXT {
    ///             VkStructureType                  sType;
    ///             void*                            pNext;
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
    ///             VkSurfaceCounterFlagsEXT         supportedSurfaceCounters;
    ///         } VkSurfaceCapabilities2EXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 72)]
    public unsafe partial struct VkSurfaceCapabilities2EXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.SurfaceCapabilities2EXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure. include::{chapters}/VK_KHR_surface/wsi.adoc[tag=surface_capabilities_members]
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>MinImageCount</c>
        /// </summary>
        [FieldOffset(16)]
        public int MinImageCount;

        /// <summary>
        ///     <c>MaxImageCount</c>
        /// </summary>
        [FieldOffset(20)]
        public int MaxImageCount;

        /// <summary>
        ///     <c>CurrentExtent</c>
        /// </summary>
        [FieldOffset(24)]
        public VkExtent2D CurrentExtent;

        /// <summary>
        ///     <c>MinImageExtent</c>
        /// </summary>
        [FieldOffset(32)]
        public VkExtent2D MinImageExtent;

        /// <summary>
        ///     <c>MaxImageExtent</c>
        /// </summary>
        [FieldOffset(40)]
        public VkExtent2D MaxImageExtent;

        /// <summary>
        ///     <c>MaxImageArrayLayers</c>
        /// </summary>
        [FieldOffset(48)]
        public int MaxImageArrayLayers;

        /// <summary>
        ///     <c>SupportedTransforms</c>
        /// </summary>
        [FieldOffset(52)]
        public VkSurfaceTransformFlagsKHR SupportedTransforms;

        /// <summary>
        ///     <c>CurrentTransform</c>
        /// </summary>
        [FieldOffset(56)]
        public VkSurfaceTransformFlagsKHR CurrentTransform;

        /// <summary>
        ///     <c>SupportedCompositeAlpha</c>
        /// </summary>
        [FieldOffset(60)]
        public VkCompositeAlphaFlagsKHR SupportedCompositeAlpha;

        /// <summary>
        ///     <c>SupportedUsageFlags</c>
        /// </summary>
        [FieldOffset(64)]
        public VkImageUsageFlags SupportedUsageFlags;

        /// <summary>
        ///     <c>SupportedSurfaceCounters</c> is a bitmask of <c>VkSurfaceCounterFlagsEXT</c> indicating the supported surface counter types. It <i>must</i> not include <c>VK_SURFACE_COUNTER_VBLANK_BIT_EXT</c> unless the surface queried is a <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#wsi-display-surfaces">display surface^</see>
        /// </summary>
        [FieldOffset(68)]
        public VkSurfaceCounterFlagsEXT SupportedSurfaceCounters;
    }
}
