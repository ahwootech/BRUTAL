namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceDynamicRenderingLocalReadFeatures.html">VkPhysicalDeviceDynamicRenderingLocalReadFeatures</see> - Structure indicating support for local reads in dynamic render pass instances
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceDynamicRenderingLocalReadFeatures</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_4
    ///         typedef struct VkPhysicalDeviceDynamicRenderingLocalReadFeatures {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           dynamicRenderingLocalRead;
    ///         } VkPhysicalDeviceDynamicRenderingLocalReadFeatures;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceDynamicRenderingLocalReadFeatures()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceDynamicRenderingLocalReadFeatures;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>DynamicRenderingLocalRead</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 DynamicRenderingLocalRead;
    }
}
