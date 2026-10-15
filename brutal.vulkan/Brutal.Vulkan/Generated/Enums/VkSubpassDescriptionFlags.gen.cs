namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSubpassDescriptionFlagBits.html">VkSubpassDescriptionFlagBits</see> - Bitmask specifying usage of a subpass
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which <i>can</i> be set in <c>VkSubpassDescription::flags</c>,
    ///         specifying usage of the subpass, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef enum VkSubpassDescriptionFlagBits {
    ///             // Provided by VK_NVX_multiview_per_view_attributes
    ///             VK_SUBPASS_DESCRIPTION_PER_VIEW_ATTRIBUTES_BIT_NVX = 0x00000001,
    ///             // Provided by VK_NVX_multiview_per_view_attributes
    ///             VK_SUBPASS_DESCRIPTION_PER_VIEW_POSITION_X_ONLY_BIT_NVX = 0x00000002,
    ///             // Provided by VK_QCOM_tile_shading
    ///             VK_SUBPASS_DESCRIPTION_TILE_SHADING_APRON_BIT_QCOM = 0x00000100,
    ///             // Provided by VK_EXT_rasterization_order_attachment_access
    ///             VK_SUBPASS_DESCRIPTION_RASTERIZATION_ORDER_ATTACHMENT_COLOR_ACCESS_BIT_EXT = 0x00000010,
    ///             // Provided by VK_EXT_rasterization_order_attachment_access
    ///             VK_SUBPASS_DESCRIPTION_RASTERIZATION_ORDER_ATTACHMENT_DEPTH_ACCESS_BIT_EXT = 0x00000020,
    ///             // Provided by VK_EXT_rasterization_order_attachment_access
    ///             VK_SUBPASS_DESCRIPTION_RASTERIZATION_ORDER_ATTACHMENT_STENCIL_ACCESS_BIT_EXT = 0x00000040,
    ///             // Provided by VK_EXT_legacy_dithering
    ///             VK_SUBPASS_DESCRIPTION_ENABLE_LEGACY_DITHERING_BIT_EXT = 0x00000080,
    ///             // Provided by VK_EXT_custom_resolve
    ///             VK_SUBPASS_DESCRIPTION_FRAGMENT_REGION_BIT_EXT = 0x00000004,
    ///             // Provided by VK_EXT_custom_resolve
    ///             VK_SUBPASS_DESCRIPTION_CUSTOM_RESOLVE_BIT_EXT = 0x00000008,
    ///             // Provided by VK_QCOM_render_pass_shader_resolve
    ///             VK_SUBPASS_DESCRIPTION_FRAGMENT_REGION_BIT_QCOM = VK_SUBPASS_DESCRIPTION_FRAGMENT_REGION_BIT_EXT,
    ///             // Provided by VK_QCOM_render_pass_shader_resolve
    ///             VK_SUBPASS_DESCRIPTION_SHADER_RESOLVE_BIT_QCOM = VK_SUBPASS_DESCRIPTION_CUSTOM_RESOLVE_BIT_EXT,
    ///             // Provided by VK_ARM_rasterization_order_attachment_access
    ///             VK_SUBPASS_DESCRIPTION_RASTERIZATION_ORDER_ATTACHMENT_COLOR_ACCESS_BIT_ARM = VK_SUBPASS_DESCRIPTION_RASTERIZATION_ORDER_ATTACHMENT_COLOR_ACCESS_BIT_EXT,
    ///             // Provided by VK_ARM_rasterization_order_attachment_access
    ///             VK_SUBPASS_DESCRIPTION_RASTERIZATION_ORDER_ATTACHMENT_DEPTH_ACCESS_BIT_ARM = VK_SUBPASS_DESCRIPTION_RASTERIZATION_ORDER_ATTACHMENT_DEPTH_ACCESS_BIT_EXT,
    ///             // Provided by VK_ARM_rasterization_order_attachment_access
    ///             VK_SUBPASS_DESCRIPTION_RASTERIZATION_ORDER_ATTACHMENT_STENCIL_ACCESS_BIT_ARM = VK_SUBPASS_DESCRIPTION_RASTERIZATION_ORDER_ATTACHMENT_STENCIL_ACCESS_BIT_EXT,
    ///         } VkSubpassDescriptionFlagBits;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkSubpassDescriptionFlags : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>PerViewAttributesBitNVX</c>
        /// </summary>
        PerViewAttributesBitNVX = 0x00000001,

        /// <summary>
        ///     <c>PerViewPositionXOnlyBitNVX</c>
        /// </summary>
        PerViewPositionXOnlyBitNVX = 0x00000002,

        /// <summary>
        ///     <c>TileShadingApronBitQCOM</c>
        /// </summary>
        TileShadingApronBitQCOM = 0x00000100,

        /// <summary>
        ///     <c>RasterizationOrderAttachmentColorAccessBitEXT</c>
        /// </summary>
        RasterizationOrderAttachmentColorAccessBitEXT = 0x00000010,

        /// <summary>
        ///     <c>RasterizationOrderAttachmentDepthAccessBitEXT</c>
        /// </summary>
        RasterizationOrderAttachmentDepthAccessBitEXT = 0x00000020,

        /// <summary>
        ///     <c>RasterizationOrderAttachmentStencilAccessBitEXT</c>
        /// </summary>
        RasterizationOrderAttachmentStencilAccessBitEXT = 0x00000040,

        /// <summary>
        ///     <c>EnableLegacyDitheringBitEXT</c>
        /// </summary>
        EnableLegacyDitheringBitEXT = 0x00000080,

        /// <summary>
        ///     <c>FragmentRegionBitEXT</c>
        /// </summary>
        FragmentRegionBitEXT = 0x00000004,

        /// <summary>
        ///     <c>CustomResolveBitEXT</c>
        /// </summary>
        CustomResolveBitEXT = 0x00000008,

        /// <summary>
        ///     <c>FragmentRegionBitQCOM</c>
        /// </summary>
        FragmentRegionBitQCOM = FragmentRegionBitEXT,

        /// <summary>
        ///     <c>ShaderResolveBitQCOM</c>
        /// </summary>
        ShaderResolveBitQCOM = CustomResolveBitEXT,

        /// <summary>
        ///     <c>RasterizationOrderAttachmentColorAccessBitARM</c>
        /// </summary>
        RasterizationOrderAttachmentColorAccessBitARM = RasterizationOrderAttachmentColorAccessBitEXT,

        /// <summary>
        ///     <c>RasterizationOrderAttachmentDepthAccessBitARM</c>
        /// </summary>
        RasterizationOrderAttachmentDepthAccessBitARM = RasterizationOrderAttachmentDepthAccessBitEXT,

        /// <summary>
        ///     <c>RasterizationOrderAttachmentStencilAccessBitARM</c>
        /// </summary>
        RasterizationOrderAttachmentStencilAccessBitARM = RasterizationOrderAttachmentStencilAccessBitEXT,

        /// <summary>
        ///     <c>FlagBitsMaxEnum</c>
        /// </summary>
        FlagBitsMaxEnum = 0x7FFFFFFF,
    }
}
