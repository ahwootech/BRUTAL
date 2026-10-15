namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkImageViewCreateFlagBits.html">VkImageViewCreateFlagBits</see> - Bitmask specifying additional parameters of an image view
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which <i>can</i> be set in <c>VkImageViewCreateInfo::flags</c>,
    ///         specifying additional parameters of an image view, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef enum VkImageViewCreateFlagBits {
    ///             // Provided by VK_EXT_fragment_density_map
    ///             VK_IMAGE_VIEW_CREATE_FRAGMENT_DENSITY_MAP_DYNAMIC_BIT_EXT = 0x00000001,
    ///             // Provided by VK_EXT_descriptor_buffer
    ///             VK_IMAGE_VIEW_CREATE_DESCRIPTOR_BUFFER_CAPTURE_REPLAY_BIT_EXT = 0x00000004,
    ///             // Provided by VK_EXT_fragment_density_map2
    ///             VK_IMAGE_VIEW_CREATE_FRAGMENT_DENSITY_MAP_DEFERRED_BIT_EXT = 0x00000002,
    ///         } VkImageViewCreateFlagBits;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkImageViewCreateFlags : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>FragmentDensityMapDynamicBitEXT</c>
        /// </summary>
        FragmentDensityMapDynamicBitEXT = 0x00000001,

        /// <summary>
        ///     <c>DescriptorBufferCaptureReplayBitEXT</c>
        /// </summary>
        DescriptorBufferCaptureReplayBitEXT = 0x00000004,

        /// <summary>
        ///     <c>FragmentDensityMapDeferredBitEXT</c>
        /// </summary>
        FragmentDensityMapDeferredBitEXT = 0x00000002,

        /// <summary>
        ///     <c>FlagBitsMaxEnum</c>
        /// </summary>
        FlagBitsMaxEnum = 0x7FFFFFFF,
    }
}
