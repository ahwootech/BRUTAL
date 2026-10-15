namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceNestedCommandBufferPropertiesEXT.html">VkPhysicalDeviceNestedCommandBufferPropertiesEXT</see> - Structure describing the nested command buffer limits of an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceNestedCommandBufferPropertiesEXT</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_nested_command_buffer
    ///         typedef struct VkPhysicalDeviceNestedCommandBufferPropertiesEXT {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             uint32_t           maxCommandBufferNestingLevel;
    ///         } VkPhysicalDeviceNestedCommandBufferPropertiesEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceNestedCommandBufferPropertiesEXT()
    {
        /// <summary>
        ///     <c>sType</c>
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceNestedCommandBufferPropertiesEXT;

        /// <summary>
        ///     <c>Next</c>
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>MaxCommandBufferNestingLevel</c>
        /// </summary>
        [FieldOffset(16)]
        public int MaxCommandBufferNestingLevel;
    }
}
