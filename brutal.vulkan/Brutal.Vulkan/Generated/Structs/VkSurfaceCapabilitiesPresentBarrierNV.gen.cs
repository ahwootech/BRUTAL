namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSurfaceCapabilitiesPresentBarrierNV.html">VkSurfaceCapabilitiesPresentBarrierNV</see> - Structure describing present barrier capabilities of a surface
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkSurfaceCapabilitiesPresentBarrierNV</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_present_barrier
    ///         typedef struct VkSurfaceCapabilitiesPresentBarrierNV {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           presentBarrierSupported;
    ///         } VkSurfaceCapabilitiesPresentBarrierNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkSurfaceCapabilitiesPresentBarrierNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.SurfaceCapabilitiesPresentBarrierNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>PresentBarrierSupported</c> is a boolean describing whether the surface is able to make use of the present barrier feature.
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 PresentBarrierSupported;
    }
}
