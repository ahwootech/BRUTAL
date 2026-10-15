namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkColorComponentFlagBits.html">VkColorComponentFlagBits</see> - Bitmask controlling which components are written to the framebuffer
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which <i>can</i> be set in
    ///         <c>VkPipelineColorBlendAttachmentState::colorWriteMask</c>, determining
    ///         whether the final color values <c>R, G, B</c> and <c>A</c> are written to the
    ///         framebuffer attachment, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef enum VkColorComponentFlagBits {
    ///             VK_COLOR_COMPONENT_R_BIT = 0x00000001,
    ///             VK_COLOR_COMPONENT_G_BIT = 0x00000002,
    ///             VK_COLOR_COMPONENT_B_BIT = 0x00000004,
    ///             VK_COLOR_COMPONENT_A_BIT = 0x00000008,
    ///         } VkColorComponentFlagBits;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkColorComponentFlags : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>RBit</c> specifies that the <c>R</c> value is written to the color attachment for the appropriate sample. Otherwise, the value in memory is unmodified.
        /// </summary>
        RBit = 0x00000001,

        /// <summary>
        ///     <c>GBit</c> specifies that the <c>G</c> value is written to the color attachment for the appropriate sample. Otherwise, the value in memory is unmodified.
        /// </summary>
        GBit = 0x00000002,

        /// <summary>
        ///     <c>BBit</c> specifies that the <c>B</c> value is written to the color attachment for the appropriate sample. Otherwise, the value in memory is unmodified.
        /// </summary>
        BBit = 0x00000004,

        /// <summary>
        ///     <c>ABit</c> specifies that the <c>A</c> value is written to the color attachment for the appropriate sample. Otherwise, the value in memory is unmodified.  The color write mask operation is applied regardless of whether blending is enabled.
        /// </summary>
        ABit = 0x00000008,

        /// <summary>
        ///     <c>FlagBitsMaxEnum</c>
        /// </summary>
        FlagBitsMaxEnum = 0x7FFFFFFF,
    }
}
