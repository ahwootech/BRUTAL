namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkShadingRatePaletteEntryNV.html">VkShadingRatePaletteEntryNV</see> - Shading rate image palette entry types
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The supported shading rate image palette entries are defined by
    ///         <c>VkShadingRatePaletteEntryNV</c>:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_shading_rate_image
    ///         typedef enum VkShadingRatePaletteEntryNV {
    ///             VK_SHADING_RATE_PALETTE_ENTRY_NO_INVOCATIONS_NV = 0,
    ///             VK_SHADING_RATE_PALETTE_ENTRY_16_INVOCATIONS_PER_PIXEL_NV = 1,
    ///             VK_SHADING_RATE_PALETTE_ENTRY_8_INVOCATIONS_PER_PIXEL_NV = 2,
    ///             VK_SHADING_RATE_PALETTE_ENTRY_4_INVOCATIONS_PER_PIXEL_NV = 3,
    ///             VK_SHADING_RATE_PALETTE_ENTRY_2_INVOCATIONS_PER_PIXEL_NV = 4,
    ///             VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_PIXEL_NV = 5,
    ///             VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_2X1_PIXELS_NV = 6,
    ///             VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_1X2_PIXELS_NV = 7,
    ///             VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_2X2_PIXELS_NV = 8,
    ///             VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_4X2_PIXELS_NV = 9,
    ///             VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_2X4_PIXELS_NV = 10,
    ///             VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_4X4_PIXELS_NV = 11,
    ///         } VkShadingRatePaletteEntryNV;
    ///     </code>
    /// </remarks>
    public enum VkShadingRatePaletteEntryNV : int
    {
        /// <summary>
        ///     <c>NoInvocationsNV</c>
        /// </summary>
        NoInvocationsNV = 0,

        /// <summary>
        ///     <c>_16InvocationsPerPixelNV</c>
        /// </summary>
        _16InvocationsPerPixelNV = 1,

        /// <summary>
        ///     <c>_8InvocationsPerPixelNV</c>
        /// </summary>
        _8InvocationsPerPixelNV = 2,

        /// <summary>
        ///     <c>_4InvocationsPerPixelNV</c>
        /// </summary>
        _4InvocationsPerPixelNV = 3,

        /// <summary>
        ///     <c>_2InvocationsPerPixelNV</c>
        /// </summary>
        _2InvocationsPerPixelNV = 4,

        /// <summary>
        ///     <c>_1InvocationPerPixelNV</c>
        /// </summary>
        _1InvocationPerPixelNV = 5,

        /// <summary>
        ///     <c>_1InvocationPer2X1PixelsNV</c>
        /// </summary>
        _1InvocationPer2X1PixelsNV = 6,

        /// <summary>
        ///     <c>_1InvocationPer1X2PixelsNV</c>
        /// </summary>
        _1InvocationPer1X2PixelsNV = 7,

        /// <summary>
        ///     <c>_1InvocationPer2X2PixelsNV</c>
        /// </summary>
        _1InvocationPer2X2PixelsNV = 8,

        /// <summary>
        ///     <c>_1InvocationPer4X2PixelsNV</c>
        /// </summary>
        _1InvocationPer4X2PixelsNV = 9,

        /// <summary>
        ///     <c>_1InvocationPer2X4PixelsNV</c>
        /// </summary>
        _1InvocationPer2X4PixelsNV = 10,

        /// <summary>
        ///     <c>_1InvocationPer4X4PixelsNV</c>
        /// </summary>
        _1InvocationPer4X4PixelsNV = 11,

        /// <summary>
        ///     <c>MaxEnumNV</c>
        /// </summary>
        MaxEnumNV = 0x7FFFFFFF,
    }
}
