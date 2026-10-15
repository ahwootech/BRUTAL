namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceRayTracingPipelineFeaturesKHR.html">VkPhysicalDeviceRayTracingPipelineFeaturesKHR</see> - Structure describing the ray tracing features that can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceRayTracingPipelineFeaturesKHR</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_ray_tracing_pipeline
    ///         typedef struct VkPhysicalDeviceRayTracingPipelineFeaturesKHR {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           rayTracingPipeline;
    ///             VkBool32           rayTracingPipelineShaderGroupHandleCaptureReplay;
    ///             VkBool32           rayTracingPipelineShaderGroupHandleCaptureReplayMixed;
    ///             VkBool32           rayTracingPipelineTraceRaysIndirect;
    ///             VkBool32           rayTraversalPrimitiveCulling;
    ///         } VkPhysicalDeviceRayTracingPipelineFeaturesKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct VkPhysicalDeviceRayTracingPipelineFeaturesKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceRayTracingPipelineFeaturesKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>RayTracingPipeline</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 RayTracingPipeline;

        /// <summary>
        ///     <c>RayTracingPipelineShaderGroupHandleCaptureReplay</c>
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 RayTracingPipelineShaderGroupHandleCaptureReplay;

        /// <summary>
        ///     <c>RayTracingPipelineShaderGroupHandleCaptureReplayMixed</c>
        /// </summary>
        [FieldOffset(24)]
        public Brutal.Bool32 RayTracingPipelineShaderGroupHandleCaptureReplayMixed;

        /// <summary>
        ///     <c>RayTracingPipelineTraceRaysIndirect</c>
        /// </summary>
        [FieldOffset(28)]
        public Brutal.Bool32 RayTracingPipelineTraceRaysIndirect;

        /// <summary>
        ///     <c>RayTraversalPrimitiveCulling</c>
        /// </summary>
        [FieldOffset(32)]
        public Brutal.Bool32 RayTraversalPrimitiveCulling;
    }
}
