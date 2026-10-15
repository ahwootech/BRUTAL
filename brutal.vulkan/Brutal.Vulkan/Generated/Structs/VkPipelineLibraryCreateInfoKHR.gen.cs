namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPipelineLibraryCreateInfoKHR.html">VkPipelineLibraryCreateInfoKHR</see> - Structure specifying pipeline libraries to use when creating a pipeline
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPipelineLibraryCreateInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_pipeline_library
    ///         typedef struct VkPipelineLibraryCreateInfoKHR {
    ///             VkStructureType      sType;
    ///             const void*          pNext;
    ///             uint32_t             libraryCount;
    ///             const VkPipeline*    pLibraries;
    ///         } VkPipelineLibraryCreateInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkPipelineLibraryCreateInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PipelineLibraryCreateInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>LibraryCount</c> is the number of pipeline libraries in <c>pLibraries</c>.
        /// </summary>
        [FieldOffset(16)]
        public int LibraryCount;

        /// <summary>
        ///     <c>Libraries</c> is a pointer to an array of <c>VkPipeline</c> structures specifying pipeline libraries to use when creating a pipeline.
        /// </summary>
        [FieldOffset(24)]
        public VkPipeline* Libraries;
    }
}
