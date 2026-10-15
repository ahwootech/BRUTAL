namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDebugMarkerObjectNameInfoEXT.html">VkDebugMarkerObjectNameInfoEXT</see> - Specify parameters of a name to give to an object
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkDebugMarkerObjectNameInfoEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_debug_marker
    ///         typedef struct VkDebugMarkerObjectNameInfoEXT {
    ///             VkStructureType               sType;
    ///             const void*                   pNext;
    ///             VkDebugReportObjectTypeEXT    objectType;
    ///             uint64_t                      object;
    ///             const char*                   pObjectName;
    ///         } VkDebugMarkerObjectNameInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct VkDebugMarkerObjectNameInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.DebugMarkerObjectNameInfoEXT;

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
        ///     <c>Object</c> is the object to be named.
        /// </summary>
        [FieldOffset(24)]
        public nint Object;

        /// <summary>
        ///     <c>ObjectName</c> is a null-terminated UTF-8 string specifying the name to apply to <c>object</c>.
        /// </summary>
        [FieldOffset(32)]
        public byte* ObjectName;
    }
}
