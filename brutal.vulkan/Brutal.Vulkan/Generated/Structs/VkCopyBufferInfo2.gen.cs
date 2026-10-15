namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkCopyBufferInfo2.html">VkCopyBufferInfo2</see> - Structure specifying parameters of a buffer copy command
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkCopyBufferInfo2
    ///     </para>
    ///     <para>
    ///         The <c>VkCopyBufferInfo2</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_3
    ///         typedef struct VkCopyBufferInfo2 {
    ///             VkStructureType         sType;
    ///             const void*             pNext;
    ///             VkBuffer                srcBuffer;
    ///             VkBuffer                dstBuffer;
    ///             uint32_t                regionCount;
    ///             const VkBufferCopy2*    pRegions;
    ///         } VkCopyBufferInfo2;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public unsafe partial struct VkCopyBufferInfo2()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.CopyBufferInfo2;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>SrcBuffer</c> is the source buffer.
        /// </summary>
        [FieldOffset(16)]
        public VkBuffer SrcBuffer;

        /// <summary>
        ///     <c>DstBuffer</c> is the destination buffer.
        /// </summary>
        [FieldOffset(24)]
        public VkBuffer DstBuffer;

        /// <summary>
        ///     <c>RegionCount</c> is the number of regions to copy.
        /// </summary>
        [FieldOffset(32)]
        public int RegionCount;

        /// <summary>
        ///     <c>Regions</c> is a pointer to an array of <c>VkBufferCopy2</c> structures specifying the regions to copy.
        /// </summary>
        [FieldOffset(40)]
        public VkBufferCopy2* Regions;
    }
}
