namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceProvokingVertexFeaturesEXT.html">VkPhysicalDeviceProvokingVertexFeaturesEXT</see> - Structure describing the provoking vertex features that can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceProvokingVertexFeaturesEXT</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_provoking_vertex
    ///         typedef struct VkPhysicalDeviceProvokingVertexFeaturesEXT {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           provokingVertexLast;
    ///             VkBool32           transformFeedbackPreservesProvokingVertex;
    ///         } VkPhysicalDeviceProvokingVertexFeaturesEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceProvokingVertexFeaturesEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceProvokingVertexFeaturesEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ProvokingVertexLast</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 ProvokingVertexLast;

        /// <summary>
        ///     <c>TransformFeedbackPreservesProvokingVertex</c>
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 TransformFeedbackPreservesProvokingVertex;
    }
}
