namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkImageBlit2.html">VkImageBlit2</see> - Structure specifying an image blit operation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkImageBlit2
    ///     </para>
    ///     <para>
    ///         The <c>VkImageBlit2</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_3
    ///         typedef struct VkImageBlit2 {
    ///             VkStructureType             sType;
    ///             const void*                 pNext;
    ///             VkImageSubresourceLayers    srcSubresource;
    ///             VkOffset3D                  srcOffsets[2];
    ///             VkImageSubresourceLayers    dstSubresource;
    ///             VkOffset3D                  dstOffsets[2];
    ///         } VkImageBlit2;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 96)]
    public unsafe partial struct VkImageBlit2()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.ImageBlit2;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>SrcSubresource</c> is the subresource to blit from.
        /// </summary>
        [FieldOffset(16)]
        public VkImageSubresourceLayers SrcSubresource;

        /// <summary>
        ///     <c>SrcOffsets</c> is a pointer to an array of two <c>VkOffset3D</c> structures specifying the bounds of the source region within <c>srcSubresource</c>.
        /// </summary>
        [FieldOffset(32)]
        public VkOffset3D_2 SrcOffsets;

        /// <summary>
        ///     <c>DstSubresource</c> is the subresource to blit into.
        /// </summary>
        [FieldOffset(56)]
        public VkImageSubresourceLayers DstSubresource;

        /// <summary>
        ///     <c>DstOffsets</c> is a pointer to an array of two <c>VkOffset3D</c> structures specifying the bounds of the destination region within <c>dstSubresource</c>.
        /// </summary>
        [FieldOffset(72)]
        public VkOffset3D_2 DstOffsets;
    }
}
