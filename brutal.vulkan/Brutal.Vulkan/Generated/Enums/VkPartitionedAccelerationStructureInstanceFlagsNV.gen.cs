namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPartitionedAccelerationStructureInstanceFlagBitsNV.html">VkPartitionedAccelerationStructureInstanceFlagBitsNV</see> - Bitmask specifying flags for PTLAS instances
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which <i>can</i> be set in
    ///         <c>VkPartitionedAccelerationStructureWriteInstanceDataNV::instanceFlags</c>,
    ///         specifying flags for instances, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_partitioned_acceleration_structure
    ///         typedef enum VkPartitionedAccelerationStructureInstanceFlagBitsNV {
    ///             VK_PARTITIONED_ACCELERATION_STRUCTURE_INSTANCE_FLAG_TRIANGLE_FACING_CULL_DISABLE_BIT_NV = 0x00000001,
    ///             VK_PARTITIONED_ACCELERATION_STRUCTURE_INSTANCE_FLAG_TRIANGLE_FLIP_FACING_BIT_NV = 0x00000002,
    ///             VK_PARTITIONED_ACCELERATION_STRUCTURE_INSTANCE_FLAG_FORCE_OPAQUE_BIT_NV = 0x00000004,
    ///             VK_PARTITIONED_ACCELERATION_STRUCTURE_INSTANCE_FLAG_FORCE_NO_OPAQUE_BIT_NV = 0x00000008,
    ///             VK_PARTITIONED_ACCELERATION_STRUCTURE_INSTANCE_FLAG_ENABLE_EXPLICIT_BOUNDING_BOX_NV = 0x00000010,
    ///         } VkPartitionedAccelerationStructureInstanceFlagBitsNV;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkPartitionedAccelerationStructureInstanceFlagsNV : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>FlagTriangleFacingCullDisableBitNV</c>  disables face culling for this instance.
        /// </summary>
        FlagTriangleFacingCullDisableBitNV = 0x00000001,

        /// <summary>
        ///     <c>FlagTriangleFlipFacingBitNV</c>  specifies that the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#ray-traversal-culling-face">facing determination^</see> for geometry in this instance is inverted.
        /// </summary>
        FlagTriangleFlipFacingBitNV = 0x00000002,

        /// <summary>
        ///     <c>FlagForceOpaqueBitNV</c>  causes this instance to act as though <c>VK_GEOMETRY_OPAQUE_BIT_KHR</c> were specified on all geometries referenced by this instance.
        /// </summary>
        FlagForceOpaqueBitNV = 0x00000004,

        /// <summary>
        ///     <c>FlagForceNoOpaqueBitNV</c>  causes this instance to act as though <c>VK_GEOMETRY_OPAQUE_BIT_KHR</c> were not specified on all geometries referenced by this instance.
        /// </summary>
        FlagForceNoOpaqueBitNV = 0x00000008,

        /// <summary>
        ///     <c>FlagEnableExplicitBoundingBoxNV</c>  enables use of an explicit bounding box for this instance.
        /// </summary>
        FlagEnableExplicitBoundingBoxNV = 0x00000010,

        /// <summary>
        ///     <c>FlagBitsMaxEnumNV</c>
        /// </summary>
        FlagBitsMaxEnumNV = 0x7FFFFFFF,
    }
}
