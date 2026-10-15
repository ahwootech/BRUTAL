namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceRayTracingMaintenance1FeaturesKHR.html">VkPhysicalDeviceRayTracingMaintenance1FeaturesKHR</see> - Structure describing the ray tracing maintenance features that can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceRayTracingMaintenance1FeaturesKHR</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_ray_tracing_maintenance1
    ///         typedef struct VkPhysicalDeviceRayTracingMaintenance1FeaturesKHR {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           rayTracingMaintenance1;
    ///             VkBool32           rayTracingPipelineTraceRaysIndirect2;
    ///         } VkPhysicalDeviceRayTracingMaintenance1FeaturesKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceRayTracingMaintenance1FeaturesKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceRayTracingMaintenance1FeaturesKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>RayTracingMaintenance1</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 RayTracingMaintenance1;

        /// <summary>
        ///     <c>RayTracingPipelineTraceRaysIndirect2</c>
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 RayTracingPipelineTraceRaysIndirect2;
    }
}
