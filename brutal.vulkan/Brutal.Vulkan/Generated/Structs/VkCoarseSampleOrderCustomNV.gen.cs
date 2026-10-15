namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkCoarseSampleOrderCustomNV.html">VkCoarseSampleOrderCustomNV</see> - Structure specifying parameters controlling shading rate image usage
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkCoarseSampleOrderCustomNV</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_shading_rate_image
    ///         typedef struct VkCoarseSampleOrderCustomNV {
    ///             VkShadingRatePaletteEntryNV        shadingRate;
    ///             uint32_t                           sampleCount;
    ///             uint32_t                           sampleLocationCount;
    ///             const VkCoarseSampleLocationNV*    pSampleLocations;
    ///         } VkCoarseSampleOrderCustomNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkCoarseSampleOrderCustomNV()
    {
        /// <summary>
        ///     <c>ShadingRate</c> is a shading rate palette entry that identifies the fragment width and height for the combination of fragment area and per-pixel coverage sample count to control.
        /// </summary>
        [FieldOffset(0)]
        public VkShadingRatePaletteEntryNV ShadingRate;

        /// <summary>
        ///     <c>SampleCount</c> identifies the per-pixel coverage sample count for the combination of fragment area and coverage sample count to control.
        /// </summary>
        [FieldOffset(4)]
        public int SampleCount;

        /// <summary>
        ///     <c>SampleLocationCount</c> specifies the number of sample locations in the custom ordering.
        /// </summary>
        [FieldOffset(8)]
        public int SampleLocationCount;

        /// <summary>
        ///     <c>SampleLocations</c> is a pointer to an array of <c>VkCoarseSampleLocationNV</c> structures specifying the location of each sample in the custom ordering.
        /// </summary>
        [FieldOffset(16)]
        public VkCoarseSampleLocationNV* SampleLocations;
    }
}
