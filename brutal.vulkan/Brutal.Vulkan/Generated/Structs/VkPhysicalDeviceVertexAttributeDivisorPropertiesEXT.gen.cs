namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceVertexAttributeDivisorPropertiesEXT.html">VkPhysicalDeviceVertexAttributeDivisorPropertiesEXT</see> - Structure describing max value of vertex attribute divisor that can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceVertexAttributeDivisorPropertiesEXT</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_vertex_attribute_divisor
    ///         typedef struct VkPhysicalDeviceVertexAttributeDivisorPropertiesEXT {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             uint32_t           maxVertexAttribDivisor;
    ///         } VkPhysicalDeviceVertexAttributeDivisorPropertiesEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceVertexAttributeDivisorPropertiesEXT()
    {
        /// <summary>
        ///     <c>sType</c>
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceVertexAttributeDivisorPropertiesEXT;

        /// <summary>
        ///     <c>Next</c>
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>MaxVertexAttribDivisor</c>
        /// </summary>
        [FieldOffset(16)]
        public int MaxVertexAttribDivisor;
    }
}
