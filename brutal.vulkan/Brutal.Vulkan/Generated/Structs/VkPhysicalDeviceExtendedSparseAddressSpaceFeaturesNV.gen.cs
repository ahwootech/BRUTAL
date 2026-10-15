namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceExtendedSparseAddressSpaceFeaturesNV.html">VkPhysicalDeviceExtendedSparseAddressSpaceFeaturesNV</see> - Structure describing feature to use extended sparse address space
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceExtendedSparseAddressSpaceFeaturesNV</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_extended_sparse_address_space
    ///         typedef struct VkPhysicalDeviceExtendedSparseAddressSpaceFeaturesNV {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           extendedSparseAddressSpace;
    ///         } VkPhysicalDeviceExtendedSparseAddressSpaceFeaturesNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceExtendedSparseAddressSpaceFeaturesNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceExtendedSparseAddressSpaceFeaturesNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ExtendedSparseAddressSpace</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 ExtendedSparseAddressSpace;
    }
}
