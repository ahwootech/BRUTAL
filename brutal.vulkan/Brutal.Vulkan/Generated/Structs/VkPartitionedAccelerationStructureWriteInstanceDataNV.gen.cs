namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPartitionedAccelerationStructureWriteInstanceDataNV.html">VkPartitionedAccelerationStructureWriteInstanceDataNV</see> - Structure describing instance data to write in PTLAS
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkPartitionedAccelerationStructureWriteInstanceDataNV
    ///     </para>
    ///     <para>
    ///         The <c>VkPartitionedAccelerationStructureWriteInstanceDataNV</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_partitioned_acceleration_structure
    ///         typedef struct VkPartitionedAccelerationStructureWriteInstanceDataNV {
    ///             VkTransformMatrixKHR                                 transform;
    ///             float                                                explicitAABB[6];
    ///             uint32_t                                             instanceID;
    ///             uint32_t                                             instanceMask;
    ///             uint32_t                                             instanceContributionToHitGroupIndex;
    ///             VkPartitionedAccelerationStructureInstanceFlagsNV    instanceFlags;
    ///             uint32_t                                             instanceIndex;
    ///             uint32_t                                             partitionIndex;
    ///             VkDeviceAddress                                      accelerationStructure;
    ///         } VkPartitionedAccelerationStructureWriteInstanceDataNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 104)]
    public unsafe partial struct VkPartitionedAccelerationStructureWriteInstanceDataNV()
    {
        /// <summary>
        ///     <c>Transform</c> is a <c>VkTransformMatrixKHR</c> structure describing the transformation to be applied to the instance in PTLAS.
        /// </summary>
        [FieldOffset(0)]
        public VkTransformMatrixKHR Transform;

        ///
        [FieldOffset(48)]
        public fixed float ExplicitAABB[6];

        /// <summary>
        ///     <c>InstanceID</c> is a user specified constant assigned to an instance in the PTLAS.
        /// </summary>
        [FieldOffset(72)]
        public int InstanceID;

        /// <summary>
        ///     <c>InstanceMask</c> is a 8-bit mask assigned to the instance that may: be used to include or reject group of instances.
        /// </summary>
        [FieldOffset(76)]
        public int InstanceMask;

        /// <summary>
        ///     <c>InstanceContributionToHitGroupIndex</c> is a 24-bit per application specified instance value added in the indexing into the shader binding table to fetch the hit group to use.
        /// </summary>
        [FieldOffset(80)]
        public int InstanceContributionToHitGroupIndex;

        /// <summary>
        ///     <c>InstanceFlags</c> is a bitmask of <c>VkPartitionedAccelerationStructureInstanceFlagsNV</c> specifying flags an instance in the PTLAS.
        /// </summary>
        [FieldOffset(84)]
        public VkPartitionedAccelerationStructureInstanceFlagsNV InstanceFlags;

        /// <summary>
        ///     <c>InstanceIndex</c> is the index of the instance within the PTLAS.
        /// </summary>
        [FieldOffset(88)]
        public int InstanceIndex;

        /// <summary>
        ///     <c>PartitionIndex</c> is the index of the partition to which this instance belongs. <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#ptlas-global-partition">Global partitions^</see> are referred to by <c>VK_PARTITIONED_ACCELERATION_STRUCTURE_PARTITION_INDEX_GLOBAL_NV</c>.
        /// </summary>
        [FieldOffset(92)]
        public int PartitionIndex;

        /// <summary>
        ///     <c>AccelerationStructure</c> is the device address of the bottom level acceleration structure or a clustered bottom level acceleration structure that is being instanced. This instance is disabled if the device address is `0`.
        /// </summary>
        [FieldOffset(96)]
        public VkDeviceAddress AccelerationStructure;
    }
}
