namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceSeparateDepthStencilLayoutsFeatures.html">VkPhysicalDeviceSeparateDepthStencilLayoutsFeatures</see> - Structure describing whether the implementation can do depth and stencil image barriers separately
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceSeparateDepthStencilLayoutsFeatures</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_2
    ///         typedef struct VkPhysicalDeviceSeparateDepthStencilLayoutsFeatures {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           separateDepthStencilLayouts;
    ///         } VkPhysicalDeviceSeparateDepthStencilLayoutsFeatures;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceSeparateDepthStencilLayoutsFeatures()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceSeparateDepthStencilLayoutsFeatures;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>SeparateDepthStencilLayouts</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 SeparateDepthStencilLayouts;
    }
}
