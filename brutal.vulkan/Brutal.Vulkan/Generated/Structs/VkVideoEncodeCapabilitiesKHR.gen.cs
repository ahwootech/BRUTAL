namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeCapabilitiesKHR.html">VkVideoEncodeCapabilitiesKHR</see> - Structure describing general video encode capabilities for a video profile
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         When calling <c>vkGetPhysicalDeviceVideoCapabilitiesKHR</c> with
    ///         <c>pVideoProfile</c>-&gt;videoCodecOperation specifying an encode operation, the
    ///         <c>VkVideoEncodeCapabilitiesKHR</c> structure <i>must</i> be included in the
    ///         <c>pNext</c> chain of the <c>VkVideoCapabilitiesKHR</c> structure to retrieve
    ///         capabilities specific to video encoding.
    ///     </para>
    ///     <para>
    ///         The <c>VkVideoEncodeCapabilitiesKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_encode_queue
    ///         typedef struct VkVideoEncodeCapabilitiesKHR {
    ///             VkStructureType                         sType;
    ///             void*                                   pNext;
    ///             VkVideoEncodeCapabilityFlagsKHR         flags;
    ///             VkVideoEncodeRateControlModeFlagsKHR    rateControlModes;
    ///             uint32_t                                maxRateControlLayers;
    ///             uint64_t                                maxBitrate;
    ///             uint32_t                                maxQualityLevels;
    ///             VkExtent2D                              encodeInputPictureGranularity;
    ///             VkVideoEncodeFeedbackFlagsKHR           supportedEncodeFeedbackFlags;
    ///         } VkVideoEncodeCapabilitiesKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public unsafe partial struct VkVideoEncodeCapabilitiesKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.VideoEncodeCapabilitiesKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is a bitmask of <c>VkVideoEncodeCapabilityFlagsKHR</c> describing supported encoding features.
        /// </summary>
        [FieldOffset(16)]
        public VkVideoEncodeCapabilityFlagsKHR Flags;

        /// <summary>
        ///     <c>RateControlModes</c> is a bitmask of <c>VkVideoEncodeRateControlModeFlagsKHR</c> indicating supported <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-rate-control-modes">rate control modes^</see>.
        /// </summary>
        [FieldOffset(20)]
        public VkVideoEncodeRateControlModeFlagsKHR RateControlModes;

        /// <summary>
        ///     <c>MaxRateControlLayers</c> indicates the maximum number of <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-rate-control-layers">rate control layers^</see> supported.
        /// </summary>
        [FieldOffset(24)]
        public int MaxRateControlLayers;

        /// <summary>
        ///     <c>MaxBitrate</c> indicates the maximum supported bitrate.
        /// </summary>
        [FieldOffset(32)]
        public nint MaxBitrate;

        /// <summary>
        ///     <c>MaxQualityLevels</c> indicates the number of discrete <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-quality-level">video encode quality levels^</see> supported. Implementations <i>must</i> support at least one quality level.
        /// </summary>
        [FieldOffset(40)]
        public int MaxQualityLevels;

        /// <summary>
        ///     <c>EncodeInputPictureGranularity</c> indicates the granularity at which <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-input-picture">encode input picture^</see> data is encoded and may: indicate a texel granularity up to the size of the largest supported codec-specific coding block. This capability does not impose any valid usage constraints on the application, however, depending on the contents of the encode input picture, it may: have effects on the encoded bitstream, as described in more detail below.
        /// </summary>
        [FieldOffset(44)]
        public VkExtent2D EncodeInputPictureGranularity;

        /// <summary>
        ///     <c>SupportedEncodeFeedbackFlags</c> is a bitmask of <c>VkVideoEncodeFeedbackFlagsKHR</c> values specifying the supported flags for <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#queries-video-encode-feedback">video encode feedback queries^</see>.
        /// </summary>
        [FieldOffset(52)]
        public VkVideoEncodeFeedbackFlagsKHR SupportedEncodeFeedbackFlags;
    }
}
