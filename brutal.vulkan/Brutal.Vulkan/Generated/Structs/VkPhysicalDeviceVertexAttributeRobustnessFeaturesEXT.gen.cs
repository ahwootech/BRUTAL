namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceVertexAttributeRobustnessFeaturesEXT.html">VkPhysicalDeviceVertexAttributeRobustnessFeaturesEXT</see> - Structure describing whether the vertex attribute robustness feature is supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceVertexAttributeRobustnessFeaturesEXT</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_vertex_attribute_robustness
    ///         typedef struct VkPhysicalDeviceVertexAttributeRobustnessFeaturesEXT {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           vertexAttributeRobustness;
    ///         } VkPhysicalDeviceVertexAttributeRobustnessFeaturesEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceVertexAttributeRobustnessFeaturesEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceVertexAttributeRobustnessFeaturesEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>VertexAttributeRobustness</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 VertexAttributeRobustness;
    }
}
