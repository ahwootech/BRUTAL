namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSamplerBorderColorComponentMappingCreateInfoEXT.html">VkSamplerBorderColorComponentMappingCreateInfoEXT</see> - Structure specifying the component mapping of the border color
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         If the sampler is created with <c>VK_BORDER_COLOR_FLOAT_OPAQUE_BLACK</c>,
    ///         <c>VK_BORDER_COLOR_INT_OPAQUE_BLACK</c>,
    ///         <c>VK_BORDER_COLOR_FLOAT_CUSTOM_EXT</c>, or
    ///         <c>VK_BORDER_COLOR_INT_CUSTOM_EXT</c> <c>borderColor</c>, and that sampler
    ///         will be combined with an image view that does not have an
    ///         <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#resources-image-views-identity-mappings">identity swizzle^</see>, and
    ///         <c>VkPhysicalDeviceBorderColorSwizzleFeaturesEXT::borderColorSwizzleFromImage</c>
    ///         is not enabled, then it is necessary to specify the component mapping of the
    ///         border color, by including the
    ///         <c>VkSamplerBorderColorComponentMappingCreateInfoEXT</c> structure in the
    ///         <c>VkSamplerCreateInfo::pNext</c> chain, to get defined results.
    ///     </para>
    ///     <para>
    ///         The <c>VkSamplerBorderColorComponentMappingCreateInfoEXT</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_border_color_swizzle
    ///         typedef struct VkSamplerBorderColorComponentMappingCreateInfoEXT {
    ///             VkStructureType       sType;
    ///             const void*           pNext;
    ///             VkComponentMapping    components;
    ///             VkBool32              srgb;
    ///         } VkSamplerBorderColorComponentMappingCreateInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct VkSamplerBorderColorComponentMappingCreateInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.SamplerBorderColorComponentMappingCreateInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Components</c> is a <c>VkComponentMapping</c> structure specifying a remapping of the border color components.
        /// </summary>
        [FieldOffset(16)]
        public VkComponentMapping Components;

        /// <summary>
        ///     <c>SRGB</c> indicates that the sampler will be combined with an image view that has an image format which is sRGB encoded.
        /// </summary>
        [FieldOffset(32)]
        public Brutal.Bool32 SRGB;
    }
}
