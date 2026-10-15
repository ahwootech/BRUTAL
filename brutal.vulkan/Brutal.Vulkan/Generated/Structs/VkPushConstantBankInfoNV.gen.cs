namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPushConstantBankInfoNV.html">VkPushConstantBankInfoNV</see> - Structure specifying push constant bank information
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPushConstantBankInfoNV</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_push_constant_bank
    ///         typedef struct VkPushConstantBankInfoNV {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             uint32_t           bank;
    ///         } VkPushConstantBankInfoNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPushConstantBankInfoNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PushConstantBankInfoNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Bank</c> is the index of the hardware bank into which the data is pushed.
        /// </summary>
        [FieldOffset(16)]
        public int Bank;
    }
}
