namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceDiscardRectanglePropertiesEXT.html">VkPhysicalDeviceDiscardRectanglePropertiesEXT</see> - Structure describing discard rectangle limits that can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceDiscardRectanglePropertiesEXT</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_discard_rectangles
    ///         typedef struct VkPhysicalDeviceDiscardRectanglePropertiesEXT {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             uint32_t           maxDiscardRectangles;
    ///         } VkPhysicalDeviceDiscardRectanglePropertiesEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceDiscardRectanglePropertiesEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceDiscardRectanglePropertiesEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>MaxDiscardRectangles</c>
        /// </summary>
        [FieldOffset(16)]
        public int MaxDiscardRectangles;
    }
}
