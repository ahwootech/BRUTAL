namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkIndirectCommandsLayoutUsageFlagBitsNV.html">VkIndirectCommandsLayoutUsageFlagBitsNV</see> - Bitmask specifying allowed usage of an indirect commands layout
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which <i>can</i> be set in
    ///         <c>VkIndirectCommandsLayoutCreateInfoNV::flags</c>, specifying usage
    ///         hints of an indirect command layout, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_device_generated_commands
    ///         typedef enum VkIndirectCommandsLayoutUsageFlagBitsNV {
    ///             VK_INDIRECT_COMMANDS_LAYOUT_USAGE_EXPLICIT_PREPROCESS_BIT_NV = 0x00000001,
    ///             VK_INDIRECT_COMMANDS_LAYOUT_USAGE_INDEXED_SEQUENCES_BIT_NV = 0x00000002,
    ///             VK_INDIRECT_COMMANDS_LAYOUT_USAGE_UNORDERED_SEQUENCES_BIT_NV = 0x00000004,
    ///         } VkIndirectCommandsLayoutUsageFlagBitsNV;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkIndirectCommandsLayoutUsageFlagsNV : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>ExplicitPreprocessBitNV</c>  specifies that the layout is always used with the manual preprocessing step through calling <c>vkCmdPreprocessGeneratedCommandsNV</c> and executed by <c>vkCmdExecuteGeneratedCommandsNV</c> with <c>isPreprocessed</c> set to <c>VK_TRUE</c>.
        /// </summary>
        ExplicitPreprocessBitNV = 0x00000001,

        /// <summary>
        ///     <c>IndexedSequencesBitNV</c>  specifies that the input data for the sequences is not implicitly indexed from 0..sequencesUsed, but an application-provided <c>VkBuffer</c> encoding the index is provided.
        /// </summary>
        IndexedSequencesBitNV = 0x00000002,

        /// <summary>
        ///     <c>UnorderedSequencesBitNV</c>  specifies that the processing of sequences <i>can</i> happen at an implementation-dependent order, which is not guaranteed to be coherent using the same input data.
        /// </summary>
        UnorderedSequencesBitNV = 0x00000004,

        /// <summary>
        ///     <c>FlagBitsMaxEnumNV</c>
        /// </summary>
        FlagBitsMaxEnumNV = 0x7FFFFFFF,
    }
}
