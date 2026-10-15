namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkImageDrmFormatModifierPropertiesEXT.html">VkImageDrmFormatModifierPropertiesEXT</see> - Properties of an image&amp;apos;s Linux DRM format modifier
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkImageDrmFormatModifierPropertiesEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_image_drm_format_modifier
    ///         typedef struct VkImageDrmFormatModifierPropertiesEXT {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             uint64_t           drmFormatModifier;
    ///         } VkImageDrmFormatModifierPropertiesEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkImageDrmFormatModifierPropertiesEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.ImageDrmFormatModifierPropertiesEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>DrmFormatModifier</c> returns the image&apos;s <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#glossary-drm-format-modifier">Linux DRM format modifier^</see>.
        /// </summary>
        [FieldOffset(16)]
        public nint DrmFormatModifier;
    }
}
