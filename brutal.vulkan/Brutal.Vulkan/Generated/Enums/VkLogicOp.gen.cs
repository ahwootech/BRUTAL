namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkLogicOp.html">VkLogicOp</see> - Framebuffer logical operations
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Logical operations are controlled by the <c>logicOpEnable</c> and
    ///         <c>logicOp</c> members of <c>VkPipelineColorBlendStateCreateInfo</c>.
    ///         If <c>logicOpEnable</c> is <c>VK_TRUE</c>, then a logical operation selected
    ///         by <c>logicOp</c> is applied between each color attachment and the fragment&apos;s
    ///         corresponding output value, and blending of all attachments is treated as if
    ///         it were disabled.
    ///         Any attachments using color formats for which logical operations are not
    ///         supported simply pass through the color values unmodified.
    ///         The logical operation is applied independently for each of the red, green,
    ///         blue, and alpha components.
    ///         The <c>logicOp</c> is selected from the following operations:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef enum VkLogicOp {
    ///             VK_LOGIC_OP_CLEAR = 0,
    ///             VK_LOGIC_OP_AND = 1,
    ///             VK_LOGIC_OP_AND_REVERSE = 2,
    ///             VK_LOGIC_OP_COPY = 3,
    ///             VK_LOGIC_OP_AND_INVERTED = 4,
    ///             VK_LOGIC_OP_NO_OP = 5,
    ///             VK_LOGIC_OP_XOR = 6,
    ///             VK_LOGIC_OP_OR = 7,
    ///             VK_LOGIC_OP_NOR = 8,
    ///             VK_LOGIC_OP_EQUIVALENT = 9,
    ///             VK_LOGIC_OP_INVERT = 10,
    ///             VK_LOGIC_OP_OR_REVERSE = 11,
    ///             VK_LOGIC_OP_COPY_INVERTED = 12,
    ///             VK_LOGIC_OP_OR_INVERTED = 13,
    ///             VK_LOGIC_OP_NAND = 14,
    ///             VK_LOGIC_OP_SET = 15,
    ///         } VkLogicOp;
    ///     </code>
    /// </remarks>
    public enum VkLogicOp : int
    {
        /// <summary>
        ///     <c>Clear</c>
        /// </summary>
        Clear = 0,

        /// <summary>
        ///     <c>And</c>
        /// </summary>
        And = 1,

        /// <summary>
        ///     <c>AndReverse</c>
        /// </summary>
        AndReverse = 2,

        /// <summary>
        ///     <c>Copy</c>
        /// </summary>
        Copy = 3,

        /// <summary>
        ///     <c>AndInverted</c>
        /// </summary>
        AndInverted = 4,

        /// <summary>
        ///     <c>NoOp</c>
        /// </summary>
        NoOp = 5,

        /// <summary>
        ///     <c>Xor</c>
        /// </summary>
        Xor = 6,

        /// <summary>
        ///     <c>Or</c>
        /// </summary>
        Or = 7,

        /// <summary>
        ///     <c>Nor</c>
        /// </summary>
        Nor = 8,

        /// <summary>
        ///     <c>Equivalent</c>
        /// </summary>
        Equivalent = 9,

        /// <summary>
        ///     <c>Invert</c>
        /// </summary>
        Invert = 10,

        /// <summary>
        ///     <c>OrReverse</c>
        /// </summary>
        OrReverse = 11,

        /// <summary>
        ///     <c>CopyInverted</c>
        /// </summary>
        CopyInverted = 12,

        /// <summary>
        ///     <c>OrInverted</c>
        /// </summary>
        OrInverted = 13,

        /// <summary>
        ///     <c>Nand</c>
        /// </summary>
        Nand = 14,

        /// <summary>
        ///     <c>Set</c>
        /// </summary>
        Set = 15,

        /// <summary>
        ///     <c>MaxEnum</c>
        /// </summary>
        MaxEnum = 0x7FFFFFFF,
    }
}
