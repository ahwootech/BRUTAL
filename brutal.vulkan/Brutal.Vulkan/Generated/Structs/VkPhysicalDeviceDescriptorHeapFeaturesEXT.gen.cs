namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceDescriptorHeapFeaturesEXT.html">VkPhysicalDeviceDescriptorHeapFeaturesEXT</see> - Structure describing support for descriptor heaps
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceDescriptorHeapFeaturesEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_descriptor_heap
    ///         typedef struct VkPhysicalDeviceDescriptorHeapFeaturesEXT {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           descriptorHeap;
    ///             VkBool32           descriptorHeapCaptureReplay;
    ///         } VkPhysicalDeviceDescriptorHeapFeaturesEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceDescriptorHeapFeaturesEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceDescriptorHeapFeaturesEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>DescriptorHeap</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 DescriptorHeap;

        /// <summary>
        ///     <c>DescriptorHeapCaptureReplay</c>
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 DescriptorHeapCaptureReplay;
    }
}
