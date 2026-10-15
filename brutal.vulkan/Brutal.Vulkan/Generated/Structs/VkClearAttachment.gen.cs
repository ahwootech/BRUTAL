namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkClearAttachment.html">VkClearAttachment</see> - Structure specifying a clear attachment
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkClearAttachment</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef struct VkClearAttachment {
    ///             VkImageAspectFlags    aspectMask;
    ///             uint32_t              colorAttachment;
    ///             VkClearValue          clearValue;
    ///         } VkClearAttachment;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct VkClearAttachment()
    {
        /// <summary>
        ///     <c>AspectMask</c> is a mask selecting the color, depth and/or stencil aspects of the attachment to be cleared.
        /// </summary>
        [FieldOffset(0)]
        public VkImageAspectFlags AspectMask;

        /// <summary>
        ///     <c>ColorAttachment</c> is only meaningful if <c>VK_IMAGE_ASPECT_COLOR_BIT</c> is set in <c>aspectMask</c>, in which case it is an index into the bound color attachments.
        /// </summary>
        [FieldOffset(4)]
        public int ColorAttachment;

        /// <summary>
        ///     <c>ClearValue</c> is the color or depth/stencil value to clear the attachment to, as described in <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#clears-values">Clear Values^</see> below.
        /// </summary>
        [FieldOffset(8)]
        public VkClearValue ClearValue;
    }
}
