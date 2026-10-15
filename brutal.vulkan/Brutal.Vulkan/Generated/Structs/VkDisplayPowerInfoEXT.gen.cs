namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDisplayPowerInfoEXT.html">VkDisplayPowerInfoEXT</see> - Describe the power state of a display
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkDisplayPowerInfoEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_display_control
    ///         typedef struct VkDisplayPowerInfoEXT {
    ///             VkStructureType           sType;
    ///             const void*               pNext;
    ///             VkDisplayPowerStateEXT    powerState;
    ///         } VkDisplayPowerInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkDisplayPowerInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.DisplayPowerInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>PowerState</c> is a <c>VkDisplayPowerStateEXT</c> value specifying the new power state of the display.
        /// </summary>
        [FieldOffset(16)]
        public VkDisplayPowerStateEXT PowerState;
    }
}
