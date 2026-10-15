namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkBlendOp.html">VkBlendOp</see> - Framebuffer blending operations
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Once the source and destination blend factors have been selected, they along
    ///         with the source and destination components are passed to the blending
    ///         operations.
    ///         RGB and alpha components <i>can</i> use different operations.
    ///         Possible values of <c>VkBlendOp</c>, specifying the operations, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef enum VkBlendOp {
    ///             VK_BLEND_OP_ADD = 0,
    ///             VK_BLEND_OP_SUBTRACT = 1,
    ///             VK_BLEND_OP_REVERSE_SUBTRACT = 2,
    ///             VK_BLEND_OP_MIN = 3,
    ///             VK_BLEND_OP_MAX = 4,
    ///             // Provided by VK_EXT_blend_operation_advanced
    ///             VK_BLEND_OP_ZERO_EXT = 1000148000,
    ///             // Provided by VK_EXT_blend_operation_advanced
    ///             VK_BLEND_OP_SRC_EXT = 1000148001,
    ///             // Provided by VK_EXT_blend_operation_advanced
    ///             VK_BLEND_OP_DST_EXT = 1000148002,
    ///             // Provided by VK_EXT_blend_operation_advanced
    ///             VK_BLEND_OP_SRC_OVER_EXT = 1000148003,
    ///             // Provided by VK_EXT_blend_operation_advanced
    ///             VK_BLEND_OP_DST_OVER_EXT = 1000148004,
    ///             // Provided by VK_EXT_blend_operation_advanced
    ///             VK_BLEND_OP_SRC_IN_EXT = 1000148005,
    ///             // Provided by VK_EXT_blend_operation_advanced
    ///             VK_BLEND_OP_DST_IN_EXT = 1000148006,
    ///             // Provided by VK_EXT_blend_operation_advanced
    ///             VK_BLEND_OP_SRC_OUT_EXT = 1000148007,
    ///             // Provided by VK_EXT_blend_operation_advanced
    ///             VK_BLEND_OP_DST_OUT_EXT = 1000148008,
    ///             // Provided by VK_EXT_blend_operation_advanced
    ///             VK_BLEND_OP_SRC_ATOP_EXT = 1000148009,
    ///             // Provided by VK_EXT_blend_operation_advanced
    ///             VK_BLEND_OP_DST_ATOP_EXT = 1000148010,
    ///             // Provided by VK_EXT_blend_operation_advanced
    ///             VK_BLEND_OP_XOR_EXT = 1000148011,
    ///             // Provided by VK_EXT_blend_operation_advanced
    ///             VK_BLEND_OP_MULTIPLY_EXT = 1000148012,
    ///             // Provided by VK_EXT_blend_operation_advanced
    ///             VK_BLEND_OP_SCREEN_EXT = 1000148013,
    ///             // Provided by VK_EXT_blend_operation_advanced
    ///             VK_BLEND_OP_OVERLAY_EXT = 1000148014,
    ///             // Provided by VK_EXT_blend_operation_advanced
    ///             VK_BLEND_OP_DARKEN_EXT = 1000148015,
    ///             // Provided by VK_EXT_blend_operation_advanced
    ///             VK_BLEND_OP_LIGHTEN_EXT = 1000148016,
    ///             // Provided by VK_EXT_blend_operation_advanced
    ///             VK_BLEND_OP_COLORDODGE_EXT = 1000148017,
    ///             // Provided by VK_EXT_blend_operation_advanced
    ///             VK_BLEND_OP_COLORBURN_EXT = 1000148018,
    ///             // Provided by VK_EXT_blend_operation_advanced
    ///             VK_BLEND_OP_HARDLIGHT_EXT = 1000148019,
    ///             // Provided by VK_EXT_blend_operation_advanced
    ///             VK_BLEND_OP_SOFTLIGHT_EXT = 1000148020,
    ///             // Provided by VK_EXT_blend_operation_advanced
    ///             VK_BLEND_OP_DIFFERENCE_EXT = 1000148021,
    ///             // Provided by VK_EXT_blend_operation_advanced
    ///             VK_BLEND_OP_EXCLUSION_EXT = 1000148022,
    ///             // Provided by VK_EXT_blend_operation_advanced
    ///             VK_BLEND_OP_INVERT_EXT = 1000148023,
    ///             // Provided by VK_EXT_blend_operation_advanced
    ///             VK_BLEND_OP_INVERT_RGB_EXT = 1000148024,
    ///             // Provided by VK_EXT_blend_operation_advanced
    ///             VK_BLEND_OP_LINEARDODGE_EXT = 1000148025,
    ///             // Provided by VK_EXT_blend_operation_advanced
    ///             VK_BLEND_OP_LINEARBURN_EXT = 1000148026,
    ///             // Provided by VK_EXT_blend_operation_advanced
    ///             VK_BLEND_OP_VIVIDLIGHT_EXT = 1000148027,
    ///             // Provided by VK_EXT_blend_operation_advanced
    ///             VK_BLEND_OP_LINEARLIGHT_EXT = 1000148028,
    ///             // Provided by VK_EXT_blend_operation_advanced
    ///             VK_BLEND_OP_PINLIGHT_EXT = 1000148029,
    ///             // Provided by VK_EXT_blend_operation_advanced
    ///             VK_BLEND_OP_HARDMIX_EXT = 1000148030,
    ///             // Provided by VK_EXT_blend_operation_advanced
    ///             VK_BLEND_OP_HSL_HUE_EXT = 1000148031,
    ///             // Provided by VK_EXT_blend_operation_advanced
    ///             VK_BLEND_OP_HSL_SATURATION_EXT = 1000148032,
    ///             // Provided by VK_EXT_blend_operation_advanced
    ///             VK_BLEND_OP_HSL_COLOR_EXT = 1000148033,
    ///             // Provided by VK_EXT_blend_operation_advanced
    ///             VK_BLEND_OP_HSL_LUMINOSITY_EXT = 1000148034,
    ///             // Provided by VK_EXT_blend_operation_advanced
    ///             VK_BLEND_OP_PLUS_EXT = 1000148035,
    ///             // Provided by VK_EXT_blend_operation_advanced
    ///             VK_BLEND_OP_PLUS_CLAMPED_EXT = 1000148036,
    ///             // Provided by VK_EXT_blend_operation_advanced
    ///             VK_BLEND_OP_PLUS_CLAMPED_ALPHA_EXT = 1000148037,
    ///             // Provided by VK_EXT_blend_operation_advanced
    ///             VK_BLEND_OP_PLUS_DARKER_EXT = 1000148038,
    ///             // Provided by VK_EXT_blend_operation_advanced
    ///             VK_BLEND_OP_MINUS_EXT = 1000148039,
    ///             // Provided by VK_EXT_blend_operation_advanced
    ///             VK_BLEND_OP_MINUS_CLAMPED_EXT = 1000148040,
    ///             // Provided by VK_EXT_blend_operation_advanced
    ///             VK_BLEND_OP_CONTRAST_EXT = 1000148041,
    ///             // Provided by VK_EXT_blend_operation_advanced
    ///             VK_BLEND_OP_INVERT_OVG_EXT = 1000148042,
    ///             // Provided by VK_EXT_blend_operation_advanced
    ///             VK_BLEND_OP_RED_EXT = 1000148043,
    ///             // Provided by VK_EXT_blend_operation_advanced
    ///             VK_BLEND_OP_GREEN_EXT = 1000148044,
    ///             // Provided by VK_EXT_blend_operation_advanced
    ///             VK_BLEND_OP_BLUE_EXT = 1000148045,
    ///         } VkBlendOp;
    ///     </code>
    /// </remarks>
    public enum VkBlendOp : int
    {
        /// <summary>
        ///     <c>Add</c>
        /// </summary>
        Add = 0,

        /// <summary>
        ///     <c>Subtract</c>
        /// </summary>
        Subtract = 1,

        /// <summary>
        ///     <c>ReverseSubtract</c>
        /// </summary>
        ReverseSubtract = 2,

        /// <summary>
        ///     <c>Min</c>
        /// </summary>
        Min = 3,

        /// <summary>
        ///     <c>Max</c>
        /// </summary>
        Max = 4,

        /// <summary>
        ///     <c>ZeroEXT</c>
        /// </summary>
        ZeroEXT = 1000148000,

        /// <summary>
        ///     <c>SrcEXT</c>
        /// </summary>
        SrcEXT = 1000148001,

        /// <summary>
        ///     <c>DstEXT</c>
        /// </summary>
        DstEXT = 1000148002,

        /// <summary>
        ///     <c>SrcOverEXT</c>
        /// </summary>
        SrcOverEXT = 1000148003,

        /// <summary>
        ///     <c>DstOverEXT</c>
        /// </summary>
        DstOverEXT = 1000148004,

        /// <summary>
        ///     <c>SrcInEXT</c>
        /// </summary>
        SrcInEXT = 1000148005,

        /// <summary>
        ///     <c>DstInEXT</c>
        /// </summary>
        DstInEXT = 1000148006,

        /// <summary>
        ///     <c>SrcOutEXT</c>
        /// </summary>
        SrcOutEXT = 1000148007,

        /// <summary>
        ///     <c>DstOutEXT</c>
        /// </summary>
        DstOutEXT = 1000148008,

        /// <summary>
        ///     <c>SrcAtopEXT</c>
        /// </summary>
        SrcAtopEXT = 1000148009,

        /// <summary>
        ///     <c>DstAtopEXT</c>
        /// </summary>
        DstAtopEXT = 1000148010,

        /// <summary>
        ///     <c>XorEXT</c>
        /// </summary>
        XorEXT = 1000148011,

        /// <summary>
        ///     <c>MultiplyEXT</c>
        /// </summary>
        MultiplyEXT = 1000148012,

        /// <summary>
        ///     <c>ScreenEXT</c>
        /// </summary>
        ScreenEXT = 1000148013,

        /// <summary>
        ///     <c>OverlayEXT</c>
        /// </summary>
        OverlayEXT = 1000148014,

        /// <summary>
        ///     <c>DarkenEXT</c>
        /// </summary>
        DarkenEXT = 1000148015,

        /// <summary>
        ///     <c>LightenEXT</c>
        /// </summary>
        LightenEXT = 1000148016,

        /// <summary>
        ///     <c>ColordodgeEXT</c>
        /// </summary>
        ColordodgeEXT = 1000148017,

        /// <summary>
        ///     <c>ColorburnEXT</c>
        /// </summary>
        ColorburnEXT = 1000148018,

        /// <summary>
        ///     <c>HardlightEXT</c>
        /// </summary>
        HardlightEXT = 1000148019,

        /// <summary>
        ///     <c>SoftlightEXT</c>
        /// </summary>
        SoftlightEXT = 1000148020,

        /// <summary>
        ///     <c>DifferenceEXT</c>
        /// </summary>
        DifferenceEXT = 1000148021,

        /// <summary>
        ///     <c>ExclusionEXT</c>
        /// </summary>
        ExclusionEXT = 1000148022,

        /// <summary>
        ///     <c>InvertEXT</c>
        /// </summary>
        InvertEXT = 1000148023,

        /// <summary>
        ///     <c>InvertRGBEXT</c>
        /// </summary>
        InvertRGBEXT = 1000148024,

        /// <summary>
        ///     <c>LineardodgeEXT</c>
        /// </summary>
        LineardodgeEXT = 1000148025,

        /// <summary>
        ///     <c>LinearburnEXT</c>
        /// </summary>
        LinearburnEXT = 1000148026,

        /// <summary>
        ///     <c>VividlightEXT</c>
        /// </summary>
        VividlightEXT = 1000148027,

        /// <summary>
        ///     <c>LinearlightEXT</c>
        /// </summary>
        LinearlightEXT = 1000148028,

        /// <summary>
        ///     <c>PinlightEXT</c>
        /// </summary>
        PinlightEXT = 1000148029,

        /// <summary>
        ///     <c>HardmixEXT</c>
        /// </summary>
        HardmixEXT = 1000148030,

        /// <summary>
        ///     <c>HslHueEXT</c>
        /// </summary>
        HslHueEXT = 1000148031,

        /// <summary>
        ///     <c>HslSaturationEXT</c>
        /// </summary>
        HslSaturationEXT = 1000148032,

        /// <summary>
        ///     <c>HslColorEXT</c>
        /// </summary>
        HslColorEXT = 1000148033,

        /// <summary>
        ///     <c>HslLuminosityEXT</c>
        /// </summary>
        HslLuminosityEXT = 1000148034,

        /// <summary>
        ///     <c>PlusEXT</c>
        /// </summary>
        PlusEXT = 1000148035,

        /// <summary>
        ///     <c>PlusClampedEXT</c>
        /// </summary>
        PlusClampedEXT = 1000148036,

        /// <summary>
        ///     <c>PlusClampedAlphaEXT</c>
        /// </summary>
        PlusClampedAlphaEXT = 1000148037,

        /// <summary>
        ///     <c>PlusDarkerEXT</c>
        /// </summary>
        PlusDarkerEXT = 1000148038,

        /// <summary>
        ///     <c>MinusEXT</c>
        /// </summary>
        MinusEXT = 1000148039,

        /// <summary>
        ///     <c>MinusClampedEXT</c>
        /// </summary>
        MinusClampedEXT = 1000148040,

        /// <summary>
        ///     <c>ContrastEXT</c>
        /// </summary>
        ContrastEXT = 1000148041,

        /// <summary>
        ///     <c>InvertOvgEXT</c>
        /// </summary>
        InvertOvgEXT = 1000148042,

        /// <summary>
        ///     <c>RedEXT</c>
        /// </summary>
        RedEXT = 1000148043,

        /// <summary>
        ///     <c>GreenEXT</c>
        /// </summary>
        GreenEXT = 1000148044,

        /// <summary>
        ///     <c>BlueEXT</c>
        /// </summary>
        BlueEXT = 1000148045,

        /// <summary>
        ///     <c>MaxEnum</c>
        /// </summary>
        MaxEnum = 0x7FFFFFFF,
    }
}
