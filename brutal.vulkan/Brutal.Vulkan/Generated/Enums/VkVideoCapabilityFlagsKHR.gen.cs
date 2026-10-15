namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoCapabilityFlagBitsKHR.html">VkVideoCapabilityFlagBitsKHR</see> - Video decode and encode capability bits
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which <i>can</i> be set in <c>VkVideoCapabilitiesKHR::flags</c> are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_queue
    ///         typedef enum VkVideoCapabilityFlagBitsKHR {
    ///             VK_VIDEO_CAPABILITY_PROTECTED_CONTENT_BIT_KHR = 0x00000001,
    ///             VK_VIDEO_CAPABILITY_SEPARATE_REFERENCE_IMAGES_BIT_KHR = 0x00000002,
    ///         } VkVideoCapabilityFlagBitsKHR;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkVideoCapabilityFlagsKHR : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>ProtectedContentBitKHR</c> specifies that video sessions support producing and consuming protected content.
        /// </summary>
        ProtectedContentBitKHR = 0x00000001,

        /// <summary>
        ///     <c>SeparateReferenceImagesBitKHR</c>
        /// </summary>
        SeparateReferenceImagesBitKHR = 0x00000002,

        /// <summary>
        ///     <c>FlagBitsMaxEnumKHR</c>
        /// </summary>
        FlagBitsMaxEnumKHR = 0x7FFFFFFF,
    }
}
