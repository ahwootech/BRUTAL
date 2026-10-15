namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceExtendedDynamicState3PropertiesEXT.html">VkPhysicalDeviceExtendedDynamicState3PropertiesEXT</see> - Structure describing capabilities of extended dynamic state
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceExtendedDynamicState3PropertiesEXT</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_extended_dynamic_state3
    ///         typedef struct VkPhysicalDeviceExtendedDynamicState3PropertiesEXT {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           dynamicPrimitiveTopologyUnrestricted;
    ///         } VkPhysicalDeviceExtendedDynamicState3PropertiesEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceExtendedDynamicState3PropertiesEXT()
    {
        /// <summary>
        ///     <c>sType</c>
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceExtendedDynamicState3PropertiesEXT;

        /// <summary>
        ///     <c>Next</c>
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>DynamicPrimitiveTopologyUnrestricted</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 DynamicPrimitiveTopologyUnrestricted;
    }
}
