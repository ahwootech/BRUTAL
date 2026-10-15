namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceMeshShaderPropertiesEXT.html">VkPhysicalDeviceMeshShaderPropertiesEXT</see> - Structure describing mesh shading properties
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceMeshShaderPropertiesEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_mesh_shader
    ///         typedef struct VkPhysicalDeviceMeshShaderPropertiesEXT {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             uint32_t           maxTaskWorkGroupTotalCount;
    ///             uint32_t           maxTaskWorkGroupCount[3];
    ///             uint32_t           maxTaskWorkGroupInvocations;
    ///             uint32_t           maxTaskWorkGroupSize[3];
    ///             uint32_t           maxTaskPayloadSize;
    ///             uint32_t           maxTaskSharedMemorySize;
    ///             uint32_t           maxTaskPayloadAndSharedMemorySize;
    ///             uint32_t           maxMeshWorkGroupTotalCount;
    ///             uint32_t           maxMeshWorkGroupCount[3];
    ///             uint32_t           maxMeshWorkGroupInvocations;
    ///             uint32_t           maxMeshWorkGroupSize[3];
    ///             uint32_t           maxMeshSharedMemorySize;
    ///             uint32_t           maxMeshPayloadAndSharedMemorySize;
    ///             uint32_t           maxMeshOutputMemorySize;
    ///             uint32_t           maxMeshPayloadAndOutputMemorySize;
    ///             uint32_t           maxMeshOutputComponents;
    ///             uint32_t           maxMeshOutputVertices;
    ///             uint32_t           maxMeshOutputPrimitives;
    ///             uint32_t           maxMeshOutputLayers;
    ///             uint32_t           maxMeshMultiviewViewCount;
    ///             uint32_t           meshOutputPerVertexGranularity;
    ///             uint32_t           meshOutputPerPrimitiveGranularity;
    ///             uint32_t           maxPreferredTaskWorkGroupInvocations;
    ///             uint32_t           maxPreferredMeshWorkGroupInvocations;
    ///             VkBool32           prefersLocalInvocationVertexOutput;
    ///             VkBool32           prefersLocalInvocationPrimitiveOutput;
    ///             VkBool32           prefersCompactVertexOutput;
    ///             VkBool32           prefersCompactPrimitiveOutput;
    ///         } VkPhysicalDeviceMeshShaderPropertiesEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 160)]
    public unsafe partial struct VkPhysicalDeviceMeshShaderPropertiesEXT()
    {
        /// <summary>
        ///     <c>sType</c>
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceMeshShaderPropertiesEXT;

        /// <summary>
        ///     <c>Next</c>
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>MaxTaskWorkGroupTotalCount</c>
        /// </summary>
        [FieldOffset(16)]
        public int MaxTaskWorkGroupTotalCount;

        /// <summary>
        ///     <c>MaxTaskWorkGroupCount</c>
        /// </summary>
        [FieldOffset(20)]
        public uint3 MaxTaskWorkGroupCount;

        /// <summary>
        ///     <c>MaxTaskWorkGroupInvocations</c>
        /// </summary>
        [FieldOffset(32)]
        public int MaxTaskWorkGroupInvocations;

        /// <summary>
        ///     <c>MaxTaskWorkGroupSize</c>
        /// </summary>
        [FieldOffset(36)]
        public uint3 MaxTaskWorkGroupSize;

        /// <summary>
        ///     <c>MaxTaskPayloadSize</c>
        /// </summary>
        [FieldOffset(48)]
        public int MaxTaskPayloadSize;

        /// <summary>
        ///     <c>MaxTaskSharedMemorySize</c>
        /// </summary>
        [FieldOffset(52)]
        public int MaxTaskSharedMemorySize;

        /// <summary>
        ///     <c>MaxTaskPayloadAndSharedMemorySize</c>
        /// </summary>
        [FieldOffset(56)]
        public int MaxTaskPayloadAndSharedMemorySize;

        /// <summary>
        ///     <c>MaxMeshWorkGroupTotalCount</c>
        /// </summary>
        [FieldOffset(60)]
        public int MaxMeshWorkGroupTotalCount;

        /// <summary>
        ///     <c>MaxMeshWorkGroupCount</c>
        /// </summary>
        [FieldOffset(64)]
        public uint3 MaxMeshWorkGroupCount;

        /// <summary>
        ///     <c>MaxMeshWorkGroupInvocations</c>
        /// </summary>
        [FieldOffset(76)]
        public int MaxMeshWorkGroupInvocations;

        /// <summary>
        ///     <c>MaxMeshWorkGroupSize</c>
        /// </summary>
        [FieldOffset(80)]
        public uint3 MaxMeshWorkGroupSize;

        /// <summary>
        ///     <c>MaxMeshSharedMemorySize</c>
        /// </summary>
        [FieldOffset(92)]
        public int MaxMeshSharedMemorySize;

        /// <summary>
        ///     <c>MaxMeshPayloadAndSharedMemorySize</c>
        /// </summary>
        [FieldOffset(96)]
        public int MaxMeshPayloadAndSharedMemorySize;

        /// <summary>
        ///     <c>MaxMeshOutputMemorySize</c>
        /// </summary>
        [FieldOffset(100)]
        public int MaxMeshOutputMemorySize;

        /// <summary>
        ///     <c>MaxMeshPayloadAndOutputMemorySize</c>
        /// </summary>
        [FieldOffset(104)]
        public int MaxMeshPayloadAndOutputMemorySize;

        /// <summary>
        ///     <c>MaxMeshOutputComponents</c>
        /// </summary>
        [FieldOffset(108)]
        public int MaxMeshOutputComponents;

        /// <summary>
        ///     <c>MaxMeshOutputVertices</c>
        /// </summary>
        [FieldOffset(112)]
        public int MaxMeshOutputVertices;

        /// <summary>
        ///     <c>MaxMeshOutputPrimitives</c>
        /// </summary>
        [FieldOffset(116)]
        public int MaxMeshOutputPrimitives;

        /// <summary>
        ///     <c>MaxMeshOutputLayers</c>
        /// </summary>
        [FieldOffset(120)]
        public int MaxMeshOutputLayers;

        /// <summary>
        ///     <c>MaxMeshMultiviewViewCount</c>
        /// </summary>
        [FieldOffset(124)]
        public int MaxMeshMultiviewViewCount;

        /// <summary>
        ///     <c>MeshOutputPerVertexGranularity</c>
        /// </summary>
        [FieldOffset(128)]
        public int MeshOutputPerVertexGranularity;

        /// <summary>
        ///     <c>MeshOutputPerPrimitiveGranularity</c>
        /// </summary>
        [FieldOffset(132)]
        public int MeshOutputPerPrimitiveGranularity;

        /// <summary>
        ///     <c>MaxPreferredTaskWorkGroupInvocations</c>
        /// </summary>
        [FieldOffset(136)]
        public int MaxPreferredTaskWorkGroupInvocations;

        /// <summary>
        ///     <c>MaxPreferredMeshWorkGroupInvocations</c>
        /// </summary>
        [FieldOffset(140)]
        public int MaxPreferredMeshWorkGroupInvocations;

        /// <summary>
        ///     <c>PrefersLocalInvocationVertexOutput</c>
        /// </summary>
        [FieldOffset(144)]
        public Brutal.Bool32 PrefersLocalInvocationVertexOutput;

        /// <summary>
        ///     <c>PrefersLocalInvocationPrimitiveOutput</c>
        /// </summary>
        [FieldOffset(148)]
        public Brutal.Bool32 PrefersLocalInvocationPrimitiveOutput;

        /// <summary>
        ///     <c>PrefersCompactVertexOutput</c>
        /// </summary>
        [FieldOffset(152)]
        public Brutal.Bool32 PrefersCompactVertexOutput;

        /// <summary>
        ///     <c>PrefersCompactPrimitiveOutput</c>
        /// </summary>
        [FieldOffset(156)]
        public Brutal.Bool32 PrefersCompactPrimitiveOutput;
    }
}
