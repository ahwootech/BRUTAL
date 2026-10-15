namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceRayTracingLinearSweptSpheresFeaturesNV.html">VkPhysicalDeviceRayTracingLinearSweptSpheresFeaturesNV</see> - Structure describing the ray tracing linear swept spheres features that can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceRayTracingLinearSweptSpheresFeaturesNV</c> structure
    ///         is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_ray_tracing_linear_swept_spheres
    ///         typedef struct VkPhysicalDeviceRayTracingLinearSweptSpheresFeaturesNV {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           spheres;
    ///             VkBool32           linearSweptSpheres;
    ///         } VkPhysicalDeviceRayTracingLinearSweptSpheresFeaturesNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceRayTracingLinearSweptSpheresFeaturesNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceRayTracingLinearSweptSpheresFeaturesNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Spheres</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 Spheres;

        /// <summary>
        ///     <c>LinearSweptSpheres</c>
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 LinearSweptSpheres;
    }
}
