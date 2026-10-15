namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkRenderingAttachmentFlagBitsKHR.html">VkRenderingAttachmentFlagBitsKHR</see> - Bitmask specifying additional properties of a rendering attachment
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which <i>can</i> be set in
    ///         <c>VkRenderingAttachmentFlagsInfoKHR::flags</c>, describing additional
    ///         properties of a rendering attachment, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_maintenance10
    ///         typedef enum VkRenderingAttachmentFlagBitsKHR {
    ///             // Provided by VK_KHR_maintenance10 with (VK_VERSION_1_4 or VK_KHR_dynamic_rendering_local_read) and (VK_VERSION_1_3 or VK_KHR_dynamic_rendering)
    ///             VK_RENDERING_ATTACHMENT_INPUT_ATTACHMENT_FEEDBACK_BIT_KHR = 0x00000001,
    ///             // Provided by VK_KHR_maintenance10 with VK_VERSION_1_3 or VK_KHR_dynamic_rendering
    ///             VK_RENDERING_ATTACHMENT_RESOLVE_SKIP_TRANSFER_FUNCTION_BIT_KHR = 0x00000002,
    ///             // Provided by VK_KHR_maintenance10 with VK_VERSION_1_3 or VK_KHR_dynamic_rendering
    ///             VK_RENDERING_ATTACHMENT_RESOLVE_ENABLE_TRANSFER_FUNCTION_BIT_KHR = 0x00000004,
    ///         } VkRenderingAttachmentFlagBitsKHR;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkRenderingAttachmentFlagsKHR : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>InputAttachmentFeedbackBitKHR</c>  specifies that the attachment <i>can</i> be used concurrently as both an input attachment and a write-only attachment during the render pass, creating a feedback loop while processing a fragment, and without a <c>VK_DEPENDENCY_BY_REGION_BIT</c> barrier separating the write attachment and input attachment usage. Using this flag does not remove the general requirement to use a <c>VK_DEPENDENCY_BY_REGION_BIT</c> barrier to resolve hazards when two different fragments accesses a particular attachment region, where one of them performs an attachment write, and a subsequent fragment performs an input attachment read. If <c>VK_RENDERING_LOCAL_READ_CONCURRENT_ACCESS_CONTROL_BIT_KHR</c> is specified in the rendering info, this flag <i>must</i> be set for an attachment to be used concurrently as an input attachment and a write attachment in this manner. If <c>VK_RENDERING_LOCAL_READ_CONCURRENT_ACCESS_CONTROL_BIT_KHR</c> is not specified in the rendering info, this flag is implied to be set for any attachment which has a combination of image layouts and image view usage flags which support input attachment usage.
        /// </summary>
        InputAttachmentFeedbackBitKHR = 0x00000001,

        /// <summary>
        ///     <c>ResolveSkipTransferFunctionBitKHR</c>  specifies that resolve operations happening to an sRGB encoded attachment <i>must</i> not convert samples from nonlinear to linear before averaging.
        /// </summary>
        ResolveSkipTransferFunctionBitKHR = 0x00000002,

        /// <summary>
        ///     <c>ResolveEnableTransferFunctionBitKHR</c>  specifies that resolve operations happening to an sRGB encoded attachment <i>must</i> convert samples from nonlinear to linear before averaging.  [NOTE]
        /// </summary>
        ResolveEnableTransferFunctionBitKHR = 0x00000004,

        /// <summary>
        ///     <c>FlagBitsMaxEnumKHR</c>
        /// </summary>
        FlagBitsMaxEnumKHR = 0x7FFFFFFF,
    }
}
