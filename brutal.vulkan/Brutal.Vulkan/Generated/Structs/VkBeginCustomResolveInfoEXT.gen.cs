namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkBeginCustomResolveInfoEXT.html">VkBeginCustomResolveInfoEXT</see> - Structure specifying shader resolve information
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkBeginCustomResolveInfoEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_custom_resolve with VK_KHR_dynamic_rendering or VK_VERSION_1_3
    ///         typedef struct VkBeginCustomResolveInfoEXT {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///         } VkBeginCustomResolveInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public unsafe partial struct VkBeginCustomResolveInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.BeginCustomResolveInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;
    }
}
