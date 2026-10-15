namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPipelineCreateFlags2CreateInfo.html">VkPipelineCreateFlags2CreateInfo</see> - Extended pipeline create flags
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPipelineCreateFlags2CreateInfo</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_4
    ///         typedef struct VkPipelineCreateFlags2CreateInfo {
    ///             VkStructureType           sType;
    ///             const void*               pNext;
    ///             VkPipelineCreateFlags2    flags;
    ///         } VkPipelineCreateFlags2CreateInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPipelineCreateFlags2CreateInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PipelineCreateFlags2CreateInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is a bitmask of <c>VkPipelineCreateFlags2</c> specifying how a pipeline will be generated.
        /// </summary>
        [FieldOffset(16)]
        public VkPipelineCreateFlags2 Flags;
    }
}
