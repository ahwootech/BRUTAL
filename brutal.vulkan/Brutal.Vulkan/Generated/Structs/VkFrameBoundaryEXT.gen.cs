namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkFrameBoundaryEXT.html">VkFrameBoundaryEXT</see> - Add frame boundary information to queue submissions
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkFrameBoundaryEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_frame_boundary
    ///         typedef struct VkFrameBoundaryEXT {
    ///             VkStructureType            sType;
    ///             const void*                pNext;
    ///             VkFrameBoundaryFlagsEXT    flags;
    ///             uint64_t                   frameID;
    ///             uint32_t                   imageCount;
    ///             const VkImage*             pImages;
    ///             uint32_t                   bufferCount;
    ///             const VkBuffer*            pBuffers;
    ///             uint64_t                   tagName;
    ///             size_t                     tagSize;
    ///             const void*                pTag;
    ///         } VkFrameBoundaryEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 88)]
    public unsafe partial struct VkFrameBoundaryEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.FrameBoundaryEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is a bitmask of <c>VkFrameBoundaryFlagsEXT</c> that can flag the last submission of a frame identifier.
        /// </summary>
        [FieldOffset(16)]
        public VkFrameBoundaryFlagsEXT Flags;

        /// <summary>
        ///     <c>FrameID</c> is the frame identifier.
        /// </summary>
        [FieldOffset(24)]
        public nint FrameID;

        /// <summary>
        ///     <c>ImageCount</c> is the number of images that store frame results.
        /// </summary>
        [FieldOffset(32)]
        public int ImageCount;

        /// <summary>
        ///     <c>Images</c> is a pointer to an array of VkImage objects with imageCount entries.
        /// </summary>
        [FieldOffset(40)]
        public VkImage* Images;

        /// <summary>
        ///     <c>BufferCount</c> is the number of buffers the store the frame results.
        /// </summary>
        [FieldOffset(48)]
        public int BufferCount;

        /// <summary>
        ///     <c>Buffers</c> is a pointer to an array of VkBuffer objects with bufferCount entries.
        /// </summary>
        [FieldOffset(56)]
        public VkBuffer* Buffers;

        /// <summary>
        ///     <c>TagName</c> is a numerical identifier for tag data.
        /// </summary>
        [FieldOffset(64)]
        public nint TagName;

        /// <summary>
        ///     <c>TagSize</c> is the number of bytes of tag data.
        /// </summary>
        [FieldOffset(72)]
        public nuint TagSize;

        /// <summary>
        ///     <c>Tag</c> is a pointer to an array of <c>tagSize</c> bytes containing tag data.
        /// </summary>
        [FieldOffset(80)]
        public void* Tag;
    }
}
