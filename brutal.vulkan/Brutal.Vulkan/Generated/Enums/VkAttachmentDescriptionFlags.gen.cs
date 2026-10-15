namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkAttachmentDescriptionFlagBits.html">VkAttachmentDescriptionFlagBits</see> - Bitmask specifying additional properties of an attachment
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which <i>can</i> be set in <c>VkAttachmentDescription::flags</c>,
    ///         describing additional properties of the attachment, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef enum VkAttachmentDescriptionFlagBits {
    ///             VK_ATTACHMENT_DESCRIPTION_MAY_ALIAS_BIT = 0x00000001,
    ///             // Provided by VK_KHR_maintenance10
    ///             VK_ATTACHMENT_DESCRIPTION_RESOLVE_SKIP_TRANSFER_FUNCTION_BIT_KHR = 0x00000002,
    ///             // Provided by VK_KHR_maintenance10
    ///             VK_ATTACHMENT_DESCRIPTION_RESOLVE_ENABLE_TRANSFER_FUNCTION_BIT_KHR = 0x00000004,
    ///         } VkAttachmentDescriptionFlagBits;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkAttachmentDescriptionFlags : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>MayAliasBit</c> specifies that the attachment aliases the same device memory as other attachments.
        /// </summary>
        MayAliasBit = 0x00000001,

        /// <summary>
        ///     <c>ResolveSkipTransferFunctionBitKHR</c>
        /// </summary>
        ResolveSkipTransferFunctionBitKHR = 0x00000002,

        /// <summary>
        ///     <c>ResolveEnableTransferFunctionBitKHR</c>
        /// </summary>
        ResolveEnableTransferFunctionBitKHR = 0x00000004,

        /// <summary>
        ///     <c>FlagBitsMaxEnum</c>
        /// </summary>
        FlagBitsMaxEnum = 0x7FFFFFFF,
    }
}
