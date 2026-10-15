namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPushConstantsInfo.html">VkPushConstantsInfo</see> - Structure specifying a push constant update operation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkPushConstantsInfo
    ///     </para>
    ///     <para>
    ///         The <c>VkPushConstantsInfo</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_4
    ///         typedef struct VkPushConstantsInfo {
    ///             VkStructureType       sType;
    ///             const void*           pNext;
    ///             VkPipelineLayout      layout;
    ///             VkShaderStageFlags    stageFlags;
    ///             uint32_t              offset;
    ///             uint32_t              size;
    ///             const void*           pValues;
    ///         } VkPushConstantsInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public unsafe partial struct VkPushConstantsInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PushConstantsInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Layout</c> is the pipeline layout used to program the push constant updates.
        /// </summary>
        [FieldOffset(16)]
        public VkPipelineLayout Layout;

        /// <summary>
        ///     <c>StageFlags</c> is a bitmask of <c>VkShaderStageFlags</c> specifying the shader stages that will use the push constants in the updated range.
        /// </summary>
        [FieldOffset(24)]
        public VkShaderStageFlags StageFlags;

        /// <summary>
        ///     <c>Offset</c> is the start offset of the push constant range to update, in units of bytes.
        /// </summary>
        [FieldOffset(28)]
        public int Offset;

        /// <summary>
        ///     <c>Size</c> is the size of the push constant range to update, in units of bytes.
        /// </summary>
        [FieldOffset(32)]
        public int Size;

        /// <summary>
        ///     <c>Values</c> is a pointer to an array of <c>size</c> bytes containing the new push constant values.
        /// </summary>
        [FieldOffset(40)]
        public void* Values;
    }
}
