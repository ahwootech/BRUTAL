namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkClusterAccelerationStructureClusterFlagBitsNV.html">VkClusterAccelerationStructureClusterFlagBitsNV</see> - Bitmask specifying cluster acceleration structure flags
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which <i>can</i> be set in
    ///         <c>VkClusterAccelerationStructureBuildTriangleClusterInfoNV::clusterFlags</c>,
    ///         specifying flags for clusters in an acceleration structure, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_cluster_acceleration_structure
    ///         typedef enum VkClusterAccelerationStructureClusterFlagBitsNV {
    ///             VK_CLUSTER_ACCELERATION_STRUCTURE_CLUSTER_ALLOW_DISABLE_OPACITY_MICROMAPS_NV = 0x00000001,
    ///         } VkClusterAccelerationStructureClusterFlagBitsNV;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkClusterAccelerationStructureClusterFlagsNV : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>AllowDisableOpacityMicromapsNV</c>  specifies that the specified cluster acceleration structure may: be referenced in an instance with <c>VK_GEOMETRY_INSTANCE_DISABLE_OPACITY_MICROMAPS_BIT_EXT</c> set.
        /// </summary>
        AllowDisableOpacityMicromapsNV = 0x00000001,

        /// <summary>
        ///     <c>FlagBitsMaxEnumNV</c>
        /// </summary>
        FlagBitsMaxEnumNV = 0x7FFFFFFF,
    }
}
