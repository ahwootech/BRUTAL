namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeAV1StdFlagBitsKHR.html">VkVideoEncodeAV1StdFlagBitsKHR</see> - Video encode AV1 syntax capability flags
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which may: be set in
    ///         <c>VkVideoEncodeAV1CapabilitiesKHR::stdSyntaxFlags</c>, indicating the
    ///         capabilities related to the AV1 syntax elements, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_encode_av1
    ///         typedef enum VkVideoEncodeAV1StdFlagBitsKHR {
    ///             VK_VIDEO_ENCODE_AV1_STD_UNIFORM_TILE_SPACING_FLAG_SET_BIT_KHR = 0x00000001,
    ///             VK_VIDEO_ENCODE_AV1_STD_SKIP_MODE_PRESENT_UNSET_BIT_KHR = 0x00000002,
    ///             VK_VIDEO_ENCODE_AV1_STD_PRIMARY_REF_FRAME_BIT_KHR = 0x00000004,
    ///             VK_VIDEO_ENCODE_AV1_STD_DELTA_Q_BIT_KHR = 0x00000008,
    ///         } VkVideoEncodeAV1StdFlagBitsKHR;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkVideoEncodeAV1StdFlagsKHR : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>UniformTileSpacingFlagSetBitKHR</c>  specifies whether the implementation supports using the application-provided value for <c>StdVideoAV1TileInfoFlags::uniform_tile_spacing_flag</c> in the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-av1-tile-params">AV1 tile parameters^</see> when that value is `1`, regardless of the coded extent of the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-input-picture">encode input picture^</see> and the number of tile columns and rows requested in the <c>TileCols</c> and <c>TileRows</c> members of <c>StdVideoAV1TileInfo</c>.
        /// </summary>
        UniformTileSpacingFlagSetBitKHR = 0x00000001,

        /// <summary>
        ///     <c>SkipModePresentUnsetBitKHR</c> specifies whether the implementation supports using the application-provided value for <c>StdVideoEncodeAV1PictureInfoFlags::skip_mode_present</c> when that value is `0`.
        /// </summary>
        SkipModePresentUnsetBitKHR = 0x00000002,

        /// <summary>
        ///     <c>PrimaryRefFrameBitKHR</c> specifies whether the implementation supports using the application-provided value for <c>StdVideoEncodeAV1PictureInfo::primary_ref_frame</c>.
        /// </summary>
        PrimaryRefFrameBitKHR = 0x00000004,

        /// <summary>
        ///     <c>DeltaQBitKHR</c> specifies whether the implementation supports using the application-provided values for the <c>DeltaQYDc</c>, <c>DeltaQUDc</c>, <c>DeltaQUAc</c>, <c>DeltaQVDc</c>, and <c>DeltaQVAc</c> members of <c>StdVideoAV1Quantization</c>.  These capability flags provide information to the application about specific AV1 syntax element values that the implementation supports without having to <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-av1-overrides">override^</see> them and do not otherwise restrict the values that the application <i>can</i> specify for any of the mentioned AV1 syntax elements.
        /// </summary>
        DeltaQBitKHR = 0x00000008,

        /// <summary>
        ///     <c>FlagBitsMaxEnumKHR</c>
        /// </summary>
        FlagBitsMaxEnumKHR = 0x7FFFFFFF,
    }
}
