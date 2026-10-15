namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkClearDepthStencilValue.html">VkClearDepthStencilValue</see> - Structure specifying a clear depth stencil value
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkClearDepthStencilValue</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef struct VkClearDepthStencilValue {
    ///             float       depth;
    ///             uint32_t    stencil;
    ///         } VkClearDepthStencilValue;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct VkClearDepthStencilValue()
    {
        /// <summary>
        ///     <c>Depth</c> is the clear value for the depth aspect of the depth/stencil attachment. It is a floating-point value which is automatically converted to the attachment&apos;s format.
        /// </summary>
        [FieldOffset(0)]
        public float Depth;

        /// <summary>
        ///     <c>Stencil</c> is the clear value for the stencil aspect of the depth/stencil attachment. It is a 32-bit integer value which is converted to the attachment&apos;s format by taking the appropriate number of LSBs.
        /// </summary>
        [FieldOffset(4)]
        public int Stencil;
    }
}
