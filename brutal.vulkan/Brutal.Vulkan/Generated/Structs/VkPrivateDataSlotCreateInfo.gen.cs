namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPrivateDataSlotCreateInfo.html">VkPrivateDataSlotCreateInfo</see> - Structure specifying the parameters of private data slot construction
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPrivateDataSlotCreateInfo</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_3
    ///         typedef struct VkPrivateDataSlotCreateInfo {
    ///             VkStructureType                 sType;
    ///             const void*                     pNext;
    ///             VkPrivateDataSlotCreateFlags    flags;
    ///         } VkPrivateDataSlotCreateInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPrivateDataSlotCreateInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PrivateDataSlotCreateInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is reserved for future use.
        /// </summary>
        [FieldOffset(16)]
        public VkPrivateDataSlotCreateFlags Flags;
    }
}
