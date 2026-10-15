namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceExternalBufferInfo.html">VkPhysicalDeviceExternalBufferInfo</see> - Structure specifying buffer creation parameters
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkPhysicalDeviceExternalBufferInfo
    ///     </para>
    ///     <para>
    ///         The <c>VkPhysicalDeviceExternalBufferInfo</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_1
    ///         typedef struct VkPhysicalDeviceExternalBufferInfo {
    ///             VkStructureType                       sType;
    ///             const void*                           pNext;
    ///             VkBufferCreateFlags                   flags;
    ///             VkBufferUsageFlags                    usage;
    ///             VkExternalMemoryHandleTypeFlagBits    handleType;
    ///         } VkPhysicalDeviceExternalBufferInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkPhysicalDeviceExternalBufferInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceExternalBufferInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is a bitmask of <c>VkBufferCreateFlags</c> describing additional parameters of the buffer, corresponding to <c>VkBufferCreateInfo::flags</c>.
        /// </summary>
        [FieldOffset(16)]
        public VkBufferCreateFlags Flags;

        /// <summary>
        ///     <c>Usage</c> is a bitmask of <c>VkBufferUsageFlags</c> describing the intended usage of the buffer, corresponding to <c>VkBufferCreateInfo::usage</c>.
        /// </summary>
        [FieldOffset(20)]
        public VkBufferUsageFlags Usage;

        /// <summary>
        ///     <c>HandleType</c> is a <c>VkExternalMemoryHandleTypeFlags</c> value specifying the memory handle type that will be used with the memory associated with the buffer.
        /// </summary>
        [FieldOffset(24)]
        public VkExternalMemoryHandleTypeFlags HandleType;
    }
}
