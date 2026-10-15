namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceMaintenance3Properties.html">VkPhysicalDeviceMaintenance3Properties</see> - Structure describing descriptor set properties
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceMaintenance3Properties</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_1
    ///         typedef struct VkPhysicalDeviceMaintenance3Properties {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             uint32_t           maxPerSetDescriptors;
    ///             VkDeviceSize       maxMemoryAllocationSize;
    ///         } VkPhysicalDeviceMaintenance3Properties;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkPhysicalDeviceMaintenance3Properties()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceMaintenance3Properties;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>MaxPerSetDescriptors</c>
        /// </summary>
        [FieldOffset(16)]
        public int MaxPerSetDescriptors;

        /// <summary>
        ///     <c>MaxMemoryAllocationSize</c>
        /// </summary>
        [FieldOffset(24)]
        public ByteSize64 MaxMemoryAllocationSize;
    }
}
