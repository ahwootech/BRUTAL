namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceRayTracingPositionFetchFeaturesKHR.html">VkPhysicalDeviceRayTracingPositionFetchFeaturesKHR</see> - Structure describing support for fetching vertex positions of hit triangles
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceRayTracingPositionFetchFeaturesKHR</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_ray_tracing_position_fetch
    ///         typedef struct VkPhysicalDeviceRayTracingPositionFetchFeaturesKHR {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           rayTracingPositionFetch;
    ///         } VkPhysicalDeviceRayTracingPositionFetchFeaturesKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceRayTracingPositionFetchFeaturesKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceRayTracingPositionFetchFeaturesKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>RayTracingPositionFetch</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 RayTracingPositionFetch;
    }
}
