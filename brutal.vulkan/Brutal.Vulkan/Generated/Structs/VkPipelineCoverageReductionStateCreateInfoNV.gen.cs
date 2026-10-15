namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPipelineCoverageReductionStateCreateInfoNV.html">VkPipelineCoverageReductionStateCreateInfoNV</see> - Structure specifying parameters controlling coverage reduction
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPipelineCoverageReductionStateCreateInfoNV</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_coverage_reduction_mode
    ///         typedef struct VkPipelineCoverageReductionStateCreateInfoNV {
    ///             VkStructureType                                  sType;
    ///             const void*                                      pNext;
    ///             VkPipelineCoverageReductionStateCreateFlagsNV    flags;
    ///             VkCoverageReductionModeNV                        coverageReductionMode;
    ///         } VkPipelineCoverageReductionStateCreateInfoNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPipelineCoverageReductionStateCreateInfoNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PipelineCoverageReductionStateCreateInfoNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is reserved for future use.
        /// </summary>
        [FieldOffset(16)]
        public VkPipelineCoverageReductionStateCreateFlagsNV Flags;

        /// <summary>
        ///     <c>CoverageReductionMode</c> is a <c>VkCoverageReductionModeNV</c> value controlling how color sample coverage is generated from pixel coverage.
        /// </summary>
        [FieldOffset(20)]
        public VkCoverageReductionModeNV CoverageReductionMode;
    }
}
