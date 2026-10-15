namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkStencilOp.html">VkStencilOp</see> - Stencil comparison function
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Possible values of the <c>failOp</c>, <c>passOp</c>, and <c>depthFailOp</c>
    ///         members of <c>VkStencilOpState</c>, specifying what happens to the stored
    ///         stencil value if this or certain subsequent tests fail or pass, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef enum VkStencilOp {
    ///             VK_STENCIL_OP_KEEP = 0,
    ///             VK_STENCIL_OP_ZERO = 1,
    ///             VK_STENCIL_OP_REPLACE = 2,
    ///             VK_STENCIL_OP_INCREMENT_AND_CLAMP = 3,
    ///             VK_STENCIL_OP_DECREMENT_AND_CLAMP = 4,
    ///             VK_STENCIL_OP_INVERT = 5,
    ///             VK_STENCIL_OP_INCREMENT_AND_WRAP = 6,
    ///             VK_STENCIL_OP_DECREMENT_AND_WRAP = 7,
    ///         } VkStencilOp;
    ///     </code>
    /// </remarks>
    public enum VkStencilOp : int
    {
        /// <summary>
        ///     <c>Keep</c> keeps the current value.
        /// </summary>
        Keep = 0,

        /// <summary>
        ///     <c>Zero</c> sets the value to 0.
        /// </summary>
        Zero = 1,

        /// <summary>
        ///     <c>Replace</c> sets the value to <c>reference</c>.
        /// </summary>
        Replace = 2,

        /// <summary>
        ///     <c>IncrementAndClamp</c> increments the current value and clamps to the maximum representable unsigned value.
        /// </summary>
        IncrementAndClamp = 3,

        /// <summary>
        ///     <c>DecrementAndClamp</c> decrements the current value and clamps to 0.
        /// </summary>
        DecrementAndClamp = 4,

        /// <summary>
        ///     <c>Invert</c> bitwise-inverts the current value.
        /// </summary>
        Invert = 5,

        /// <summary>
        ///     <c>IncrementAndWrap</c> increments the current value and wraps to 0 when the maximum value would have been exceeded.
        /// </summary>
        IncrementAndWrap = 6,

        /// <summary>
        ///     <c>DecrementAndWrap</c> decrements the current value and wraps to the maximum possible value when the value would go below 0.  For purposes of increment and decrement, the stencil bits are considered as an unsigned integer.
        /// </summary>
        DecrementAndWrap = 7,

        /// <summary>
        ///     <c>MaxEnum</c>
        /// </summary>
        MaxEnum = 0x7FFFFFFF,
    }
}
