namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkClearValue.html">VkClearValue</see> - Structure specifying a clear value
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkClearValue</c> union is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef union VkClearValue {
    ///             VkClearColorValue           color;
    ///             VkClearDepthStencilValue    depthStencil;
    ///         } VkClearValue;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct VkClearValue()
    {
        /// <summary>
        ///     <c>Color</c> specifies the color image clear values to use when clearing a color image or attachment.
        /// </summary>
        [FieldOffset(0)]
        public VkClearColorValue Color;

        /// <summary>
        ///     <c>DepthStencil</c> specifies the depth and stencil clear values to use when clearing a depth/stencil image or attachment.
        /// </summary>
        [FieldOffset(0)]
        public VkClearDepthStencilValue DepthStencil;
    }
}
