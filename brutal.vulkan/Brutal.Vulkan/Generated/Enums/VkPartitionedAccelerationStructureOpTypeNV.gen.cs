namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPartitionedAccelerationStructureOpTypeNV.html">VkPartitionedAccelerationStructureOpTypeNV</see> - Enum providing the type of PTLAS operation to perform
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Values which <i>can</i> be set in <c>VkPartitionedAccelerationStructureOpTypeNV</c>
    ///         are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_partitioned_acceleration_structure
    ///         typedef enum VkPartitionedAccelerationStructureOpTypeNV {
    ///             VK_PARTITIONED_ACCELERATION_STRUCTURE_OP_TYPE_WRITE_INSTANCE_NV = 0,
    ///             VK_PARTITIONED_ACCELERATION_STRUCTURE_OP_TYPE_UPDATE_INSTANCE_NV = 1,
    ///             VK_PARTITIONED_ACCELERATION_STRUCTURE_OP_TYPE_WRITE_PARTITION_TRANSLATION_NV = 2,
    ///         } VkPartitionedAccelerationStructureOpTypeNV;
    ///     </code>
    /// </remarks>
    public enum VkPartitionedAccelerationStructureOpTypeNV : int
    {
        /// <summary>
        ///     <c>WriteInstanceNV</c> is used to assign a transformed bottom level acceleration structure to an instance and partition. This is similar to <c>VkAccelerationStructureInstanceKHR</c> that defines the properties and transformations for a single instance in non-partitioned TLAS. Any partition that contains at least one of the affected instances will have their internal acceleration structure rebuilt.
        /// </summary>
        WriteInstanceNV = 0,

        /// <summary>
        ///     <c>UpdateInstanceNV</c>  specifies that an instance will be updated with a new bottom level acceleration structure.
        /// </summary>
        UpdateInstanceNV = 1,

        /// <summary>
        ///     <c>WritePartitionTranslationNV</c>  specifies that a partition will be assigned a <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#ptlas-partition-translation">translation vector^</see>.
        /// </summary>
        WritePartitionTranslationNV = 2,

        /// <summary>
        ///     <c>MaxEnumNV</c>
        /// </summary>
        MaxEnumNV = 0x7FFFFFFF,
    }
}
