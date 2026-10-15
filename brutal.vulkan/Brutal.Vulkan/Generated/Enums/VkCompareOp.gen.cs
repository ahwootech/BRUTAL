namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkCompareOp.html">VkCompareOp</see> - Comparison operator for depth, stencil, and sampler operations
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         <i>Comparison operators</i> compare a <i>reference</i> and a <i>test</i> value, and return
    ///         a true (&quot;`passed`&quot;) or false (&quot;`failed`&quot;) value depending on the comparison
    ///         operator chosen.
    ///         The supported operators are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef enum VkCompareOp {
    ///             VK_COMPARE_OP_NEVER = 0,
    ///             VK_COMPARE_OP_LESS = 1,
    ///             VK_COMPARE_OP_EQUAL = 2,
    ///             VK_COMPARE_OP_LESS_OR_EQUAL = 3,
    ///             VK_COMPARE_OP_GREATER = 4,
    ///             VK_COMPARE_OP_NOT_EQUAL = 5,
    ///             VK_COMPARE_OP_GREATER_OR_EQUAL = 6,
    ///             VK_COMPARE_OP_ALWAYS = 7,
    ///         } VkCompareOp;
    ///     </code>
    /// </remarks>
    public enum VkCompareOp : int
    {
        /// <summary>
        ///     <c>Never</c> specifies that the comparison always evaluates false.
        /// </summary>
        Never = 0,

        /// <summary>
        ///     <c>Less</c> specifies that the comparison evaluates <c><i>reference</i> &lt; <i>test</i></c>.
        /// </summary>
        Less = 1,

        /// <summary>
        ///     <c>Equal</c> specifies that the comparison evaluates <c><i>reference</i> = <i>test</i></c>.
        /// </summary>
        Equal = 2,

        /// <summary>
        ///     <c>LessOrEqual</c> specifies that the comparison evaluates <c><i>reference</i> &lt;= <i>test</i></c>.
        /// </summary>
        LessOrEqual = 3,

        /// <summary>
        ///     <c>Greater</c> specifies that the comparison evaluates <c><i>reference</i> &gt; <i>test</i></c>.
        /// </summary>
        Greater = 4,

        /// <summary>
        ///     <c>NotEqual</c> specifies that the comparison evaluates <c><i>reference</i> != <i>test</i></c>.
        /// </summary>
        NotEqual = 5,

        /// <summary>
        ///     <c>GreaterOrEqual</c> specifies that the comparison evaluates <c><i>reference</i> &gt;= <i>test</i></c>.
        /// </summary>
        GreaterOrEqual = 6,

        /// <summary>
        ///     <c>Always</c> specifies that the comparison always evaluates true.  Comparison operators are used for:
        /// </summary>
        Always = 7,

        /// <summary>
        ///     <c>MaxEnum</c>
        /// </summary>
        MaxEnum = 0x7FFFFFFF,
    }
}
