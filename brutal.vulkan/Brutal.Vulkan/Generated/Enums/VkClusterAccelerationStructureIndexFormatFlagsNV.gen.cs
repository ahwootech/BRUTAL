namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkClusterAccelerationStructureIndexFormatFlagBitsNV.html">VkClusterAccelerationStructureIndexFormatFlagBitsNV</see> - Bits specifying the index type in the index buffer
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits that <i>can</i> be set in
    ///         <c>VkClusterAccelerationStructureBuildTriangleClusterInfoNV::indexType</c>,
    ///         <c>VkClusterAccelerationStructureBuildTriangleClusterInfoNV::opacityMicromapIndexType</c>,
    ///         <c>VkClusterAccelerationStructureBuildTriangleClusterTemplateInfoNV::indexType</c>
    ///         and
    ///         <c>VkClusterAccelerationStructureBuildTriangleClusterTemplateInfoNV::opacityMicromapIndexType</c>
    ///         specifying the index type is one of:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_cluster_acceleration_structure
    ///         typedef enum VkClusterAccelerationStructureIndexFormatFlagBitsNV {
    ///             VK_CLUSTER_ACCELERATION_STRUCTURE_INDEX_FORMAT_8BIT_NV = 0x00000001,
    ///             VK_CLUSTER_ACCELERATION_STRUCTURE_INDEX_FORMAT_16BIT_NV = 0x00000002,
    ///             VK_CLUSTER_ACCELERATION_STRUCTURE_INDEX_FORMAT_32BIT_NV = 0x00000004,
    ///         } VkClusterAccelerationStructureIndexFormatFlagBitsNV;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkClusterAccelerationStructureIndexFormatFlagsNV : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>_8BitNV</c> specifies that 8-bit indices will be used.
        /// </summary>
        _8BitNV = 0x00000001,

        /// <summary>
        ///     <c>_16BitNV</c> specifies that 16-bit indices will be used.
        /// </summary>
        _16BitNV = 0x00000002,

        /// <summary>
        ///     <c>_32BitNV</c> specifies that 32-bit indices will be used.
        /// </summary>
        _32BitNV = 0x00000004,

        /// <summary>
        ///     <c>FlagBitsMaxEnumNV</c>
        /// </summary>
        FlagBitsMaxEnumNV = 0x7FFFFFFF,
    }
}
