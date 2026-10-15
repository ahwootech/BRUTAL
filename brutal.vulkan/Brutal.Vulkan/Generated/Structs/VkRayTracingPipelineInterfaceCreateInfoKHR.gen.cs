namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkRayTracingPipelineInterfaceCreateInfoKHR.html">VkRayTracingPipelineInterfaceCreateInfoKHR</see> - Structure specifying additional interface information when using libraries
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkRayTracingPipelineInterfaceCreateInfoKHR
    ///     </para>
    ///     <para>
    ///         The <c>VkRayTracingPipelineInterfaceCreateInfoKHR</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_ray_tracing_pipeline
    ///         typedef struct VkRayTracingPipelineInterfaceCreateInfoKHR {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             uint32_t           maxPipelineRayPayloadSize;
    ///             uint32_t           maxPipelineRayHitAttributeSize;
    ///         } VkRayTracingPipelineInterfaceCreateInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkRayTracingPipelineInterfaceCreateInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.RayTracingPipelineInterfaceCreateInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>MaxPipelineRayPayloadSize</c> is the maximum payload size in bytes used by any shader in the pipeline.
        /// </summary>
        [FieldOffset(16)]
        public int MaxPipelineRayPayloadSize;

        /// <summary>
        ///     <c>MaxPipelineRayHitAttributeSize</c> is the maximum attribute structure size in bytes used by any shader in the pipeline.
        /// </summary>
        [FieldOffset(20)]
        public int MaxPipelineRayHitAttributeSize;
    }
}
