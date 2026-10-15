namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPipelineCompilerControlFlagBitsAMD.html">VkPipelineCompilerControlFlagBitsAMD</see> - Enum specifying available compilation control flags
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         There are currently no available flags for this extension; flags will be
    ///         added by future versions of this extension.
    ///     </para>
    ///     <code>
    ///         // Provided by VK_AMD_pipeline_compiler_control
    ///         typedef enum VkPipelineCompilerControlFlagBitsAMD {
    ///         } VkPipelineCompilerControlFlagBitsAMD;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkPipelineCompilerControlFlagsAMD : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>FlagBitsMaxEnumAMD</c>
        /// </summary>
        FlagBitsMaxEnumAMD = 0x7FFFFFFF,
    }
}
