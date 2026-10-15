namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDevicePipelineBinaryPropertiesKHR.html">VkPhysicalDevicePipelineBinaryPropertiesKHR</see> - Structure describing properties about the pipeline binary implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDevicePipelineBinaryPropertiesKHR</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_pipeline_binary
    ///         typedef struct VkPhysicalDevicePipelineBinaryPropertiesKHR {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           pipelineBinaryInternalCache;
    ///             VkBool32           pipelineBinaryInternalCacheControl;
    ///             VkBool32           pipelineBinaryPrefersInternalCache;
    ///             VkBool32           pipelineBinaryPrecompiledInternalCache;
    ///             VkBool32           pipelineBinaryCompressedData;
    ///         } VkPhysicalDevicePipelineBinaryPropertiesKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct VkPhysicalDevicePipelineBinaryPropertiesKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDevicePipelineBinaryPropertiesKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>PipelineBinaryInternalCache</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 PipelineBinaryInternalCache;

        /// <summary>
        ///     <c>PipelineBinaryInternalCacheControl</c>
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 PipelineBinaryInternalCacheControl;

        /// <summary>
        ///     <c>PipelineBinaryPrefersInternalCache</c>
        /// </summary>
        [FieldOffset(24)]
        public Brutal.Bool32 PipelineBinaryPrefersInternalCache;

        /// <summary>
        ///     <c>PipelineBinaryPrecompiledInternalCache</c>
        /// </summary>
        [FieldOffset(28)]
        public Brutal.Bool32 PipelineBinaryPrecompiledInternalCache;

        /// <summary>
        ///     <c>PipelineBinaryCompressedData</c>
        /// </summary>
        [FieldOffset(32)]
        public Brutal.Bool32 PipelineBinaryCompressedData;
    }
}
