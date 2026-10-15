namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceRayTracingMotionBlurFeaturesNV.html">VkPhysicalDeviceRayTracingMotionBlurFeaturesNV</see> - Structure describing the ray tracing motion blur features that can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceRayTracingMotionBlurFeaturesNV</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_ray_tracing_motion_blur
    ///         typedef struct VkPhysicalDeviceRayTracingMotionBlurFeaturesNV {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           rayTracingMotionBlur;
    ///             VkBool32           rayTracingMotionBlurPipelineTraceRaysIndirect;
    ///         } VkPhysicalDeviceRayTracingMotionBlurFeaturesNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceRayTracingMotionBlurFeaturesNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceRayTracingMotionBlurFeaturesNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>RayTracingMotionBlur</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 RayTracingMotionBlur;

        /// <summary>
        ///     <c>RayTracingMotionBlurPipelineTraceRaysIndirect</c>
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 RayTracingMotionBlurPipelineTraceRaysIndirect;
    }
}
