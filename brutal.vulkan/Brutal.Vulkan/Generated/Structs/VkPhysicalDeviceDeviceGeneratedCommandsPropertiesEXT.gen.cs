namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceDeviceGeneratedCommandsPropertiesEXT.html">VkPhysicalDeviceDeviceGeneratedCommandsPropertiesEXT</see> - Structure describing push descriptor limits that can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceDeviceGeneratedCommandsPropertiesEXT</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_device_generated_commands
    ///         typedef struct VkPhysicalDeviceDeviceGeneratedCommandsPropertiesEXT {
    ///             VkStructureType                        sType;
    ///             void*                                  pNext;
    ///             uint32_t                               maxIndirectPipelineCount;
    ///             uint32_t                               maxIndirectShaderObjectCount;
    ///             uint32_t                               maxIndirectSequenceCount;
    ///             uint32_t                               maxIndirectCommandsTokenCount;
    ///             uint32_t                               maxIndirectCommandsTokenOffset;
    ///             uint32_t                               maxIndirectCommandsIndirectStride;
    ///             VkIndirectCommandsInputModeFlagsEXT    supportedIndirectCommandsInputModes;
    ///             VkShaderStageFlags                     supportedIndirectCommandsShaderStages;
    ///             VkShaderStageFlags                     supportedIndirectCommandsShaderStagesPipelineBinding;
    ///             VkShaderStageFlags                     supportedIndirectCommandsShaderStagesShaderBinding;
    ///             VkBool32                               deviceGeneratedCommandsTransformFeedback;
    ///             VkBool32                               deviceGeneratedCommandsMultiDrawIndirectCount;
    ///         } VkPhysicalDeviceDeviceGeneratedCommandsPropertiesEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public unsafe partial struct VkPhysicalDeviceDeviceGeneratedCommandsPropertiesEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceDeviceGeneratedCommandsPropertiesEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>MaxIndirectPipelineCount</c>
        /// </summary>
        [FieldOffset(16)]
        public int MaxIndirectPipelineCount;

        /// <summary>
        ///     <c>MaxIndirectShaderObjectCount</c>
        /// </summary>
        [FieldOffset(20)]
        public int MaxIndirectShaderObjectCount;

        /// <summary>
        ///     <c>MaxIndirectSequenceCount</c>
        /// </summary>
        [FieldOffset(24)]
        public int MaxIndirectSequenceCount;

        /// <summary>
        ///     <c>MaxIndirectCommandsTokenCount</c>
        /// </summary>
        [FieldOffset(28)]
        public int MaxIndirectCommandsTokenCount;

        /// <summary>
        ///     <c>MaxIndirectCommandsTokenOffset</c>
        /// </summary>
        [FieldOffset(32)]
        public int MaxIndirectCommandsTokenOffset;

        /// <summary>
        ///     <c>MaxIndirectCommandsIndirectStride</c>
        /// </summary>
        [FieldOffset(36)]
        public int MaxIndirectCommandsIndirectStride;

        /// <summary>
        ///     <c>SupportedIndirectCommandsInputModes</c>
        /// </summary>
        [FieldOffset(40)]
        public VkIndirectCommandsInputModeFlagsEXT SupportedIndirectCommandsInputModes;

        /// <summary>
        ///     <c>SupportedIndirectCommandsShaderStages</c>
        /// </summary>
        [FieldOffset(44)]
        public VkShaderStageFlags SupportedIndirectCommandsShaderStages;

        /// <summary>
        ///     <c>SupportedIndirectCommandsShaderStagesPipelineBinding</c>
        /// </summary>
        [FieldOffset(48)]
        public VkShaderStageFlags SupportedIndirectCommandsShaderStagesPipelineBinding;

        /// <summary>
        ///     <c>SupportedIndirectCommandsShaderStagesShaderBinding</c>
        /// </summary>
        [FieldOffset(52)]
        public VkShaderStageFlags SupportedIndirectCommandsShaderStagesShaderBinding;

        /// <summary>
        ///     <c>DeviceGeneratedCommandsTransformFeedback</c>
        /// </summary>
        [FieldOffset(56)]
        public Brutal.Bool32 DeviceGeneratedCommandsTransformFeedback;

        /// <summary>
        ///     <c>DeviceGeneratedCommandsMultiDrawIndirectCount</c>
        /// </summary>
        [FieldOffset(60)]
        public Brutal.Bool32 DeviceGeneratedCommandsMultiDrawIndirectCount;
    }
}
