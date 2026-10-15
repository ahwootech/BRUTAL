namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDebugMarkerObjectTagInfoEXT.html">VkDebugMarkerObjectTagInfoEXT</see> - Specify parameters of a tag to attach to an object
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkDebugMarkerObjectTagInfoEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_debug_marker
    ///         typedef struct VkDebugMarkerObjectTagInfoEXT {
    ///             VkStructureType               sType;
    ///             const void*                   pNext;
    ///             VkDebugReportObjectTypeEXT    objectType;
    ///             uint64_t                      object;
    ///             uint64_t                      tagName;
    ///             size_t                        tagSize;
    ///             const void*                   pTag;
    ///         } VkDebugMarkerObjectTagInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public unsafe partial struct VkDebugMarkerObjectTagInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.DebugMarkerObjectTagInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ObjectType</c> is a <c>VkDebugReportObjectTypeEXT</c> specifying the type of the object to be named.
        /// </summary>
        [FieldOffset(16)]
        public VkDebugReportObjectTypeEXT ObjectType;

        /// <summary>
        ///     <c>Object</c> is the object to be tagged.
        /// </summary>
        [FieldOffset(24)]
        public nint Object;

        /// <summary>
        ///     <c>TagName</c> is a numerical identifier of the tag.
        /// </summary>
        [FieldOffset(32)]
        public nint TagName;

        /// <summary>
        ///     <c>TagSize</c> is the number of bytes of data to attach to the object.
        /// </summary>
        [FieldOffset(40)]
        public nuint TagSize;

        /// <summary>
        ///     <c>Tag</c> is a pointer to an array of <c>tagSize</c> bytes containing the data to be associated with the object.
        /// </summary>
        [FieldOffset(48)]
        public void* Tag;
    }
}
