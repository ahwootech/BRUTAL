namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkClusterAccelerationStructureMoveObjectsInfoNV.html">VkClusterAccelerationStructureMoveObjectsInfoNV</see> - Parameters describing move operation for a cluster acceleration structure
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkClusterAccelerationStructureMoveObjectsInfoNV
    ///     </para>
    ///     <para>
    ///         The <c>VkClusterAccelerationStructureMoveObjectsInfoNV</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_cluster_acceleration_structure
    ///         typedef struct VkClusterAccelerationStructureMoveObjectsInfoNV {
    ///             VkDeviceAddress    srcAccelerationStructure;
    ///         } VkClusterAccelerationStructureMoveObjectsInfoNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct VkClusterAccelerationStructureMoveObjectsInfoNV()
    {
        /// <summary>
        ///     <c>SrcAccelerationStructure</c> is the device address of the source cluster acceleration structure that will be moved.
        /// </summary>
        [FieldOffset(0)]
        public VkDeviceAddress SrcAccelerationStructure;
    }
}
