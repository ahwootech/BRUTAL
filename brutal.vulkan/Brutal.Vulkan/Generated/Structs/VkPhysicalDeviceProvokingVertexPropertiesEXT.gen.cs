namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceProvokingVertexPropertiesEXT.html">VkPhysicalDeviceProvokingVertexPropertiesEXT</see> - Structure describing provoking vertex properties supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceProvokingVertexPropertiesEXT</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_provoking_vertex
    ///         typedef struct VkPhysicalDeviceProvokingVertexPropertiesEXT {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           provokingVertexModePerPipeline;
    ///             VkBool32           transformFeedbackPreservesTriangleFanProvokingVertex;
    ///         } VkPhysicalDeviceProvokingVertexPropertiesEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceProvokingVertexPropertiesEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceProvokingVertexPropertiesEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ProvokingVertexModePerPipeline</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 ProvokingVertexModePerPipeline;

        /// <summary>
        ///     <c>TransformFeedbackPreservesTriangleFanProvokingVertex</c>
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 TransformFeedbackPreservesTriangleFanProvokingVertex;
    }
}
