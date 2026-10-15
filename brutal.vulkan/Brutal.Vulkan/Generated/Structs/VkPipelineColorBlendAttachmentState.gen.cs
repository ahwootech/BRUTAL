namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPipelineColorBlendAttachmentState.html">VkPipelineColorBlendAttachmentState</see> - Structure specifying a pipeline color blend attachment state
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPipelineColorBlendAttachmentState</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef struct VkPipelineColorBlendAttachmentState {
    ///             VkBool32                 blendEnable;
    ///             VkBlendFactor            srcColorBlendFactor;
    ///             VkBlendFactor            dstColorBlendFactor;
    ///             VkBlendOp                colorBlendOp;
    ///             VkBlendFactor            srcAlphaBlendFactor;
    ///             VkBlendFactor            dstAlphaBlendFactor;
    ///             VkBlendOp                alphaBlendOp;
    ///             VkColorComponentFlags    colorWriteMask;
    ///         } VkPipelineColorBlendAttachmentState;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial struct VkPipelineColorBlendAttachmentState()
    {
        /// <summary>
        ///     <c>BlendEnable</c> controls whether blending is enabled for the corresponding color attachment. If blending is not enabled, the source fragment&apos;s color for that attachment is passed through unmodified.
        /// </summary>
        [FieldOffset(0)]
        public Brutal.Bool32 BlendEnable;

        /// <summary>
        ///     <c>SrcColorBlendFactor</c> selects which blend factor is used to determine the source factors <c>(S~r~,S~g~,S~b~)</c>.
        /// </summary>
        [FieldOffset(4)]
        public VkBlendFactor SrcColorBlendFactor;

        /// <summary>
        ///     <c>DstColorBlendFactor</c> selects which blend factor is used to determine the destination factors <c>(D~r~,D~g~,D~b~)</c>.
        /// </summary>
        [FieldOffset(8)]
        public VkBlendFactor DstColorBlendFactor;

        /// <summary>
        ///     <c>ColorBlendOp</c> selects which blend operation is used to calculate the RGB values to write to the color attachment.
        /// </summary>
        [FieldOffset(12)]
        public VkBlendOp ColorBlendOp;

        /// <summary>
        ///     <c>SrcAlphaBlendFactor</c> selects which blend factor is used to determine the source factor <c>S~a~</c>.
        /// </summary>
        [FieldOffset(16)]
        public VkBlendFactor SrcAlphaBlendFactor;

        /// <summary>
        ///     <c>DstAlphaBlendFactor</c> selects which blend factor is used to determine the destination factor <c>D~a~</c>.
        /// </summary>
        [FieldOffset(20)]
        public VkBlendFactor DstAlphaBlendFactor;

        /// <summary>
        ///     <c>AlphaBlendOp</c> selects which blend operation is used to calculate the alpha values to write to the color attachment.
        /// </summary>
        [FieldOffset(24)]
        public VkBlendOp AlphaBlendOp;

        /// <summary>
        ///     <c>ColorWriteMask</c> is a bitmask of <c>VkColorComponentFlags</c> specifying which of the R, G, B, and/or A components are enabled for writing, as described for the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#framebuffer-color-write-mask">Color Write Mask^</see>.
        /// </summary>
        [FieldOffset(28)]
        public VkColorComponentFlags ColorWriteMask;
    }
}
