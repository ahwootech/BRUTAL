namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH265QualityLevelPropertiesKHR.html">VkVideoEncodeH265QualityLevelPropertiesKHR</see> - Structure describing the H.265 encode quality level properties
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         When calling <c>vkGetPhysicalDeviceVideoEncodeQualityLevelPropertiesKHR</c>
    ///         with <c>pVideoProfile</c>-&gt;videoCodecOperation specified as
    ///         <c>VK_VIDEO_CODEC_OPERATION_ENCODE_H265_BIT_KHR</c>, the
    ///         <c>VkVideoEncodeH265QualityLevelPropertiesKHR</c> structure <i>must</i> be included
    ///         in the <c>pNext</c> chain of the <c>VkVideoEncodeQualityLevelPropertiesKHR</c>
    ///         structure to retrieve additional video encode quality level properties
    ///         specific to H.265 encoding.
    ///     </para>
    ///     <para>
    ///         The <c>VkVideoEncodeH265QualityLevelPropertiesKHR</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_encode_h265
    ///         typedef struct VkVideoEncodeH265QualityLevelPropertiesKHR {
    ///             VkStructureType                         sType;
    ///             void*                                   pNext;
    ///             VkVideoEncodeH265RateControlFlagsKHR    preferredRateControlFlags;
    ///             uint32_t                                preferredGopFrameCount;
    ///             uint32_t                                preferredIdrPeriod;
    ///             uint32_t                                preferredConsecutiveBFrameCount;
    ///             uint32_t                                preferredSubLayerCount;
    ///             VkVideoEncodeH265QpKHR                  preferredConstantQp;
    ///             uint32_t                                preferredMaxL0ReferenceCount;
    ///             uint32_t                                preferredMaxL1ReferenceCount;
    ///         } VkVideoEncodeH265QualityLevelPropertiesKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public unsafe partial struct VkVideoEncodeH265QualityLevelPropertiesKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.VideoEncodeH265QualityLevelPropertiesKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>PreferredRateControlFlags</c> is a bitmask of <c>VkVideoEncodeH265RateControlFlagsKHR</c> values indicating the preferred flags to use for <c>VkVideoEncodeH265RateControlInfoKHR::flags</c>.
        /// </summary>
        [FieldOffset(16)]
        public VkVideoEncodeH265RateControlFlagsKHR PreferredRateControlFlags;

        /// <summary>
        ///     <c>PreferredGopFrameCount</c> indicates the preferred value to use for <c>VkVideoEncodeH265RateControlInfoKHR::gopFrameCount</c>.
        /// </summary>
        [FieldOffset(20)]
        public int PreferredGopFrameCount;

        /// <summary>
        ///     <c>PreferredIdrPeriod</c> indicates the preferred value to use for <c>VkVideoEncodeH265RateControlInfoKHR::idrPeriod</c>.
        /// </summary>
        [FieldOffset(24)]
        public int PreferredIdrPeriod;

        /// <summary>
        ///     <c>PreferredConsecutiveBFrameCount</c> indicates the preferred value to use for <c>VkVideoEncodeH265RateControlInfoKHR::consecutiveBFrameCount</c>.
        /// </summary>
        [FieldOffset(28)]
        public int PreferredConsecutiveBFrameCount;

        /// <summary>
        ///     <c>PreferredSubLayerCount</c> indicates the preferred value to use for <c>VkVideoEncodeH265RateControlInfoKHR::subLayerCount</c>.
        /// </summary>
        [FieldOffset(32)]
        public int PreferredSubLayerCount;

        /// <summary>
        ///     <c>PreferredConstantQp</c> indicates the preferred values to use for <c>VkVideoEncodeH265NaluSliceSegmentInfoKHR::constantQp</c> for each picture type when using <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-rate-control-modes">rate control mode^</see> <c>VK_VIDEO_ENCODE_RATE_CONTROL_MODE_DISABLED_BIT_KHR</c>.
        /// </summary>
        [FieldOffset(36)]
        public VkVideoEncodeH265QpKHR PreferredConstantQp;

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
    }
}
