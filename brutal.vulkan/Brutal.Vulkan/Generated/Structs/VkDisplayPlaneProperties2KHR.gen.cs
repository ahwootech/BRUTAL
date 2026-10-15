namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDisplayPlaneProperties2KHR.html">VkDisplayPlaneProperties2KHR</see> - Structure describing an available display plane
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkDisplayPlaneProperties2KHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_get_display_properties2
    ///         typedef struct VkDisplayPlaneProperties2KHR {
    ///             VkStructureType                sType;
    ///             void*                          pNext;
    ///             VkDisplayPlanePropertiesKHR    displayPlaneProperties;
    ///         } VkDisplayPlaneProperties2KHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkDisplayPlaneProperties2KHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.DisplayPlaneProperties2KHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>DisplayPlaneProperties</c> is a <c>VkDisplayPlanePropertiesKHR</c> structure.
        /// </summary>
        [FieldOffset(16)]
        public VkDisplayPlanePropertiesKHR DisplayPlaneProperties;
    }
}
