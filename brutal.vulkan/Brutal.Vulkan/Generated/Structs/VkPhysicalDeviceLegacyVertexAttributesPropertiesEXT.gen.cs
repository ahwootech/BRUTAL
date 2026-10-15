namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceLegacyVertexAttributesPropertiesEXT.html">VkPhysicalDeviceLegacyVertexAttributesPropertiesEXT</see> - Structure describing properties for legacy vertex attributes
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceLegacyVertexAttributesPropertiesEXT</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_legacy_vertex_attributes
    ///         typedef struct VkPhysicalDeviceLegacyVertexAttributesPropertiesEXT {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           nativeUnalignedPerformance;
    ///         } VkPhysicalDeviceLegacyVertexAttributesPropertiesEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceLegacyVertexAttributesPropertiesEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceLegacyVertexAttributesPropertiesEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>NativeUnalignedPerformance</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 NativeUnalignedPerformance;
    }
}
