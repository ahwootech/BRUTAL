namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDevicePipelineBinaryFeaturesKHR.html">VkPhysicalDevicePipelineBinaryFeaturesKHR</see> - Structure describing support for pipeline binaries
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDevicePipelineBinaryFeaturesKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_pipeline_binary
    ///         typedef struct VkPhysicalDevicePipelineBinaryFeaturesKHR {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           pipelineBinaries;
    ///         } VkPhysicalDevicePipelineBinaryFeaturesKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDevicePipelineBinaryFeaturesKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDevicePipelineBinaryFeaturesKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>PipelineBinaries</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 PipelineBinaries;
    }
}
