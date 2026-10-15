namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceMeshShaderFeaturesEXT.html">VkPhysicalDeviceMeshShaderFeaturesEXT</see> - Structure describing mesh shading features that can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceMeshShaderFeaturesEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_mesh_shader
    ///         typedef struct VkPhysicalDeviceMeshShaderFeaturesEXT {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           taskShader;
    ///             VkBool32           meshShader;
    ///             VkBool32           multiviewMeshShader;
    ///             VkBool32           primitiveFragmentShadingRateMeshShader;
    ///             VkBool32           meshShaderQueries;
    ///         } VkPhysicalDeviceMeshShaderFeaturesEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct VkPhysicalDeviceMeshShaderFeaturesEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceMeshShaderFeaturesEXT;

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

        /// <summary>
        ///     <c>MultiviewMeshShader</c>
        /// </summary>
        [FieldOffset(24)]
        public Brutal.Bool32 MultiviewMeshShader;

        /// <summary>
        ///     <c>PrimitiveFragmentShadingRateMeshShader</c>
        /// </summary>
        [FieldOffset(28)]
        public Brutal.Bool32 PrimitiveFragmentShadingRateMeshShader;

        /// <summary>
        ///     <c>MeshShaderQueries</c>
        /// </summary>
        [FieldOffset(32)]
        public Brutal.Bool32 MeshShaderQueries;
    }
}
