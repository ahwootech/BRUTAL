namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH265StdFlagBitsKHR.html">VkVideoEncodeH265StdFlagBitsKHR</see> - Video encode H.265 syntax capability flags
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which may: be set in
    ///         <c>VkVideoEncodeH265CapabilitiesKHR::stdSyntaxFlags</c>, indicating the
    ///         capabilities related to the H.265 syntax elements, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_encode_h265
    ///         typedef enum VkVideoEncodeH265StdFlagBitsKHR {
    ///             VK_VIDEO_ENCODE_H265_STD_SEPARATE_COLOR_PLANE_FLAG_SET_BIT_KHR = 0x00000001,
    ///             VK_VIDEO_ENCODE_H265_STD_SAMPLE_ADAPTIVE_OFFSET_ENABLED_FLAG_SET_BIT_KHR = 0x00000002,
    ///             VK_VIDEO_ENCODE_H265_STD_SCALING_LIST_DATA_PRESENT_FLAG_SET_BIT_KHR = 0x00000004,
    ///             VK_VIDEO_ENCODE_H265_STD_PCM_ENABLED_FLAG_SET_BIT_KHR = 0x00000008,
    ///             VK_VIDEO_ENCODE_H265_STD_SPS_TEMPORAL_MVP_ENABLED_FLAG_SET_BIT_KHR = 0x00000010,
    ///             VK_VIDEO_ENCODE_H265_STD_INIT_QP_MINUS26_BIT_KHR = 0x00000020,
    ///             VK_VIDEO_ENCODE_H265_STD_WEIGHTED_PRED_FLAG_SET_BIT_KHR = 0x00000040,
    ///             VK_VIDEO_ENCODE_H265_STD_WEIGHTED_BIPRED_FLAG_SET_BIT_KHR = 0x00000080,
    ///             VK_VIDEO_ENCODE_H265_STD_LOG2_PARALLEL_MERGE_LEVEL_MINUS2_BIT_KHR = 0x00000100,
    ///             VK_VIDEO_ENCODE_H265_STD_SIGN_DATA_HIDING_ENABLED_FLAG_SET_BIT_KHR = 0x00000200,
    ///             VK_VIDEO_ENCODE_H265_STD_TRANSFORM_SKIP_ENABLED_FLAG_SET_BIT_KHR = 0x00000400,
    ///             VK_VIDEO_ENCODE_H265_STD_TRANSFORM_SKIP_ENABLED_FLAG_UNSET_BIT_KHR = 0x00000800,
    ///             VK_VIDEO_ENCODE_H265_STD_PPS_SLICE_CHROMA_QP_OFFSETS_PRESENT_FLAG_SET_BIT_KHR = 0x00001000,
    ///             VK_VIDEO_ENCODE_H265_STD_TRANSQUANT_BYPASS_ENABLED_FLAG_SET_BIT_KHR = 0x00002000,
    ///             VK_VIDEO_ENCODE_H265_STD_CONSTRAINED_INTRA_PRED_FLAG_SET_BIT_KHR = 0x00004000,
    ///             VK_VIDEO_ENCODE_H265_STD_ENTROPY_CODING_SYNC_ENABLED_FLAG_SET_BIT_KHR = 0x00008000,
    ///             VK_VIDEO_ENCODE_H265_STD_DEBLOCKING_FILTER_OVERRIDE_ENABLED_FLAG_SET_BIT_KHR = 0x00010000,
    ///             VK_VIDEO_ENCODE_H265_STD_DEPENDENT_SLICE_SEGMENTS_ENABLED_FLAG_SET_BIT_KHR = 0x00020000,
    ///             VK_VIDEO_ENCODE_H265_STD_DEPENDENT_SLICE_SEGMENT_FLAG_SET_BIT_KHR = 0x00040000,
    ///             VK_VIDEO_ENCODE_H265_STD_SLICE_QP_DELTA_BIT_KHR = 0x00080000,
    ///             VK_VIDEO_ENCODE_H265_STD_DIFFERENT_SLICE_QP_DELTA_BIT_KHR = 0x00100000,
    ///         } VkVideoEncodeH265StdFlagBitsKHR;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkVideoEncodeH265StdFlagsKHR : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>SeparateColorPlaneFlagSetBitKHR</c>  specifies whether the implementation supports using the application-provided value for <c>StdVideoH265SpsFlags::separate_colour_plane_flag</c> in the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h265-sps">SPS^</see> when that value is `1`.
        /// </summary>
        SeparateColorPlaneFlagSetBitKHR = 0x00000001,

        /// <summary>
        ///     <c>SampleAdaptiveOffsetEnabledFlagSetBitKHR</c>  specifies whether the implementation supports using the application-provided value for <c>StdVideoH265SpsFlags::sample_adaptive_offset_enabled_flag</c> in the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h265-sps">SPS^</see> when that value is `1`.
        /// </summary>
        SampleAdaptiveOffsetEnabledFlagSetBitKHR = 0x00000002,

        /// <summary>
        ///     <c>ScalingListDataPresentFlagSetBitKHR</c>  specifies whether the implementation supports using the application-provided value for the <c>scaling_list_enabled_flag</c> and <c>sps_scaling_list_data_present_flag</c> members of <c>StdVideoH265SpsFlags</c> in the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h265-sps">SPS^</see>, and the application-provided value for <c>StdVideoH265PpsFlags::pps_scaling_list_data_present_flag</c> in the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h265-pps">PPS^</see> when those values are `1`.
        /// </summary>
        ScalingListDataPresentFlagSetBitKHR = 0x00000004,

        /// <summary>
        ///     <c>PcmEnabledFlagSetBitKHR</c> specifies whether the implementation supports using the application-provided value for <c>StdVideoH265SpsFlags::pcm_enable_flag</c> in the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h265-sps">SPS^</see> when that value is `1`.
        /// </summary>
        PcmEnabledFlagSetBitKHR = 0x00000008,

        /// <summary>
        ///     <c>SpsTemporalMvpEnabledFlagSetBitKHR</c>  specifies whether the implementation supports using the application-provided value for <c>StdVideoH265SpsFlags::sps_temporal_mvp_enabled_flag</c> in the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h265-sps">SPS^</see> when that value is `1`.
        /// </summary>
        SpsTemporalMvpEnabledFlagSetBitKHR = 0x00000010,

        /// <summary>
        ///     <c>InitQpMinus26BitKHR</c> specifies whether the implementation supports using the application-provided value for <c>StdVideoH265PictureParameterSet::init_qp_minus26</c> in the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h265-pps">PPS^</see> when that value is non-zero.
        /// </summary>
        InitQpMinus26BitKHR = 0x00000020,

        /// <summary>
        ///     <c>WeightedPredFlagSetBitKHR</c> specifies whether the implementation supports using the application-provided value for <c>StdVideoH265PpsFlags::weighted_pred_flag</c> in the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h265-pps">PPS^</see> when that value is `1`.
        /// </summary>
        WeightedPredFlagSetBitKHR = 0x00000040,

        /// <summary>
        ///     <c>WeightedBipredFlagSetBitKHR</c>  specifies whether the implementation supports using the application-provided value for <c>StdVideoH265PpsFlags::weighted_bipred_flag</c> in the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h265-pps">PPS^</see> when that value is `1`.
        /// </summary>
        WeightedBipredFlagSetBitKHR = 0x00000080,

        /// <summary>
        ///     <c>Log2ParallelMergeLevelMinus2BitKHR</c>  specifies whether the implementation supports using the application-provided value for <c>StdVideoH265PictureParameterSet::log2_parallel_merge_level_minus2</c> in the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h265-pps">PPS^</see> when that value is non-zero.
        /// </summary>
        Log2ParallelMergeLevelMinus2BitKHR = 0x00000100,

        /// <summary>
        ///     <c>SignDataHidingEnabledFlagSetBitKHR</c>  specifies whether the implementation supports using the application-provided value for <c>StdVideoH265PpsFlags::sign_data_hiding_enabled_flag</c> in the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h265-pps">PPS^</see> when that value is `1`.
        /// </summary>
        SignDataHidingEnabledFlagSetBitKHR = 0x00000200,

        /// <summary>
        ///     <c>TransformSkipEnabledFlagSetBitKHR</c>  specifies whether the implementation supports using the application-provided value for <c>StdVideoH265PpsFlags::transform_skip_enabled_flag</c> in the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h265-pps">PPS^</see> when that value is `1`.
        /// </summary>
        TransformSkipEnabledFlagSetBitKHR = 0x00000400,

        /// <summary>
        ///     <c>TransformSkipEnabledFlagUnsetBitKHR</c>  specifies whether the implementation supports using the application-provided value for <c>StdVideoH265PpsFlags::transform_skip_enabled_flag</c> in the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h265-pps">PPS^</see> when that value is `0`.
        /// </summary>
        TransformSkipEnabledFlagUnsetBitKHR = 0x00000800,

        /// <summary>
        ///     <c>PpsSliceChromaQpOffsetsPresentFlagSetBitKHR</c>  specifies whether the implementation supports using the application-provided value for <c>StdVideoH265PpsFlags::pps_slice_chroma_qp_offsets_present_flag</c> in the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h265-pps">PPS^</see> when that value is `1`.
        /// </summary>
        PpsSliceChromaQpOffsetsPresentFlagSetBitKHR = 0x00001000,

        /// <summary>
        ///     <c>TransquantBypassEnabledFlagSetBitKHR</c>  specifies whether the implementation supports using the application-provided value for <c>StdVideoH265PpsFlags::transquant_bypass_enabled_flag</c> in the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h265-pps">PPS^</see> when that value is `1`.
        /// </summary>
        TransquantBypassEnabledFlagSetBitKHR = 0x00002000,

        /// <summary>
        ///     <c>ConstrainedIntraPredFlagSetBitKHR</c>  specifies whether the implementation supports using the application-provided value for <c>StdVideoH265PpsFlags::constrained_intra_pred_flag</c> in the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h265-pps">PPS^</see> when that value is `1`.
        /// </summary>
        ConstrainedIntraPredFlagSetBitKHR = 0x00004000,

        /// <summary>
        ///     <c>EntropyCodingSyncEnabledFlagSetBitKHR</c>  specifies whether the implementation supports using the application-provided value for <c>StdVideoH265PpsFlags::entropy_coding_sync_enabled_flag</c> in the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h265-pps">PPS^</see> when that value is `1`.
        /// </summary>
        EntropyCodingSyncEnabledFlagSetBitKHR = 0x00008000,

        /// <summary>
        ///     <c>DeblockingFilterOverrideEnabledFlagSetBitKHR</c>  specifies whether the implementation supports using the application-provided value for <c>StdVideoH265PpsFlags::deblocking_filter_override_enabled_flag</c> in the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h265-pps">PPS^</see> when that value is `1`.
        /// </summary>
        DeblockingFilterOverrideEnabledFlagSetBitKHR = 0x00010000,

        /// <summary>
        ///     <c>DependentSliceSegmentsEnabledFlagSetBitKHR</c>  specifies whether the implementation supports using the application-provided value for <c>StdVideoH265PpsFlags::dependent_slice_segments_enabled_flag</c> in the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h265-pps">PPS^</see> when that value is `1`.
        /// </summary>
        DependentSliceSegmentsEnabledFlagSetBitKHR = 0x00020000,

        /// <summary>
        ///     <c>DependentSliceSegmentFlagSetBitKHR</c>  specifies whether the implementation supports using the application-provided value for <c>StdVideoEncodeH265SliceSegmentHeader::dependent_slice_segment_flag</c> in the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h265-slice-segment-header-params">H.265 slice segment header parameters^</see> when that value is `1`.
        /// </summary>
        DependentSliceSegmentFlagSetBitKHR = 0x00040000,

        /// <summary>
        ///     <c>SliceQpDeltaBitKHR</c> specifies whether the implementation supports using the application-provided value for <c>StdVideoEncodeH265SliceSegmentHeader::slice_qp_delta</c> in the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h265-slice-segment-header-params">H.265 slice segment header parameters^</see> when that value is identical across the slice segments of the encoded frame.
        /// </summary>
        SliceQpDeltaBitKHR = 0x00080000,

        /// <summary>
        ///     <c>DifferentSliceQpDeltaBitKHR</c>  specifies whether the implementation supports using the application-provided value for <c>StdVideoEncodeH265SliceSegmentHeader::slice_qp_delta</c> in the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h265-slice-segment-header-params">H.265 slice segment header parameters^</see> when that value is different across the slice segments of the encoded frame.  These capability flags provide information to the application about specific H.265 syntax element values that the implementation supports without having to <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h265-overrides">override^</see> them and do not otherwise restrict the values that the application <i>can</i> specify for any of the mentioned H.265 syntax elements.
        /// </summary>
        DifferentSliceQpDeltaBitKHR = 0x00100000,

        /// <summary>
        ///     <c>FlagBitsMaxEnumKHR</c>
        /// </summary>
        FlagBitsMaxEnumKHR = 0x7FFFFFFF,
    }
}
