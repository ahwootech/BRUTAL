namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSurfaceCapabilitiesPresentId2KHR.html">VkSurfaceCapabilitiesPresentId2KHR</see> - Structure describing presentation-ID capabilities of a surface
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkSurfaceCapabilitiesPresentId2KHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_present_id2
    ///         typedef struct VkSurfaceCapabilitiesPresentId2KHR {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           presentId2Supported;
    ///         } VkSurfaceCapabilitiesPresentId2KHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkSurfaceCapabilitiesPresentId2KHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.SurfaceCapabilitiesPresentId2KHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>PresentId2Supported</c> is a boolean describing whether the surface is able to support the present-ID extension
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 PresentId2Supported;
    }
}
