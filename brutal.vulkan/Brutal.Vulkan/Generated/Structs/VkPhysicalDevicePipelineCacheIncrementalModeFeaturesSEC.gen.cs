namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDevicePipelineCacheIncrementalModeFeaturesSEC.html">VkPhysicalDevicePipelineCacheIncrementalModeFeaturesSEC</see> - Stub description of VkPhysicalDevicePipelineCacheIncrementalModeFeaturesSEC
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         [[features-pipelineCacheIncrementalMode]]
    ///         There is currently no specification language written for this type.
    ///         This section acts only as placeholder and to avoid dead links in the
    ///         specification and reference pages.
    ///     </para>
    ///     <code>
    ///         // Provided by VK_SEC_pipeline_cache_incremental_mode
    ///         typedef struct VkPhysicalDevicePipelineCacheIncrementalModeFeaturesSEC {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           pipelineCacheIncrementalMode;
    ///         } VkPhysicalDevicePipelineCacheIncrementalModeFeaturesSEC;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDevicePipelineCacheIncrementalModeFeaturesSEC()
    {
        /// <summary>
        ///     <c>sType</c>
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDevicePipelineCacheIncrementalModeFeaturesSEC;

        /// <summary>
        ///     <c>Next</c>
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>PipelineCacheIncrementalMode</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 PipelineCacheIncrementalMode;
    }
}
