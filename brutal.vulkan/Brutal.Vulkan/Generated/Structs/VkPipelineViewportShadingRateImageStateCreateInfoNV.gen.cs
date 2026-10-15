namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPipelineViewportShadingRateImageStateCreateInfoNV.html">VkPipelineViewportShadingRateImageStateCreateInfoNV</see> - Structure specifying parameters controlling shading rate image usage
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         If the <c>pNext</c> chain of <c>VkPipelineViewportStateCreateInfo</c> includes
    ///         a <c>VkPipelineViewportShadingRateImageStateCreateInfoNV</c> structure, then
    ///         that structure includes parameters controlling the shading rate.
    ///     </para>
    ///     <para>
    ///         The <c>VkPipelineViewportShadingRateImageStateCreateInfoNV</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_shading_rate_image
    ///         typedef struct VkPipelineViewportShadingRateImageStateCreateInfoNV {
    ///             VkStructureType                  sType;
    ///             const void*                      pNext;
    ///             VkBool32                         shadingRateImageEnable;
    ///             uint32_t                         viewportCount;
    ///             const VkShadingRatePaletteNV*    pShadingRatePalettes;
    ///         } VkPipelineViewportShadingRateImageStateCreateInfoNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkPipelineViewportShadingRateImageStateCreateInfoNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PipelineViewportShadingRateImageStateCreateInfoNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ShadingRateImageEnable</c> specifies whether shading rate image and palettes are used during rasterization.
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 ShadingRateImageEnable;

        /// <summary>
        ///     <c>ViewportCount</c> specifies the number of per-viewport palettes used to translate values stored in shading rate images.
        /// </summary>
        [FieldOffset(20)]
        public int ViewportCount;

        /// <summary>
        ///     <c>ShadingRatePalettes</c> is a pointer to an array of <c>VkShadingRatePaletteNV</c> structures defining the palette for each viewport. If the shading rate palette state is dynamic, this member is ignored.
        /// </summary>
        [FieldOffset(24)]
        public VkShadingRatePaletteNV* ShadingRatePalettes;
    }
}
