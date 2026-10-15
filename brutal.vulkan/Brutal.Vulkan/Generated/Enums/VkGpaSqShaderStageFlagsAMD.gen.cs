namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkGpaSqShaderStageFlagBitsAMD.html">VkGpaSqShaderStageFlagBitsAMD</see> - Bitmask specifying GPU shader stage to sample
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which <i>can</i> be set to control which GPU shader stages are sampled, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_AMD_gpa_interface
    ///         typedef enum VkGpaSqShaderStageFlagBitsAMD {
    ///             VK_GPA_SQ_SHADER_STAGE_PS_BIT_AMD = 0x00000001,
    ///             VK_GPA_SQ_SHADER_STAGE_VS_BIT_AMD = 0x00000002,
    ///             VK_GPA_SQ_SHADER_STAGE_GS_BIT_AMD = 0x00000004,
    ///             VK_GPA_SQ_SHADER_STAGE_ES_BIT_AMD = 0x00000008,
    ///             VK_GPA_SQ_SHADER_STAGE_HS_BIT_AMD = 0x00000010,
    ///             VK_GPA_SQ_SHADER_STAGE_LS_BIT_AMD = 0x00000020,
    ///             VK_GPA_SQ_SHADER_STAGE_CS_BIT_AMD = 0x00000040,
    ///         } VkGpaSqShaderStageFlagBitsAMD;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkGpaSqShaderStageFlagsAMD : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>PsBitAMD</c> specifies the pixel shader stage.
        /// </summary>
        PsBitAMD = 0x00000001,

        /// <summary>
        ///     <c>VsBitAMD</c> specifies the vertex shader stage.
        /// </summary>
        VsBitAMD = 0x00000002,

        /// <summary>
        ///     <c>GsBitAMD</c> specifies the geometry shader stage.
        /// </summary>
        GsBitAMD = 0x00000004,

        /// <summary>
        ///     <c>EsBitAMD</c> specifies the export shader stage.
        /// </summary>
        EsBitAMD = 0x00000008,

        /// <summary>
        ///     <c>HsBitAMD</c> specifies the hull shader stage.
        /// </summary>
        HsBitAMD = 0x00000010,

        /// <summary>
        ///     <c>LsBitAMD</c> specifies the local shader stage.
        /// </summary>
        LsBitAMD = 0x00000020,

        /// <summary>
        ///     <c>CsBitAMD</c> specifies the compute shader stage.
        /// </summary>
        CsBitAMD = 0x00000040,

        /// <summary>
        ///     <c>FlagBitsMaxEnumAMD</c>
        /// </summary>
        FlagBitsMaxEnumAMD = 0x7FFFFFFF,
    }
}
