namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkImageResolve.html">VkImageResolve</see> - Structure specifying an image resolve operation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkImageResolve
    ///     </para>
    ///     <para>
    ///         The <c>VkImageResolve</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef struct VkImageResolve {
    ///             VkImageSubresourceLayers    srcSubresource;
    ///             VkOffset3D                  srcOffset;
    ///             VkImageSubresourceLayers    dstSubresource;
    ///             VkOffset3D                  dstOffset;
    ///             VkExtent3D                  extent;
    ///         } VkImageResolve;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 68)]
    public partial struct VkImageResolve()
    {
        /// <summary>
        ///     <c>SrcSubresource</c> and <c>dstSubresource</c> are <c>VkImageSubresourceLayers</c> structures specifying the image subresources of the images used for the source and destination image data, respectively. Resolve of depth/stencil images is not supported.
        /// </summary>
        [FieldOffset(0)]
        public VkImageSubresourceLayers SrcSubresource;

        /// <summary>
        ///     <c>SrcOffset</c> and <c>dstOffset</c> select the initial <c>x</c>, <c>y</c>, and <c>z</c> offsets in texels of the sub-regions of the source and destination image data.
        /// </summary>
        [FieldOffset(16)]
        public VkOffset3D SrcOffset;

        /// <summary>
        ///     <c>DstSubresource</c>
        /// </summary>
        [FieldOffset(28)]
        public VkImageSubresourceLayers DstSubresource;

        /// <summary>
        ///     <c>DstOffset</c>
        /// </summary>
        [FieldOffset(44)]
        public VkOffset3D DstOffset;

        /// <summary>
        ///     <c>Extent</c> is the size in texels of the source image to resolve in <c>width</c>, <c>height</c> and <c>depth</c>.
        /// </summary>
        [FieldOffset(56)]
        public VkExtent3D Extent;
    }
}
