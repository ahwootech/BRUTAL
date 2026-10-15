namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkImageViewSlicedCreateInfoEXT.html">VkImageViewSlicedCreateInfoEXT</see> - Specify the subset of 3D slices of an image view
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The range of 3D slices for the created image view <i>can</i> be restricted to a
    ///         subset of the parent image&apos;s Z range by adding a
    ///         <c>VkImageViewSlicedCreateInfoEXT</c> structure to the <c>pNext</c> chain of
    ///         <c>VkImageViewCreateInfo</c>.
    ///     </para>
    ///     <para>
    ///         The <c>VkImageViewSlicedCreateInfoEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_image_sliced_view_of_3d
    ///         typedef struct VkImageViewSlicedCreateInfoEXT {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             uint32_t           sliceOffset;
    ///             uint32_t           sliceCount;
    ///         } VkImageViewSlicedCreateInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkImageViewSlicedCreateInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.ImageViewSlicedCreateInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>SliceOffset</c> is the Z-offset for the first 3D slice accessible to the image view.
        /// </summary>
        [FieldOffset(16)]
        public int SliceOffset;

        /// <summary>
        ///     <c>SliceCount</c> is the number of 3D slices accessible to the image view.
        /// </summary>
        [FieldOffset(20)]
        public int SliceCount;
    }
}
