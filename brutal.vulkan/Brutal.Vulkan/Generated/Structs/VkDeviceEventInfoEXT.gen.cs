namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDeviceEventInfoEXT.html">VkDeviceEventInfoEXT</see> - Describe a device event to create
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkDeviceEventInfoEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_display_control
    ///         typedef struct VkDeviceEventInfoEXT {
    ///             VkStructureType         sType;
    ///             const void*             pNext;
    ///             VkDeviceEventTypeEXT    deviceEvent;
    ///         } VkDeviceEventInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkDeviceEventInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.DeviceEventInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>DeviceEvent</c> is a <c>VkDeviceEventTypeEXT</c> value specifying when the fence will be signaled.
        /// </summary>
        [FieldOffset(16)]
        public VkDeviceEventTypeEXT DeviceEvent;
    }
}
