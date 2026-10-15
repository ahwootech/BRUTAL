namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkIndirectCommandsLayoutUsageFlagBitsEXT.html">VkIndirectCommandsLayoutUsageFlagBitsEXT</see> - Bitmask specifying allowed usage of an indirect commands layout
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which <i>can</i> be set in
    ///         <c>VkIndirectCommandsLayoutCreateInfoEXT::flags</c>, specifying usage
    ///         hints of an indirect command layout, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_device_generated_commands
    ///         typedef enum VkIndirectCommandsLayoutUsageFlagBitsEXT {
    ///             VK_INDIRECT_COMMANDS_LAYOUT_USAGE_EXPLICIT_PREPROCESS_BIT_EXT = 0x00000001,
    ///             VK_INDIRECT_COMMANDS_LAYOUT_USAGE_UNORDERED_SEQUENCES_BIT_EXT = 0x00000002,
    ///         } VkIndirectCommandsLayoutUsageFlagBitsEXT;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkIndirectCommandsLayoutUsageFlagsEXT : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>ExplicitPreprocessBitEXT</c>  specifies that the layout is always used with the manual preprocessing step through calling <c>vkCmdPreprocessGeneratedCommandsEXT</c> and executed by <c>vkCmdExecuteGeneratedCommandsEXT</c> with <c>isPreprocessed</c> set to <c>VK_TRUE</c>.
        /// </summary>
        ExplicitPreprocessBitEXT = 0x00000001,

        /// <summary>
        ///     <c>UnorderedSequencesBitEXT</c>  specifies that the processing of sequences will happen at an implementation-dependent order, which is not guaranteed to be deterministic using the same input data. This flag is ignored when the <c>shaderStages</c> is <c>VK_SHADER_STAGE_COMPUTE_BIT</c> as it is implied that the dispatch sequence is always unordered.
        /// </summary>
        UnorderedSequencesBitEXT = 0x00000002,

        /// <summary>
        ///     <c>FlagBitsMaxEnumEXT</c>
        /// </summary>
        FlagBitsMaxEnumEXT = 0x7FFFFFFF,
    }
}
