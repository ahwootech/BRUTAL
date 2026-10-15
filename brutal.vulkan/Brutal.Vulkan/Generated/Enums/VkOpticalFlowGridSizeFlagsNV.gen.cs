namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkOpticalFlowGridSizeFlagBitsNV.html">VkOpticalFlowGridSizeFlagBitsNV</see> - Bits specifying grid sizes for optical flow operations
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Optical flow vectors are generated block-wise, one vector for each block of
    ///         NxN pixels (referred to as grid).
    ///     </para>
    ///     <para>
    ///         Bits which <i>can</i> be set in
    ///         <c>VkOpticalFlowSessionCreateInfoNV::outputGridSize</c> and
    ///         <c>VkOpticalFlowSessionCreateInfoNV::hintGridSize</c>, or which are
    ///         returned in
    ///         <c>VkPhysicalDeviceOpticalFlowPropertiesNV::supportedOutputGridSizes</c>
    ///         and
    ///         <c>VkPhysicalDeviceOpticalFlowPropertiesNV::supportedHintGridSizes</c>
    ///         controlling optical flow grid sizes, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_optical_flow
    ///         typedef enum VkOpticalFlowGridSizeFlagBitsNV {
    ///             VK_OPTICAL_FLOW_GRID_SIZE_UNKNOWN_NV = 0,
    ///             VK_OPTICAL_FLOW_GRID_SIZE_1X1_BIT_NV = 0x00000001,
    ///             VK_OPTICAL_FLOW_GRID_SIZE_2X2_BIT_NV = 0x00000002,
    ///             VK_OPTICAL_FLOW_GRID_SIZE_4X4_BIT_NV = 0x00000004,
    ///             VK_OPTICAL_FLOW_GRID_SIZE_8X8_BIT_NV = 0x00000008,
    ///         } VkOpticalFlowGridSizeFlagBitsNV;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkOpticalFlowGridSizeFlagsNV : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>UnknownNV</c>
        /// </summary>
        UnknownNV = 0,

        /// <summary>
        ///     <c>_1X1BitNV</c> specifies that grid is 1x1 pixel.
        /// </summary>
        _1X1BitNV = 0x00000001,

        /// <summary>
        ///     <c>_2X2BitNV</c> specifies that grid is 2x2 pixel.
        /// </summary>
        _2X2BitNV = 0x00000002,

        /// <summary>
        ///     <c>_4X4BitNV</c> specifies that grid is 4x4 pixel.
        /// </summary>
        _4X4BitNV = 0x00000004,

        /// <summary>
        ///     <c>_8X8BitNV</c> specifies that grid is 8x8 pixel.
        /// </summary>
        _8X8BitNV = 0x00000008,

        /// <summary>
        ///     <c>FlagBitsMaxEnumNV</c>
        /// </summary>
        FlagBitsMaxEnumNV = 0x7FFFFFFF,
    }
}
