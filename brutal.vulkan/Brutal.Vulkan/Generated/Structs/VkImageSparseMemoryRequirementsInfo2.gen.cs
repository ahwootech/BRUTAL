namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkImageSparseMemoryRequirementsInfo2.html">VkImageSparseMemoryRequirementsInfo2</see> - (None)
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkImageSparseMemoryRequirementsInfo2</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_1
    ///         typedef struct VkImageSparseMemoryRequirementsInfo2 {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             VkImage            image;
    ///         } VkImageSparseMemoryRequirementsInfo2;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkImageSparseMemoryRequirementsInfo2()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.ImageSparseMemoryRequirementsInfo2;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Image</c> is the image to query.
        /// </summary>
        [FieldOffset(16)]
        public VkImage Image;
    }
}
