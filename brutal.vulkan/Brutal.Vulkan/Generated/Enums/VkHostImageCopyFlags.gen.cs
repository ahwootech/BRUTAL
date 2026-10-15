namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkHostImageCopyFlagBits.html">VkHostImageCopyFlagBits</see> - Bitmask specifying additional copy parameters
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which <i>can</i> be set in <c>VkCopyMemoryToImageInfo::flags</c>,
    ///         <c>VkCopyImageToMemoryInfo::flags</c>, and
    ///         <c>VkCopyImageToImageInfo::flags</c>, specifying additional copy
    ///         parameters are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_4
    ///         typedef enum VkHostImageCopyFlagBits {
    ///             VK_HOST_IMAGE_COPY_MEMCPY_BIT = 0x00000001,
    ///             // VK_HOST_IMAGE_COPY_MEMCPY is a legacy alias
    ///             VK_HOST_IMAGE_COPY_MEMCPY = VK_HOST_IMAGE_COPY_MEMCPY_BIT,
    ///             // Provided by VK_EXT_host_image_copy
    ///             VK_HOST_IMAGE_COPY_MEMCPY_BIT_EXT = VK_HOST_IMAGE_COPY_MEMCPY_BIT,
    ///             // Provided by VK_EXT_host_image_copy
    ///             // VK_HOST_IMAGE_COPY_MEMCPY_EXT is a legacy alias
    ///             VK_HOST_IMAGE_COPY_MEMCPY_EXT = VK_HOST_IMAGE_COPY_MEMCPY_BIT,
    ///         } VkHostImageCopyFlagBits;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkHostImageCopyFlags : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>MemcpyBit</c> specifies that no memory layout swizzling is to be applied during data copy. For copies between memory and images, this flag indicates that image data in host memory is swizzled in exactly the same way as the image data on the device. Using this flag indicates that the implementations may: use a simple memory copy to transfer the data between the host memory and the device memory. The format of the swizzled data in host memory is platform dependent and is not defined in this specification.
        /// </summary>
        MemcpyBit = 0x00000001,

        /// <summary>
        ///     <c>Memcpy</c>
        /// </summary>
        Memcpy = MemcpyBit,

        /// <summary>
        ///     <c>MemcpyBitEXT</c>
        /// </summary>
        MemcpyBitEXT = MemcpyBit,

        /// <summary>
        ///     <c>MemcpyEXT</c>
        /// </summary>
        MemcpyEXT = MemcpyBit,

        /// <summary>
        ///     <c>FlagBitsMaxEnum</c>
        /// </summary>
        FlagBitsMaxEnum = 0x7FFFFFFF,
    }
}
