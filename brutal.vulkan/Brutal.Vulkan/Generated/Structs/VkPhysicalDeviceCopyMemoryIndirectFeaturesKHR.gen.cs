namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceCopyMemoryIndirectFeaturesKHR.html">VkPhysicalDeviceCopyMemoryIndirectFeaturesKHR</see> - Structure describing indirect copy features supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceCopyMemoryIndirectFeaturesKHR</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_copy_memory_indirect
    ///         typedef struct VkPhysicalDeviceCopyMemoryIndirectFeaturesKHR {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           indirectMemoryCopy;
    ///             VkBool32           indirectMemoryToImageCopy;
    ///         } VkPhysicalDeviceCopyMemoryIndirectFeaturesKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceCopyMemoryIndirectFeaturesKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceCopyMemoryIndirectFeaturesKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>IndirectMemoryCopy</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 IndirectMemoryCopy;

        /// <summary>
        ///     <c>IndirectMemoryToImageCopy</c>
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 IndirectMemoryToImageCopy;
    }
}
