namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkFramebufferCreateFlagBits.html">VkFramebufferCreateFlagBits</see> - Bitmask specifying framebuffer properties
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which <i>can</i> be set in <c>VkFramebufferCreateInfo::flags</c>,
    ///         specifying options for framebuffers, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef enum VkFramebufferCreateFlagBits {
    ///             // Provided by VK_VERSION_1_2
    ///             VK_FRAMEBUFFER_CREATE_IMAGELESS_BIT = 0x00000001,
    ///             // Provided by VK_KHR_imageless_framebuffer
    ///             VK_FRAMEBUFFER_CREATE_IMAGELESS_BIT_KHR = VK_FRAMEBUFFER_CREATE_IMAGELESS_BIT,
    ///         } VkFramebufferCreateFlagBits;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkFramebufferCreateFlags : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>ImagelessBit</c>
        /// </summary>
        ImagelessBit = 0x00000001,

        /// <summary>
        ///     <c>ImagelessBitKHR</c>
        /// </summary>
        ImagelessBitKHR = ImagelessBit,

        /// <summary>
        ///     <c>FlagBitsMaxEnum</c>
        /// </summary>
        FlagBitsMaxEnum = 0x7FFFFFFF,
    }
}
