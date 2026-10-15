namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH264CapabilityFlagBitsKHR.html">VkVideoEncodeH264CapabilityFlagBitsKHR</see> - H.264 encode capability flags
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which may: be set in
    ///         <c>VkVideoEncodeH264CapabilitiesKHR::flags</c>, indicating the H.264
    ///         encoding capabilities supported, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_encode_h264
    ///         typedef enum VkVideoEncodeH264CapabilityFlagBitsKHR {
    ///             VK_VIDEO_ENCODE_H264_CAPABILITY_HRD_COMPLIANCE_BIT_KHR = 0x00000001,
    ///             VK_VIDEO_ENCODE_H264_CAPABILITY_PREDICTION_WEIGHT_TABLE_GENERATED_BIT_KHR = 0x00000002,
    ///             VK_VIDEO_ENCODE_H264_CAPABILITY_ROW_UNALIGNED_SLICE_BIT_KHR = 0x00000004,
    ///             VK_VIDEO_ENCODE_H264_CAPABILITY_DIFFERENT_SLICE_TYPE_BIT_KHR = 0x00000008,
    ///             VK_VIDEO_ENCODE_H264_CAPABILITY_B_FRAME_IN_L0_LIST_BIT_KHR = 0x00000010,
    ///             VK_VIDEO_ENCODE_H264_CAPABILITY_B_FRAME_IN_L1_LIST_BIT_KHR = 0x00000020,
    ///             VK_VIDEO_ENCODE_H264_CAPABILITY_PER_PICTURE_TYPE_MIN_MAX_QP_BIT_KHR = 0x00000040,
    ///             VK_VIDEO_ENCODE_H264_CAPABILITY_PER_SLICE_CONSTANT_QP_BIT_KHR = 0x00000080,
    ///             VK_VIDEO_ENCODE_H264_CAPABILITY_GENERATE_PREFIX_NALU_BIT_KHR = 0x00000100,
    ///             // Provided by VK_KHR_video_encode_h264 with VK_KHR_video_encode_intra_refresh
    ///             VK_VIDEO_ENCODE_H264_CAPABILITY_B_PICTURE_INTRA_REFRESH_BIT_KHR = 0x00000400,
    ///             // Provided by VK_KHR_video_encode_h264 with VK_KHR_video_encode_quantization_map
    ///             VK_VIDEO_ENCODE_H264_CAPABILITY_MB_QP_DIFF_WRAPAROUND_BIT_KHR = 0x00000200,
    ///         } VkVideoEncodeH264CapabilityFlagBitsKHR;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkVideoEncodeH264CapabilityFlagsKHR : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>HrdComplianceBitKHR</c> specifies whether the implementation may: be able to generate HRD compliant bitstreams if any of the <c>nal_hrd_parameters_present_flag</c> or <c>vcl_hrd_parameters_present_flag</c> members of <c>StdVideoH264SpsVuiFlags</c> are set to `1` in the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h264-active-sps">active SPS^</see>.
        /// </summary>
        HrdComplianceBitKHR = 0x00000001,

        /// <summary>
        ///     <c>PredictionWeightTableGeneratedBitKHR</c>  specifies that if <c>StdVideoH264PpsFlags::weighted_pred_flag</c> is set to `1` or <c>StdVideoH264PictureParameterSet::weighted_bipred_idc</c> is set to <c>STD_VIDEO_H264_WEIGHTED_BIPRED_IDC_EXPLICIT</c> in the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h264-active-pps">active PPS^</see> when encoding a <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h264-p-pic">P picture^</see> or <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h264-b-pic">B picture^</see>, respectively, then the implementation is able to internally decide syntax for <c>pred_weight_table</c>, as defined in section 7.4.3.2 of the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#itu-t-h264">ITU-T H.264 Specification^</see>, and the application is not required: to provide a weight table in the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h264-slice-header-params">H.264 slice header parameters^</see>.
        /// </summary>
        PredictionWeightTableGeneratedBitKHR = 0x00000002,

        /// <summary>
        ///     <c>RowUnalignedSliceBitKHR</c>  specifies that each slice in a frame with multiple slices may begin or finish at any offset in a macroblock row. If not supported, all slices in the frame <i>must</i> begin at the start of a macroblock row (and hence each slice <i>must</i> finish at the end of a macroblock row).
        /// </summary>
        RowUnalignedSliceBitKHR = 0x00000004,

        /// <summary>
        ///     <c>DifferentSliceTypeBitKHR</c>  specifies that when a frame is encoded with multiple slices, the implementation allows encoding each slice with a different <c>StdVideoEncodeH264SliceHeader::slice_type</c> specified in the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h264-slice-header-params">H.264 slice header parameters^</see>. If not supported, all slices of the frame <i>must</i> be encoded with the same <c>slice_type</c> which corresponds to the picture type of the frame.
        /// </summary>
        DifferentSliceTypeBitKHR = 0x00000008,

        /// <summary>
        ///     <c>BFrameInL0ListBitKHR</c>  specifies support for using a <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h264-b-pic">B frame^</see> as L0 reference, as specified in <c>StdVideoEncodeH264ReferenceListsInfo::RefPicList0</c> in the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h264-picture-info">H.264 picture information^</see>.
        /// </summary>
        BFrameInL0ListBitKHR = 0x00000010,

        /// <summary>
        ///     <c>BFrameInL1ListBitKHR</c>  specifies support for using a <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h264-b-pic">B frame^</see> as L1 reference, as specified in <c>StdVideoEncodeH264ReferenceListsInfo::RefPicList1</c> in the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h264-picture-info">H.264 picture information^</see>.
        /// </summary>
        BFrameInL1ListBitKHR = 0x00000020,

        /// <summary>
        ///     <c>PerPictureTypeMinMaxQpBitKHR</c>  specifies support for specifying different QP values in the members of <c>VkVideoEncodeH264QpKHR</c>.
        /// </summary>
        PerPictureTypeMinMaxQpBitKHR = 0x00000040,

        /// <summary>
        ///     <c>PerSliceConstantQpBitKHR</c>  specifies support for specifying different constant QP values for each slice.
        /// </summary>
        PerSliceConstantQpBitKHR = 0x00000080,

        /// <summary>
        ///     <c>GeneratePrefixNaluBitKHR</c>  specifies support for generating prefix NAL units by setting <c>VkVideoEncodeH264PictureInfoKHR::generatePrefixNalu</c> to <c>VK_TRUE</c>.
        /// </summary>
        GeneratePrefixNaluBitKHR = 0x00000100,

        /// <summary>
        ///     <c>BPictureIntraRefreshBitKHR</c>
        /// </summary>
        BPictureIntraRefreshBitKHR = 0x00000400,

        /// <summary>
        ///     <c>MbQpDiffWraparoundBitKHR</c>
        /// </summary>
        MbQpDiffWraparoundBitKHR = 0x00000200,

        /// <summary>
        ///     <c>FlagBitsMaxEnumKHR</c>
        /// </summary>
        FlagBitsMaxEnumKHR = 0x7FFFFFFF,
    }
}
