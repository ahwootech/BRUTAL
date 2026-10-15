namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceShaderReplicatedCompositesFeaturesEXT.html">VkPhysicalDeviceShaderReplicatedCompositesFeaturesEXT</see> - Structure describing whether support for replicated composites in SPIR-V is enabled
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceShaderReplicatedCompositesFeaturesEXT</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_shader_replicated_composites
    ///         typedef struct VkPhysicalDeviceShaderReplicatedCompositesFeaturesEXT {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           shaderReplicatedComposites;
    ///         } VkPhysicalDeviceShaderReplicatedCompositesFeaturesEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceShaderReplicatedCompositesFeaturesEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceShaderReplicatedCompositesFeaturesEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ShaderReplicatedComposites</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 ShaderReplicatedComposites;
    }
}
