namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceDynamicRenderingFeatures.html">VkPhysicalDeviceDynamicRenderingFeatures</see> - Structure indicating support for dynamic render pass instances
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceDynamicRenderingFeatures</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_3
    ///         typedef struct VkPhysicalDeviceDynamicRenderingFeatures {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           dynamicRendering;
    ///         } VkPhysicalDeviceDynamicRenderingFeatures;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceDynamicRenderingFeatures()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceDynamicRenderingFeatures;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>DynamicRendering</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 DynamicRendering;
    }
}
