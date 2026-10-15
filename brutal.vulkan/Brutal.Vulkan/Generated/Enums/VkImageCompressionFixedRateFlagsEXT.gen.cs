namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkImageCompressionFixedRateFlagBitsEXT.html">VkImageCompressionFixedRateFlagBitsEXT</see> - Bitmask specifying fixed rate image compression rates
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which <i>can</i> be set in
    ///         <c>VkImageCompressionControlEXT::pFixedRateFlags</c>, specifying
    ///         allowed compression rates for an image plane, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_image_compression_control
    ///         typedef enum VkImageCompressionFixedRateFlagBitsEXT {
    ///             VK_IMAGE_COMPRESSION_FIXED_RATE_NONE_EXT = 0,
    ///             VK_IMAGE_COMPRESSION_FIXED_RATE_1BPC_BIT_EXT = 0x00000001,
    ///             VK_IMAGE_COMPRESSION_FIXED_RATE_2BPC_BIT_EXT = 0x00000002,
    ///             VK_IMAGE_COMPRESSION_FIXED_RATE_3BPC_BIT_EXT = 0x00000004,
    ///             VK_IMAGE_COMPRESSION_FIXED_RATE_4BPC_BIT_EXT = 0x00000008,
    ///             VK_IMAGE_COMPRESSION_FIXED_RATE_5BPC_BIT_EXT = 0x00000010,
    ///             VK_IMAGE_COMPRESSION_FIXED_RATE_6BPC_BIT_EXT = 0x00000020,
    ///             VK_IMAGE_COMPRESSION_FIXED_RATE_7BPC_BIT_EXT = 0x00000040,
    ///             VK_IMAGE_COMPRESSION_FIXED_RATE_8BPC_BIT_EXT = 0x00000080,
    ///             VK_IMAGE_COMPRESSION_FIXED_RATE_9BPC_BIT_EXT = 0x00000100,
    ///             VK_IMAGE_COMPRESSION_FIXED_RATE_10BPC_BIT_EXT = 0x00000200,
    ///             VK_IMAGE_COMPRESSION_FIXED_RATE_11BPC_BIT_EXT = 0x00000400,
    ///             VK_IMAGE_COMPRESSION_FIXED_RATE_12BPC_BIT_EXT = 0x00000800,
    ///             VK_IMAGE_COMPRESSION_FIXED_RATE_13BPC_BIT_EXT = 0x00001000,
    ///             VK_IMAGE_COMPRESSION_FIXED_RATE_14BPC_BIT_EXT = 0x00002000,
    ///             VK_IMAGE_COMPRESSION_FIXED_RATE_15BPC_BIT_EXT = 0x00004000,
    ///             VK_IMAGE_COMPRESSION_FIXED_RATE_16BPC_BIT_EXT = 0x00008000,
    ///             VK_IMAGE_COMPRESSION_FIXED_RATE_17BPC_BIT_EXT = 0x00010000,
    ///             VK_IMAGE_COMPRESSION_FIXED_RATE_18BPC_BIT_EXT = 0x00020000,
    ///             VK_IMAGE_COMPRESSION_FIXED_RATE_19BPC_BIT_EXT = 0x00040000,
    ///             VK_IMAGE_COMPRESSION_FIXED_RATE_20BPC_BIT_EXT = 0x00080000,
    ///             VK_IMAGE_COMPRESSION_FIXED_RATE_21BPC_BIT_EXT = 0x00100000,
    ///             VK_IMAGE_COMPRESSION_FIXED_RATE_22BPC_BIT_EXT = 0x00200000,
    ///             VK_IMAGE_COMPRESSION_FIXED_RATE_23BPC_BIT_EXT = 0x00400000,
    ///             VK_IMAGE_COMPRESSION_FIXED_RATE_24BPC_BIT_EXT = 0x00800000,
    ///         } VkImageCompressionFixedRateFlagBitsEXT;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkImageCompressionFixedRateFlagsEXT : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>NoneEXT</c> specifies that fixed-rate compression <i>must</i> not be used.
        /// </summary>
        NoneEXT = 0,

        /// <summary>
        ///     <c>_1BpcBitEXT</c> specifies that fixed-rate compression with a bitrate of <c>[1,2)</c> bits per component may: be used.
        /// </summary>
        _1BpcBitEXT = 0x00000001,

        /// <summary>
        ///     <c>_2BpcBitEXT</c> specifies that fixed-rate compression with a bitrate of <c>[2,3)</c> bits per component may: be used.
        /// </summary>
        _2BpcBitEXT = 0x00000002,

        /// <summary>
        ///     <c>_3BpcBitEXT</c> specifies that fixed-rate compression with a bitrate of <c>[3,4)</c> bits per component may: be used.
        /// </summary>
        _3BpcBitEXT = 0x00000004,

        /// <summary>
        ///     <c>_4BpcBitEXT</c> specifies that fixed-rate compression with a bitrate of <c>[4,5)</c> bits per component may: be used.
        /// </summary>
        _4BpcBitEXT = 0x00000008,

        /// <summary>
        ///     <c>_5BpcBitEXT</c> specifies that fixed-rate compression with a bitrate of <c>[5,6)</c> bits per component may: be used.
        /// </summary>
        _5BpcBitEXT = 0x00000010,

        /// <summary>
        ///     <c>_6BpcBitEXT</c> specifies that fixed-rate compression with a bitrate of <c>[6,7)</c> bits per component may: be used.
        /// </summary>
        _6BpcBitEXT = 0x00000020,

        /// <summary>
        ///     <c>_7BpcBitEXT</c> specifies that fixed-rate compression with a bitrate of <c>[7,8)</c> bits per component may: be used.
        /// </summary>
        _7BpcBitEXT = 0x00000040,

        /// <summary>
        ///     <c>_8BpcBitEXT</c> specifies that fixed-rate compression with a bitrate of <c>[8,9)</c> bits per component may: be used.
        /// </summary>
        _8BpcBitEXT = 0x00000080,

        /// <summary>
        ///     <c>_9BpcBitEXT</c> specifies that fixed-rate compression with a bitrate of <c>[9,10)</c> bits per component may: be used.
        /// </summary>
        _9BpcBitEXT = 0x00000100,

        /// <summary>
        ///     <c>_10BpcBitEXT</c> specifies that fixed-rate compression with a bitrate of <c>[10,11)</c> bits per component may: be used.
        /// </summary>
        _10BpcBitEXT = 0x00000200,

        /// <summary>
        ///     <c>_11BpcBitEXT</c> specifies that fixed-rate compression with a bitrate of <c>[11,12)</c> bits per component may: be used.
        /// </summary>
        _11BpcBitEXT = 0x00000400,

        /// <summary>
        ///     <c>_12BpcBitEXT</c> specifies that fixed-rate compression with a bitrate of at least 12 bits per component may: be used.  If the format has a different bit rate for different components, <c>VkImageCompressionControlEXT::pFixedRateFlags</c> describes the rate of the component with the largest number of bits assigned to it, scaled pro rata. For example, to request that a <c>VK_FORMAT_A2R10G10B10_UNORM_PACK32</c> format be stored at a rate of 8 bits per pixel, use <c>VK_IMAGE_COMPRESSION_FIXED_RATE_2BPC_BIT_EXT</c> (10 bits for the largest component, stored at quarter the original size, 2.5 bits, rounded down).  If <c>flags</c> includes <c>VK_IMAGE_COMPRESSION_FIXED_RATE_EXPLICIT_EXT</c>, and multiple bits are set in <c>VkImageCompressionControlEXT::pFixedRateFlags</c> for a plane, implementations <i>should</i> apply the lowest allowed bitrate that is supported.  [NOTE]
        /// </summary>
        _12BpcBitEXT = 0x00000800,

        /// <summary>
        ///     <c>_13BpcBitEXT</c>
        /// </summary>
        _13BpcBitEXT = 0x00001000,

        /// <summary>
        ///     <c>_14BpcBitEXT</c>
        /// </summary>
        _14BpcBitEXT = 0x00002000,

        /// <summary>
        ///     <c>_15BpcBitEXT</c>
        /// </summary>
        _15BpcBitEXT = 0x00004000,

        /// <summary>
        ///     <c>_16BpcBitEXT</c>
        /// </summary>
        _16BpcBitEXT = 0x00008000,

        /// <summary>
        ///     <c>_17BpcBitEXT</c>
        /// </summary>
        _17BpcBitEXT = 0x00010000,

        /// <summary>
        ///     <c>_18BpcBitEXT</c>
        /// </summary>
        _18BpcBitEXT = 0x00020000,

        /// <summary>
        ///     <c>_19BpcBitEXT</c>
        /// </summary>
        _19BpcBitEXT = 0x00040000,

        /// <summary>
        ///     <c>_20BpcBitEXT</c>
        /// </summary>
        _20BpcBitEXT = 0x00080000,

        /// <summary>
        ///     <c>_21BpcBitEXT</c>
        /// </summary>
        _21BpcBitEXT = 0x00100000,

        /// <summary>
        ///     <c>_22BpcBitEXT</c>
        /// </summary>
        _22BpcBitEXT = 0x00200000,

        /// <summary>
        ///     <c>_23BpcBitEXT</c>
        /// </summary>
        _23BpcBitEXT = 0x00400000,

        /// <summary>
        ///     <c>_24BpcBitEXT</c>
        /// </summary>
        _24BpcBitEXT = 0x00800000,

        /// <summary>
        ///     <c>FlagBitsMaxEnumEXT</c>
        /// </summary>
        FlagBitsMaxEnumEXT = 0x7FFFFFFF,
    }
}
