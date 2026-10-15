namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkColorBlendEquationEXT.html">VkColorBlendEquationEXT</see> - Structure specifying the color blend factors and operations for an attachment
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkColorBlendEquationEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_extended_dynamic_state3, VK_EXT_shader_object
    ///         typedef struct VkColorBlendEquationEXT {
    ///             VkBlendFactor    srcColorBlendFactor;
    ///             VkBlendFactor    dstColorBlendFactor;
    ///             VkBlendOp        colorBlendOp;
    ///             VkBlendFactor    srcAlphaBlendFactor;
    ///             VkBlendFactor    dstAlphaBlendFactor;
    ///             VkBlendOp        alphaBlendOp;
    ///         } VkColorBlendEquationEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct VkColorBlendEquationEXT()
    {
        /// <summary>
        ///     <c>SrcColorBlendFactor</c> selects which blend factor is used to determine the source factors <c>(S~r~,S~g~,S~b~)</c>.
        /// </summary>
        [FieldOffset(0)]
        public VkBlendFactor SrcColorBlendFactor;

        /// <summary>
        ///     <c>DstColorBlendFactor</c> selects which blend factor is used to determine the destination factors <c>(D~r~,D~g~,D~b~)</c>.
        /// </summary>
        [FieldOffset(4)]
        public VkBlendFactor DstColorBlendFactor;

        /// <summary>
        ///     <c>ColorBlendOp</c> selects which blend operation is used to calculate the RGB values to write to the color attachment.
        /// </summary>
        [FieldOffset(8)]
        public VkBlendOp ColorBlendOp;

        /// <summary>
        ///     <c>SrcAlphaBlendFactor</c> selects which blend factor is used to determine the source factor <c>S~a~</c>.
        /// </summary>
        [FieldOffset(12)]
        public VkBlendFactor SrcAlphaBlendFactor;

        /// <summary>
        ///     <c>DstAlphaBlendFactor</c> selects which blend factor is used to determine the destination factor <c>D~a~</c>.
        /// </summary>
        [FieldOffset(16)]
        public VkBlendFactor DstAlphaBlendFactor;

        /// <summary>
        ///     <c>AlphaBlendOp</c> selects which blend operation is use to calculate the alpha values to write to the color attachment.
        /// </summary>
        [FieldOffset(20)]
        public VkBlendOp AlphaBlendOp;
    }
}
