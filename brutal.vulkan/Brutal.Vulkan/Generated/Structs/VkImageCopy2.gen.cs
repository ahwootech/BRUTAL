namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkImageCopy2.html">VkImageCopy2</see> - Structure specifying an image copy operation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkImageCopy2
    ///     </para>
    ///     <para>
    ///         The <c>VkImageCopy2</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_3
    ///         typedef struct VkImageCopy2 {
    ///             VkStructureType             sType;
    ///             const void*                 pNext;
    ///             VkImageSubresourceLayers    srcSubresource;
    ///             VkOffset3D                  srcOffset;
    ///             VkImageSubresourceLayers    dstSubresource;
    ///             VkOffset3D                  dstOffset;
    ///             VkExtent3D                  extent;
    ///         } VkImageCopy2;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 88)]
    public unsafe partial struct VkImageCopy2()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.ImageCopy2;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>SrcSubresource</c> and <c>dstSubresource</c> are <c>VkImageSubresourceLayers</c> structures specifying the image subresources of the images used for the source and destination image data, respectively.
        /// </summary>
        [FieldOffset(16)]
        public VkImageSubresourceLayers SrcSubresource;

        /// <summary>
        ///     <c>SrcOffset</c> and <c>dstOffset</c> select the initial <c>x</c>, <c>y</c>, and <c>z</c> offsets in texels of the sub-regions of the source and destination image data.
        /// </summary>
        [FieldOffset(32)]
        public VkOffset3D SrcOffset;

        /// <summary>
        ///     <c>DstSubresource</c>
        /// </summary>
        [FieldOffset(44)]
        public VkImageSubresourceLayers DstSubresource;

        /// <summary>
        ///     <c>DstOffset</c>
        /// </summary>
        [FieldOffset(60)]
        public VkOffset3D DstOffset;

        /// <summary>
        ///     <c>Extent</c> is the size in texels of the image to copy in <c>width</c>, <c>height</c> and <c>depth</c>.
        /// </summary>
        [FieldOffset(72)]
        public VkExtent3D Extent;
    }
}
