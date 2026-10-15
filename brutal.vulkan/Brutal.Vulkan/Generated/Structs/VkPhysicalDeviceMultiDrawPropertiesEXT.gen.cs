namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceMultiDrawPropertiesEXT.html">VkPhysicalDeviceMultiDrawPropertiesEXT</see> - Structure describing multidraw limits of an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceMultiDrawPropertiesEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_multi_draw
    ///         typedef struct VkPhysicalDeviceMultiDrawPropertiesEXT {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             uint32_t           maxMultiDrawCount;
    ///         } VkPhysicalDeviceMultiDrawPropertiesEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceMultiDrawPropertiesEXT()
    {
        /// <summary>
        ///     <c>sType</c>
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceMultiDrawPropertiesEXT;

        /// <summary>
        ///     <c>Next</c>
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>MaxMultiDrawCount</c>
        /// </summary>
        [FieldOffset(16)]
        public int MaxMultiDrawCount;
    }
}
