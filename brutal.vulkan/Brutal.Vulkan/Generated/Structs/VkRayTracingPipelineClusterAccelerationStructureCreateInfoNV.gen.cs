namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkRayTracingPipelineClusterAccelerationStructureCreateInfoNV.html">VkRayTracingPipelineClusterAccelerationStructureCreateInfoNV</see> - Structure controlling if cluster acceleration structures are allowed
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkRayTracingPipelineClusterAccelerationStructureCreateInfoNV
    ///     </para>
    ///     <para>
    ///         The <c>VkRayTracingPipelineClusterAccelerationStructureCreateInfoNV</c>
    ///         structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_ray_tracing_pipeline with VK_NV_cluster_acceleration_structure
    ///         typedef struct VkRayTracingPipelineClusterAccelerationStructureCreateInfoNV {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           allowClusterAccelerationStructure;
    ///         } VkRayTracingPipelineClusterAccelerationStructureCreateInfoNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkRayTracingPipelineClusterAccelerationStructureCreateInfoNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType =
            VkStructureType.RayTracingPipelineClusterAccelerationStructureCreateInfoNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>AllowClusterAccelerationStructure</c> controls if cluster acceleration structures are allowed in the ray tracing pipeline.
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 AllowClusterAccelerationStructure;
    }
}
