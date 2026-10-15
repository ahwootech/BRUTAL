namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkImageViewMinLodCreateInfoEXT.html">VkImageViewMinLodCreateInfoEXT</see> - Structure describing the minimum LOD of an image view
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkImageViewMinLodCreateInfoEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_image_view_min_lod
    ///         typedef struct VkImageViewMinLodCreateInfoEXT {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             float              minLod;
    ///         } VkImageViewMinLodCreateInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkImageViewMinLodCreateInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.ImageViewMinLodCreateInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>MinLod</c> is the value to clamp the minimum LOD accessible by this <c>VkImageView</c>.
        /// </summary>
        [FieldOffset(16)]
        public float MinLod;
    }
}
