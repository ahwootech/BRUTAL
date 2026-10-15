namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSampleCountFlagBits.html">VkSampleCountFlagBits</see> - Bitmask specifying sample counts supported for an image used for storage operations
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which may: be set in the sample count limits returned by
    ///         <c>VkPhysicalDeviceLimits</c>, as well as in other queries and structures
    ///         representing image sample counts, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef enum VkSampleCountFlagBits {
    ///             VK_SAMPLE_COUNT_1_BIT = 0x00000001,
    ///             VK_SAMPLE_COUNT_2_BIT = 0x00000002,
    ///             VK_SAMPLE_COUNT_4_BIT = 0x00000004,
    ///             VK_SAMPLE_COUNT_8_BIT = 0x00000008,
    ///             VK_SAMPLE_COUNT_16_BIT = 0x00000010,
    ///             VK_SAMPLE_COUNT_32_BIT = 0x00000020,
    ///             VK_SAMPLE_COUNT_64_BIT = 0x00000040,
    ///         } VkSampleCountFlagBits;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkSampleCountFlags : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>_1Bit</c> specifies an image with one sample per pixel.
        /// </summary>
        _1Bit = 0x00000001,

        /// <summary>
        ///     <c>_2Bit</c> specifies an image with 2 samples per pixel.
        /// </summary>
        _2Bit = 0x00000002,

        /// <summary>
        ///     <c>_4Bit</c> specifies an image with 4 samples per pixel.
        /// </summary>
        _4Bit = 0x00000004,

        /// <summary>
        ///     <c>_8Bit</c> specifies an image with 8 samples per pixel.
        /// </summary>
        _8Bit = 0x00000008,

        /// <summary>
        ///     <c>_16Bit</c> specifies an image with 16 samples per pixel.
        /// </summary>
        _16Bit = 0x00000010,

        /// <summary>
        ///     <c>_32Bit</c> specifies an image with 32 samples per pixel.
        /// </summary>
        _32Bit = 0x00000020,

        /// <summary>
        ///     <c>_64Bit</c> specifies an image with 64 samples per pixel.
        /// </summary>
        _64Bit = 0x00000040,

        /// <summary>
        ///     <c>FlagBitsMaxEnum</c>
        /// </summary>
        FlagBitsMaxEnum = 0x7FFFFFFF,
    }
}
