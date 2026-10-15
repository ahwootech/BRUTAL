namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH264QualityLevelPropertiesKHR.html">VkVideoEncodeH264QualityLevelPropertiesKHR</see> - Structure describing the H.264 encode quality level properties
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         When calling <c>vkGetPhysicalDeviceVideoEncodeQualityLevelPropertiesKHR</c>
    ///         with <c>pVideoProfile</c>-&gt;videoCodecOperation specified as
    ///         <c>VK_VIDEO_CODEC_OPERATION_ENCODE_H264_BIT_KHR</c>, the
    ///         <c>VkVideoEncodeH264QualityLevelPropertiesKHR</c> structure <i>must</i> be included
    ///         in the <c>pNext</c> chain of the <c>VkVideoEncodeQualityLevelPropertiesKHR</c>
    ///         structure to retrieve additional video encode quality level properties
    ///         specific to H.264 encoding.
    ///     </para>
    ///     <para>
    ///         The <c>VkVideoEncodeH264QualityLevelPropertiesKHR</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_encode_h264
    ///         typedef struct VkVideoEncodeH264QualityLevelPropertiesKHR {
    ///             VkStructureType                         sType;
    ///             void*                                   pNext;
    ///             VkVideoEncodeH264RateControlFlagsKHR    preferredRateControlFlags;
    ///             uint32_t                                preferredGopFrameCount;
    ///             uint32_t                                preferredIdrPeriod;
    ///             uint32_t                                preferredConsecutiveBFrameCount;
    ///             uint32_t                                preferredTemporalLayerCount;
    ///             VkVideoEncodeH264QpKHR                  preferredConstantQp;
    ///             uint32_t                                preferredMaxL0ReferenceCount;
    ///             uint32_t                                preferredMaxL1ReferenceCount;
    ///             VkBool32                                preferredStdEntropyCodingModeFlag;
    ///         } VkVideoEncodeH264QualityLevelPropertiesKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public unsafe partial struct VkVideoEncodeH264QualityLevelPropertiesKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.VideoEncodeH264QualityLevelPropertiesKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>PreferredRateControlFlags</c> is a bitmask of <c>VkVideoEncodeH264RateControlFlagsKHR</c> values indicating the preferred flags to use for <c>VkVideoEncodeH264RateControlInfoKHR::flags</c>.
        /// </summary>
        [FieldOffset(16)]
        public VkVideoEncodeH264RateControlFlagsKHR PreferredRateControlFlags;

        /// <summary>
        ///     <c>PreferredGopFrameCount</c> indicates the preferred value to use for <c>VkVideoEncodeH264RateControlInfoKHR::gopFrameCount</c>.
        /// </summary>
        [FieldOffset(20)]
        public int PreferredGopFrameCount;

        /// <summary>
        ///     <c>PreferredIdrPeriod</c> indicates the preferred value to use for <c>VkVideoEncodeH264RateControlInfoKHR::idrPeriod</c>.
        /// </summary>
        [FieldOffset(24)]
        public int PreferredIdrPeriod;

        /// <summary>
        ///     <c>PreferredConsecutiveBFrameCount</c> indicates the preferred value to use for <c>VkVideoEncodeH264RateControlInfoKHR::consecutiveBFrameCount</c>.
        /// </summary>
        [FieldOffset(28)]
        public int PreferredConsecutiveBFrameCount;

        /// <summary>
        ///     <c>PreferredTemporalLayerCount</c> indicates the preferred value to use for <c>VkVideoEncodeH264RateControlInfoKHR::temporalLayerCount</c>.
        /// </summary>
        [FieldOffset(32)]
        public int PreferredTemporalLayerCount;

        /// <summary>
        ///     <c>PreferredConstantQp</c> indicates the preferred values to use for <c>VkVideoEncodeH264NaluSliceInfoKHR::constantQp</c> for each picture type when using <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-rate-control-modes">rate control mode^</see> <c>VK_VIDEO_ENCODE_RATE_CONTROL_MODE_DISABLED_BIT_KHR</c>.
        /// </summary>
        [FieldOffset(36)]
        public VkVideoEncodeH264QpKHR PreferredConstantQp;

        /// <summary>
        ///     <c>PreferredMaxL0ReferenceCount</c> indicates the preferred maximum number of reference pictures to use in the reference list L0.
        /// </summary>
        [FieldOffset(48)]
        public int PreferredMaxL0ReferenceCount;

        /// <summary>
        ///     <c>PreferredMaxL1ReferenceCount</c> indicates the preferred maximum number of reference pictures to use in the reference list L1.
        /// </summary>
        [FieldOffset(52)]
        public int PreferredMaxL1ReferenceCount;

        /// <summary>
        ///     <c>PreferredStdEntropyCodingModeFlag</c> indicates the preferred value to use for <c>entropy_coding_mode_flag</c> in <c>StdVideoH264PpsFlags</c>.
        /// </summary>
        [FieldOffset(56)]
        public Brutal.Bool32 PreferredStdEntropyCodingModeFlag;
    }
}
