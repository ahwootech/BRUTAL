namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkShaderInfoTypeAMD.html">VkShaderInfoTypeAMD</see> - Enum specifying which type of shader information to query
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Possible values of <c>vkGetShaderInfoAMD::infoType</c>, specifying the
    ///         information being queried from a shader, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_AMD_shader_info
    ///         typedef enum VkShaderInfoTypeAMD {
    ///             VK_SHADER_INFO_TYPE_STATISTICS_AMD = 0,
    ///             VK_SHADER_INFO_TYPE_BINARY_AMD = 1,
    ///             VK_SHADER_INFO_TYPE_DISASSEMBLY_AMD = 2,
    ///         } VkShaderInfoTypeAMD;
    ///     </code>
    /// </remarks>
    public enum VkShaderInfoTypeAMD : int
    {
        /// <summary>
        ///     <c>StatisticsAMD</c> specifies that device resources used by a shader will be queried.
        /// </summary>
        StatisticsAMD = 0,

        /// <summary>
        ///     <c>BinaryAMD</c> specifies that implementation-specific information will be queried.
        /// </summary>
        BinaryAMD = 1,

        /// <summary>
        ///     <c>DisassemblyAMD</c> specifies that human-readable disassembly of a shader.
        /// </summary>
        DisassemblyAMD = 2,

        /// <summary>
        ///     <c>MaxEnumAMD</c>
        /// </summary>
        MaxEnumAMD = 0x7FFFFFFF,
    }
}
