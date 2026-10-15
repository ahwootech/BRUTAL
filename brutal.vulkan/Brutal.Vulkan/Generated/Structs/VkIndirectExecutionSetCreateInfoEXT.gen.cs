namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkIndirectExecutionSetCreateInfoEXT.html">VkIndirectExecutionSetCreateInfoEXT</see> - Structure specifying parameters of a newly created indirect execution set
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkIndirectExecutionSetCreateInfoEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_device_generated_commands
    ///         typedef struct VkIndirectExecutionSetCreateInfoEXT {
    ///             VkStructureType                      sType;
    ///             const void*                          pNext;
    ///             VkIndirectExecutionSetInfoTypeEXT    type;
    ///             VkIndirectExecutionSetInfoEXT        info;
    ///         } VkIndirectExecutionSetCreateInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkIndirectExecutionSetCreateInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.IndirectExecutionSetCreateInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Type</c> is a <c>VkIndirectExecutionSetInfoTypeEXT</c> describing the type of set being created and determining which field of the <c>info</c> union will be used.
        /// </summary>
        [FieldOffset(16)]
        public VkIndirectExecutionSetInfoTypeEXT Type;

        /// <summary>
        ///     <c>Info</c> is a <c>VkIndirectExecutionSetInfoEXT</c> union containing layout information for the set.
        /// </summary>
        [FieldOffset(24)]
        public VkIndirectExecutionSetInfoEXT Info;
    }
}
