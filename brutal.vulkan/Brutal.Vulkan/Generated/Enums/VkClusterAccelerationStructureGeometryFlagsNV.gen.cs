namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkClusterAccelerationStructureGeometryFlagBitsNV.html">VkClusterAccelerationStructureGeometryFlagBitsNV</see> - Bitmask specifying geometry flags for cluster acceleration structure
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which <i>can</i> be set in
    ///         <c>VkClusterAccelerationStructureGeometryIndexAndGeometryFlagsNV::geometryFlags</c>,
    ///         specifying geometry flags for cluster acceleration structure, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_cluster_acceleration_structure
    ///         typedef enum VkClusterAccelerationStructureGeometryFlagBitsNV {
    ///             VK_CLUSTER_ACCELERATION_STRUCTURE_GEOMETRY_CULL_DISABLE_BIT_NV = 0x00000001,
    ///             VK_CLUSTER_ACCELERATION_STRUCTURE_GEOMETRY_NO_DUPLICATE_ANYHIT_INVOCATION_BIT_NV = 0x00000002,
    ///             VK_CLUSTER_ACCELERATION_STRUCTURE_GEOMETRY_OPAQUE_BIT_NV = 0x00000004,
    ///         } VkClusterAccelerationStructureGeometryFlagBitsNV;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkClusterAccelerationStructureGeometryFlagsNV : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>CullDisableBitNV</c>  disables face culling for this geometry.
        /// </summary>
        CullDisableBitNV = 0x00000001,

        /// <summary>
        ///     <c>NoDuplicateAnyhitInvocationBitNV</c>  specifies that the implementation <i>must</i> only call the any-hit shader a single time for each primitive in this geometry. If this bit is absent an implementation may: invoke the any-hit shader more than once for this geometry.
        /// </summary>
        NoDuplicateAnyhitInvocationBitNV = 0x00000002,

        /// <summary>
        ///     <c>OpaqueBitNV</c> specifies that this geometry does not invoke the any-hit shaders even if present in a hit group.
        /// </summary>
        OpaqueBitNV = 0x00000004,

        /// <summary>
        ///     <c>FlagBitsMaxEnumNV</c>
        /// </summary>
        FlagBitsMaxEnumNV = 0x7FFFFFFF,
    }
}
