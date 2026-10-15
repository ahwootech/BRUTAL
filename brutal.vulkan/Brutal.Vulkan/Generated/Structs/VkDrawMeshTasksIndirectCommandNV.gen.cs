namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDrawMeshTasksIndirectCommandNV.html">VkDrawMeshTasksIndirectCommandNV</see> - Structure specifying a mesh tasks draw indirect command
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkDrawMeshTasksIndirectCommandNV</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_mesh_shader
    ///         typedef struct VkDrawMeshTasksIndirectCommandNV {
    ///             uint32_t    taskCount;
    ///             uint32_t    firstTask;
    ///         } VkDrawMeshTasksIndirectCommandNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct VkDrawMeshTasksIndirectCommandNV()
    {
        /// <summary>
        ///     <c>TaskCount</c> is the number of local workgroups to dispatch in the X dimension. Y and Z dimension are implicitly set to one.
        /// </summary>
        [FieldOffset(0)]
        public int TaskCount;

        /// <summary>
        ///     <c>FirstTask</c> is the X component of the first workgroup ID.
        /// </summary>
        [FieldOffset(4)]
        public int FirstTask;
    }
}
