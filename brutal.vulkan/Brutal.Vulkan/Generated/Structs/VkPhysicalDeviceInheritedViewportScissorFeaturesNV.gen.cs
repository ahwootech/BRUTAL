namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceInheritedViewportScissorFeaturesNV.html">VkPhysicalDeviceInheritedViewportScissorFeaturesNV</see> - Structure describing the viewport scissor inheritance behavior for an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceInheritedViewportScissorFeaturesNV</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_inherited_viewport_scissor
    ///         typedef struct VkPhysicalDeviceInheritedViewportScissorFeaturesNV {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           inheritedViewportScissor2D;
    ///         } VkPhysicalDeviceInheritedViewportScissorFeaturesNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceInheritedViewportScissorFeaturesNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceInheritedViewportScissorFeaturesNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>InheritedViewportScissor2D</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 InheritedViewportScissor2D;
    }
}
