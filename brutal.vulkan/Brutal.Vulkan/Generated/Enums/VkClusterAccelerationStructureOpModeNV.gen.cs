namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkClusterAccelerationStructureOpModeNV.html">VkClusterAccelerationStructureOpModeNV</see> - Enum providing the mode of operation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Values which <i>can</i> be set in <c>VkClusterAccelerationStructureOpModeNV</c>
    ///         are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_cluster_acceleration_structure
    ///         typedef enum VkClusterAccelerationStructureOpModeNV {
    ///             VK_CLUSTER_ACCELERATION_STRUCTURE_OP_MODE_IMPLICIT_DESTINATIONS_NV = 0,
    ///             VK_CLUSTER_ACCELERATION_STRUCTURE_OP_MODE_EXPLICIT_DESTINATIONS_NV = 1,
    ///             VK_CLUSTER_ACCELERATION_STRUCTURE_OP_MODE_COMPUTE_SIZES_NV = 2,
    ///         } VkClusterAccelerationStructureOpModeNV;
    ///     </code>
    /// </remarks>
    public enum VkClusterAccelerationStructureOpModeNV : int
    {
        /// <summary>
        ///     <c>ImplicitDestinationsNV</c>  specifies that the build or move operation will implicitly distribute built or compacted cluster acceleration structures starting at the address provided in <c>VkClusterAccelerationStructureCommandsInfoNV::dstImplicitData</c>. If a move operation is being performed, the acceleration structures will be tightly compacted.
        /// </summary>
        ImplicitDestinationsNV = 0,

        /// <summary>
        ///     <c>ExplicitDestinationsNV</c>  specifies that the build or move operation will explicitly write built or compacted cluster acceleration structures in the array of addresses provided in <c>VkClusterAccelerationStructureCommandsInfoNV::dstAddressesArray</c>.
        /// </summary>
        ExplicitDestinationsNV = 1,

        /// <summary>
        ///     <c>ComputeSizesNV</c>  specifies that computed cluster acceleration structure sizes will be written to <c>VkClusterAccelerationStructureCommandsInfoNV::dstSizesArray</c>.
        /// </summary>
        ComputeSizesNV = 2,

        /// <summary>
        ///     <c>MaxEnumNV</c>
        /// </summary>
        MaxEnumNV = 0x7FFFFFFF,
    }
}
