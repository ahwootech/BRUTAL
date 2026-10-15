namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDevicePipelineCreationCacheControlFeatures.html">VkPhysicalDevicePipelineCreationCacheControlFeatures</see> - Structure describing whether pipeline cache control can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDevicePipelineCreationCacheControlFeatures</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_3
    ///         typedef struct VkPhysicalDevicePipelineCreationCacheControlFeatures {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           pipelineCreationCacheControl;
    ///         } VkPhysicalDevicePipelineCreationCacheControlFeatures;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDevicePipelineCreationCacheControlFeatures()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDevicePipelineCreationCacheControlFeatures;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>PipelineCreationCacheControl</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 PipelineCreationCacheControl;
    }
}
