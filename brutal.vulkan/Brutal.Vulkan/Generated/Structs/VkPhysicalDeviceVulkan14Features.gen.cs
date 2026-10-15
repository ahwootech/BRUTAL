namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceVulkan14Features.html">VkPhysicalDeviceVulkan14Features</see> - Structure describing the Vulkan 1.4 features that can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceVulkan14Features</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_4
    ///         typedef struct VkPhysicalDeviceVulkan14Features {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           globalPriorityQuery;
    ///             VkBool32           shaderSubgroupRotate;
    ///             VkBool32           shaderSubgroupRotateClustered;
    ///             VkBool32           shaderFloatControls2;
    ///             VkBool32           shaderExpectAssume;
    ///             VkBool32           rectangularLines;
    ///             VkBool32           bresenhamLines;
    ///             VkBool32           smoothLines;
    ///             VkBool32           stippledRectangularLines;
    ///             VkBool32           stippledBresenhamLines;
    ///             VkBool32           stippledSmoothLines;
    ///             VkBool32           vertexAttributeInstanceRateDivisor;
    ///             VkBool32           vertexAttributeInstanceRateZeroDivisor;
    ///             VkBool32           indexTypeUint8;
    ///             VkBool32           dynamicRenderingLocalRead;
    ///             VkBool32           maintenance5;
    ///             VkBool32           maintenance6;
    ///             VkBool32           pipelineProtectedAccess;
    ///             VkBool32           pipelineRobustness;
    ///             VkBool32           hostImageCopy;
    ///             VkBool32           pushDescriptor;
    ///         } VkPhysicalDeviceVulkan14Features;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 104)]
    public unsafe partial struct VkPhysicalDeviceVulkan14Features()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceVulkan14Features;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>GlobalPriorityQuery</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 GlobalPriorityQuery;

        /// <summary>
        ///     <c>ShaderSubgroupRotate</c>
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 ShaderSubgroupRotate;

        /// <summary>
        ///     <c>ShaderSubgroupRotateClustered</c>
        /// </summary>
        [FieldOffset(24)]
        public Brutal.Bool32 ShaderSubgroupRotateClustered;

        /// <summary>
        ///     <c>ShaderFloatControls2</c>
        /// </summary>
        [FieldOffset(28)]
        public Brutal.Bool32 ShaderFloatControls2;

        /// <summary>
        ///     <c>ShaderExpectAssume</c>
        /// </summary>
        [FieldOffset(32)]
        public Brutal.Bool32 ShaderExpectAssume;

        /// <summary>
        ///     <c>RectangularLines</c>
        /// </summary>
        [FieldOffset(36)]
        public Brutal.Bool32 RectangularLines;

        /// <summary>
        ///     <c>BresenhamLines</c>
        /// </summary>
        [FieldOffset(40)]
        public Brutal.Bool32 BresenhamLines;

        /// <summary>
        ///     <c>SmoothLines</c>
        /// </summary>
        [FieldOffset(44)]
        public Brutal.Bool32 SmoothLines;

        /// <summary>
        ///     <c>StippledRectangularLines</c>
        /// </summary>
        [FieldOffset(48)]
        public Brutal.Bool32 StippledRectangularLines;

        /// <summary>
        ///     <c>StippledBresenhamLines</c>
        /// </summary>
        [FieldOffset(52)]
        public Brutal.Bool32 StippledBresenhamLines;

        /// <summary>
        ///     <c>StippledSmoothLines</c>
        /// </summary>
        [FieldOffset(56)]
        public Brutal.Bool32 StippledSmoothLines;

        /// <summary>
        ///     <c>VertexAttributeInstanceRateDivisor</c>
        /// </summary>
        [FieldOffset(60)]
        public Brutal.Bool32 VertexAttributeInstanceRateDivisor;

        /// <summary>
        ///     <c>VertexAttributeInstanceRateZeroDivisor</c>
        /// </summary>
        [FieldOffset(64)]
        public Brutal.Bool32 VertexAttributeInstanceRateZeroDivisor;

        /// <summary>
        ///     <c>IndexTypeUint8</c>
        /// </summary>
        [FieldOffset(68)]
        public Brutal.Bool32 IndexTypeUint8;

        /// <summary>
        ///     <c>DynamicRenderingLocalRead</c>
        /// </summary>
        [FieldOffset(72)]
        public Brutal.Bool32 DynamicRenderingLocalRead;

        /// <summary>
        ///     <c>Maintenance5</c>
        /// </summary>
        [FieldOffset(76)]
        public Brutal.Bool32 Maintenance5;

        /// <summary>
        ///     <c>Maintenance6</c>
        /// </summary>
        [FieldOffset(80)]
        public Brutal.Bool32 Maintenance6;

        /// <summary>
        ///     <c>PipelineProtectedAccess</c>
        /// </summary>
        [FieldOffset(84)]
        public Brutal.Bool32 PipelineProtectedAccess;

        /// <summary>
        ///     <c>PipelineRobustness</c>
        /// </summary>
        [FieldOffset(88)]
        public Brutal.Bool32 PipelineRobustness;

        /// <summary>
        ///     <c>HostImageCopy</c>
        /// </summary>
        [FieldOffset(92)]
        public Brutal.Bool32 HostImageCopy;

        /// <summary>
        ///     <c>PushDescriptor</c>
        /// </summary>
        [FieldOffset(96)]
        public Brutal.Bool32 PushDescriptor;
    }
}
