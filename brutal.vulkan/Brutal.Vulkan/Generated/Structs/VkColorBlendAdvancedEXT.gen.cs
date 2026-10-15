namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkColorBlendAdvancedEXT.html">VkColorBlendAdvancedEXT</see> - Structure specifying the advanced blend operation parameters for an attachment
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkColorBlendAdvancedEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_extended_dynamic_state3, VK_EXT_shader_object
    ///         typedef struct VkColorBlendAdvancedEXT {
    ///             VkBlendOp            advancedBlendOp;
    ///             VkBool32             srcPremultiplied;
    ///             VkBool32             dstPremultiplied;
    ///             VkBlendOverlapEXT    blendOverlap;
    ///             VkBool32             clampResults;
    ///         } VkColorBlendAdvancedEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public partial struct VkColorBlendAdvancedEXT()
    {
        /// <summary>
        ///     <c>AdvancedBlendOp</c> selects which blend operation is used to calculate the RGB values to write to the color attachment.
        /// </summary>
        [FieldOffset(0)]
        public VkBlendOp AdvancedBlendOp;

        /// <summary>
        ///     <c>SrcPremultiplied</c> specifies whether the source color of the blend operation is treated as premultiplied.
        /// </summary>
        [FieldOffset(4)]
        public Brutal.Bool32 SrcPremultiplied;

        /// <summary>
        ///     <c>DstPremultiplied</c> specifies whether the destination color of the blend operation is treated as premultiplied.
        /// </summary>
        [FieldOffset(8)]
        public Brutal.Bool32 DstPremultiplied;

        /// <summary>
        ///     <c>BlendOverlap</c> is a <c>VkBlendOverlapEXT</c> value specifying how the source and destination sample&apos;s coverage is correlated.
        /// </summary>
        [FieldOffset(12)]
        public VkBlendOverlapEXT BlendOverlap;

        /// <summary>
        ///     <c>ClampResults</c> specifies that results <i>must</i> be clamped to the [0,1] range before writing to the attachment, which is useful when the attachment format is not normalized fixed-point.
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 ClampResults;
    }
}
