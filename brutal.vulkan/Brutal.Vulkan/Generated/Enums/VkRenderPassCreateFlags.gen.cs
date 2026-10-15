namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkRenderPassCreateFlagBits.html">VkRenderPassCreateFlagBits</see> - Bitmask specifying additional properties of a render pass
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which <i>can</i> be set in <c>VkRenderPassCreateInfo::flags</c>,
    ///         describing additional properties of the render pass, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef enum VkRenderPassCreateFlagBits {
    ///             // Provided by VK_QCOM_render_pass_transform
    ///             VK_RENDER_PASS_CREATE_TRANSFORM_BIT_QCOM = 0x00000002,
    ///             // Provided by VK_VALVE_fragment_density_map_layered
    ///             VK_RENDER_PASS_CREATE_PER_LAYER_FRAGMENT_DENSITY_BIT_VALVE = 0x00000004,
    ///         } VkRenderPassCreateFlagBits;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkRenderPassCreateFlags : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>TransformBitQCOM</c>
        /// </summary>
        TransformBitQCOM = 0x00000002,

        /// <summary>
        ///     <c>PerLayerFragmentDensityBitVALVE</c>
        /// </summary>
        PerLayerFragmentDensityBitVALVE = 0x00000004,

        /// <summary>
        ///     <c>FlagBitsMaxEnum</c>
        /// </summary>
        FlagBitsMaxEnum = 0x7FFFFFFF,
    }
}
