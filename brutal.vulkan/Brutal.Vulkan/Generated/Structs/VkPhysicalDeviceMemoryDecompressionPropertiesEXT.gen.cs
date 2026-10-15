namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceMemoryDecompressionPropertiesEXT.html">VkPhysicalDeviceMemoryDecompressionPropertiesEXT</see> - Structure describing supported memory decompression methods by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceMemoryDecompressionPropertiesEXT</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_memory_decompression
    ///         typedef struct VkPhysicalDeviceMemoryDecompressionPropertiesEXT {
    ///             VkStructureType                        sType;
    ///             void*                                  pNext;
    ///             VkMemoryDecompressionMethodFlagsEXT    decompressionMethods;
    ///             uint64_t                               maxDecompressionIndirectCount;
    ///         } VkPhysicalDeviceMemoryDecompressionPropertiesEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkPhysicalDeviceMemoryDecompressionPropertiesEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceMemoryDecompressionPropertiesEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>DecompressionMethods</c> is a bitmask of <c>VkMemoryDecompressionMethodFlagsEXT</c> specifying memory decompression methods supported by the implementation.
        /// </summary>
        [FieldOffset(16)]
        public VkMemoryDecompressionMethodFlagsEXT DecompressionMethods;

        /// <summary>
        ///     <c>MaxDecompressionIndirectCount</c> specifies the maximum supported count value identified by either <c>vkCmdDecompressMemoryIndirectCountEXT::maxDecompressionCount</c> or the value specified in <c>vkCmdDecompressMemoryIndirectCountEXT::indirectCommandsCountAddress</c>
        /// </summary>
        [FieldOffset(24)]
        public nint MaxDecompressionIndirectCount;
    }
}
