namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkBufferImageCopy.html">VkBufferImageCopy</see> - Structure specifying a buffer image copy operation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkBufferImageCopy
    ///     </para>
    ///     <para>
    ///         For both <c>vkCmdCopyBufferToImage</c> and <c>vkCmdCopyImageToBuffer</c>, each
    ///         element of <c>pRegions</c> is a structure defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef struct VkBufferImageCopy {
    ///             VkDeviceSize                bufferOffset;
    ///             uint32_t                    bufferRowLength;
    ///             uint32_t                    bufferImageHeight;
    ///             VkImageSubresourceLayers    imageSubresource;
    ///             VkOffset3D                  imageOffset;
    ///             VkExtent3D                  imageExtent;
    ///         } VkBufferImageCopy;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public partial struct VkBufferImageCopy()
    {
        /// <summary>
        ///     <c>BufferOffset</c> is the offset in bytes from the start of the buffer object where the image data is copied from or to.
        /// </summary>
        [FieldOffset(0)]
        public ByteSize64 BufferOffset;

        /// <summary>
        ///     <c>BufferRowLength</c> and <c>bufferImageHeight</c> specify in texels a subregion of a larger two- or three-dimensional image in buffer memory, and control the addressing calculations. If either of these values is zero, that aspect of the buffer memory is considered to be tightly packed according to the <c>imageExtent</c>.
        /// </summary>
        [FieldOffset(8)]
        public int BufferRowLength;

        /// <summary>
        ///     <c>BufferImageHeight</c>
        /// </summary>
        [FieldOffset(12)]
        public int BufferImageHeight;

        /// <summary>
        ///     <c>ImageSubresource</c> is a <c>VkImageSubresourceLayers</c> used to specify the specific image subresources of the image used for the source or destination image data.
        /// </summary>
        [FieldOffset(16)]
        public VkImageSubresourceLayers ImageSubresource;

        /// <summary>
        ///     <c>ImageOffset</c> selects the initial <c>x</c>, <c>y</c>, <c>z</c> offsets in texels of the sub-region of the source or destination image data.
        /// </summary>
        [FieldOffset(32)]
        public VkOffset3D ImageOffset;

        /// <summary>
        ///     <c>ImageExtent</c> is the size in texels of the image to copy in <c>width</c>, <c>height</c> and <c>depth</c>.
        /// </summary>
        [FieldOffset(44)]
        public VkExtent3D ImageExtent;
    }
}
