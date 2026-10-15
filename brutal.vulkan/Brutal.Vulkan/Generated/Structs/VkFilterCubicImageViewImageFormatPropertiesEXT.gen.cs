namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkFilterCubicImageViewImageFormatPropertiesEXT.html">VkFilterCubicImageViewImageFormatPropertiesEXT</see> - Structure for querying cubic filtering capabilities of an image view type
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkFilterCubicImageViewImageFormatPropertiesEXT</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_filter_cubic
    ///         typedef struct VkFilterCubicImageViewImageFormatPropertiesEXT {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           filterCubic;
    ///             VkBool32           filterCubicMinmax;
    ///         } VkFilterCubicImageViewImageFormatPropertiesEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkFilterCubicImageViewImageFormatPropertiesEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.FilterCubicImageViewImageFormatPropertiesEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>FilterCubic</c> tells if image format, image type and image view type <i>can</i> be used with cubic filtering. This field is set by the implementation. An application-specified value is ignored.
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 FilterCubic;

        /// <summary>
        ///     <c>FilterCubicMinmax</c> tells if image format, image type and image view type <i>can</i> be used with cubic filtering and minmax filtering. This field is set by the implementation. An application-specified value is ignored.
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 FilterCubicMinmax;
    }
}
