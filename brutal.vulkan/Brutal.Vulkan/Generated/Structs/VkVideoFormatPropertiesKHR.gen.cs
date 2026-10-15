namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoFormatPropertiesKHR.html">VkVideoFormatPropertiesKHR</see> - Structure enumerating the video image formats
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkVideoFormatPropertiesKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_queue
    ///         typedef struct VkVideoFormatPropertiesKHR {
    ///             VkStructureType       sType;
    ///             void*                 pNext;
    ///             VkFormat              format;
    ///             VkComponentMapping    componentMapping;
    ///             VkImageCreateFlags    imageCreateFlags;
    ///             VkImageType           imageType;
    ///             VkImageTiling         imageTiling;
    ///             VkImageUsageFlags     imageUsageFlags;
    ///         } VkVideoFormatPropertiesKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public unsafe partial struct VkVideoFormatPropertiesKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.VideoFormatPropertiesKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Format</c> is a <c>VkFormat</c> that specifies the format that <i>can</i> be used with the specified video profiles and image usages.
        /// </summary>
        [FieldOffset(16)]
        public VkFormat Format;

        /// <summary>
        ///     <c>ComponentMapping</c> defines the color channel order used for the format. <c>format</c> along with <c>componentMapping</c> describe how the color channels are ordered when producing video decoder output or are expected to be ordered in video encoder input, when applicable. If the <c>format</c> reported does not require component swizzling then all members of <c>componentMapping</c> will be set to <c>VK_COMPONENT_SWIZZLE_IDENTITY</c>.
        /// </summary>
        [FieldOffset(20)]
        public VkComponentMapping ComponentMapping;

        /// <summary>
        ///     <c>ImageCreateFlags</c> is a bitmask of <c>VkImageCreateFlags</c> specifying the supported image creation flags for the format.
        /// </summary>
        [FieldOffset(36)]
        public VkImageCreateFlags ImageCreateFlags;

        /// <summary>
        ///     <c>ImageType</c> is a <c>VkImageType</c> that specifies the image type the format <i>can</i> be used with.
        /// </summary>
        [FieldOffset(40)]
        public VkImageType ImageType;

        /// <summary>
        ///     <c>ImageTiling</c> is a <c>VkImageTiling</c> that specifies the image tiling the format <i>can</i> be used with.
        /// </summary>
        [FieldOffset(44)]
        public VkImageTiling ImageTiling;

        /// <summary>
        ///     <c>ImageUsageFlags</c> is a bitmask of <c>VkImageUsageFlags</c> specifying the supported image usage flags for the format.
        /// </summary>
        [FieldOffset(48)]
        public VkImageUsageFlags ImageUsageFlags;
    }
}
