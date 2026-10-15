namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceClusterCullingShaderFeaturesHUAWEI.html">VkPhysicalDeviceClusterCullingShaderFeaturesHUAWEI</see> - Structure describing whether cluster culling shader is enabled
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceClusterCullingShaderFeaturesHUAWEI</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_HUAWEI_cluster_culling_shader
    ///         typedef struct VkPhysicalDeviceClusterCullingShaderFeaturesHUAWEI {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           clustercullingShader;
    ///             VkBool32           multiviewClusterCullingShader;
    ///         } VkPhysicalDeviceClusterCullingShaderFeaturesHUAWEI;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceClusterCullingShaderFeaturesHUAWEI()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceClusterCullingShaderFeaturesHUAWEI;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ClustercullingShader</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 ClustercullingShader;

        /// <summary>
        ///     <c>MultiviewClusterCullingShader</c>
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 MultiviewClusterCullingShader;
    }
}
