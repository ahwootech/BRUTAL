namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPartitionedAccelerationStructureUpdateInstanceDataNV.html">VkPartitionedAccelerationStructureUpdateInstanceDataNV</see> - Structure describing instance data to update in PTLAS
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkPartitionedAccelerationStructureUpdateInstanceDataNV
    ///     </para>
    ///     <para>
    ///         The <c>VkPartitionedAccelerationStructureUpdateInstanceDataNV</c> structure
    ///         is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_partitioned_acceleration_structure
    ///         typedef struct VkPartitionedAccelerationStructureUpdateInstanceDataNV {
    ///             uint32_t           instanceIndex;
    ///             uint32_t           instanceContributionToHitGroupIndex;
    ///             VkDeviceAddress    accelerationStructure;
    ///         } VkPartitionedAccelerationStructureUpdateInstanceDataNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct VkPartitionedAccelerationStructureUpdateInstanceDataNV()
    {
        /// <summary>
        ///     <c>InstanceIndex</c> is the index of the instance being updated.
        /// </summary>
        [FieldOffset(0)]
        public int InstanceIndex;

        /// <summary>
        ///     <c>InstanceContributionToHitGroupIndex</c> is a 24-bit per instance value added in the indexing into the shader binding table to fetch the hit group to use.
        /// </summary>
        [FieldOffset(4)]
        public int InstanceContributionToHitGroupIndex;

        /// <summary>
        ///     <c>AccelerationStructure</c> is the device address of the bottom level acceleration structure or a clustered bottom level acceleration structure whose instance is being updated. The instance is disabled if the device address is `0`.
        /// </summary>
        [FieldOffset(8)]
        public VkDeviceAddress AccelerationStructure;
    }
}
