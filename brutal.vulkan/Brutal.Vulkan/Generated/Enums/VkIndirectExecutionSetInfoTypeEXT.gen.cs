namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkIndirectExecutionSetInfoTypeEXT.html">VkIndirectExecutionSetInfoTypeEXT</see> - Enum specifying allowed usage of an indirect execution set
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Values which <i>can</i> be set in
    ///         <c>VkIndirectExecutionSetCreateInfoEXT::type</c>, specifying contents
    ///         of an indirect execution set, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_device_generated_commands
    ///         typedef enum VkIndirectExecutionSetInfoTypeEXT {
    ///             VK_INDIRECT_EXECUTION_SET_INFO_TYPE_PIPELINES_EXT = 0,
    ///             VK_INDIRECT_EXECUTION_SET_INFO_TYPE_SHADER_OBJECTS_EXT = 1,
    ///         } VkIndirectExecutionSetInfoTypeEXT;
    ///     </code>
    /// </remarks>
    public enum VkIndirectExecutionSetInfoTypeEXT : int
    {
        /// <summary>
        ///     <c>PipelinesEXT</c> specifies that the indirect execution set contains <c>VkPipeline</c> objects.
        /// </summary>
        PipelinesEXT = 0,

        /// <summary>
        ///     <c>ShaderObjectsEXT</c> <i>must</i> not be used.
        /// </summary>
        ShaderObjectsEXT = 1,

        /// <summary>
        ///     <c>MaxEnumEXT</c>
        /// </summary>
        MaxEnumEXT = 0x7FFFFFFF,
    }
}
