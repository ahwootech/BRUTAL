namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkShadingRatePaletteNV.html">VkShadingRatePaletteNV</see> - Structure specifying a single shading rate palette
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkShadingRatePaletteNV</c> structure specifies to contents of a single
    ///         shading rate image palette and is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_shading_rate_image
    ///         typedef struct VkShadingRatePaletteNV {
    ///             uint32_t                              shadingRatePaletteEntryCount;
    ///             const VkShadingRatePaletteEntryNV*    pShadingRatePaletteEntries;
    ///         } VkShadingRatePaletteNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public unsafe partial struct VkShadingRatePaletteNV()
    {
        /// <summary>
        ///     <c>ShadingRatePaletteEntryCount</c> specifies the number of entries in the shading rate image palette.
        /// </summary>
        [FieldOffset(0)]
        public int ShadingRatePaletteEntryCount;

        /// <summary>
        ///     <c>ShadingRatePaletteEntries</c> is a pointer to an array of <c>VkShadingRatePaletteEntryNV</c> enums defining the shading rate for each palette entry.
        /// </summary>
        [FieldOffset(8)]
        public VkShadingRatePaletteEntryNV* ShadingRatePaletteEntries;
    }
}
