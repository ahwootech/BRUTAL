namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceRayTracingInvocationReorderFeaturesEXT.html">VkPhysicalDeviceRayTracingInvocationReorderFeaturesEXT</see> - Structure describing feature to control ray tracing invocation reordering
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceRayTracingInvocationReorderFeaturesEXT</c> structure
    ///         is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_ray_tracing_invocation_reorder
    ///         typedef struct VkPhysicalDeviceRayTracingInvocationReorderFeaturesEXT {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           rayTracingInvocationReorder;
    ///         } VkPhysicalDeviceRayTracingInvocationReorderFeaturesEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceRayTracingInvocationReorderFeaturesEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceRayTracingInvocationReorderFeaturesEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>RayTracingInvocationReorder</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 RayTracingInvocationReorder;
    }
}
