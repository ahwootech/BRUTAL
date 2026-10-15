namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkIndirectCommandsLayoutPushDataTokenNV.html">VkIndirectCommandsLayoutPushDataTokenNV</see> - Struct specifying the details of an indirect push data command layout token
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkIndirectCommandsLayoutTokenNV</c> structure specifies details to the
    ///         function arguments that need to be known at layout creation time:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_descriptor_heap with VK_NV_device_generated_commands
    ///         typedef struct VkIndirectCommandsLayoutPushDataTokenNV {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             uint32_t           pushDataOffset;
    ///             uint32_t           pushDataSize;
    ///         } VkIndirectCommandsLayoutPushDataTokenNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkIndirectCommandsLayoutPushDataTokenNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.IndirectCommandsLayoutPushDataTokenNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>PushDataOffset</c> is the offset used for the push data command.
        /// </summary>
        [FieldOffset(16)]
        public int PushDataOffset;

        /// <summary>
        ///     <c>PushDataSize</c> is the size used for the push data command.
        /// </summary>
        [FieldOffset(20)]
        public int PushDataSize;
    }
}
