namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkCopyMemoryToImageIndirectCommandKHR.html">VkCopyMemoryToImageIndirectCommandKHR</see> - Structure specifying indirect memory region to image copy operation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkCopyMemoryToImageIndirectCommandKHR
    ///     </para>
    ///     <para>
    ///         The structure describing source and destination memory regions,
    ///         <c>VkCopyMemoryToImageIndirectCommandKHR</c> is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_copy_memory_indirect
    ///         typedef struct VkCopyMemoryToImageIndirectCommandKHR {
    ///             VkDeviceAddress             srcAddress;
    ///             uint32_t                    bufferRowLength;
    ///             uint32_t                    bufferImageHeight;
    ///             VkImageSubresourceLayers    imageSubresource;
    ///             VkOffset3D                  imageOffset;
    ///             VkExtent3D                  imageExtent;
    ///         } VkCopyMemoryToImageIndirectCommandKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public partial struct VkCopyMemoryToImageIndirectCommandKHR()
    {
        /// <summary>
        ///     <c>SrcAddress</c> is the starting address of the source device memory to copy from.
        /// </summary>
        [FieldOffset(0)]
        public VkDeviceAddress SrcAddress;

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
        ///     <c>ImageSubresource</c> is a <c>VkImageSubresourceLayers</c> structure used to specify the specific image subresources of the image used for the destination image data, which <i>must</i> match the value specified in corresponding index of the <c>pCopyMemoryToImageIndirectInfo</c>-&gt;pImageSubresources array of <c>vkCmdCopyMemoryToImageIndirectKHR</c> during command recording.
        /// </summary>
        [FieldOffset(16)]
        public VkImageSubresourceLayers ImageSubresource;

        /// <summary>
        ///     <c>ImageOffset</c> selects the initial <c>x</c>, <c>y</c>, <c>z</c> offsets in texels of the sub-region of the destination image data.
        /// </summary>
        [FieldOffset(32)]
        public VkOffset3D ImageOffset;

        /// <summary>
        ///     <c>ImageExtent</c> is the size in texels of the destination image in <c>width</c>, <c>height</c> and <c>depth</c>.
        /// </summary>
        [FieldOffset(44)]
        public VkExtent3D ImageExtent;
    }
}
