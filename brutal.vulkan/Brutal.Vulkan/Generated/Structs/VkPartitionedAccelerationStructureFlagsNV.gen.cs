namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPartitionedAccelerationStructureFlagsNV.html">VkPartitionedAccelerationStructureFlagsNV</see> - Structure describing additional flags for PTLAS
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkPartitionedAccelerationStructureFlagsNV
    ///     </para>
    ///     <para>
    ///         The <c>VkPartitionedAccelerationStructureFlagsNV</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_partitioned_acceleration_structure
    ///         typedef struct VkPartitionedAccelerationStructureFlagsNV {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           enablePartitionTranslation;
    ///         } VkPartitionedAccelerationStructureFlagsNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPartitionedAccelerationStructureFlagsNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PartitionedAccelerationStructureFlagsNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>EnablePartitionTranslation</c> specifies if a <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#ptlas-partition-translation">partition translation^</see> may: be applied with <c>VkPartitionedAccelerationStructureWritePartitionTranslationDataNV</c>.
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 EnablePartitionTranslation;
    }
}
