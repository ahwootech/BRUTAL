namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkConditionalRenderingFlagBitsEXT.html">VkConditionalRenderingFlagBitsEXT</see> - Specify the behavior of conditional rendering
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which <i>can</i> be set in
    ///         <c>vkCmdBeginConditionalRenderingEXT::flags</c>, specifying the
    ///         behavior of conditional rendering, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_conditional_rendering
    ///         typedef enum VkConditionalRenderingFlagBitsEXT {
    ///             VK_CONDITIONAL_RENDERING_INVERTED_BIT_EXT = 0x00000001,
    ///         } VkConditionalRenderingFlagBitsEXT;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkConditionalRenderingFlagsEXT : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>InvertedBitEXT</c> specifies the condition used to determine whether to discard rendering commands or not. That is, if the 32-bit predicate read from <c>buffer</c> memory at <c>offset</c> is zero, the rendering commands are not discarded, and if non zero, then they are discarded.
        /// </summary>
        InvertedBitEXT = 0x00000001,

        /// <summary>
        ///     <c>FlagBitsMaxEnumEXT</c>
        /// </summary>
        FlagBitsMaxEnumEXT = 0x7FFFFFFF,
    }
}
