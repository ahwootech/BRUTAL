namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkImageDrmFormatModifierExplicitCreateInfoEXT.html">VkImageDrmFormatModifierExplicitCreateInfoEXT</see> - Specify that an image be created with the provided DRM format modifier and explicit memory layout
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         If the <c>pNext</c> chain of <c>VkImageCreateInfo</c> includes a
    ///         <c>VkImageDrmFormatModifierExplicitCreateInfoEXT</c> structure, then the
    ///         image will be created with the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#glossary-drm-format-modifier">Linux DRM
    ///         format modifier^</see> and memory layout defined by the structure.
    ///     </para>
    ///     <para>
    ///         The <c>VkImageDrmFormatModifierExplicitCreateInfoEXT</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_image_drm_format_modifier
    ///         typedef struct VkImageDrmFormatModifierExplicitCreateInfoEXT {
    ///             VkStructureType               sType;
    ///             const void*                   pNext;
    ///             uint64_t                      drmFormatModifier;
    ///             uint32_t                      drmFormatModifierPlaneCount;
    ///             const VkSubresourceLayout*    pPlaneLayouts;
    ///         } VkImageDrmFormatModifierExplicitCreateInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct VkImageDrmFormatModifierExplicitCreateInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.ImageDrmFormatModifierExplicitCreateInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>DrmFormatModifier</c> is the <i>Linux DRM format modifier</i> with which the image will be created.
        /// </summary>
        [FieldOffset(16)]
        public nint DrmFormatModifier;

        /// <summary>
        ///     <c>DrmFormatModifierPlaneCount</c> is the number of <i>memory planes</i> in the image (as reported by <c>VkDrmFormatModifierPropertiesEXT</c>) as well as the length of the <c>pPlaneLayouts</c> array.
        /// </summary>
        [FieldOffset(24)]
        public int DrmFormatModifierPlaneCount;

        /// <summary>
        ///     <c>PlaneLayouts</c> is a pointer to an array of <c>VkSubresourceLayout</c> structures describing the image&apos;s <i>memory planes</i>.
        /// </summary>
        [FieldOffset(32)]
        public VkSubresourceLayout* PlaneLayouts;
    }
}
