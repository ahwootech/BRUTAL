namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkBuildPartitionedAccelerationStructureIndirectCommandNV.html">VkBuildPartitionedAccelerationStructureIndirectCommandNV</see> - Structure describing PTLAS operation to perform
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkBuildPartitionedAccelerationStructureIndirectCommandNV
    ///     </para>
    ///     <para>
    ///         The <c>VkBuildPartitionedAccelerationStructureIndirectCommandNV</c> structure
    ///         is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_partitioned_acceleration_structure
    ///         typedef struct VkBuildPartitionedAccelerationStructureIndirectCommandNV {
    ///             VkPartitionedAccelerationStructureOpTypeNV    opType;
    ///             uint32_t                                      argCount;
    ///             VkStridedDeviceAddressNV                      argData;
    ///         } VkBuildPartitionedAccelerationStructureIndirectCommandNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct VkBuildPartitionedAccelerationStructureIndirectCommandNV()
    {
        /// <summary>
        ///     <c>OpType</c> is a <c>VkPartitionedAccelerationStructureOpTypeNV</c> describing the type of operation.
        /// </summary>
        [FieldOffset(0)]
        public VkPartitionedAccelerationStructureOpTypeNV OpType;

        /// <summary>
        ///     <c>ArgCount</c> the number of structures in <c>argData</c> array.
        /// </summary>
        [FieldOffset(4)]
        public int ArgCount;

        /// <summary>
        ///     <c>ArgData</c> is an array of <c>VkStridedDeviceAddressNV</c> structures containing the write or update data for instances and partitions in the PTLAS. The structure is dependent on <c>opType</c> as shown in the table below. [options=&quot;header&quot;] |
        /// </summary>
        [FieldOffset(8)]
        public VkStridedDeviceAddressNV ArgData;
    }
}
