namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkImageFormatListCreateInfo.html">VkImageFormatListCreateInfo</see> - Specify that an image &lt;i&gt;can&lt;/i&gt; be used with a particular set of formats
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         If the <c>pNext</c> chain of <c>VkImageCreateInfo</c> includes a
    ///         <c>VkImageFormatListCreateInfo</c> structure, then that structure contains a
    ///         list of all formats that <i>can</i> be used when creating views of this image.
    ///     </para>
    ///     <para>
    ///         The <c>VkImageFormatListCreateInfo</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_2
    ///         typedef struct VkImageFormatListCreateInfo {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             uint32_t           viewFormatCount;
    ///             const VkFormat*    pViewFormats;
    ///         } VkImageFormatListCreateInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkImageFormatListCreateInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.ImageFormatListCreateInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ViewFormatCount</c> is the number of entries in the <c>pViewFormats</c> array.
        /// </summary>
        [FieldOffset(16)]
        public int ViewFormatCount;

        /// <summary>
        ///     <c>ViewFormats</c> is a pointer to an array of <c>VkFormat</c> values specifying all formats which <i>can</i> be used when creating views of this image.
        /// </summary>
        [FieldOffset(24)]
        public VkFormat* ViewFormats;
    }
}
