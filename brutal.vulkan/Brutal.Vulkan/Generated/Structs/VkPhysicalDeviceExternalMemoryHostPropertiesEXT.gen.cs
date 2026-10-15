namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceExternalMemoryHostPropertiesEXT.html">VkPhysicalDeviceExternalMemoryHostPropertiesEXT</see> - Structure describing external memory host pointer limits that can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceExternalMemoryHostPropertiesEXT</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_external_memory_host
    ///         typedef struct VkPhysicalDeviceExternalMemoryHostPropertiesEXT {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkDeviceSize       minImportedHostPointerAlignment;
    ///         } VkPhysicalDeviceExternalMemoryHostPropertiesEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceExternalMemoryHostPropertiesEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceExternalMemoryHostPropertiesEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>MinImportedHostPointerAlignment</c>
        /// </summary>
        [FieldOffset(16)]
        public ByteSize64 MinImportedHostPointerAlignment;
    }
}
