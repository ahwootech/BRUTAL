namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDataGraphTOSALevelARM.html">VkDataGraphTOSALevelARM</see> - Enumeration describing a data graph TOSA level
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkDataGraphTOSALevelARM
    ///     </para>
    ///     <para>
    ///         The defined data graph TOSA levels are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ARM_data_graph_instruction_set_tosa
    ///         typedef enum VkDataGraphTOSALevelARM {
    ///             VK_DATA_GRAPH_TOSA_LEVEL_NONE_ARM = 0,
    ///             VK_DATA_GRAPH_TOSA_LEVEL_8K_ARM = 1,
    ///         } VkDataGraphTOSALevelARM;
    ///     </code>
    /// </remarks>
    public enum VkDataGraphTosaLevelARM : int
    {
        /// <summary>
        ///     <c>NoneARM</c> corresponds to the none TOSA level, as described in the TOSA specification.
        /// </summary>
        NoneARM = 0,

        /// <summary>
        ///     <c>_8KARM</c> corresponds to the 8K TOSA level, as described in the TOSA specification.
        /// </summary>
        _8KARM = 1,

        /// <summary>
        ///     <c>MaxEnumARM</c>
        /// </summary>
        MaxEnumARM = 0x7FFFFFFF,
    }
}
