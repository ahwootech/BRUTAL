namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDebugUtilsLabelEXT.html">VkDebugUtilsLabelEXT</see> - Specify parameters of a label region
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkDebugUtilsLabelEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_debug_utils
    ///         typedef struct VkDebugUtilsLabelEXT {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             const char*        pLabelName;
    ///             float              color[4];
    ///         } VkDebugUtilsLabelEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct VkDebugUtilsLabelEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.DebugUtilsLabelEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>LabelName</c> is a pointer to a null-terminated UTF-8 string containing the name of the label.
        /// </summary>
        [FieldOffset(16)]
        public byte* LabelName;

        /// <summary>
        ///     <c>Color</c> is an optional RGBA color value that can be associated with the label. A particular implementation may: choose to ignore this color value. The values contain RGBA values in order, in the range 0.0 to 1.0. If all elements in <c>color</c> are 0.0, then it is ignored.
        /// </summary>
        [FieldOffset(24)]
        public float4 Color;
    }
}
