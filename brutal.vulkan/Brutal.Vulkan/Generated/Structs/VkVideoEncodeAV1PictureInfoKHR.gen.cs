namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeAV1PictureInfoKHR.html">VkVideoEncodeAV1PictureInfoKHR</see> - Structure specifies AV1 encode frame parameters
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkVideoEncodeAV1PictureInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_encode_av1
    ///         typedef struct VkVideoEncodeAV1PictureInfoKHR {
    ///             VkStructureType                        sType;
    ///             const void*                            pNext;
    ///             VkVideoEncodeAV1PredictionModeKHR      predictionMode;
    ///             VkVideoEncodeAV1RateControlGroupKHR    rateControlGroup;
    ///             uint32_t                               constantQIndex;
    ///             const StdVideoEncodeAV1PictureInfo*    pStdPictureInfo;
    ///             int32_t                                referenceNameSlotIndices[VK_MAX_VIDEO_AV1_REFERENCES_PER_FRAME_KHR];
    ///             VkBool32                               primaryReferenceCdfOnly;
    ///             VkBool32                               generateObuExtensionHeader;
    ///         } VkVideoEncodeAV1PictureInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 80)]
    public unsafe partial struct VkVideoEncodeAV1PictureInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.VideoEncodeAV1PictureInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>PredictionMode</c> specifies the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-av1-prediction-modes">AV1 prediction mode^</see> to use for the encoded frame.
        /// </summary>
        [FieldOffset(16)]
        public VkVideoEncodeAV1PredictionModeKHR PredictionMode;

        /// <summary>
        ///     <c>RateControlGroup</c> specifies the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-av1-rate-control-group">AV1 rate control group^</see> to use for the encoded frame when the current <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-rate-control-modes">rate control mode^</see> is not <c>VK_VIDEO_ENCODE_RATE_CONTROL_MODE_DISABLED_BIT_KHR</c>. Otherwise it is ignored.
        /// </summary>
        [FieldOffset(20)]
        public VkVideoEncodeAV1RateControlGroupKHR RateControlGroup;

        /// <summary>
        ///     <c>ConstantQIndex</c> is the quantizer index to use for the encoded frame if the current <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-rate-control-modes">rate control mode^</see> configured for the video session is <c>VK_VIDEO_ENCODE_RATE_CONTROL_MODE_DISABLED_BIT_KHR</c>.
        /// </summary>
        [FieldOffset(24)]
        public int ConstantQIndex;

        /// <summary>
        ///     <c>StdPictureInfo</c> is a pointer to a <c>StdVideoEncodeAV1PictureInfo</c> structure specifying <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-av1-picture-info">AV1 picture information^</see>.
        /// </summary>
        [FieldOffset(32)]
        public StdVideoEncodeAV1PictureInfo* StdPictureInfo;

        ///
        [FieldOffset(40)]
        public fixed int ReferenceNameSlotIndices[7];

        /// <summary>
        ///     <c>PrimaryReferenceCdfOnly</c> controls whether the primary reference frame indicated by the value of <c>pStdPictureInfo</c>-&gt;primary_ref_frame is used only for CDF data reference, as defined in sections 6.8.2 of the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#aomedia-av1">AV1 Specification^</see>. If set to <c>VK_TRUE</c>, then the primary reference frame&apos;s picture data will not be used for sample prediction.
        /// </summary>
        [FieldOffset(68)]
        public Brutal.Bool32 PrimaryReferenceCdfOnly;

        /// <summary>
        ///     <c>GenerateObuExtensionHeader</c> controls whether OBU extension headers are generated into the target bitstream, as defined in sections 5.3.1, 5.3.2, and 5.3.3 of the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#aomedia-av1">AV1 Specification^</see>.
        /// </summary>
        [FieldOffset(72)]
        public Brutal.Bool32 GenerateObuExtensionHeader;
    }
}
