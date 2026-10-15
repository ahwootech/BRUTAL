namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDevicePipelineOpacityMicromapFeaturesARM.html">VkPhysicalDevicePipelineOpacityMicromapFeaturesARM</see> - Structure describing features supported by VK_ARM_pipeline_opacity_micromap
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDevicePipelineOpacityMicromapFeaturesARM</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ARM_pipeline_opacity_micromap
    ///         typedef struct VkPhysicalDevicePipelineOpacityMicromapFeaturesARM {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           pipelineOpacityMicromap;
    ///         } VkPhysicalDevicePipelineOpacityMicromapFeaturesARM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDevicePipelineOpacityMicromapFeaturesARM()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDevicePipelineOpacityMicromapFeaturesARM;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>PipelineOpacityMicromap</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 PipelineOpacityMicromap;
    }
}
