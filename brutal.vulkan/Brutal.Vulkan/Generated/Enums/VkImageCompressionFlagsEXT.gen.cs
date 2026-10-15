namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkImageCompressionFlagBitsEXT.html">VkImageCompressionFlagBitsEXT</see> - Bitmask specifying image compression controls
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Possible values of <c>VkImageCompressionControlEXT::flags</c>,
    ///         specifying compression controls for an image, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_image_compression_control
    ///         typedef enum VkImageCompressionFlagBitsEXT {
    ///             VK_IMAGE_COMPRESSION_DEFAULT_EXT = 0,
    ///             VK_IMAGE_COMPRESSION_FIXED_RATE_DEFAULT_EXT = 0x00000001,
    ///             VK_IMAGE_COMPRESSION_FIXED_RATE_EXPLICIT_EXT = 0x00000002,
    ///             VK_IMAGE_COMPRESSION_DISABLED_EXT = 0x00000004,
    ///         } VkImageCompressionFlagBitsEXT;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkImageCompressionFlagsEXT : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>DefaultEXT</c> specifies that the default image compression setting is used. Implementations <i>must</i> not apply fixed-rate compression.
        /// </summary>
        DefaultEXT = 0,

        /// <summary>
        ///     <c>FixedRateDefaultEXT</c> specifies that the implementation may: choose any supported fixed-rate compression setting in an implementation-defined manner based on the properties of the image.
        /// </summary>
        FixedRateDefaultEXT = 0x00000001,

        /// <summary>
        ///     <c>FixedRateExplicitEXT</c> specifies that fixed-rate compression may: be used and that the allowed compression rates are specified by <c>VkImageCompressionControlEXT::pFixedRateFlags</c>.
        /// </summary>
        FixedRateExplicitEXT = 0x00000002,

        /// <summary>
        ///     <c>DisabledEXT</c> specifies that all lossless and fixed-rate compression <i>should</i> be disabled.  If <c>VkImageCompressionControlEXT::flags</c> is <c>VK_IMAGE_COMPRESSION_FIXED_RATE_EXPLICIT_EXT</c>, then the etext:i^th^ member of the <c>pFixedRateFlags</c> array specifies the allowed compression rates for the image&apos;s etext:i^th^ plane.  [NOTE]
        /// </summary>
        DisabledEXT = 0x00000004,

        /// <summary>
        ///     <c>FlagBitsMaxEnumEXT</c>
        /// </summary>
        FlagBitsMaxEnumEXT = 0x7FFFFFFF,
    }
}
