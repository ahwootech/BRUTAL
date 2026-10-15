namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDrawMeshTasksIndirectCommandEXT.html">VkDrawMeshTasksIndirectCommandEXT</see> - Structure specifying a mesh tasks draw indirect command
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkDrawMeshTasksIndirectCommandEXT
    ///     </para>
    ///     <para>
    ///         The <c>VkDrawMeshTasksIndirectCommandEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_mesh_shader
    ///         typedef struct VkDrawMeshTasksIndirectCommandEXT {
    ///             uint32_t    groupCountX;
    ///             uint32_t    groupCountY;
    ///             uint32_t    groupCountZ;
    ///         } VkDrawMeshTasksIndirectCommandEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial struct VkDrawMeshTasksIndirectCommandEXT()
    {
        /// <summary>
        ///     <c>GroupCountX</c> is the number of local workgroups to dispatch in the X dimension.
        /// </summary>
        [FieldOffset(0)]
        public int GroupCountX;

        /// <summary>
        ///     <c>GroupCountY</c> is the number of local workgroups to dispatch in the Y dimension.
        /// </summary>
        [FieldOffset(4)]
        public int GroupCountY;

        /// <summary>
        ///     <c>GroupCountZ</c> is the number of local workgroups to dispatch in the Z dimension.
        /// </summary>
        [FieldOffset(8)]
        public int GroupCountZ;
    }
}
