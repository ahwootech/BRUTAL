namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPipelineCacheCreateInfo.html">VkPipelineCacheCreateInfo</see> - Structure specifying parameters of a newly created pipeline cache
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPipelineCacheCreateInfo</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef struct VkPipelineCacheCreateInfo {
    ///             VkStructureType               sType;
    ///             const void*                   pNext;
    ///             VkPipelineCacheCreateFlags    flags;
    ///             size_t                        initialDataSize;
    ///             const void*                   pInitialData;
    ///         } VkPipelineCacheCreateInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct VkPipelineCacheCreateInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PipelineCacheCreateInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is reserved for future use.
        /// </summary>
        [FieldOffset(16)]
        public VkPipelineCacheCreateFlags Flags;

        /// <summary>
        ///     <c>InitialDataSize</c> is the number of bytes in <c>pInitialData</c>. If <c>initialDataSize</c> is zero, the pipeline cache will initially be empty.
        /// </summary>
        [FieldOffset(24)]
        public nuint InitialDataSize;

        /// <summary>
        ///     <c>InitialData</c> is a pointer to previously retrieved pipeline cache data. If the pipeline cache data is incompatible (as defined below) with the device, the pipeline cache will be initially empty. If <c>initialDataSize</c> is zero, <c>pInitialData</c> is ignored.
        /// </summary>
        [FieldOffset(32)]
        public void* InitialData;
    }
}
