namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPipelineCoverageModulationStateCreateInfoNV.html">VkPipelineCoverageModulationStateCreateInfoNV</see> - Structure specifying parameters controlling coverage modulation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         As part of coverage reduction, fragment color values <i>can</i> also be modulated
    ///         (multiplied) by a value that is a function of fraction of covered
    ///         rasterization samples associated with that color sample.
    ///     </para>
    ///     <para>
    ///         Pipeline state controlling coverage modulation is specified through the
    ///         members of the <c>VkPipelineCoverageModulationStateCreateInfoNV</c>
    ///         structure.
    ///     </para>
    ///     <para>
    ///         The <c>VkPipelineCoverageModulationStateCreateInfoNV</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_framebuffer_mixed_samples
    ///         typedef struct VkPipelineCoverageModulationStateCreateInfoNV {
    ///             VkStructureType                                   sType;
    ///             const void*                                       pNext;
    ///             VkPipelineCoverageModulationStateCreateFlagsNV    flags;
    ///             VkCoverageModulationModeNV                        coverageModulationMode;
    ///             VkBool32                                          coverageModulationTableEnable;
    ///             uint32_t                                          coverageModulationTableCount;
    ///             const float*                                      pCoverageModulationTable;
    ///         } VkPipelineCoverageModulationStateCreateInfoNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct VkPipelineCoverageModulationStateCreateInfoNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PipelineCoverageModulationStateCreateInfoNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is reserved for future use.
        /// </summary>
        [FieldOffset(16)]
        public VkPipelineCoverageModulationStateCreateFlagsNV Flags;

        /// <summary>
        ///     <c>CoverageModulationMode</c> is a <c>VkCoverageModulationModeNV</c> value controlling which color components are modulated.
        /// </summary>
        [FieldOffset(20)]
        public VkCoverageModulationModeNV CoverageModulationMode;

        /// <summary>
        ///     <c>CoverageModulationTableEnable</c> controls whether the modulation factor is looked up from a table in <c>pCoverageModulationTable</c>.
        /// </summary>
        [FieldOffset(24)]
        public Brutal.Bool32 CoverageModulationTableEnable;

        /// <summary>
        ///     <c>CoverageModulationTableCount</c> is the number of elements in <c>pCoverageModulationTable</c>.
        /// </summary>
        [FieldOffset(28)]
        public int CoverageModulationTableCount;

        /// <summary>
        ///     <c>CoverageModulationTable</c> is a table of modulation factors containing a value for each number of covered samples.
        /// </summary>
        [FieldOffset(32)]
        public float* CoverageModulationTable;
    }
}
