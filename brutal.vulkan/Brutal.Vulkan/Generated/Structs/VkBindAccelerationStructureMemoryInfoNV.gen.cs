namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkBindAccelerationStructureMemoryInfoNV.html">VkBindAccelerationStructureMemoryInfoNV</see> - Structure specifying acceleration structure memory binding
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkBindAccelerationStructureMemoryInfoNV
    ///     </para>
    ///     <para>
    ///         The <c>VkBindAccelerationStructureMemoryInfoNV</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_ray_tracing
    ///         typedef struct VkBindAccelerationStructureMemoryInfoNV {
    ///             VkStructureType              sType;
    ///             const void*                  pNext;
    ///             VkAccelerationStructureNV    accelerationStructure;
    ///             VkDeviceMemory               memory;
    ///             VkDeviceSize                 memoryOffset;
    ///             uint32_t                     deviceIndexCount;
    ///             const uint32_t*              pDeviceIndices;
    ///         } VkBindAccelerationStructureMemoryInfoNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public unsafe partial struct VkBindAccelerationStructureMemoryInfoNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.BindAccelerationStructureMemoryInfoNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>AccelerationStructure</c> is the acceleration structure to be attached to memory.
        /// </summary>
        [FieldOffset(16)]
        public VkAccelerationStructureNV AccelerationStructure;

        /// <summary>
        ///     <c>Memory</c> is a <c>VkDeviceMemory</c> object describing the device memory to attach.
        /// </summary>
        [FieldOffset(24)]
        public VkDeviceMemory Memory;

        /// <summary>
        ///     <c>MemoryOffset</c> is the start offset of the region of memory that is to be bound to the acceleration structure. The number of bytes returned in the <c>VkMemoryRequirements::size</c> member in <c>memory</c>, starting from <c>memoryOffset</c> bytes, will be bound to the specified acceleration structure.
        /// </summary>
        [FieldOffset(32)]
        public ByteSize64 MemoryOffset;

        /// <summary>
        ///     <c>DeviceIndexCount</c> is the number of elements in <c>pDeviceIndices</c>.
        /// </summary>
        [FieldOffset(40)]
        public int DeviceIndexCount;

        /// <summary>
        ///     <c>DeviceIndices</c> is a pointer to an array of device indices.
        /// </summary>
        [FieldOffset(48)]
        public int* DeviceIndices;
    }
}
