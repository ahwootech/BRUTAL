namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeIntraRefreshModeFlagBitsKHR.html">VkVideoEncodeIntraRefreshModeFlagBitsKHR</see> - Video encode intra refresh modes
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The intra refresh modes are defined with the following enums:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_encode_intra_refresh
    ///         typedef enum VkVideoEncodeIntraRefreshModeFlagBitsKHR {
    ///             VK_VIDEO_ENCODE_INTRA_REFRESH_MODE_NONE_KHR = 0,
    ///             VK_VIDEO_ENCODE_INTRA_REFRESH_MODE_PER_PICTURE_PARTITION_BIT_KHR = 0x00000001,
    ///             VK_VIDEO_ENCODE_INTRA_REFRESH_MODE_BLOCK_BASED_BIT_KHR = 0x00000002,
    ///             VK_VIDEO_ENCODE_INTRA_REFRESH_MODE_BLOCK_ROW_BASED_BIT_KHR = 0x00000004,
    ///             VK_VIDEO_ENCODE_INTRA_REFRESH_MODE_BLOCK_COLUMN_BASED_BIT_KHR = 0x00000008,
    ///         } VkVideoEncodeIntraRefreshModeFlagBitsKHR;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkVideoEncodeIntraRefreshModeFlagsKHR : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>NoneKHR</c> specifies that intra refresh <i>must</i> not be used.
        /// </summary>
        NoneKHR = 0,

        /// <summary>
        ///     <c>PerPicturePartitionBitKHR</c>  specifies the use of <i>per picture partition intra refresh</i>. In this mode each intra refresh region <c>i</c> corresponds to the encoded picture partition <c>i</c>.
        /// </summary>
        PerPicturePartitionBitKHR = 0x00000001,

        /// <summary>
        ///     <c>BlockBasedBitKHR</c> specifies the use of any _block-based intra refresh_. In this mode each intra refresh region encompasses a set of coding blocks, independent of encoded picture partitions but without any additional guarantees on the granularity at which the picture is split into intra refresh regions. When using this mode, the set of coding blocks comprising the intra refresh regions and the direction of intra refresh are implementation-defined.
        /// </summary>
        BlockBasedBitKHR = 0x00000002,

        /// <summary>
        ///     <c>BlockRowBasedBitKHR</c>  specifies the use of _block-row-based intra refresh_. This mode is a block-based intra refresh mode where each intra refresh region encompasses a set of coding block rows.
        /// </summary>
        BlockRowBasedBitKHR = 0x00000004,

        /// <summary>
        ///     <c>BlockColumnBasedBitKHR</c>  specifies the use of _block-column-based intra refresh_. This mode is a block-based intra refresh mode where each intra refresh region encompasses a set of coding block columns.
        /// </summary>
        BlockColumnBasedBitKHR = 0x00000008,

        /// <summary>
        ///     <c>FlagBitsMaxEnumKHR</c>
        /// </summary>
        FlagBitsMaxEnumKHR = 0x7FFFFFFF,
    }
}
