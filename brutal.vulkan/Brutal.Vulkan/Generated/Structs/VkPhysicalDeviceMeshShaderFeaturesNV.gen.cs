namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceMeshShaderFeaturesNV.html">VkPhysicalDeviceMeshShaderFeaturesNV</see> - Structure describing mesh shading features that can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceMeshShaderFeaturesNV</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_mesh_shader
    ///         typedef struct VkPhysicalDeviceMeshShaderFeaturesNV {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           taskShader;
    ///             VkBool32           meshShader;
    ///         } VkPhysicalDeviceMeshShaderFeaturesNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceMeshShaderFeaturesNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceMeshShaderFeaturesNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>TaskShader</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 TaskShader;

        /// <summary>
        ///     <c>MeshShader</c>
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 MeshShader;
    }
}
