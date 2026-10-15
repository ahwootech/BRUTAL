namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkResolveImageFlagBitsKHR.html">VkResolveImageFlagBitsKHR</see> - Bitmask specifying additional properties of a resolve image operation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which <i>can</i> be set in <c>VkResolveImageModeInfoKHR::flags</c>,
    ///         describing additional properties of a resolve operation, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_maintenance10
    ///         typedef enum VkResolveImageFlagBitsKHR {
    ///             // Provided by VK_KHR_maintenance10 with VK_VERSION_1_3 or VK_KHR_copy_commands2
    ///             VK_RESOLVE_IMAGE_SKIP_TRANSFER_FUNCTION_BIT_KHR = 0x00000001,
    ///             // Provided by VK_KHR_maintenance10 with VK_VERSION_1_3 or VK_KHR_copy_commands2
    ///             VK_RESOLVE_IMAGE_ENABLE_TRANSFER_FUNCTION_BIT_KHR = 0x00000002,
    ///         } VkResolveImageFlagBitsKHR;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkResolveImageFlagsKHR : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>SkipTransferFunctionBitKHR</c> specifies that resolve operations happening to an sRGB encoded image <i>must</i> not convert samples from nonlinear to linear before averaging.
        /// </summary>
        SkipTransferFunctionBitKHR = 0x00000001,

        /// <summary>
        ///     <c>EnableTransferFunctionBitKHR</c> specifies that resolve operations happening to an sRGB encoded image <i>must</i> convert samples from nonlinear to linear before averaging.
        /// </summary>
        EnableTransferFunctionBitKHR = 0x00000002,

        /// <summary>
        ///     <c>FlagBitsMaxEnumKHR</c>
        /// </summary>
        FlagBitsMaxEnumKHR = 0x7FFFFFFF,
    }
}
