namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkCopyMemoryToImageIndirectInfoKHR.html">VkCopyMemoryToImageIndirectInfoKHR</see> - Parameters describing indirect image copy parameters
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkCopyMemoryToImageIndirectInfoKHR
    ///     </para>
    ///     <para>
    ///         The <c>VkCopyMemoryToImageIndirectInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_copy_memory_indirect
    ///         typedef struct VkCopyMemoryToImageIndirectInfoKHR {
    ///             VkStructureType                    sType;
    ///             const void*                        pNext;
    ///             VkAddressCopyFlagsKHR              srcCopyFlags;
    ///             uint32_t                           copyCount;
    ///             VkStridedDeviceAddressRangeKHR     copyAddressRange;
    ///             VkImage                            dstImage;
    ///             VkImageLayout                      dstImageLayout;
    ///             const VkImageSubresourceLayers*    pImageSubresources;
    ///         } VkCopyMemoryToImageIndirectInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 72)]
    public unsafe partial struct VkCopyMemoryToImageIndirectInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.CopyMemoryToImageIndirectInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>SrcCopyFlags</c> is a <c>VkAddressCopyFlagsKHR</c> value defining the copy flags for the source address range.
        /// </summary>
        [FieldOffset(16)]
        public VkAddressCopyFlagsKHR SrcCopyFlags;

        /// <summary>
        ///     <c>CopyCount</c> is the number of copies to execute, and <i>can</i> be zero.
        /// </summary>
        [FieldOffset(20)]
        public int CopyCount;

        /// <summary>
        ///     <c>CopyAddressRange</c> is a memory region specifying the copy parameters. It is laid out as an array of <c>VkCopyMemoryToImageIndirectCommandKHR</c> structures.
        /// </summary>
        [FieldOffset(24)]
        public VkStridedDeviceAddressRangeKHR CopyAddressRange;

        /// <summary>
        ///     <c>DstImage</c> is the destination image.
        /// </summary>
        [FieldOffset(48)]
        public VkImage DstImage;

        /// <summary>
        ///     <c>DstImageLayout</c> is the layout of the destination image subresources for the copy.
        /// </summary>
        [FieldOffset(56)]
        public VkImageLayout DstImageLayout;

        /// <summary>
        ///     <c>ImageSubresources</c> is a pointer to an array of <c>copyCount</c> <c>VkImageSubresourceLayers</c> structures, specifying the image subresources of the destination image data for the copy operation.
        /// </summary>
        [FieldOffset(64)]
        public VkImageSubresourceLayers* ImageSubresources;
    }
}
