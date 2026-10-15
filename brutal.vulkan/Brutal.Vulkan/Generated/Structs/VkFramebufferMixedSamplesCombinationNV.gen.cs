namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkFramebufferMixedSamplesCombinationNV.html">VkFramebufferMixedSamplesCombinationNV</see> - Structure specifying a supported sample count combination
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkFramebufferMixedSamplesCombinationNV</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_coverage_reduction_mode
    ///         typedef struct VkFramebufferMixedSamplesCombinationNV {
    ///             VkStructureType              sType;
    ///             void*                        pNext;
    ///             VkCoverageReductionModeNV    coverageReductionMode;
    ///             VkSampleCountFlagBits        rasterizationSamples;
    ///             VkSampleCountFlags           depthStencilSamples;
    ///             VkSampleCountFlags           colorSamples;
    ///         } VkFramebufferMixedSamplesCombinationNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkFramebufferMixedSamplesCombinationNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.FramebufferMixedSamplesCombinationNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>CoverageReductionMode</c> is a <c>VkCoverageReductionModeNV</c> value specifying the coverage reduction mode.
        /// </summary>
        [FieldOffset(16)]
        public VkCoverageReductionModeNV CoverageReductionMode;

        /// <summary>
        ///     <c>RasterizationSamples</c> is a <c>VkSampleCountFlags</c> specifying the number of rasterization samples in the supported combination.
        /// </summary>
        [FieldOffset(20)]
        public VkSampleCountFlags RasterizationSamples;

        /// <summary>
        ///     <c>DepthStencilSamples</c> specifies the number of samples in the depth stencil attachment in the supported combination. A value of 0 indicates the combination does not have a depth stencil attachment.
        /// </summary>
        [FieldOffset(24)]
        public VkSampleCountFlags DepthStencilSamples;

        /// <summary>
        ///     <c>ColorSamples</c> specifies the number of color samples in a color attachment in the supported combination. A value of 0 indicates the combination does not have a color attachment.
        /// </summary>
        [FieldOffset(28)]
        public VkSampleCountFlags ColorSamples;
    }
}
