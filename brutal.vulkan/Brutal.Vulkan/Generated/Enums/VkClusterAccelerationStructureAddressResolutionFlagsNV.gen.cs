namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkClusterAccelerationStructureAddressResolutionFlagBitsNV.html">VkClusterAccelerationStructureAddressResolutionFlagBitsNV</see> - Bitmask specifying address resolution flags in cluster acceleration structure
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which <i>can</i> be set in
    ///         <c>VkClusterAccelerationStructureCommandsInfoNV::addressResolutionFlags</c>,
    ///         specifying how the device address in
    ///         <c>VkClusterAccelerationStructureCommandsInfoNV</c> are interpreted, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_cluster_acceleration_structure
    ///         typedef enum VkClusterAccelerationStructureAddressResolutionFlagBitsNV {
    ///             VK_CLUSTER_ACCELERATION_STRUCTURE_ADDRESS_RESOLUTION_NONE_NV = 0,
    ///             VK_CLUSTER_ACCELERATION_STRUCTURE_ADDRESS_RESOLUTION_INDIRECTED_DST_IMPLICIT_DATA_BIT_NV = 0x00000001,
    ///             VK_CLUSTER_ACCELERATION_STRUCTURE_ADDRESS_RESOLUTION_INDIRECTED_SCRATCH_DATA_BIT_NV = 0x00000002,
    ///             VK_CLUSTER_ACCELERATION_STRUCTURE_ADDRESS_RESOLUTION_INDIRECTED_DST_ADDRESS_ARRAY_BIT_NV = 0x00000004,
    ///             VK_CLUSTER_ACCELERATION_STRUCTURE_ADDRESS_RESOLUTION_INDIRECTED_DST_SIZES_ARRAY_BIT_NV = 0x00000008,
    ///             VK_CLUSTER_ACCELERATION_STRUCTURE_ADDRESS_RESOLUTION_INDIRECTED_SRC_INFOS_ARRAY_BIT_NV = 0x00000010,
    ///             VK_CLUSTER_ACCELERATION_STRUCTURE_ADDRESS_RESOLUTION_INDIRECTED_SRC_INFOS_COUNT_BIT_NV = 0x00000020,
    ///         } VkClusterAccelerationStructureAddressResolutionFlagBitsNV;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkClusterAccelerationStructureAddressResolutionFlagsNV : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>NoneNV</c>  specifies that no address resolution flags are provided.
        /// </summary>
        NoneNV = 0,

        /// <summary>
        ///     <c>IndirectedDstImplicitDataBitNV</c>  specifies another level of indirection when reading <c>VkClusterAccelerationStructureCommandsInfoNV::dstImplicitData</c>.
        /// </summary>
        IndirectedDstImplicitDataBitNV = 0x00000001,

        /// <summary>
        ///     <c>IndirectedScratchDataBitNV</c>  specifies another level of indirection when reading <c>VkClusterAccelerationStructureCommandsInfoNV::scratchData</c>.
        /// </summary>
        IndirectedScratchDataBitNV = 0x00000002,

        /// <summary>
        ///     <c>IndirectedDstAddressArrayBitNV</c>  specifies another level of indirection when reading <c>VkClusterAccelerationStructureCommandsInfoNV::dstAddressesArray</c>.
        /// </summary>
        IndirectedDstAddressArrayBitNV = 0x00000004,

        /// <summary>
        ///     <c>IndirectedDstSizesArrayBitNV</c>  specifies another level of indirection when reading <c>VkClusterAccelerationStructureCommandsInfoNV::dstSizesArray</c>.
        /// </summary>
        IndirectedDstSizesArrayBitNV = 0x00000008,

        /// <summary>
        ///     <c>IndirectedSrcInfosArrayBitNV</c>  specifies another level of indirection when reading <c>VkClusterAccelerationStructureCommandsInfoNV::srcInfosArray</c>.
        /// </summary>
        IndirectedSrcInfosArrayBitNV = 0x00000010,

        /// <summary>
        ///     <c>IndirectedSrcInfosCountBitNV</c>  specifies another level of indirection when reading <c>VkClusterAccelerationStructureCommandsInfoNV::srcInfosCount</c>.
        /// </summary>
        IndirectedSrcInfosCountBitNV = 0x00000020,

        /// <summary>
        ///     <c>FlagBitsMaxEnumNV</c>
        /// </summary>
        FlagBitsMaxEnumNV = 0x7FFFFFFF,
    }
}
