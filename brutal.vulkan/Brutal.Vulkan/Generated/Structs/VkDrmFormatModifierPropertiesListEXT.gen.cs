namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDrmFormatModifierPropertiesListEXT.html">VkDrmFormatModifierPropertiesListEXT</see> - Structure specifying the list of DRM format modifiers supported for a format
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         To obtain the list of <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#glossary-drm-format-modifier">Linux DRM format
    ///         modifiers^</see> compatible with a <c>VkFormat</c>, add a
    ///         <c>VkDrmFormatModifierPropertiesListEXT</c> structure to the <c>pNext</c>
    ///         chain of <c>VkFormatProperties2</c>.
    ///     </para>
    ///     <para>
    ///         The <c>VkDrmFormatModifierPropertiesListEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_image_drm_format_modifier
    ///         typedef struct VkDrmFormatModifierPropertiesListEXT {
    ///             VkStructureType                      sType;
    ///             void*                                pNext;
    ///             uint32_t                             drmFormatModifierCount;
    ///             VkDrmFormatModifierPropertiesEXT*    pDrmFormatModifierProperties;
    ///         } VkDrmFormatModifierPropertiesListEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkDrmFormatModifierPropertiesListEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.DrmFormatModifierPropertiesListEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>DrmFormatModifierCount</c> is an inout parameter related to the number of modifiers compatible with the <c>format</c>, as described below.
        /// </summary>
        [FieldOffset(16)]
        public int DrmFormatModifierCount;

        /// <summary>
        ///     <c>DrmFormatModifierProperties</c> is either `NULL` or a pointer to an array of <c>VkDrmFormatModifierPropertiesEXT</c> structures.
        /// </summary>
        [FieldOffset(24)]
        public VkDrmFormatModifierPropertiesEXT* DrmFormatModifierProperties;
    }
}
