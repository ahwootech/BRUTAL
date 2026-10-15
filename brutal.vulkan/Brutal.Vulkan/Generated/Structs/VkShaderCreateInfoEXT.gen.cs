namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkShaderCreateInfoEXT.html">VkShaderCreateInfoEXT</see> - Structure specifying parameters of a newly created shader
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkShaderCreateInfoEXT
    ///     </para>
    ///     <para>
    ///         The <c>VkShaderCreateInfoEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_shader_object
    ///         typedef struct VkShaderCreateInfoEXT {
    ///             VkStructureType                 sType;
    ///             const void*                     pNext;
    ///             VkShaderCreateFlagsEXT          flags;
    ///             VkShaderStageFlagBits           stage;
    ///             VkShaderStageFlags              nextStage;
    ///             VkShaderCodeTypeEXT             codeType;
    ///             size_t                          codeSize;
    ///             const void*                     pCode;
    ///             const char*                     pName;
    ///             uint32_t                        setLayoutCount;
    ///             const VkDescriptorSetLayout*    pSetLayouts;
    ///             uint32_t                        pushConstantRangeCount;
    ///             const VkPushConstantRange*      pPushConstantRanges;
    ///             const VkSpecializationInfo*     pSpecializationInfo;
    ///         } VkShaderCreateInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 96)]
    public unsafe partial struct VkShaderCreateInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.ShaderCreateInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is a bitmask of <c>VkShaderCreateFlagsEXT</c> describing additional parameters of the shader.
        /// </summary>
        [FieldOffset(16)]
        public VkShaderCreateFlagsEXT Flags;

        /// <summary>
        ///     <c>Stage</c> is a <c>VkShaderStageFlags</c> value specifying a single shader stage.
        /// </summary>
        [FieldOffset(20)]
        public VkShaderStageFlags Stage;

        /// <summary>
        ///     <c>NextStage</c> is a bitmask of <c>VkShaderStageFlags</c> specifying which stages <i>can</i> be used as a logically next bound stage when drawing with the shader bound. A value of zero indicates this shader stage <i>must</i> be the last one.
        /// </summary>
        [FieldOffset(24)]
        public VkShaderStageFlags NextStage;

        /// <summary>
        ///     <c>CodeType</c> is a <c>VkShaderCodeTypeEXT</c> value specifying the type of the shader code pointed to be <c>pCode</c>.
        /// </summary>
        [FieldOffset(28)]
        public VkShaderCodeTypeEXT CodeType;

        /// <summary>
        ///     <c>CodeSize</c> is the size in bytes of the shader code pointed to be <c>pCode</c>.
        /// </summary>
        [FieldOffset(32)]
        public nuint CodeSize;

        /// <summary>
        ///     <c>Code</c> is a pointer to the shader code to use to create the shader.
        /// </summary>
        [FieldOffset(40)]
        public void* Code;

        /// <summary>
        ///     <c>Name</c> is a pointer to a null-terminated UTF-8 string specifying the entry point name of the shader for this stage.
        /// </summary>
        [FieldOffset(48)]
        public byte* Name;

        /// <summary>
        ///     <c>SetLayoutCount</c> is the number of descriptor set layouts pointed to by <c>pSetLayouts</c>.
        /// </summary>
        [FieldOffset(56)]
        public int SetLayoutCount;

        /// <summary>
        ///     <c>SetLayouts</c> is a pointer to an array of <c>VkDescriptorSetLayout</c> objects used by the shader stage. The implementation <i>must</i> not access these objects outside of the duration of the command this structure is passed to.
        /// </summary>
        [FieldOffset(64)]
        public VkDescriptorSetLayout* SetLayouts;

        /// <summary>
        ///     <c>PushConstantRangeCount</c> is the number of push constant ranges pointed to by <c>pPushConstantRanges</c>.
        /// </summary>
        [FieldOffset(72)]
        public int PushConstantRangeCount;

        /// <summary>
        ///     <c>PushConstantRanges</c> is a pointer to an array of <c>VkPushConstantRange</c> structures used by the shader stage.
        /// </summary>
        [FieldOffset(80)]
        public VkPushConstantRange* PushConstantRanges;

        /// <summary>
        ///     <c>SpecializationInfo</c> is a pointer to a <c>VkSpecializationInfo</c> structure, as described in <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#pipelines-specialization-constants">Specialization Constants^</see>, or `NULL`.
        /// </summary>
        [FieldOffset(88)]
        public VkSpecializationInfo* SpecializationInfo;
    }
}
