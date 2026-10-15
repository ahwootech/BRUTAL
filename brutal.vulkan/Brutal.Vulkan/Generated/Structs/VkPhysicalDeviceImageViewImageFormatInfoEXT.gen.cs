namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceImageViewImageFormatInfoEXT.html">VkPhysicalDeviceImageViewImageFormatInfoEXT</see> - Structure for providing image view type
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceImageViewImageFormatInfoEXT</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_filter_cubic
    ///         typedef struct VkPhysicalDeviceImageViewImageFormatInfoEXT {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkImageViewType    imageViewType;
    ///         } VkPhysicalDeviceImageViewImageFormatInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceImageViewImageFormatInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceImageViewImageFormatInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ImageViewType</c> is a <c>VkImageViewType</c> value specifying the type of the image view.
        /// </summary>
        [FieldOffset(16)]
        public VkImageViewType ImageViewType;
    }
}
