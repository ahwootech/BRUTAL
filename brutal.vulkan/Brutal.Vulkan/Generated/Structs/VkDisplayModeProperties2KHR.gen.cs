namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDisplayModeProperties2KHR.html">VkDisplayModeProperties2KHR</see> - Structure describing an available display mode
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkDisplayModeProperties2KHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_get_display_properties2
    ///         typedef struct VkDisplayModeProperties2KHR {
    ///             VkStructureType               sType;
    ///             void*                         pNext;
    ///             VkDisplayModePropertiesKHR    displayModeProperties;
    ///         } VkDisplayModeProperties2KHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct VkDisplayModeProperties2KHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.DisplayModeProperties2KHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>DisplayModeProperties</c> is a <c>VkDisplayModePropertiesKHR</c> structure.
        /// </summary>
        [FieldOffset(16)]
        public VkDisplayModePropertiesKHR DisplayModeProperties;
    }
}
