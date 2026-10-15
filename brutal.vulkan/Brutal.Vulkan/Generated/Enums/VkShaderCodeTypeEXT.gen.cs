namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkShaderCodeTypeEXT.html">VkShaderCodeTypeEXT</see> - Indicate a shader code type
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Shader objects <i>can</i> be created using different types of shader code.
    ///         Possible values of <c>VkShaderCreateInfoEXT::codeType</c>, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_shader_object
    ///         typedef enum VkShaderCodeTypeEXT {
    ///             VK_SHADER_CODE_TYPE_BINARY_EXT = 0,
    ///             VK_SHADER_CODE_TYPE_SPIRV_EXT = 1,
    ///         } VkShaderCodeTypeEXT;
    ///     </code>
    /// </remarks>
    public enum VkShaderCodeTypeEXT : int
    {
        /// <summary>
        ///     <c>BinaryEXT</c> specifies shader code in an opaque, implementation-defined binary format specific to the physical device.
        /// </summary>
        BinaryEXT = 0,

        /// <summary>
        ///     <c>SpirvEXT</c> specifies shader code in SPIR-V format.
        /// </summary>
        SpirvEXT = 1,

        /// <summary>
        ///     <c>MaxEnumEXT</c>
        /// </summary>
        MaxEnumEXT = 0x7FFFFFFF,
    }
}
