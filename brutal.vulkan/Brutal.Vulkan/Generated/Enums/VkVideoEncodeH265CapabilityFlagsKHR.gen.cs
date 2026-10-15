namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH265CapabilityFlagBitsKHR.html">VkVideoEncodeH265CapabilityFlagBitsKHR</see> - Video encode H.265 capability flags
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which may: be set in
    ///         <c>VkVideoEncodeH265CapabilitiesKHR::flags</c>, indicating the H.265
    ///         encoding capabilities supported, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_encode_h265
    ///         typedef enum VkVideoEncodeH265CapabilityFlagBitsKHR {
    ///             VK_VIDEO_ENCODE_H265_CAPABILITY_HRD_COMPLIANCE_BIT_KHR = 0x00000001,
    ///             VK_VIDEO_ENCODE_H265_CAPABILITY_PREDICTION_WEIGHT_TABLE_GENERATED_BIT_KHR = 0x00000002,
    ///             VK_VIDEO_ENCODE_H265_CAPABILITY_ROW_UNALIGNED_SLICE_SEGMENT_BIT_KHR = 0x00000004,
    ///             VK_VIDEO_ENCODE_H265_CAPABILITY_DIFFERENT_SLICE_SEGMENT_TYPE_BIT_KHR = 0x00000008,
    ///             VK_VIDEO_ENCODE_H265_CAPABILITY_B_FRAME_IN_L0_LIST_BIT_KHR = 0x00000010,
    ///             VK_VIDEO_ENCODE_H265_CAPABILITY_B_FRAME_IN_L1_LIST_BIT_KHR = 0x00000020,
    ///             VK_VIDEO_ENCODE_H265_CAPABILITY_PER_PICTURE_TYPE_MIN_MAX_QP_BIT_KHR = 0x00000040,
    ///             VK_VIDEO_ENCODE_H265_CAPABILITY_PER_SLICE_SEGMENT_CONSTANT_QP_BIT_KHR = 0x00000080,
    ///             VK_VIDEO_ENCODE_H265_CAPABILITY_MULTIPLE_TILES_PER_SLICE_SEGMENT_BIT_KHR = 0x00000100,
    ///             VK_VIDEO_ENCODE_H265_CAPABILITY_MULTIPLE_SLICE_SEGMENTS_PER_TILE_BIT_KHR = 0x00000200,
    ///             // Provided by VK_KHR_video_encode_h265 with VK_KHR_video_encode_intra_refresh
    ///             VK_VIDEO_ENCODE_H265_CAPABILITY_B_PICTURE_INTRA_REFRESH_BIT_KHR = 0x00000800,
    ///             // Provided by VK_KHR_video_encode_h265 with VK_KHR_video_encode_quantization_map
    ///             VK_VIDEO_ENCODE_H265_CAPABILITY_CU_QP_DIFF_WRAPAROUND_BIT_KHR = 0x00000400,
    ///         } VkVideoEncodeH265CapabilityFlagBitsKHR;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkVideoEncodeH265CapabilityFlagsKHR : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>HrdComplianceBitKHR</c> specifies whether the implementation may: be able to generate HRD compliant bitstreams if any of the <c>nal_hrd_parameters_present_flag</c>, <c>vcl_hrd_parameters_present_flag</c>, or <c>sub_pic_hrd_params_present_flag</c> members of <c>StdVideoH265HrdFlags</c> are set to `1` in the HRD parameters of the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h265-active-vps">active VPS^</see> or <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h265-active-sps">active SPS^</see>, or if <c>StdVideoH265SpsVuiFlags::vui_hrd_parameters_present_flag</c> is set to `1` in the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h265-active-sps">active SPS^</see>.
        /// </summary>
        HrdComplianceBitKHR = 0x00000001,

        /// <summary>
        ///     <c>PredictionWeightTableGeneratedBitKHR</c>  specifies that if the <c>weighted_pred_flag</c> or the <c>weighted_bipred_flag</c> member of <c>StdVideoH265PpsFlags</c> is set to `1` in the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h265-active-pps">active PPS^</see> when encoding a <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h265-p-pic">P picture^</see> or <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h265-b-pic">B picture^</see>, respectively, then the implementation is able to internally decide syntax for <c>pred_weight_table</c>, as defined in section 7.4.7.3 of the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#itu-t-h265">ITU-T H.265 Specification^</see>, and the application is not required: to provide a weight table in the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h265-slice-segment-header-params">H.265 slice segment header parameters^</see>.
        /// </summary>
        PredictionWeightTableGeneratedBitKHR = 0x00000002,

        /// <summary>
        ///     <c>RowUnalignedSliceSegmentBitKHR</c>  specifies that each slice segment in a frame with a single or multiple tiles per slice may begin or finish at any offset in a CTB row. If not supported, all slice segments in such a frame <i>must</i> begin at the start of a CTB row (and hence each slice segment <i>must</i> finish at the end of a CTB row). Also indicates that each slice segment in a frame with multiple slices per tile may begin or finish at any offset within the enclosing tile&apos;s CTB row. If not supported, slice segments in such a frame <i>must</i> begin at the start of the enclosing tile&apos;s CTB row (and hence each slice segment <i>must</i> finish at the end of the enclosing tile&apos;s CTB row).
        /// </summary>
        RowUnalignedSliceSegmentBitKHR = 0x00000004,

        /// <summary>
        ///     <c>DifferentSliceSegmentTypeBitKHR</c>  specifies that when a frame is encoded with multiple slice segments, the implementation allows encoding each slice segment with a different <c>StdVideoEncodeH265SliceSegmentHeader::slice_type</c> specified in the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h265-slice-segment-header-params">H.265 slice segment header parameters^</see>. If not supported, all slice segments of the frame <i>must</i> be encoded with the same <c>slice_type</c> which corresponds to the picture type of the frame.
        /// </summary>
        DifferentSliceSegmentTypeBitKHR = 0x00000008,

        /// <summary>
        ///     <c>BFrameInL0ListBitKHR</c>  specifies support for using a <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h265-b-pic">B frame^</see> as L0 reference, as specified in <c>StdVideoEncodeH265ReferenceListsInfo::RefPicList0</c> in the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h265-picture-info">H.265 picture information^</see>.
        /// </summary>
        BFrameInL0ListBitKHR = 0x00000010,

        /// <summary>
        ///     <c>BFrameInL1ListBitKHR</c>  specifies support for using a <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h265-b-pic">B frame^</see> as L1 reference, as specified in <c>StdVideoEncodeH265ReferenceListsInfo::RefPicList1</c> in the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h265-picture-info">H.265 picture information^</see>.
        /// </summary>
        BFrameInL1ListBitKHR = 0x00000020,

        /// <summary>
        ///     <c>PerPictureTypeMinMaxQpBitKHR</c>  specifies support for specifying different QP values in the members of <c>VkVideoEncodeH265QpKHR</c>.
        /// </summary>
        PerPictureTypeMinMaxQpBitKHR = 0x00000040,

        /// <summary>
        ///     <c>PerSliceSegmentConstantQpBitKHR</c>  specifies support for specifying different constant QP values for each slice segment.
        /// </summary>
        PerSliceSegmentConstantQpBitKHR = 0x00000080,

        /// <summary>
        ///     <c>MultipleTilesPerSliceSegmentBitKHR</c>  specifies whether encoding multiple tiles per slice segment, as defined in section 6.3.1 of the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#itu-t-h265">ITU-T H.265 Specification^</see>, is supported. If this capability flag is not present, then the implementation is only able to encode a single tile for each slice segment.
        /// </summary>
        MultipleTilesPerSliceSegmentBitKHR = 0x00000100,

        /// <summary>
        ///     <c>MultipleSliceSegmentsPerTileBitKHR</c>  specifies whether encoding multiple slice segments per tile, as defined in section 6.3.1 of the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#itu-t-h265">ITU-T H.265 Specification^</see>, is supported. If this capability flag is not present, then the implementation is only able to encode a single slice segment for each tile.
        /// </summary>
        MultipleSliceSegmentsPerTileBitKHR = 0x00000200,

        /// <summary>
        ///     <c>BPictureIntraRefreshBitKHR</c>
        /// </summary>
        BPictureIntraRefreshBitKHR = 0x00000800,

        /// <summary>
        ///     <c>CuQpDiffWraparoundBitKHR</c>
        /// </summary>
        CuQpDiffWraparoundBitKHR = 0x00000400,

        /// <summary>
        ///     <c>FlagBitsMaxEnumKHR</c>
        /// </summary>
        FlagBitsMaxEnumKHR = 0x7FFFFFFF,
    }
}
