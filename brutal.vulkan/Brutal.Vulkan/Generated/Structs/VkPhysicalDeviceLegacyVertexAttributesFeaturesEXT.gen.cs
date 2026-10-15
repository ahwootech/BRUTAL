namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceLegacyVertexAttributesFeaturesEXT.html">VkPhysicalDeviceLegacyVertexAttributesFeaturesEXT</see> - Structure describing compatibility features for vertex attributes
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceLegacyVertexAttributesFeaturesEXT</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_legacy_vertex_attributes
    ///         typedef struct VkPhysicalDeviceLegacyVertexAttributesFeaturesEXT {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           legacyVertexAttributes;
    ///         } VkPhysicalDeviceLegacyVertexAttributesFeaturesEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceLegacyVertexAttributesFeaturesEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceLegacyVertexAttributesFeaturesEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>LegacyVertexAttributes</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 LegacyVertexAttributes;
    }
}
