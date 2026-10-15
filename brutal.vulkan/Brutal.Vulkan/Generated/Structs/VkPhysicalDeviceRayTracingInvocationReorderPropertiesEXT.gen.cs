namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceRayTracingInvocationReorderPropertiesEXT.html">VkPhysicalDeviceRayTracingInvocationReorderPropertiesEXT</see> - Structure describing shader module identifier properties of an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceRayTracingInvocationReorderPropertiesEXT</c> structure
    ///         is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_ray_tracing_invocation_reorder
    ///         typedef struct VkPhysicalDeviceRayTracingInvocationReorderPropertiesEXT {
    ///             VkStructureType                         sType;
    ///             void*                                   pNext;
    ///             VkRayTracingInvocationReorderModeEXT    rayTracingInvocationReorderReorderingHint;
    ///             uint32_t                                maxShaderBindingTableRecordIndex;
    ///         } VkPhysicalDeviceRayTracingInvocationReorderPropertiesEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceRayTracingInvocationReorderPropertiesEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType =
            VkStructureType.PhysicalDeviceRayTracingInvocationReorderPropertiesEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>RayTracingInvocationReorderReorderingHint</c> is a hint indicating if the implementation may: reorder at the reorder calls.
        /// </summary>
        [FieldOffset(16)]
        public VkRayTracingInvocationReorderModeEXT RayTracingInvocationReorderReorderingHint;

        /// <summary>
        ///     <c>MaxShaderBindingTableRecordIndex</c> is the maximum shader binding table record index allowed to be passed in to <c>OpHitObjectSetShaderBindingTableRecordIndexEXT</c>
        /// </summary>
        [FieldOffset(20)]
        public int MaxShaderBindingTableRecordIndex;
    }
}
