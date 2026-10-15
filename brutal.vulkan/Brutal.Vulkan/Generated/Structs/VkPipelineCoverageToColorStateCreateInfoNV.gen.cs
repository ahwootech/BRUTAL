namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPipelineCoverageToColorStateCreateInfoNV.html">VkPipelineCoverageToColorStateCreateInfoNV</see> - Structure specifying whether fragment coverage replaces a color
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPipelineCoverageToColorStateCreateInfoNV</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_fragment_coverage_to_color
    ///         typedef struct VkPipelineCoverageToColorStateCreateInfoNV {
    ///             VkStructureType                                sType;
    ///             const void*                                    pNext;
    ///             VkPipelineCoverageToColorStateCreateFlagsNV    flags;
    ///             VkBool32                                       coverageToColorEnable;
    ///             uint32_t                                       coverageToColorLocation;
    ///         } VkPipelineCoverageToColorStateCreateInfoNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkPipelineCoverageToColorStateCreateInfoNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PipelineCoverageToColorStateCreateInfoNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is reserved for future use.
        /// </summary>
        [FieldOffset(16)]
        public VkPipelineCoverageToColorStateCreateFlagsNV Flags;

        /// <summary>
        ///     <c>CoverageToColorEnable</c> controls whether the fragment coverage value replaces a fragment color output.
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 CoverageToColorEnable;

        /// <summary>
        ///     <c>CoverageToColorLocation</c> controls which fragment shader color output value is replaced.
        /// </summary>
        [FieldOffset(24)]
        public int CoverageToColorLocation;
    }
}
