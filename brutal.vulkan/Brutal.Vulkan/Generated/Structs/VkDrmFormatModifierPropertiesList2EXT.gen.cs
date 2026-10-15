namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDrmFormatModifierPropertiesList2EXT.html">VkDrmFormatModifierPropertiesList2EXT</see> - Structure specifying the list of DRM format modifiers supported for a format
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The list of <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#glossary-drm-format-modifier">Linux DRM format modifiers^</see>
    ///         compatible with a <c>VkFormat</c> <i>can</i> be obtained by adding a
    ///         <c>VkDrmFormatModifierPropertiesList2EXT</c> structure to the <c>pNext</c>
    ///         chain of <c>VkFormatProperties2</c>.
    ///     </para>
    ///     <para>
    ///         The <c>VkDrmFormatModifierPropertiesList2EXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_image_drm_format_modifier with VK_KHR_format_feature_flags2 or VK_VERSION_1_3
    ///         typedef struct VkDrmFormatModifierPropertiesList2EXT {
    ///             VkStructureType                       sType;
    ///             void*                                 pNext;
    ///             uint32_t                              drmFormatModifierCount;
    ///             VkDrmFormatModifierProperties2EXT*    pDrmFormatModifierProperties;
    ///         } VkDrmFormatModifierPropertiesList2EXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkDrmFormatModifierPropertiesList2EXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.DrmFormatModifierPropertiesList2EXT;

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
        ///     <c>DrmFormatModifierProperties</c> is either `NULL` or a pointer to an array of <c>VkDrmFormatModifierProperties2EXT</c> structures.
        /// </summary>
        [FieldOffset(24)]
        public VkDrmFormatModifierProperties2EXT* DrmFormatModifierProperties;
    }
}
