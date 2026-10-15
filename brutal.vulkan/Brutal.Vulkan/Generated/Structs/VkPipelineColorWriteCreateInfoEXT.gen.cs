namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPipelineColorWriteCreateInfoEXT.html">VkPipelineColorWriteCreateInfoEXT</see> - Structure specifying color write state of a newly created pipeline
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPipelineColorWriteCreateInfoEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_color_write_enable
    ///         typedef struct VkPipelineColorWriteCreateInfoEXT {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             uint32_t           attachmentCount;
    ///             const VkBool32*    pColorWriteEnables;
    ///         } VkPipelineColorWriteCreateInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkPipelineColorWriteCreateInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PipelineColorWriteCreateInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>AttachmentCount</c> is the number of basetype:VkBool32 elements in <c>pColorWriteEnables</c>.
        /// </summary>
        [FieldOffset(16)]
        public int AttachmentCount;

        /// <summary>
        ///     <c>ColorWriteEnables</c> is a pointer to an array of per target attachment boolean values specifying whether color writes are enabled for the given attachment.
        /// </summary>
        [FieldOffset(24)]
        public Brutal.Bool32* ColorWriteEnables;
    }
}
