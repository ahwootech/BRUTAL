namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDevicePrimitiveTopologyListRestartFeaturesEXT.html">VkPhysicalDevicePrimitiveTopologyListRestartFeaturesEXT</see> - Structure describing whether list type primitives can support primitive restart
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDevicePrimitiveTopologyListRestartFeaturesEXT</c> structure
    ///         is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_primitive_topology_list_restart
    ///         typedef struct VkPhysicalDevicePrimitiveTopologyListRestartFeaturesEXT {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           primitiveTopologyListRestart;
    ///             VkBool32           primitiveTopologyPatchListRestart;
    ///         } VkPhysicalDevicePrimitiveTopologyListRestartFeaturesEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDevicePrimitiveTopologyListRestartFeaturesEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDevicePrimitiveTopologyListRestartFeaturesEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>PrimitiveTopologyListRestart</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 PrimitiveTopologyListRestart;

        /// <summary>
        ///     <c>PrimitiveTopologyPatchListRestart</c>
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 PrimitiveTopologyPatchListRestart;
    }
}
