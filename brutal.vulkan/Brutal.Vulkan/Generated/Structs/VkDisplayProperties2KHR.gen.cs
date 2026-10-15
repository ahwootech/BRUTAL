namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDisplayProperties2KHR.html">VkDisplayProperties2KHR</see> - Structure describing an available display device
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkDisplayProperties2KHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_get_display_properties2
    ///         typedef struct VkDisplayProperties2KHR {
    ///             VkStructureType           sType;
    ///             void*                     pNext;
    ///             VkDisplayPropertiesKHR    displayProperties;
    ///         } VkDisplayProperties2KHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public unsafe partial struct VkDisplayProperties2KHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.DisplayProperties2KHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>DisplayProperties</c> is a <c>VkDisplayPropertiesKHR</c> structure.
        /// </summary>
        [FieldOffset(16)]
        public VkDisplayPropertiesKHR DisplayProperties;
    }
}
