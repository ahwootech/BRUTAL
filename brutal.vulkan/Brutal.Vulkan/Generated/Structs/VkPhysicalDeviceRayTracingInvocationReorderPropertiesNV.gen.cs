namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceRayTracingInvocationReorderPropertiesNV.html">VkPhysicalDeviceRayTracingInvocationReorderPropertiesNV</see> - Structure describing shader module identifier properties of an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceRayTracingInvocationReorderPropertiesNV</c> structure
    ///         is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_ray_tracing_invocation_reorder
    ///         typedef struct VkPhysicalDeviceRayTracingInvocationReorderPropertiesNV {
    ///             VkStructureType                         sType;
    ///             void*                                   pNext;
    ///             VkRayTracingInvocationReorderModeEXT    rayTracingInvocationReorderReorderingHint;
    ///         } VkPhysicalDeviceRayTracingInvocationReorderPropertiesNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceRayTracingInvocationReorderPropertiesNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceRayTracingInvocationReorderPropertiesNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>RayTracingInvocationReorderReorderingHint</c> is a hint indicating if the implementation will actually reorder at the reorder calls.
        /// </summary>
        [FieldOffset(16)]
        public VkRayTracingInvocationReorderModeEXT RayTracingInvocationReorderReorderingHint;
    }
}
