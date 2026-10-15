namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPartitionedAccelerationStructureInstancesInputNV.html">VkPartitionedAccelerationStructureInstancesInputNV</see> - Parameters describing a PTLAS structure
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkPartitionedAccelerationStructureInstancesInputNV
    ///     </para>
    ///     <para>
    ///         The <c>VkPartitionedAccelerationStructureInstancesInputNV</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_partitioned_acceleration_structure
    ///         typedef struct VkPartitionedAccelerationStructureInstancesInputNV {
    ///             VkStructureType                         sType;
    ///             void*                                   pNext;
    ///             VkBuildAccelerationStructureFlagsKHR    flags;
    ///             uint32_t                                instanceCount;
    ///             uint32_t                                maxInstancePerPartitionCount;
    ///             uint32_t                                partitionCount;
    ///             uint32_t                                maxInstanceInGlobalPartitionCount;
    ///         } VkPartitionedAccelerationStructureInstancesInputNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct VkPartitionedAccelerationStructureInstancesInputNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PartitionedAccelerationStructureInstancesInputNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is a bitmask of <c>VkBuildAccelerationStructureFlagsKHR</c> specifying flags for the PTLAS build operation.
        /// </summary>
        [FieldOffset(16)]
        public VkBuildAccelerationStructureFlagsKHR Flags;

        /// <summary>
        ///     <c>InstanceCount</c> is the number of instances in this PTLAS.
        /// </summary>
        [FieldOffset(20)]
        public int InstanceCount;

        /// <summary>
        ///     <c>MaxInstancePerPartitionCount</c> is the maximum number of instances per partition in the PTLAS.
        /// </summary>
        [FieldOffset(24)]
        public int MaxInstancePerPartitionCount;

        /// <summary>
        ///     <c>PartitionCount</c> is the number of partitions in the PTLAS.
        /// </summary>
        [FieldOffset(28)]
        public int PartitionCount;

        /// <summary>
        ///     <c>MaxInstanceInGlobalPartitionCount</c> is maximum number of instances in the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#ptlas-global-partition">global partition^</see>.
        /// </summary>
        [FieldOffset(32)]
        public int MaxInstanceInGlobalPartitionCount;
    }
}
