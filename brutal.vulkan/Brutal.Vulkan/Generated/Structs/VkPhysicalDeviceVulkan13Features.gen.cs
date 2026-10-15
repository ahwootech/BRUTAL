namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceVulkan13Features.html">VkPhysicalDeviceVulkan13Features</see> - Structure describing the Vulkan 1.3 features that can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceVulkan13Features</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_3
    ///         typedef struct VkPhysicalDeviceVulkan13Features {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           robustImageAccess;
    ///             VkBool32           inlineUniformBlock;
    ///             VkBool32           descriptorBindingInlineUniformBlockUpdateAfterBind;
    ///             VkBool32           pipelineCreationCacheControl;
    ///             VkBool32           privateData;
    ///             VkBool32           shaderDemoteToHelperInvocation;
    ///             VkBool32           shaderTerminateInvocation;
    ///             VkBool32           subgroupSizeControl;
    ///             VkBool32           computeFullSubgroups;
    ///             VkBool32           synchronization2;
    ///             VkBool32           textureCompressionASTC_HDR;
    ///             VkBool32           shaderZeroInitializeWorkgroupMemory;
    ///             VkBool32           dynamicRendering;
    ///             VkBool32           shaderIntegerDotProduct;
    ///             VkBool32           maintenance4;
    ///         } VkPhysicalDeviceVulkan13Features;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 80)]
    public unsafe partial struct VkPhysicalDeviceVulkan13Features()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceVulkan13Features;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>RobustImageAccess</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 RobustImageAccess;

        /// <summary>
        ///     <c>InlineUniformBlock</c>
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 InlineUniformBlock;

        /// <summary>
        ///     <c>DescriptorBindingInlineUniformBlockUpdateAfterBind</c>
        /// </summary>
        [FieldOffset(24)]
        public Brutal.Bool32 DescriptorBindingInlineUniformBlockUpdateAfterBind;

        /// <summary>
        ///     <c>PipelineCreationCacheControl</c>
        /// </summary>
        [FieldOffset(28)]
        public Brutal.Bool32 PipelineCreationCacheControl;

        /// <summary>
        ///     <c>PrivateData</c>
        /// </summary>
        [FieldOffset(32)]
        public Brutal.Bool32 PrivateData;

        /// <summary>
        ///     <c>ShaderDemoteToHelperInvocation</c>
        /// </summary>
        [FieldOffset(36)]
        public Brutal.Bool32 ShaderDemoteToHelperInvocation;

        /// <summary>
        ///     <c>ShaderTerminateInvocation</c>
        /// </summary>
        [FieldOffset(40)]
        public Brutal.Bool32 ShaderTerminateInvocation;

        /// <summary>
        ///     <c>SubgroupSizeControl</c>
        /// </summary>
        [FieldOffset(44)]
        public Brutal.Bool32 SubgroupSizeControl;

        /// <summary>
        ///     <c>ComputeFullSubgroups</c>
        /// </summary>
        [FieldOffset(48)]
        public Brutal.Bool32 ComputeFullSubgroups;

        /// <summary>
        ///     <c>Synchronization2</c>
        /// </summary>
        [FieldOffset(52)]
        public Brutal.Bool32 Synchronization2;

        /// <summary>
        ///     <c>TextureCompressionASTCHdr</c>
        /// </summary>
        [FieldOffset(56)]
        public Brutal.Bool32 TextureCompressionASTCHdr;

        /// <summary>
        ///     <c>ShaderZeroInitializeWorkgroupMemory</c>
        /// </summary>
        [FieldOffset(60)]
        public Brutal.Bool32 ShaderZeroInitializeWorkgroupMemory;

        /// <summary>
        ///     <c>DynamicRendering</c>
        /// </summary>
        [FieldOffset(64)]
        public Brutal.Bool32 DynamicRendering;

        /// <summary>
        ///     <c>ShaderIntegerDotProduct</c>
        /// </summary>
        [FieldOffset(68)]
        public Brutal.Bool32 ShaderIntegerDotProduct;

        /// <summary>
        ///     <c>Maintenance4</c>
        /// </summary>
        [FieldOffset(72)]
        public Brutal.Bool32 Maintenance4;
    }
}
