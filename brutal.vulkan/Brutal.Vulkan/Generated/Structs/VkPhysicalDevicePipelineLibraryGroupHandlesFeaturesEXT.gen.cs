namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDevicePipelineLibraryGroupHandlesFeaturesEXT.html">VkPhysicalDevicePipelineLibraryGroupHandlesFeaturesEXT</see> - Structure describing whether querying shader group handles from a pipeline library is supported by the implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDevicePipelineLibraryGroupHandlesFeaturesEXT</c> structure
    ///         is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_pipeline_library_group_handles
    ///         typedef struct VkPhysicalDevicePipelineLibraryGroupHandlesFeaturesEXT {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           pipelineLibraryGroupHandles;
    ///         } VkPhysicalDevicePipelineLibraryGroupHandlesFeaturesEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDevicePipelineLibraryGroupHandlesFeaturesEXT()
    {
        /// <summary>
        ///     <c>sType</c>
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDevicePipelineLibraryGroupHandlesFeaturesEXT;

        /// <summary>
        ///     <c>Next</c>
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>PipelineLibraryGroupHandles</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 PipelineLibraryGroupHandles;
    }
}
