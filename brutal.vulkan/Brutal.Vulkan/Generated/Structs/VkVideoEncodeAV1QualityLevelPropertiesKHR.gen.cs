namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeAV1QualityLevelPropertiesKHR.html">VkVideoEncodeAV1QualityLevelPropertiesKHR</see> - Structure describing the AV1 encode quality level properties
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         When calling <c>vkGetPhysicalDeviceVideoEncodeQualityLevelPropertiesKHR</c>
    ///         with <c>pVideoProfile</c>-&gt;videoCodecOperation specified as
    ///         <c>VK_VIDEO_CODEC_OPERATION_ENCODE_AV1_BIT_KHR</c>, the
    ///         <c>VkVideoEncodeAV1QualityLevelPropertiesKHR</c> structure <i>must</i> be included
    ///         in the <c>pNext</c> chain of the <c>VkVideoEncodeQualityLevelPropertiesKHR</c>
    ///         structure to retrieve additional video encode quality level properties
    ///         specific to AV1 encoding.
    ///     </para>
    ///     <para>
    ///         The <c>VkVideoEncodeAV1QualityLevelPropertiesKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_encode_av1
    ///         typedef struct VkVideoEncodeAV1QualityLevelPropertiesKHR {
    ///             VkStructureType                        sType;
    ///             void*                                  pNext;
    ///             VkVideoEncodeAV1RateControlFlagsKHR    preferredRateControlFlags;
    ///             uint32_t                               preferredGopFrameCount;
    ///             uint32_t                               preferredKeyFramePeriod;
    ///             uint32_t                               preferredConsecutiveBipredictiveFrameCount;
    ///             uint32_t                               preferredTemporalLayerCount;
    ///             VkVideoEncodeAV1QIndexKHR              preferredConstantQIndex;
    ///             uint32_t                               preferredMaxSingleReferenceCount;
    ///             uint32_t                               preferredSingleReferenceNameMask;
    ///             uint32_t                               preferredMaxUnidirectionalCompoundReferenceCount;
    ///             uint32_t                               preferredMaxUnidirectionalCompoundGroup1ReferenceCount;
    ///             uint32_t                               preferredUnidirectionalCompoundReferenceNameMask;
    ///             uint32_t                               preferredMaxBidirectionalCompoundReferenceCount;
    ///             uint32_t                               preferredMaxBidirectionalCompoundGroup1ReferenceCount;
    ///             uint32_t                               preferredMaxBidirectionalCompoundGroup2ReferenceCount;
    ///             uint32_t                               preferredBidirectionalCompoundReferenceNameMask;
    ///         } VkVideoEncodeAV1QualityLevelPropertiesKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 88)]
    public unsafe partial struct VkVideoEncodeAV1QualityLevelPropertiesKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.VideoEncodeAV1QualityLevelPropertiesKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>PreferredRateControlFlags</c> is a bitmask of <c>VkVideoEncodeAV1RateControlFlagsKHR</c> values indicating the preferred flags to use for <c>VkVideoEncodeAV1RateControlInfoKHR::flags</c>.
        /// </summary>
        [FieldOffset(16)]
        public VkVideoEncodeAV1RateControlFlagsKHR PreferredRateControlFlags;

        /// <summary>
        ///     <c>PreferredGopFrameCount</c> indicates the preferred value to use for <c>VkVideoEncodeAV1RateControlInfoKHR::gopFrameCount</c>.
        /// </summary>
        [FieldOffset(20)]
        public int PreferredGopFrameCount;

        /// <summary>
        ///     <c>PreferredKeyFramePeriod</c> indicates the preferred value to use for <c>VkVideoEncodeAV1RateControlInfoKHR::keyFramePeriod</c>.
        /// </summary>
        [FieldOffset(24)]
        public int PreferredKeyFramePeriod;

        /// <summary>
        ///     <c>PreferredConsecutiveBipredictiveFrameCount</c> indicates the preferred value to use for <c>VkVideoEncodeAV1RateControlInfoKHR::consecutiveBipredictiveFrameCount</c>.
        /// </summary>
        [FieldOffset(28)]
        public int PreferredConsecutiveBipredictiveFrameCount;

        /// <summary>
        ///     <c>PreferredTemporalLayerCount</c> indicates the preferred value to use for <c>VkVideoEncodeAV1RateControlInfoKHR::temporalLayerCount</c>.
        /// </summary>
        [FieldOffset(32)]
        public int PreferredTemporalLayerCount;

        /// <summary>
        ///     <c>PreferredConstantQIndex</c> indicates the preferred value to use for <c>VkVideoEncodeAV1PictureInfoKHR::constantQIndex</c> when using <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-rate-control-modes">rate control mode^</see> <c>VK_VIDEO_ENCODE_RATE_CONTROL_MODE_DISABLED_BIT_KHR</c>.
        /// </summary>
        [FieldOffset(36)]
        public VkVideoEncodeAV1QIndexKHR PreferredConstantQIndex;

        /// <summary>
        ///     <c>PreferredMaxSingleReferenceCount</c> indicates the preferred maximum number of reference pictures to use with <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-av1-prediction-modes">single reference prediction mode^</see>.
        /// </summary>
        [FieldOffset(48)]
        public int PreferredMaxSingleReferenceCount;

        /// <summary>
        ///     <c>PreferredSingleReferenceNameMask</c> is a bitmask of preferred <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-av1-reference-names">AV1 reference names^</see> when using <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-av1-prediction-modes">single reference prediction mode^</see>.
        /// </summary>
        [FieldOffset(52)]
        public int PreferredSingleReferenceNameMask;

        /// <summary>
        ///     <c>PreferredMaxUnidirectionalCompoundReferenceCount</c> indicates the preferred maximum number of reference pictures to use with <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-av1-prediction-modes">unidirectional compound prediction mode^</see>.
        /// </summary>
        [FieldOffset(56)]
        public int PreferredMaxUnidirectionalCompoundReferenceCount;

        /// <summary>
        ///     <c>PreferredMaxUnidirectionalCompoundGroup1ReferenceCount</c> indicates the preferred maximum number of reference pictures to use with <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-av1-prediction-modes">unidirectional compound prediction mode^</see> from reference frame group 1, as defined in section 6.10.24 of the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#aomedia-av1">AV1 Specification^</see>.
        /// </summary>
        [FieldOffset(60)]
        public int PreferredMaxUnidirectionalCompoundGroup1ReferenceCount;

        /// <summary>
        ///     <c>PreferredUnidirectionalCompoundReferenceNameMask</c> is a bitmask of preferred <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-av1-reference-names">AV1 reference names^</see> when using <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-av1-prediction-modes">unidirectional compound prediction mode^</see>.
        /// </summary>
        [FieldOffset(64)]
        public int PreferredUnidirectionalCompoundReferenceNameMask;

        /// <summary>
        ///     <c>PreferredMaxBidirectionalCompoundReferenceCount</c> indicates the preferred maximum number of reference pictures to use with <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-av1-prediction-modes">bidirectional compound prediction mode^</see>.
        /// </summary>
        [FieldOffset(68)]
        public int PreferredMaxBidirectionalCompoundReferenceCount;

        /// <summary>
        ///     <c>PreferredMaxBidirectionalCompoundGroup1ReferenceCount</c> indicates the preferred maximum number of reference pictures to use with <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-av1-prediction-modes">bidirectional compound prediction mode^</see> from reference frame group 1, as defined in section 6.10.24 of the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#aomedia-av1">AV1 Specification^</see>.
        /// </summary>
        [FieldOffset(72)]
        public int PreferredMaxBidirectionalCompoundGroup1ReferenceCount;

        /// <summary>
        ///     <c>PreferredMaxBidirectionalCompoundGroup2ReferenceCount</c> indicates the preferred maximum number of reference pictures to use with <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-av1-prediction-modes">bidirectional compound prediction mode^</see> from reference frame group 2, as defined in section 6.10.24 of the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#aomedia-av1">AV1 Specification^</see>.
        /// </summary>
        [FieldOffset(76)]
        public int PreferredMaxBidirectionalCompoundGroup2ReferenceCount;

        /// <summary>
        ///     <c>PreferredBidirectionalCompoundReferenceNameMask</c> is a bitmask of preferred <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-av1-reference-names">AV1 reference names^</see> when using <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-av1-prediction-modes">bidirectional compound prediction mode^</see>.
        /// </summary>
        [FieldOffset(80)]
        public int PreferredBidirectionalCompoundReferenceNameMask;
    }
}
