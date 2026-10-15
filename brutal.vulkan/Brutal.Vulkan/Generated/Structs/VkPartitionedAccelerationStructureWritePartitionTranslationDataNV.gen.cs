namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPartitionedAccelerationStructureWritePartitionTranslationDataNV.html">VkPartitionedAccelerationStructureWritePartitionTranslationDataNV</see> - Structure describing partition translation data to write in PTLAS
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkPartitionedAccelerationStructureWritePartitionTranslationDataNV
    ///     </para>
    ///     <para>
    ///         The <c>VkPartitionedAccelerationStructureWritePartitionTranslationDataNV</c>
    ///         structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_partitioned_acceleration_structure
    ///         typedef struct VkPartitionedAccelerationStructureWritePartitionTranslationDataNV {
    ///             uint32_t    partitionIndex;
    ///             float       partitionTranslation[3];
    ///         } VkPartitionedAccelerationStructureWritePartitionTranslationDataNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct VkPartitionedAccelerationStructureWritePartitionTranslationDataNV()
    {
        /// <summary>
        ///     <c>PartitionIndex</c> is the index of partition to write. <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#ptlas-global-partition">Global partition^</see> is referred to by <c>VK_PARTITIONED_ACCELERATION_STRUCTURE_PARTITION_INDEX_GLOBAL_NV</c>.
        /// </summary>
        [FieldOffset(0)]
        public int PartitionIndex;

        /// <summary>
        ///     <c>PartitionTranslation</c> sets the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#ptlas-partition-translation">translation vector^</see> for this partition. When tracing this partition, the contained instances will behave as if the partition translation was added to the translation component of the instance transform. This translation vector is also added to the instances in the partition that had their bounding box specified.
        /// </summary>
        [FieldOffset(4)]
        public float3 PartitionTranslation;
    }
}
