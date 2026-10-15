namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkCompositeAlphaFlagBitsKHR.html">VkCompositeAlphaFlagBitsKHR</see> - Alpha compositing modes supported on a device
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>supportedCompositeAlpha</c> member is of type
    ///         <c>VkCompositeAlphaFlagsKHR</c>, containing the following values:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_surface
    ///         typedef enum VkCompositeAlphaFlagBitsKHR {
    ///             VK_COMPOSITE_ALPHA_OPAQUE_BIT_KHR = 0x00000001,
    ///             VK_COMPOSITE_ALPHA_PRE_MULTIPLIED_BIT_KHR = 0x00000002,
    ///             VK_COMPOSITE_ALPHA_POST_MULTIPLIED_BIT_KHR = 0x00000004,
    ///             VK_COMPOSITE_ALPHA_INHERIT_BIT_KHR = 0x00000008,
    ///         } VkCompositeAlphaFlagBitsKHR;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkCompositeAlphaFlagsKHR : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>OpaqueBitKHR</c>
        /// </summary>
        OpaqueBitKHR = 0x00000001,

        /// <summary>
        ///     <c>PreMultipliedBitKHR</c>
        /// </summary>
        PreMultipliedBitKHR = 0x00000002,

        /// <summary>
        ///     <c>PostMultipliedBitKHR</c>
        /// </summary>
        PostMultipliedBitKHR = 0x00000004,

        /// <summary>
        ///     <c>InheritBitKHR</c>
        /// </summary>
        InheritBitKHR = 0x00000008,

        /// <summary>
        ///     <c>FlagBitsMaxEnumKHR</c>
        /// </summary>
        FlagBitsMaxEnumKHR = 0x7FFFFFFF,
    }
}
