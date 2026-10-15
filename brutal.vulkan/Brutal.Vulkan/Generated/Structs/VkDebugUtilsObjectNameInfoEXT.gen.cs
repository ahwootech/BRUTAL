namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDebugUtilsObjectNameInfoEXT.html">VkDebugUtilsObjectNameInfoEXT</see> - Specify parameters of a name to give to an object
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkDebugUtilsObjectNameInfoEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_debug_utils
    ///         typedef struct VkDebugUtilsObjectNameInfoEXT {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             VkObjectType       objectType;
    ///             uint64_t           objectHandle;
    ///             const char*        pObjectName;
    ///         } VkDebugUtilsObjectNameInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct VkDebugUtilsObjectNameInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.DebugUtilsObjectNameInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ObjectType</c> is a <c>VkObjectType</c> specifying the type of the object to be named.
        /// </summary>
        [FieldOffset(16)]
        public VkObjectType ObjectType;

        /// <summary>
        ///     <c>ObjectHandle</c> is the object to be named.
        /// </summary>
        [FieldOffset(24)]
        public nint ObjectHandle;

        /// <summary>
        ///     <c>ObjectName</c> is either `NULL` or a null-terminated UTF-8 string specifying the name to apply to <c>objectHandle</c>.
        /// </summary>
        [FieldOffset(32)]
        public byte* ObjectName;
    }
}
