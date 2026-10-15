namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDataGraphTOSANameQualityARM.html">VkDataGraphTOSANameQualityARM</see> - Structure describing the name and quality level of a TOSA profile or extension
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkDataGraphTOSANameQualityARM</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ARM_data_graph_instruction_set_tosa
    ///         typedef struct VkDataGraphTOSANameQualityARM {
    ///             char                              name[VK_MAX_DATA_GRAPH_TOSA_NAME_SIZE_ARM];
    ///             VkDataGraphTOSAQualityFlagsARM    qualityFlags;
    ///         } VkDataGraphTOSANameQualityARM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 132)]
    public unsafe partial struct VkDataGraphTosaNameQualityARM()
    {
        ///
        [FieldOffset(0)]
        public fixed byte Name[128];

        /// <summary>
        ///     <c>QualityFlags</c>
        /// </summary>
        [FieldOffset(128)]
        public VkDataGraphTosaQualityFlagsARM QualityFlags;
    }
}
