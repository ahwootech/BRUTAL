namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkShaderCorePropertiesFlagBitsAMD.html">VkShaderCorePropertiesFlagBitsAMD</see> - Bitmask specifying shader core properties
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits for this type may: be defined by future extensions, or new versions of
    ///         the `<c>VK_AMD_shader_core_properties2</c>` extension.
    ///         Possible values of the <c>flags</c> member of
    ///         <c>VkShaderCorePropertiesFlagsAMD</c> are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_AMD_shader_core_properties2
    ///         typedef enum VkShaderCorePropertiesFlagBitsAMD {
    ///         } VkShaderCorePropertiesFlagBitsAMD;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkShaderCorePropertiesFlagsAMD : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>FlagBitsMaxEnumAMD</c>
        /// </summary>
        FlagBitsMaxEnumAMD = 0x7FFFFFFF,
    }
}
