namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkImageAspectFlagBits.html">VkImageAspectFlagBits</see> - Bitmask specifying which aspects of an image are included in a view
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which <i>can</i> be set in an aspect mask to specify aspects of an image for
    ///         purposes such as identifying a subresource, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef enum VkImageAspectFlagBits {
    ///             VK_IMAGE_ASPECT_COLOR_BIT = 0x00000001,
    ///             VK_IMAGE_ASPECT_DEPTH_BIT = 0x00000002,
    ///             VK_IMAGE_ASPECT_STENCIL_BIT = 0x00000004,
    ///             VK_IMAGE_ASPECT_METADATA_BIT = 0x00000008,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_IMAGE_ASPECT_PLANE_0_BIT = 0x00000010,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_IMAGE_ASPECT_PLANE_1_BIT = 0x00000020,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_IMAGE_ASPECT_PLANE_2_BIT = 0x00000040,
    ///             // Provided by VK_VERSION_1_3
    ///             VK_IMAGE_ASPECT_NONE = 0,
    ///             // Provided by VK_EXT_image_drm_format_modifier
    ///             VK_IMAGE_ASPECT_MEMORY_PLANE_0_BIT_EXT = 0x00000080,
    ///             // Provided by VK_EXT_image_drm_format_modifier
    ///             VK_IMAGE_ASPECT_MEMORY_PLANE_1_BIT_EXT = 0x00000100,
    ///             // Provided by VK_EXT_image_drm_format_modifier
    ///             VK_IMAGE_ASPECT_MEMORY_PLANE_2_BIT_EXT = 0x00000200,
    ///             // Provided by VK_EXT_image_drm_format_modifier
    ///             VK_IMAGE_ASPECT_MEMORY_PLANE_3_BIT_EXT = 0x00000400,
    ///             // Provided by VK_KHR_sampler_ycbcr_conversion
    ///             VK_IMAGE_ASPECT_PLANE_0_BIT_KHR = VK_IMAGE_ASPECT_PLANE_0_BIT,
    ///             // Provided by VK_KHR_sampler_ycbcr_conversion
    ///             VK_IMAGE_ASPECT_PLANE_1_BIT_KHR = VK_IMAGE_ASPECT_PLANE_1_BIT,
    ///             // Provided by VK_KHR_sampler_ycbcr_conversion
    ///             VK_IMAGE_ASPECT_PLANE_2_BIT_KHR = VK_IMAGE_ASPECT_PLANE_2_BIT,
    ///             // Provided by VK_KHR_maintenance4
    ///             VK_IMAGE_ASPECT_NONE_KHR = VK_IMAGE_ASPECT_NONE,
    ///         } VkImageAspectFlagBits;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkImageAspectFlags : int
    {
        /// <summary>
        ///     <c>ColorBit</c> specifies the color aspect.
        /// </summary>
        ColorBit = 0x00000001,

        /// <summary>
        ///     <c>DepthBit</c> specifies the depth aspect.
        /// </summary>
        DepthBit = 0x00000002,

        /// <summary>
        ///     <c>StencilBit</c> specifies the stencil aspect.
        /// </summary>
        StencilBit = 0x00000004,

        /// <summary>
        ///     <c>MetadataBit</c> specifies the metadata aspect used for <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#sparsememory">sparse resource^</see> operations.
        /// </summary>
        MetadataBit = 0x00000008,

        /// <summary>
        ///     <c>Plane0Bit</c>
        /// </summary>
        Plane0Bit = 0x00000010,

        /// <summary>
        ///     <c>Plane1Bit</c>
        /// </summary>
        Plane1Bit = 0x00000020,

        /// <summary>
        ///     <c>Plane2Bit</c>
        /// </summary>
        Plane2Bit = 0x00000040,

        /// <summary>
        ///     <c>None</c>
        /// </summary>
        None = 0,

        /// <summary>
        ///     <c>MemoryPlane0BitEXT</c>
        /// </summary>
        MemoryPlane0BitEXT = 0x00000080,

        /// <summary>
        ///     <c>MemoryPlane1BitEXT</c>
        /// </summary>
        MemoryPlane1BitEXT = 0x00000100,

        /// <summary>
        ///     <c>MemoryPlane2BitEXT</c>
        /// </summary>
        MemoryPlane2BitEXT = 0x00000200,

        /// <summary>
        ///     <c>MemoryPlane3BitEXT</c>
        /// </summary>
        MemoryPlane3BitEXT = 0x00000400,

        /// <summary>
        ///     <c>Plane0BitKHR</c>
        /// </summary>
        Plane0BitKHR = Plane0Bit,

        /// <summary>
        ///     <c>Plane1BitKHR</c>
        /// </summary>
        Plane1BitKHR = Plane1Bit,

        /// <summary>
        ///     <c>Plane2BitKHR</c>
        /// </summary>
        Plane2BitKHR = Plane2Bit,

        /// <summary>
        ///     <c>NoneKHR</c>
        /// </summary>
        NoneKHR = None,

        /// <summary>
        ///     <c>FlagBitsMaxEnum</c>
        /// </summary>
        FlagBitsMaxEnum = 0x7FFFFFFF,
    }
}
