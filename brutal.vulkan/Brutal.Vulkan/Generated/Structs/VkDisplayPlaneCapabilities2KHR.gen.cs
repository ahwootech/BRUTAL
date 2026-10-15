namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDisplayPlaneCapabilities2KHR.html">VkDisplayPlaneCapabilities2KHR</see> - Structure describing the capabilities of a mode and plane combination
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkDisplayPlaneCapabilities2KHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_get_display_properties2
    ///         typedef struct VkDisplayPlaneCapabilities2KHR {
    ///             VkStructureType                  sType;
    ///             void*                            pNext;
    ///             VkDisplayPlaneCapabilitiesKHR    capabilities;
    ///         } VkDisplayPlaneCapabilities2KHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 88)]
    public unsafe partial struct VkDisplayPlaneCapabilities2KHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.DisplayPlaneCapabilities2KHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Capabilities</c> is a <c>VkDisplayPlaneCapabilitiesKHR</c> structure.
        /// </summary>
        [FieldOffset(16)]
        public VkDisplayPlaneCapabilitiesKHR Capabilities;
    }
}
