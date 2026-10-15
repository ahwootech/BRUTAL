namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceDeviceGeneratedCommandsPropertiesNV.html">VkPhysicalDeviceDeviceGeneratedCommandsPropertiesNV</see> - Structure describing push descriptor limits that can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceDeviceGeneratedCommandsPropertiesNV</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_device_generated_commands
    ///         typedef struct VkPhysicalDeviceDeviceGeneratedCommandsPropertiesNV {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             uint32_t           maxGraphicsShaderGroupCount;
    ///             uint32_t           maxIndirectSequenceCount;
    ///             uint32_t           maxIndirectCommandsTokenCount;
    ///             uint32_t           maxIndirectCommandsStreamCount;
    ///             uint32_t           maxIndirectCommandsTokenOffset;
    ///             uint32_t           maxIndirectCommandsStreamStride;
    ///             uint32_t           minSequencesCountBufferOffsetAlignment;
    ///             uint32_t           minSequencesIndexBufferOffsetAlignment;
    ///             uint32_t           minIndirectCommandsBufferOffsetAlignment;
    ///         } VkPhysicalDeviceDeviceGeneratedCommandsPropertiesNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public unsafe partial struct VkPhysicalDeviceDeviceGeneratedCommandsPropertiesNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceDeviceGeneratedCommandsPropertiesNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>MaxGraphicsShaderGroupCount</c> is the maximum number of shader groups in <c>VkGraphicsPipelineShaderGroupsCreateInfoNV</c>.
        /// </summary>
        [FieldOffset(16)]
        public int MaxGraphicsShaderGroupCount;

        /// <summary>
        ///     <c>MaxIndirectSequenceCount</c> is the maximum number of sequences in <c>VkGeneratedCommandsInfoNV</c> and in <c>VkGeneratedCommandsMemoryRequirementsInfoNV</c>.
        /// </summary>
        [FieldOffset(20)]
        public int MaxIndirectSequenceCount;

        /// <summary>
        ///     <c>MaxIndirectCommandsTokenCount</c> is the maximum number of tokens in <c>VkIndirectCommandsLayoutCreateInfoNV</c>.
        /// </summary>
        [FieldOffset(24)]
        public int MaxIndirectCommandsTokenCount;

        /// <summary>
        ///     <c>MaxIndirectCommandsStreamCount</c> is the maximum number of streams in <c>VkIndirectCommandsLayoutCreateInfoNV</c>.
        /// </summary>
        [FieldOffset(28)]
        public int MaxIndirectCommandsStreamCount;

        /// <summary>
        ///     <c>MaxIndirectCommandsTokenOffset</c> is the maximum offset in <c>VkIndirectCommandsLayoutTokenNV</c>.
        /// </summary>
        [FieldOffset(32)]
        public int MaxIndirectCommandsTokenOffset;

        /// <summary>
        ///     <c>MaxIndirectCommandsStreamStride</c> is the maximum stream stride in <c>VkIndirectCommandsLayoutCreateInfoNV</c>.
        /// </summary>
        [FieldOffset(36)]
        public int MaxIndirectCommandsStreamStride;

        /// <summary>
        ///     <c>MinSequencesCountBufferOffsetAlignment</c> is the minimum alignment for memory addresses which <i>can</i> be used in <c>VkGeneratedCommandsInfoNV</c>.
        /// </summary>
        [FieldOffset(40)]
        public int MinSequencesCountBufferOffsetAlignment;

        /// <summary>
        ///     <c>MinSequencesIndexBufferOffsetAlignment</c> is the minimum alignment for memory addresses which <i>can</i> be used in <c>VkGeneratedCommandsInfoNV</c>.
        /// </summary>
        [FieldOffset(44)]
        public int MinSequencesIndexBufferOffsetAlignment;

        /// <summary>
        ///     <c>MinIndirectCommandsBufferOffsetAlignment</c> is the minimum alignment for memory addresses used in <c>VkIndirectCommandsStreamNV</c>, and as preprocess buffer in <c>VkGeneratedCommandsInfoNV</c>.
        /// </summary>
        [FieldOffset(48)]
        public int MinIndirectCommandsBufferOffsetAlignment;
    }
}
