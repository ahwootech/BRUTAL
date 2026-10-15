namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkBlendFactor.html">VkBlendFactor</see> - Framebuffer blending factors
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The source and destination color and alpha blending factors are selected
    ///         from the enum:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef enum VkBlendFactor {
    ///             VK_BLEND_FACTOR_ZERO = 0,
    ///             VK_BLEND_FACTOR_ONE = 1,
    ///             VK_BLEND_FACTOR_SRC_COLOR = 2,
    ///             VK_BLEND_FACTOR_ONE_MINUS_SRC_COLOR = 3,
    ///             VK_BLEND_FACTOR_DST_COLOR = 4,
    ///             VK_BLEND_FACTOR_ONE_MINUS_DST_COLOR = 5,
    ///             VK_BLEND_FACTOR_SRC_ALPHA = 6,
    ///             VK_BLEND_FACTOR_ONE_MINUS_SRC_ALPHA = 7,
    ///             VK_BLEND_FACTOR_DST_ALPHA = 8,
    ///             VK_BLEND_FACTOR_ONE_MINUS_DST_ALPHA = 9,
    ///             VK_BLEND_FACTOR_CONSTANT_COLOR = 10,
    ///             VK_BLEND_FACTOR_ONE_MINUS_CONSTANT_COLOR = 11,
    ///             VK_BLEND_FACTOR_CONSTANT_ALPHA = 12,
    ///             VK_BLEND_FACTOR_ONE_MINUS_CONSTANT_ALPHA = 13,
    ///             VK_BLEND_FACTOR_SRC_ALPHA_SATURATE = 14,
    ///             VK_BLEND_FACTOR_SRC1_COLOR = 15,
    ///             VK_BLEND_FACTOR_ONE_MINUS_SRC1_COLOR = 16,
    ///             VK_BLEND_FACTOR_SRC1_ALPHA = 17,
    ///             VK_BLEND_FACTOR_ONE_MINUS_SRC1_ALPHA = 18,
    ///         } VkBlendFactor;
    ///     </code>
    /// </remarks>
    public enum VkBlendFactor : int
    {
        /// <summary>
        ///     <c>Zero</c>
        /// </summary>
        Zero = 0,

        /// <summary>
        ///     <c>One</c>
        /// </summary>
        One = 1,

        /// <summary>
        ///     <c>SrcColor</c>
        /// </summary>
        SrcColor = 2,

        /// <summary>
        ///     <c>OneMinusSrcColor</c>
        /// </summary>
        OneMinusSrcColor = 3,

        /// <summary>
        ///     <c>DstColor</c>
        /// </summary>
        DstColor = 4,

        /// <summary>
        ///     <c>OneMinusDstColor</c>
        /// </summary>
        OneMinusDstColor = 5,

        /// <summary>
        ///     <c>SrcAlpha</c>
        /// </summary>
        SrcAlpha = 6,

        /// <summary>
        ///     <c>OneMinusSrcAlpha</c>
        /// </summary>
        OneMinusSrcAlpha = 7,

        /// <summary>
        ///     <c>DstAlpha</c>
        /// </summary>
        DstAlpha = 8,

        /// <summary>
        ///     <c>OneMinusDstAlpha</c>
        /// </summary>
        OneMinusDstAlpha = 9,

        /// <summary>
        ///     <c>ConstantColor</c>
        /// </summary>
        ConstantColor = 10,

        /// <summary>
        ///     <c>OneMinusConstantColor</c>
        /// </summary>
        OneMinusConstantColor = 11,

        /// <summary>
        ///     <c>ConstantAlpha</c>
        /// </summary>
        ConstantAlpha = 12,

        /// <summary>
        ///     <c>OneMinusConstantAlpha</c>
        /// </summary>
        OneMinusConstantAlpha = 13,

        /// <summary>
        ///     <c>SrcAlphaSaturate</c>
        /// </summary>
        SrcAlphaSaturate = 14,

        /// <summary>
        ///     <c>Src1Color</c>
        /// </summary>
        Src1Color = 15,

        /// <summary>
        ///     <c>OneMinusSrc1Color</c>
        /// </summary>
        OneMinusSrc1Color = 16,

        /// <summary>
        ///     <c>Src1Alpha</c>
        /// </summary>
        Src1Alpha = 17,

        /// <summary>
        ///     <c>OneMinusSrc1Alpha</c>
        /// </summary>
        OneMinusSrc1Alpha = 18,

        /// <summary>
        ///     <c>MaxEnum</c>
        /// </summary>
        MaxEnum = 0x7FFFFFFF,
    }
}
