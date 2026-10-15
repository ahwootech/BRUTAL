namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDevicePushConstantBankPropertiesNV.html">VkPhysicalDevicePushConstantBankPropertiesNV</see> - Structure describing push constant bank properties
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDevicePushConstantBankPropertiesNV</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_push_constant_bank
    ///         typedef struct VkPhysicalDevicePushConstantBankPropertiesNV {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             uint32_t           maxGraphicsPushConstantBanks;
    ///             uint32_t           maxComputePushConstantBanks;
    ///             uint32_t           maxGraphicsPushDataBanks;
    ///             uint32_t           maxComputePushDataBanks;
    ///         } VkPhysicalDevicePushConstantBankPropertiesNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkPhysicalDevicePushConstantBankPropertiesNV()
    {
        /// <summary>
        ///     <c>sType</c>
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDevicePushConstantBankPropertiesNV;

        /// <summary>
        ///     <c>Next</c>
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>MaxGraphicsPushConstantBanks</c>
        /// </summary>
        [FieldOffset(16)]
        public int MaxGraphicsPushConstantBanks;

        /// <summary>
        ///     <c>MaxComputePushConstantBanks</c>
        /// </summary>
        [FieldOffset(20)]
        public int MaxComputePushConstantBanks;

        /// <summary>
        ///     <c>MaxGraphicsPushDataBanks</c>
        /// </summary>
        [FieldOffset(24)]
        public int MaxGraphicsPushDataBanks;

        /// <summary>
        ///     <c>MaxComputePushDataBanks</c>
        /// </summary>
        [FieldOffset(28)]
        public int MaxComputePushDataBanks;
    }
}
