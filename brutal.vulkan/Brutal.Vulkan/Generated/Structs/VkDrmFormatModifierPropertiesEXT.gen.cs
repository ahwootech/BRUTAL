namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDrmFormatModifierPropertiesEXT.html">VkDrmFormatModifierPropertiesEXT</see> - Structure specifying properties of a format when combined with a DRM format modifier
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkDrmFormatModifierPropertiesEXT</c> structure describes properties of
    ///         a <c>VkFormat</c> when that format is combined with a
    ///         <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#glossary-drm-format-modifier">Linux DRM format modifier^</see>.
    ///         These properties, like those of <c>VkFormatProperties2</c>, are independent
    ///         of any particular image.
    ///     </para>
    ///     <para>
    ///         The <c>VkDrmFormatModifierPropertiesEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_image_drm_format_modifier
    ///         typedef struct VkDrmFormatModifierPropertiesEXT {
    ///             uint64_t                drmFormatModifier;
    ///             uint32_t                drmFormatModifierPlaneCount;
    ///             VkFormatFeatureFlags    drmFormatModifierTilingFeatures;
    ///         } VkDrmFormatModifierPropertiesEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct VkDrmFormatModifierPropertiesEXT()
    {
        /// <summary>
        ///     <c>DrmFormatModifier</c> is a <i>Linux DRM format modifier</i>.
        /// </summary>
        [FieldOffset(0)]
        public nint DrmFormatModifier;

        /// <summary>
        ///     <c>DrmFormatModifierPlaneCount</c> is the number of <i>memory planes</i> in any image created with <c>format</c> and <c>drmFormatModifier</c>. An image&apos;s <i>memory planecount</i> is distinct from its <i>format planecount</i>, as explained below.
        /// </summary>
        [FieldOffset(8)]
        public int DrmFormatModifierPlaneCount;

        /// <summary>
        ///     <c>DrmFormatModifierTilingFeatures</c> is a bitmask of <c>VkFormatFeatureFlags</c> that are supported by any image created with <c>format</c> and <c>drmFormatModifier</c>.
        /// </summary>
        [FieldOffset(12)]
        public VkFormatFeatureFlags DrmFormatModifierTilingFeatures;
    }
}
