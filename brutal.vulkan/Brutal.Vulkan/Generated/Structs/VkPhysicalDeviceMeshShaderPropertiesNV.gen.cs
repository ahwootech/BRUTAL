namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceMeshShaderPropertiesNV.html">VkPhysicalDeviceMeshShaderPropertiesNV</see> - Structure describing mesh shading properties
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceMeshShaderPropertiesNV</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_mesh_shader
    ///         typedef struct VkPhysicalDeviceMeshShaderPropertiesNV {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             uint32_t           maxDrawMeshTasksCount;
    ///             uint32_t           maxTaskWorkGroupInvocations;
    ///             uint32_t           maxTaskWorkGroupSize[3];
    ///             uint32_t           maxTaskTotalMemorySize;
    ///             uint32_t           maxTaskOutputCount;
    ///             uint32_t           maxMeshWorkGroupInvocations;
    ///             uint32_t           maxMeshWorkGroupSize[3];
    ///             uint32_t           maxMeshTotalMemorySize;
    ///             uint32_t           maxMeshOutputVertices;
    ///             uint32_t           maxMeshOutputPrimitives;
    ///             uint32_t           maxMeshMultiviewViewCount;
    ///             uint32_t           meshOutputPerVertexGranularity;
    ///             uint32_t           meshOutputPerPrimitiveGranularity;
    ///         } VkPhysicalDeviceMeshShaderPropertiesNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 88)]
    public unsafe partial struct VkPhysicalDeviceMeshShaderPropertiesNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceMeshShaderPropertiesNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>MaxDrawMeshTasksCount</c> is the maximum number of local workgroups that <i>can</i> be launched by a single draw mesh tasks command. See <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#drawing-mesh-shading">here</see>.
        /// </summary>
        [FieldOffset(16)]
        public int MaxDrawMeshTasksCount;

        /// <summary>
        ///     <c>MaxTaskWorkGroupInvocations</c> is the maximum total number of task shader invocations in a single local workgroup. The product of the X, Y, and Z sizes, as specified by the <c>LocalSize</c> execution mode in shader modules or by the object decorated by the <c>WorkgroupSize</c> decoration, <i>must</i> be less than or equal to this limit.
        /// </summary>
        [FieldOffset(20)]
        public int MaxTaskWorkGroupInvocations;

        /// <summary>
        ///     <c>MaxTaskWorkGroupSize</c>
        /// </summary>
        [FieldOffset(24)]
        public uint3 MaxTaskWorkGroupSize;

        /// <summary>
        ///     <c>MaxTaskTotalMemorySize</c> is the maximum number of bytes that the task shader can use in total for shared and output memory combined.
        /// </summary>
        [FieldOffset(36)]
        public int MaxTaskTotalMemorySize;

        /// <summary>
        ///     <c>MaxTaskOutputCount</c> is the maximum number of output tasks a single task shader workgroup can emit.
        /// </summary>
        [FieldOffset(40)]
        public int MaxTaskOutputCount;

        /// <summary>
        ///     <c>MaxMeshWorkGroupInvocations</c> is the maximum total number of mesh shader invocations in a single local workgroup. The product of the X, Y, and Z sizes, as specified by the <c>LocalSize</c> execution mode in shader modules or by the object decorated by the <c>WorkgroupSize</c> decoration, <i>must</i> be less than or equal to this limit.
        /// </summary>
        [FieldOffset(44)]
        public int MaxMeshWorkGroupInvocations;

        /// <summary>
        ///     <c>MaxMeshWorkGroupSize</c>
        /// </summary>
        [FieldOffset(48)]
        public uint3 MaxMeshWorkGroupSize;

        /// <summary>
        ///     <c>MaxMeshTotalMemorySize</c> is the maximum number of bytes that the mesh shader can use in total for shared and output memory combined.
        /// </summary>
        [FieldOffset(60)]
        public int MaxMeshTotalMemorySize;

        /// <summary>
        ///     <c>MaxMeshOutputVertices</c> is the maximum number of vertices a mesh shader output can store.
        /// </summary>
        [FieldOffset(64)]
        public int MaxMeshOutputVertices;

        /// <summary>
        ///     <c>MaxMeshOutputPrimitives</c> is the maximum number of primitives a mesh shader output can store.
        /// </summary>
        [FieldOffset(68)]
        public int MaxMeshOutputPrimitives;

        /// <summary>
        ///     <c>MaxMeshMultiviewViewCount</c> is the maximum number of multiview views a mesh shader can use.
        /// </summary>
        [FieldOffset(72)]
        public int MaxMeshMultiviewViewCount;

        /// <summary>
        ///     <c>MeshOutputPerVertexGranularity</c> is the granularity with which mesh vertex outputs are allocated. The value can be used to compute the memory size used by the mesh shader, which <i>must</i> be less than or equal to <c>maxMeshTotalMemorySize</c>.
        /// </summary>
        [FieldOffset(76)]
        public int MeshOutputPerVertexGranularity;

        /// <summary>
        ///     <c>MeshOutputPerPrimitiveGranularity</c> is the granularity with which mesh outputs qualified as per-primitive are allocated. The value can be used to compute the memory size used by the mesh shader, which <i>must</i> be less than or equal to <c>maxMeshTotalMemorySize</c>.
        /// </summary>
        [FieldOffset(80)]
        public int MeshOutputPerPrimitiveGranularity;
    }
}
