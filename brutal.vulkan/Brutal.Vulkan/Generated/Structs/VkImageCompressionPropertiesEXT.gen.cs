namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkImageCompressionPropertiesEXT.html">VkImageCompressionPropertiesEXT</see> - Compression properties of an image
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         To query the compression properties of an image, add a
    ///         <c>VkImageCompressionPropertiesEXT</c> structure to the <c>pNext</c> chain of
    ///         the <c>VkSubresourceLayout2</c> structure in a call to
    ///         <c>vkGetImageSubresourceLayout2</c>.
    ///     </para>
    ///     <para>
    ///         To determine the compression rates that are supported for a given image
    ///         format, add a <c>VkImageCompressionPropertiesEXT</c> structure to the
    ///         <c>pNext</c> chain of the <c>VkImageFormatProperties2</c> structure in a call
    ///         to <c>vkGetPhysicalDeviceImageFormatProperties2</c>.
    ///     </para>
    ///     <para>
    ///         [NOTE]
    ///     </para>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkImageCompressionPropertiesEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.ImageCompressionPropertiesEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ImageCompressionFlags</c> returns a value describing the compression controls that apply to the image. The value will be either <c>VK_IMAGE_COMPRESSION_DEFAULT_EXT</c> to indicate no fixed-rate compression, <c>VK_IMAGE_COMPRESSION_FIXED_RATE_EXPLICIT_EXT</c> to indicate fixed-rate compression, or <c>VK_IMAGE_COMPRESSION_DISABLED_EXT</c> to indicate no compression.
        /// </summary>
        [FieldOffset(16)]
        public VkImageCompressionFlagsEXT ImageCompressionFlags;

        /// <summary>
        ///     <c>ImageCompressionFixedRateFlags</c> returns a <c>VkImageCompressionFixedRateFlagsEXT</c> value describing the compression rates that apply to the specified aspect of the image.
        /// </summary>
        [FieldOffset(20)]
        public VkImageCompressionFixedRateFlagsEXT ImageCompressionFixedRateFlags;
    }
}
