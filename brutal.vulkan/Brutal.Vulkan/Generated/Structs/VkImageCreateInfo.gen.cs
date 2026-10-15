namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkImageCreateInfo.html">VkImageCreateInfo</see> - Structure specifying the parameters of a newly created image object
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkImageCreateInfo</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef struct VkImageCreateInfo {
    ///             VkStructureType          sType;
    ///             const void*              pNext;
    ///             VkImageCreateFlags       flags;
    ///             VkImageType              imageType;
    ///             VkFormat                 format;
    ///             VkExtent3D               extent;
    ///             uint32_t                 mipLevels;
    ///             uint32_t                 arrayLayers;
    ///             VkSampleCountFlagBits    samples;
    ///             VkImageTiling            tiling;
    ///             VkImageUsageFlags        usage;
    ///             VkSharingMode            sharingMode;
    ///             uint32_t                 queueFamilyIndexCount;
    ///             const uint32_t*          pQueueFamilyIndices;
    ///             VkImageLayout            initialLayout;
    ///         } VkImageCreateInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 88)]
    public unsafe partial struct VkImageCreateInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.ImageCreateInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is a bitmask of <c>VkImageCreateFlags</c> describing additional parameters of the image.
        /// </summary>
        [FieldOffset(16)]
        public VkImageCreateFlags Flags;

        /// <summary>
        ///     <c>ImageType</c> is a <c>VkImageType</c> value specifying the basic dimensionality of the image. Layers in array textures do not count as a dimension for the purposes of the image type.
        /// </summary>
        [FieldOffset(20)]
        public VkImageType ImageType;

        /// <summary>
        ///     <c>Format</c> is a <c>VkFormat</c> describing the format and type of the texel blocks that will be contained in the image.
        /// </summary>
        [FieldOffset(24)]
        public VkFormat Format;

        /// <summary>
        ///     <c>Extent</c> is a <c>VkExtent3D</c> describing the number of texels/pixels in each dimension of the base level.
        /// </summary>
        [FieldOffset(28)]
        public VkExtent3D Extent;

        /// <summary>
        ///     <c>MipLevels</c> describes the number of levels of detail available for minified sampling of the image.
        /// </summary>
        [FieldOffset(40)]
        public int MipLevels;

        /// <summary>
        ///     <c>ArrayLayers</c> is the number of layers in the image.
        /// </summary>
        [FieldOffset(44)]
        public int ArrayLayers;

        /// <summary>
        ///     <c>Samples</c> is a <c>VkSampleCountFlags</c> value specifying the number of <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#primsrast-multisampling">samples per texel^</see>.
        /// </summary>
        [FieldOffset(48)]
        public VkSampleCountFlags Samples;

        /// <summary>
        ///     <c>Tiling</c> is a <c>VkImageTiling</c> value specifying the tiling arrangement of the texel blocks in memory.
        /// </summary>
        [FieldOffset(52)]
        public VkImageTiling Tiling;

        /// <summary>
        ///     <c>Usage</c> is a bitmask of <c>VkImageUsageFlags</c> describing the intended usage of the image.
        /// </summary>
        [FieldOffset(56)]
        public VkImageUsageFlags Usage;

        /// <summary>
        ///     <c>SharingMode</c> is a <c>VkSharingMode</c> value specifying the sharing mode of the image when it will be accessed by multiple queue families.
        /// </summary>
        [FieldOffset(60)]
        public VkSharingMode SharingMode;

        /// <summary>
        ///     <c>QueueFamilyIndexCount</c> is the number of entries in the <c>pQueueFamilyIndices</c> array.
        /// </summary>
        [FieldOffset(64)]
        public int QueueFamilyIndexCount;

        /// <summary>
        ///     <c>QueueFamilyIndices</c> is a pointer to an array of queue families that will access this image. It is ignored if <c>sharingMode</c> is not <c>VK_SHARING_MODE_CONCURRENT</c>.
        /// </summary>
        [FieldOffset(72)]
        public int* QueueFamilyIndices;

        /// <summary>
        ///     <c>InitialLayout</c> is a <c>VkImageLayout</c> value specifying the initial <c>VkImageLayout</c> of all image subresources of the image. See <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#resources-image-layouts">Image Layouts^</see>.
        /// </summary>
        [FieldOffset(80)]
        public VkImageLayout InitialLayout;
    }
}
