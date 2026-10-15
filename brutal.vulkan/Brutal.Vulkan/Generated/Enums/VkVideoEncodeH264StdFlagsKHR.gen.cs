namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH264StdFlagBitsKHR.html">VkVideoEncodeH264StdFlagBitsKHR</see> - Video encode H.264 syntax capability flags
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which may: be set in
    ///         <c>VkVideoEncodeH264CapabilitiesKHR::stdSyntaxFlags</c>, indicating the
    ///         capabilities related to the H.264 syntax elements, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_encode_h264
    ///         typedef enum VkVideoEncodeH264StdFlagBitsKHR {
    ///             VK_VIDEO_ENCODE_H264_STD_SEPARATE_COLOR_PLANE_FLAG_SET_BIT_KHR = 0x00000001,
    ///             VK_VIDEO_ENCODE_H264_STD_QPPRIME_Y_ZERO_TRANSFORM_BYPASS_FLAG_SET_BIT_KHR = 0x00000002,
    ///             VK_VIDEO_ENCODE_H264_STD_SCALING_MATRIX_PRESENT_FLAG_SET_BIT_KHR = 0x00000004,
    ///             VK_VIDEO_ENCODE_H264_STD_CHROMA_QP_INDEX_OFFSET_BIT_KHR = 0x00000008,
    ///             VK_VIDEO_ENCODE_H264_STD_SECOND_CHROMA_QP_INDEX_OFFSET_BIT_KHR = 0x00000010,
    ///             VK_VIDEO_ENCODE_H264_STD_PIC_INIT_QP_MINUS26_BIT_KHR = 0x00000020,
    ///             VK_VIDEO_ENCODE_H264_STD_WEIGHTED_PRED_FLAG_SET_BIT_KHR = 0x00000040,
    ///             VK_VIDEO_ENCODE_H264_STD_WEIGHTED_BIPRED_IDC_EXPLICIT_BIT_KHR = 0x00000080,
    ///             VK_VIDEO_ENCODE_H264_STD_WEIGHTED_BIPRED_IDC_IMPLICIT_BIT_KHR = 0x00000100,
    ///             VK_VIDEO_ENCODE_H264_STD_TRANSFORM_8X8_MODE_FLAG_SET_BIT_KHR = 0x00000200,
    ///             VK_VIDEO_ENCODE_H264_STD_DIRECT_SPATIAL_MV_PRED_FLAG_UNSET_BIT_KHR = 0x00000400,
    ///             VK_VIDEO_ENCODE_H264_STD_ENTROPY_CODING_MODE_FLAG_UNSET_BIT_KHR = 0x00000800,
    ///             VK_VIDEO_ENCODE_H264_STD_ENTROPY_CODING_MODE_FLAG_SET_BIT_KHR = 0x00001000,
    ///             VK_VIDEO_ENCODE_H264_STD_DIRECT_8X8_INFERENCE_FLAG_UNSET_BIT_KHR = 0x00002000,
    ///             VK_VIDEO_ENCODE_H264_STD_CONSTRAINED_INTRA_PRED_FLAG_SET_BIT_KHR = 0x00004000,
    ///             VK_VIDEO_ENCODE_H264_STD_DEBLOCKING_FILTER_DISABLED_BIT_KHR = 0x00008000,
    ///             VK_VIDEO_ENCODE_H264_STD_DEBLOCKING_FILTER_ENABLED_BIT_KHR = 0x00010000,
    ///             VK_VIDEO_ENCODE_H264_STD_DEBLOCKING_FILTER_PARTIAL_BIT_KHR = 0x00020000,
    ///             VK_VIDEO_ENCODE_H264_STD_SLICE_QP_DELTA_BIT_KHR = 0x00080000,
    ///             VK_VIDEO_ENCODE_H264_STD_DIFFERENT_SLICE_QP_DELTA_BIT_KHR = 0x00100000,
    ///         } VkVideoEncodeH264StdFlagBitsKHR;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkVideoEncodeH264StdFlagsKHR : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>SeparateColorPlaneFlagSetBitKHR</c>  specifies whether the implementation supports using the application-provided value for <c>StdVideoH264SpsFlags::separate_colour_plane_flag</c> in the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h264-sps">SPS^</see> when that value is `1`.
        /// </summary>
        SeparateColorPlaneFlagSetBitKHR = 0x00000001,

        /// <summary>
        ///     <c>QpprimeYZeroTransformBypassFlagSetBitKHR</c>  specifies whether the implementation supports using the application-provided value for <c>StdVideoH264SpsFlags::qpprime_y_zero_transform_bypass_flag</c> in the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h264-sps">SPS^</see> when that value is `1`.
        /// </summary>
        QpprimeYZeroTransformBypassFlagSetBitKHR = 0x00000002,

        /// <summary>
        ///     <c>ScalingMatrixPresentFlagSetBitKHR</c>  specifies whether the implementation supports using the application-provided values for <c>StdVideoH264SpsFlags::seq_scaling_matrix_present_flag</c> in the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h264-sps">SPS^</see> and <c>StdVideoH264PpsFlags::pic_scaling_matrix_present_flag</c> in the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h264-pps">PPS^</see> when any of those values are `1`.
        /// </summary>
        ScalingMatrixPresentFlagSetBitKHR = 0x00000004,

        /// <summary>
        ///     <c>ChromaQpIndexOffsetBitKHR</c> specifies whether the implementation supports using the application-provided value for <c>StdVideoH264PictureParameterSet::chroma_qp_index_offset</c> in the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h264-pps">PPS^</see> when that value is non-zero.
        /// </summary>
        ChromaQpIndexOffsetBitKHR = 0x00000008,

        /// <summary>
        ///     <c>SecondChromaQpIndexOffsetBitKHR</c>  specifies whether the implementation supports using the application-provided value for <c>StdVideoH264PictureParameterSet::second_chroma_qp_index_offset</c> in the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h264-pps">PPS^</see> when that value is non-zero.
        /// </summary>
        SecondChromaQpIndexOffsetBitKHR = 0x00000010,

        /// <summary>
        ///     <c>PicInitQpMinus26BitKHR</c> specifies whether the implementation supports using the application-provided value for <c>StdVideoH264PictureParameterSet::pic_init_qp_minus26</c> in the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h264-pps">PPS^</see> when that value is non-zero.
        /// </summary>
        PicInitQpMinus26BitKHR = 0x00000020,

        /// <summary>
        ///     <c>WeightedPredFlagSetBitKHR</c> specifies whether the implementation supports using the application-provided value for <c>StdVideoH264PpsFlags::weighted_pred_flag</c> in the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h264-pps">PPS^</see> when that value is `1`.
        /// </summary>
        WeightedPredFlagSetBitKHR = 0x00000040,

        /// <summary>
        ///     <c>WeightedBipredIdcExplicitBitKHR</c>  specifies whether the implementation supports using the application-provided value for <c>StdVideoH264PictureParameterSet::weighted_bipred_idc</c> in the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h264-pps">PPS^</see> when that value is <c>STD_VIDEO_H264_WEIGHTED_BIPRED_IDC_EXPLICIT</c>.
        /// </summary>
        WeightedBipredIdcExplicitBitKHR = 0x00000080,

        /// <summary>
        ///     <c>WeightedBipredIdcImplicitBitKHR</c>  specifies whether the implementation supports using the application-provided value for <c>StdVideoH264PictureParameterSet::weighted_bipred_idc</c> in the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h264-pps">PPS^</see> when that value is <c>STD_VIDEO_H264_WEIGHTED_BIPRED_IDC_IMPLICIT</c>.
        /// </summary>
        WeightedBipredIdcImplicitBitKHR = 0x00000100,

        /// <summary>
        ///     <c>Transform8X8ModeFlagSetBitKHR</c>  specifies whether the implementation supports using the application-provided value for <c>StdVideoH264PpsFlags::transform_8x8_mode_flag</c> in the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h264-pps">PPS^</see> when that value is `1`.
        /// </summary>
        Transform8X8ModeFlagSetBitKHR = 0x00000200,

        /// <summary>
        ///     <c>DirectSpatialMvPredFlagUnsetBitKHR</c>  specifies whether the implementation supports using the application-provided value for <c>StdVideoEncodeH264SliceHeaderFlags::direct_spatial_mv_pred_flag</c> in the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h264-slice-header-params">H.264 slice header parameters^</see> when that value is `0`.
        /// </summary>
        DirectSpatialMvPredFlagUnsetBitKHR = 0x00000400,

        /// <summary>
        ///     <c>EntropyCodingModeFlagUnsetBitKHR</c>  specifies whether the implementation supports CAVLC entropy coding, as defined in section 9.2 of the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#itu-t-h264">ITU-T H.264 Specification^</see>, and thus supports using the application-provided value for <c>StdVideoH264PpsFlags::entropy_coding_mode_flag</c> in the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h264-pps">PPS^</see> when that value is `0`.
        /// </summary>
        EntropyCodingModeFlagUnsetBitKHR = 0x00000800,

        /// <summary>
        ///     <c>EntropyCodingModeFlagSetBitKHR</c>  specifies whether the implementation supports CABAC entropy coding, as defined in section 9.3 of the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#itu-t-h264">ITU-T H.264 Specification^</see>, and thus supports using the application-provided value for <c>StdVideoH264PpsFlags::entropy_coding_mode_flag</c> in the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h264-pps">PPS^</see> when that value is `1`.
        /// </summary>
        EntropyCodingModeFlagSetBitKHR = 0x00001000,

        /// <summary>
        ///     <c>Direct8X8InferenceFlagUnsetBitKHR</c>  specifies whether the implementation supports using the application-provided value for <c>StdVideoH264SpsFlags::direct_8x8_inference_flag</c> in the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h264-sps">SPS^</see> when that value is `0`.
        /// </summary>
        Direct8X8InferenceFlagUnsetBitKHR = 0x00002000,

        /// <summary>
        ///     <c>ConstrainedIntraPredFlagSetBitKHR</c>  specifies whether the implementation supports using the application-provided value for <c>StdVideoH264PpsFlags::constrained_intra_pred_flag</c> in the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h264-pps">PPS^</see> when that value is `1`.
        /// </summary>
        ConstrainedIntraPredFlagSetBitKHR = 0x00004000,

        /// <summary>
        ///     <c>DeblockingFilterDisabledBitKHR</c>  specifies whether the implementation supports using the application-provided value for <c>StdVideoEncodeH264SliceHeader::disable_deblocking_filter_idc</c> in the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h264-slice-header-params">H.264 slice header parameters^</see> when that value is <c>STD_VIDEO_H264_DISABLE_DEBLOCKING_FILTER_IDC_DISABLED</c>.
        /// </summary>
        DeblockingFilterDisabledBitKHR = 0x00008000,

        /// <summary>
        ///     <c>DeblockingFilterEnabledBitKHR</c>  specifies whether the implementation supports using the application-provided value for <c>StdVideoEncodeH264SliceHeader::disable_deblocking_filter_idc</c> in the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h264-slice-header-params">H.264 slice header parameters^</see> when that value is <c>STD_VIDEO_H264_DISABLE_DEBLOCKING_FILTER_IDC_ENABLED</c>.
        /// </summary>
        DeblockingFilterEnabledBitKHR = 0x00010000,

        /// <summary>
        ///     <c>DeblockingFilterPartialBitKHR</c>  specifies whether the implementation supports using the application-provided value for <c>StdVideoEncodeH264SliceHeader::disable_deblocking_filter_idc</c> in the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h264-slice-header-params">H.264 slice header parameters^</see> when that value is <c>STD_VIDEO_H264_DISABLE_DEBLOCKING_FILTER_IDC_PARTIAL</c>.
        /// </summary>
        DeblockingFilterPartialBitKHR = 0x00020000,

        /// <summary>
        ///     <c>SliceQpDeltaBitKHR</c> specifies whether the implementation supports using the application-provided value for <c>StdVideoEncodeH264SliceHeader::slice_qp_delta</c> in the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h264-slice-header-params">H.264 slice header parameters^</see> when that value is identical across the slices of the encoded frame.
        /// </summary>
        SliceQpDeltaBitKHR = 0x00080000,

        /// <summary>
        ///     <c>DifferentSliceQpDeltaBitKHR</c>  specifies whether the implementation supports using the application-provided value for <c>StdVideoEncodeH264SliceHeader::slice_qp_delta</c> in the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h264-slice-header-params">H.264 slice header parameters^</see> when that value is different across the slices of the encoded frame.  These capability flags provide information to the application about specific H.264 syntax element values that the implementation supports without having to <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h264-overrides">override^</see> them and do not otherwise restrict the values that the application <i>can</i> specify for any of the mentioned H.264 syntax elements.
        /// </summary>
        DifferentSliceQpDeltaBitKHR = 0x00100000,

        /// <summary>
        ///     <c>FlagBitsMaxEnumKHR</c>
        /// </summary>
        FlagBitsMaxEnumKHR = 0x7FFFFFFF,
    }
}
