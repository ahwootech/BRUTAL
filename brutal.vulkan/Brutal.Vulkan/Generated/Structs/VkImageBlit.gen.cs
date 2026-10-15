namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkImageBlit.html">VkImageBlit</see> - Structure specifying an image blit operation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkImageBlit
    ///     </para>
    ///     <para>
    ///         The <c>VkImageBlit</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef struct VkImageBlit {
    ///             VkImageSubresourceLayers    srcSubresource;
    ///             VkOffset3D                  srcOffsets[2];
    ///             VkImageSubresourceLayers    dstSubresource;
    ///             VkOffset3D                  dstOffsets[2];
    ///         } VkImageBlit;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 80)]
    public partial struct VkImageBlit()
    {
        /// <summary>
        ///     <c>SrcSubresource</c> is the subresource to blit from.
        /// </summary>
        [FieldOffset(0)]
        public VkImageSubresourceLayers SrcSubresource;

        /// <summary>
        ///     <c>SrcOffsets</c> is a pointer to an array of two <c>VkOffset3D</c> structures specifying the bounds of the source region within <c>srcSubresource</c>.
        /// </summary>
        [FieldOffset(16)]
        public VkOffset3D_2 SrcOffsets;

        /// <summary>
        ///     <c>DstSubresource</c> is the subresource to blit into.
        /// </summary>
        [FieldOffset(40)]
        public VkImageSubresourceLayers DstSubresource;

        /// <summary>
        ///     <c>DstOffsets</c> is a pointer to an array of two <c>VkOffset3D</c> structures specifying the bounds of the destination region within <c>dstSubresource</c>.
        /// </summary>
        [FieldOffset(56)]
        public VkOffset3D_2 DstOffsets;
    }
}
