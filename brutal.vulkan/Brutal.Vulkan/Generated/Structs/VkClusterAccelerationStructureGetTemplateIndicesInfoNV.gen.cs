namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkClusterAccelerationStructureGetTemplateIndicesInfoNV.html">VkClusterAccelerationStructureGetTemplateIndicesInfoNV</see> - Parameters describing addresses of cluster template acceleration structure whose index data is requested
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkClusterAccelerationStructureGetTemplateIndicesInfoNV
    ///     </para>
    ///     <para>
    ///         The <c>VkClusterAccelerationStructureGetTemplateIndicesInfoNV</c> structure
    ///         is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_cluster_acceleration_structure
    ///         typedef struct VkClusterAccelerationStructureGetTemplateIndicesInfoNV {
    ///             VkDeviceAddress    clusterTemplateAddress;
    ///         } VkClusterAccelerationStructureGetTemplateIndicesInfoNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct VkClusterAccelerationStructureGetTemplateIndicesInfoNV()
    {
        /// <summary>
        ///     <c>ClusterTemplateAddress</c> is the device address of the cluster template acceleration structure whose index data is being fetched.
        /// </summary>
        [FieldOffset(0)]
        public VkDeviceAddress ClusterTemplateAddress;
    }
}
