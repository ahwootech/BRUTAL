namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceVertexInputDynamicStateFeaturesEXT.html">VkPhysicalDeviceVertexInputDynamicStateFeaturesEXT</see> - Structure describing whether the dynamic vertex input state can be used
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceVertexInputDynamicStateFeaturesEXT</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_vertex_input_dynamic_state
    ///         typedef struct VkPhysicalDeviceVertexInputDynamicStateFeaturesEXT {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           vertexInputDynamicState;
    ///         } VkPhysicalDeviceVertexInputDynamicStateFeaturesEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceVertexInputDynamicStateFeaturesEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceVertexInputDynamicStateFeaturesEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>VertexInputDynamicState</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 VertexInputDynamicState;
    }
}
