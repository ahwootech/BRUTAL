namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceImageDrmFormatModifierInfoEXT.html">VkPhysicalDeviceImageDrmFormatModifierInfoEXT</see> - Structure specifying a DRM format modifier as image creation parameter
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         To query the image capabilities that are compatible with a
    ///         <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#glossary-drm-format-modifier">Linux DRM format modifier^</see>, set
    ///         <c>VkPhysicalDeviceImageFormatInfo2::tiling</c> to
    ///         <c>VK_IMAGE_TILING_DRM_FORMAT_MODIFIER_EXT</c> and add a
    ///         <c>VkPhysicalDeviceImageDrmFormatModifierInfoEXT</c> structure to the
    ///         <c>pNext</c> chain of <c>VkPhysicalDeviceImageFormatInfo2</c>.
    ///     </para>
    ///     <para>
    ///         The <c>VkPhysicalDeviceImageDrmFormatModifierInfoEXT</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_image_drm_format_modifier
    ///         typedef struct VkPhysicalDeviceImageDrmFormatModifierInfoEXT {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             uint64_t           drmFormatModifier;
    ///             VkSharingMode      sharingMode;
    ///             uint32_t           queueFamilyIndexCount;
    ///             const uint32_t*    pQueueFamilyIndices;
    ///         } VkPhysicalDeviceImageDrmFormatModifierInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct VkPhysicalDeviceImageDrmFormatModifierInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceImageDrmFormatModifierInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>DrmFormatModifier</c> is the image&apos;s <i>Linux DRM format modifier</i>, corresponding to <c>VkImageDrmFormatModifierExplicitCreateInfoEXT::drmFormatModifier</c> or to <c>VkImageDrmFormatModifierListCreateInfoEXT::pDrmFormatModifiers</c>.
        /// </summary>
        [FieldOffset(16)]
        public nint DrmFormatModifier;

        /// <summary>
        ///     <c>SharingMode</c> specifies how the image will be accessed by multiple queue families.
        /// </summary>
        [FieldOffset(24)]
        public VkSharingMode SharingMode;

        /// <summary>
        ///     <c>QueueFamilyIndexCount</c> is the number of entries in the <c>pQueueFamilyIndices</c> array.
        /// </summary>
        [FieldOffset(28)]
        public int QueueFamilyIndexCount;

        /// <summary>
        ///     <c>QueueFamilyIndices</c> is a pointer to an array of queue families that will access the image. It is ignored if <c>sharingMode</c> is not <c>VK_SHARING_MODE_CONCURRENT</c>.
        /// </summary>
        [FieldOffset(32)]
        public int* QueueFamilyIndices;
    }
}
