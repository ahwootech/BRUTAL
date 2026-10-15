namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkFrontFace.html">VkFrontFace</see> - Interpret polygon front-facing orientation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The first step of polygon rasterization is to determine whether the triangle
    ///         is _back-facing_ or _front-facing_.
    ///         This determination is made based on the sign of the (clipped or unclipped)
    ///         polygon&apos;s area computed in framebuffer coordinates.
    ///         One way to compute this area is:
    ///     </para>
    ///     <para>
    ///         [latexmath]
    ///         ++++
    ///         a = -{1 \over 2}\sum_{i=0}^{n-1}
    ///         x_f^i y_f^{i \oplus 1} -
    ///         x_f^{i \oplus 1} y_f^i
    ///         ++++
    ///     </para>
    ///     <para>
    ///         where latexmath:[x_f^i] and latexmath:[y_f^i] are the <c>x</c> and <c>y</c>
    ///         framebuffer coordinates of the [eq]##i##th vertex of the <c>n</c>-vertex
    ///         polygon (vertices are numbered starting at zero for the purposes of this
    ///         computation) and <c>i {oplus} 1</c> is <c>(i {plus} 1) mod n</c>.
    ///     </para>
    ///     <para>
    ///         The interpretation of the sign of <c>a</c> is determined by the
    ///         <c>VkPipelineRasterizationStateCreateInfo::frontFace</c> property of
    ///         the currently active pipeline.
    ///         Possible values are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef enum VkFrontFace {
    ///             VK_FRONT_FACE_COUNTER_CLOCKWISE = 0,
    ///             VK_FRONT_FACE_CLOCKWISE = 1,
    ///         } VkFrontFace;
    ///     </code>
    /// </remarks>
    public enum VkFrontFace : int
    {
        /// <summary>
        ///     <c>CounterClockwise</c> specifies that a triangle with positive area is considered front-facing.
        /// </summary>
        CounterClockwise = 0,

        /// <summary>
        ///     <c>Clockwise</c> specifies that a triangle with negative area is considered front-facing.  Any triangle which is not front-facing is back-facing, including zero-area triangles.
        /// </summary>
        Clockwise = 1,

        /// <summary>
        ///     <c>MaxEnum</c>
        /// </summary>
        MaxEnum = 0x7FFFFFFF,
    }
}
