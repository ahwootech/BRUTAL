namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDevicePipelineProtectedAccessFeatures.html">VkPhysicalDevicePipelineProtectedAccessFeatures</see> - Structure describing support for specifying protected access on individual pipelines
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDevicePipelineProtectedAccessFeatures</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_4
    ///         typedef struct VkPhysicalDevicePipelineProtectedAccessFeatures {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           pipelineProtectedAccess;
    ///         } VkPhysicalDevicePipelineProtectedAccessFeatures;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDevicePipelineProtectedAccessFeatures()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDevicePipelineProtectedAccessFeatures;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>PipelineProtectedAccess</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 PipelineProtectedAccess;
    }
}
