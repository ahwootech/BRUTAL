namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDisplayEventInfoEXT.html">VkDisplayEventInfoEXT</see> - Describe a display event to create
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkDisplayEventInfoEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_display_control
    ///         typedef struct VkDisplayEventInfoEXT {
    ///             VkStructureType          sType;
    ///             const void*              pNext;
    ///             VkDisplayEventTypeEXT    displayEvent;
    ///         } VkDisplayEventInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkDisplayEventInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.DisplayEventInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>DisplayEvent</c> is a <c>VkDisplayEventTypeEXT</c> specifying when the fence will be signaled.
        /// </summary>
        [FieldOffset(16)]
        public VkDisplayEventTypeEXT DisplayEvent;
    }
}
