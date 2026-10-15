namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkClusterAccelerationStructureCommandsInfoNV.html">VkClusterAccelerationStructureCommandsInfoNV</see> - Structure describing parameters for building for moving an acceleration structure
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkClusterAccelerationStructureCommandsInfoNV
    ///     </para>
    ///     <para>
    ///         The <c>VkClusterAccelerationStructureCommandsInfoNV</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_cluster_acceleration_structure
    ///         typedef struct VkClusterAccelerationStructureCommandsInfoNV {
    ///             VkStructureType                                           sType;
    ///             void*                                                     pNext;
    ///             VkClusterAccelerationStructureInputInfoNV                 input;
    ///             VkDeviceAddress                                           dstImplicitData;
    ///             VkDeviceAddress                                           scratchData;
    ///             VkStridedDeviceAddressRegionKHR                           dstAddressesArray;
    ///             VkStridedDeviceAddressRegionKHR                           dstSizesArray;
    ///             VkStridedDeviceAddressRegionKHR                           srcInfosArray;
    ///             VkDeviceAddress                                           srcInfosCount;
    ///             VkClusterAccelerationStructureAddressResolutionFlagsNV    addressResolutionFlags;
    ///         } VkClusterAccelerationStructureCommandsInfoNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 160)]
    public unsafe partial struct VkClusterAccelerationStructureCommandsInfoNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.ClusterAccelerationStructureCommandsInfoNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Input</c> is <c>VkClusterAccelerationStructureInputInfoNV</c> structure describing the build or move parameters for the cluster acceleration structure.
        /// </summary>
        [FieldOffset(16)]
        public VkClusterAccelerationStructureInputInfoNV Input;

        /// <summary>
        ///     <c>DstImplicitData</c> is the device address for memory where the implicit build of cluster acceleration structure will be saved. If <c>VkClusterAccelerationStructureInputInfoNV::opMode</c> is <c>VK_CLUSTER_ACCELERATION_STRUCTURE_OP_MODE_EXPLICIT_DESTINATIONS_NV</c> or <c>VK_CLUSTER_ACCELERATION_STRUCTURE_OP_MODE_COMPUTE_SIZES_NV</c>, this value is ignored.
        /// </summary>
        [FieldOffset(56)]
        public VkDeviceAddress DstImplicitData;

        /// <summary>
        ///     <c>ScratchData</c> is the device address of scratch memory that will be used during cluster acceleration structure move or build.
        /// </summary>
        [FieldOffset(64)]
        public VkDeviceAddress ScratchData;

        /// <summary>
        ///     <c>DstAddressesArray</c> is a <c>VkStridedDeviceAddressRegionKHR</c> that specifies addresses and stride for moved or built cluster acceleration structures, depending on the value of <c>VkClusterAccelerationStructureInputInfoNV::opMode</c>. If <c>VkClusterAccelerationStructureInputInfoNV::opMode</c> is <c>VK_CLUSTER_ACCELERATION_STRUCTURE_OP_MODE_IMPLICIT_DESTINATIONS_NV</c> and <c>VkStridedDeviceAddressRegionKHR::deviceAddress</c> is not `0`, then the implementation writes the cluster addresses to the specified region. If <c>VkClusterAccelerationStructureInputInfoNV::opMode</c> is <c>VK_CLUSTER_ACCELERATION_STRUCTURE_OP_MODE_EXPLICIT_DESTINATIONS_NV</c>, the implementation reads the cluster addresses from the specified region. If <c>VkClusterAccelerationStructureInputInfoNV::opMode</c> is <c>VK_CLUSTER_ACCELERATION_STRUCTURE_OP_MODE_COMPUTE_SIZES_NV</c>, this member is ignored.
        /// </summary>
        [FieldOffset(72)]
        public VkStridedDeviceAddressRegionKHR DstAddressesArray;

        /// <summary>
        ///     <c>DstSizesArray</c> is a <c>VkStridedDeviceAddressRegionKHR</c> containing sizes of moved or built cluster acceleration structures. If <c>VkClusterAccelerationStructureInputInfoNV::opMode</c> is <c>VK_CLUSTER_ACCELERATION_STRUCTURE_OP_MODE_IMPLICIT_DESTINATIONS_NV</c> or <c>VK_CLUSTER_ACCELERATION_STRUCTURE_OP_MODE_COMPUTE_SIZES_NV</c>, then the sizes are saved. If <c>VkClusterAccelerationStructureInputInfoNV::opMode</c> is <c>VK_CLUSTER_ACCELERATION_STRUCTURE_OP_MODE_EXPLICIT_DESTINATIONS_NV</c>, then the sizes are read from.
        /// </summary>
        [FieldOffset(96)]
        public VkStridedDeviceAddressRegionKHR DstSizesArray;

        /// <summary>
        ///     <c>SrcInfosArray</c> is a <c>VkStridedDeviceAddressRegionKHR</c> where input data for the build or move operation is read from. If the stride is `0`, the structures are assumed to be packed tightly. Its format is dependent on <c>VkClusterAccelerationStructureInputInfoNV::opType</c> as per the table below. [options=&quot;header&quot;] |
        /// </summary>
        [FieldOffset(120)]
        public VkStridedDeviceAddressRegionKHR SrcInfosArray;

        /// <summary>
        ///     <c>SrcInfosCount</c>
        /// </summary>
        [FieldOffset(144)]
        public VkDeviceAddress SrcInfosCount;

        /// <summary>
        ///     <c>AddressResolutionFlags</c>
        /// </summary>
        [FieldOffset(152)]
        public VkClusterAccelerationStructureAddressResolutionFlagsNV AddressResolutionFlags;
    }
}
