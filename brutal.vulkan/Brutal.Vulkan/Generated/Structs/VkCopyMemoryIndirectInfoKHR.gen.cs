namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkCopyMemoryIndirectInfoKHR.html">VkCopyMemoryIndirectInfoKHR</see> - Parameters describing indirect copy parameters
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkCopyMemoryIndirectInfoKHR
    ///     </para>
    ///     <para>
    ///         The <c>VkCopyMemoryIndirectInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_copy_memory_indirect
    ///         typedef struct VkCopyMemoryIndirectInfoKHR {
    ///             VkStructureType                   sType;
    ///             const void*                       pNext;
    ///             VkAddressCopyFlagsKHR             srcCopyFlags;
    ///             VkAddressCopyFlagsKHR             dstCopyFlags;
    ///             uint32_t                          copyCount;
    ///             VkStridedDeviceAddressRangeKHR    copyAddressRange;
    ///         } VkCopyMemoryIndirectInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public unsafe partial struct VkCopyMemoryIndirectInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.CopyMemoryIndirectInfoKHR;

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
        ///     <c>DstCopyFlags</c> is a <c>VkAddressCopyFlagsKHR</c> value defining the copy flags for the destination address range.
        /// </summary>
        [FieldOffset(20)]
        public VkAddressCopyFlagsKHR DstCopyFlags;

        /// <summary>
        ///     <c>CopyCount</c> is the number of copies to execute, and <i>can</i> be zero.
        /// </summary>
        [FieldOffset(24)]
        public int CopyCount;

        /// <summary>
        ///     <c>CopyAddressRange</c> is a memory region specifying the copy parameters. It is laid out as an array of <c>VkCopyMemoryIndirectCommandKHR</c> structures.
        /// </summary>
        [FieldOffset(32)]
        public VkStridedDeviceAddressRangeKHR CopyAddressRange;
    }
}
