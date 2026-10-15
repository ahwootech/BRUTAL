namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDevicePipelineExecutablePropertiesFeaturesKHR.html">VkPhysicalDevicePipelineExecutablePropertiesFeaturesKHR</see> - Structure describing whether pipeline executable properties are available
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDevicePipelineExecutablePropertiesFeaturesKHR</c> structure
    ///         is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_pipeline_executable_properties
    ///         typedef struct VkPhysicalDevicePipelineExecutablePropertiesFeaturesKHR {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           pipelineExecutableInfo;
    ///         } VkPhysicalDevicePipelineExecutablePropertiesFeaturesKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDevicePipelineExecutablePropertiesFeaturesKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDevicePipelineExecutablePropertiesFeaturesKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>PipelineExecutableInfo</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 PipelineExecutableInfo;
    }
}
