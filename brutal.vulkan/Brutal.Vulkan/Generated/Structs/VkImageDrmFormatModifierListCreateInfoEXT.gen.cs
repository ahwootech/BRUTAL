namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkImageDrmFormatModifierListCreateInfoEXT.html">VkImageDrmFormatModifierListCreateInfoEXT</see> - Specify that an image must be created with a DRM format modifier from the provided list
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         If the <c>pNext</c> chain of <c>VkImageCreateInfo</c> includes a
    ///         <c>VkImageDrmFormatModifierListCreateInfoEXT</c> structure, then the image
    ///         will be created with one of the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#glossary-drm-format-modifier">Linux DRM
    ///         format modifiers^</see> listed in the structure.
    ///         The choice of modifier is implementation-dependent.
    ///     </para>
    ///     <para>
    ///         The <c>VkImageDrmFormatModifierListCreateInfoEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_image_drm_format_modifier
    ///         typedef struct VkImageDrmFormatModifierListCreateInfoEXT {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             uint32_t           drmFormatModifierCount;
    ///             const uint64_t*    pDrmFormatModifiers;
    ///         } VkImageDrmFormatModifierListCreateInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkImageDrmFormatModifierListCreateInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.ImageDrmFormatModifierListCreateInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>DrmFormatModifierCount</c> is the length of the <c>pDrmFormatModifiers</c> array.
        /// </summary>
        [FieldOffset(16)]
        public int DrmFormatModifierCount;

        /// <summary>
        ///     <c>DrmFormatModifiers</c> is a pointer to an array of <i>Linux DRM format modifiers</i>.
        /// </summary>
        [FieldOffset(24)]
        public nint* DrmFormatModifiers;
    }
}
