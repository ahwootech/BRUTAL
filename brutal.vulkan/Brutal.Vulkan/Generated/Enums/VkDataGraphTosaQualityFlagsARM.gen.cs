namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDataGraphTOSAQualityFlagBitsARM.html">VkDataGraphTOSAQualityFlagBitsARM</see> - Bits specifying quality properties for a TOSA profile or extension
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which <i>can</i> be set in
    ///         <c>VkDataGraphTOSANameQualityARM::qualityLevel</c>, describing the
    ///         quality of a TOSA profile or extension, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ARM_data_graph_instruction_set_tosa
    ///         typedef enum VkDataGraphTOSAQualityFlagBitsARM {
    ///             VK_DATA_GRAPH_TOSA_QUALITY_ACCELERATED_ARM = 0x00000001,
    ///             VK_DATA_GRAPH_TOSA_QUALITY_CONFORMANT_ARM = 0x00000002,
    ///             VK_DATA_GRAPH_TOSA_QUALITY_EXPERIMENTAL_ARM = 0x00000004,
    ///             VK_DATA_GRAPH_TOSA_QUALITY_DEPRECATED_ARM = 0x00000008,
    ///         } VkDataGraphTOSAQualityFlagBitsARM;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkDataGraphTosaQualityFlagsARM : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>AcceleratedARM</c> specifies that the implementation of the TOSA profile or extension is accelerated.
        /// </summary>
        AcceleratedARM = 0x00000001,

        /// <summary>
        ///     <c>ConformantARM</c> specifies that the implementation of the TOSA profile or extension is conformant.
        /// </summary>
        ConformantARM = 0x00000002,

        /// <summary>
        ///     <c>ExperimentalARM</c> specifies that the TOSA profile or extension is experimental.
        /// </summary>
        ExperimentalARM = 0x00000004,

        /// <summary>
        ///     <c>DeprecatedARM</c> specifies that the TOSA profile or extension is deprecated.
        /// </summary>
        DeprecatedARM = 0x00000008,

        /// <summary>
        ///     <c>FlagBitsMaxEnumARM</c>
        /// </summary>
        FlagBitsMaxEnumARM = 0x7FFFFFFF,
    }
}
