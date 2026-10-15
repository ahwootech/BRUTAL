namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceMaintenance4Properties.html">VkPhysicalDeviceMaintenance4Properties</see> - Structure describing various implementation-defined properties introduced with VK_KHR_maintenance4
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceMaintenance4Properties</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_3
    ///         typedef struct VkPhysicalDeviceMaintenance4Properties {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkDeviceSize       maxBufferSize;
    ///         } VkPhysicalDeviceMaintenance4Properties;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceMaintenance4Properties()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceMaintenance4Properties;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>MaxBufferSize</c>
        /// </summary>
        [FieldOffset(16)]
        public ByteSize64 MaxBufferSize;
    }
}
