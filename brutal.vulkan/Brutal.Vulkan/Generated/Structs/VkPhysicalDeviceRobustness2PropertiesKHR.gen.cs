namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceRobustness2PropertiesKHR.html">VkPhysicalDeviceRobustness2PropertiesKHR</see> - Structure describing robust buffer access properties supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceRobustness2PropertiesKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_robustness2
    ///         typedef struct VkPhysicalDeviceRobustness2PropertiesKHR {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkDeviceSize       robustStorageBufferAccessSizeAlignment;
    ///             VkDeviceSize       robustUniformBufferAccessSizeAlignment;
    ///         } VkPhysicalDeviceRobustness2PropertiesKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkPhysicalDeviceRobustness2PropertiesKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceRobustness2PropertiesKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>RobustStorageBufferAccessSizeAlignment</c>
        /// </summary>
        [FieldOffset(16)]
        public ByteSize64 RobustStorageBufferAccessSizeAlignment;

        /// <summary>
        ///     <c>RobustUniformBufferAccessSizeAlignment</c>
        /// </summary>
        [FieldOffset(24)]
        public ByteSize64 RobustUniformBufferAccessSizeAlignment;
    }
}
