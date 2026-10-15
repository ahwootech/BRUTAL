namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceClusterCullingShaderVrsFeaturesHUAWEI.html">VkPhysicalDeviceClusterCullingShaderVrsFeaturesHUAWEI</see> - Structure describing whether cluster culling shader support VRS
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         To query whether a Cluster Culling Shader supports the per-cluster shading
    ///         rate feature, include a
    ///         <c>VkPhysicalDeviceClusterCullingShaderVrsFeaturesHUAWEI</c> structure in the
    ///         <c>pNext</c> chain of the
    ///         <c>VkPhysicalDeviceClusterCullingShaderFeaturesHUAWEI</c> structure.
    ///         This structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_HUAWEI_cluster_culling_shader
    ///         typedef struct VkPhysicalDeviceClusterCullingShaderVrsFeaturesHUAWEI {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           clusterShadingRate;
    ///         } VkPhysicalDeviceClusterCullingShaderVrsFeaturesHUAWEI;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceClusterCullingShaderVrsFeaturesHUAWEI()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceClusterCullingShaderVrsFeaturesHUAWEI;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ClusterShadingRate</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 ClusterShadingRate;
    }
}
