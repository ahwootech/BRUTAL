namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceFragmentShaderBarycentricPropertiesKHR.html">VkPhysicalDeviceFragmentShaderBarycentricPropertiesKHR</see> - Structure describing fragment shader barycentric limits of an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceFragmentShaderBarycentricPropertiesKHR</c> structure
    ///         is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_fragment_shader_barycentric with VK_EXT_provoking_vertex
    ///         typedef struct VkPhysicalDeviceFragmentShaderBarycentricPropertiesKHR {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           triStripVertexOrderIndependentOfProvokingVertex;
    ///         } VkPhysicalDeviceFragmentShaderBarycentricPropertiesKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceFragmentShaderBarycentricPropertiesKHR()
    {
        /// <summary>
        ///     <c>sType</c>
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceFragmentShaderBarycentricPropertiesKHR;

        /// <summary>
        ///     <c>Next</c>
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>TriStripVertexOrderIndependentOfProvokingVertex</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 TriStripVertexOrderIndependentOfProvokingVertex;
    }
}
